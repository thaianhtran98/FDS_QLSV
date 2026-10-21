using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using QuanLySVHelperDataBase;
using QuanLySVModel;

namespace QuanLySVDataBase
{
	/// <summary>
	/// Data access for the STUDENT table. Keeps an in-memory <see cref="DataTable"/> cache
	/// and pushes pending changes to Oracle through an <see cref="OracleDataAdapter"/>.
	/// </summary>
	public class StudentDB
	{
		private DBHelper DBHelper = new DBHelper();
		/// <summary>
		/// Gets or sets the cached STUDENT table.
		/// </summary>
		public DataTable DBStudent
		{
			get; set;
		}

		private OracleDataAdapter _adapter;
		private OracleCommand fillSql;
		private OracleCommand createSql;
		private OracleCommand updateSql;
		private OracleCommand deleteSql;

		/// <summary>
		/// Creates the SELECT/INSERT/UPDATE/DELETE commands and binds them to the data adapter.
		/// </summary>
		public StudentDB()
		{
			StudentModel StudentMod = new StudentModel();
			OracleConnection conn = new OracleConnection(DBHelper.ConnectionString);

			// Select Command
			fillSql =  new OracleCommand("SELECT STUDENTID, NAME, SEX, BIRTHOFDATE, BIRTHLOCAL, VNEID, " +
				"DATEOFISSUE, LOCALOFISSUE, HOMETOWN, PLACEOFRESIDENCE, NUMBERPHONE, STATUS " +
				"FROM STUDENT ", conn);

			// Insert Command
			createSql = new OracleCommand("INSERT INTO STUDENT (STUDENTID, NAME, SEX, BIRTHOFDATE, BIRTHLOCAL, VNEID, DATEOFISSUE, LOCALOFISSUE, HOMETOWN, PLACEOFRESIDENCE, NUMBERPHONE, STATUS) " +
				"VALUES (:STUDENTID, :NAME, :SEX, :BIRTHOFDATE, :BIRTHLOCAL, :VNEID, :DATEOFISSUE, :LOCALOFISSUE, :HOMETOWN, :PLACEOFRESIDENCE, :NUMBERPHONE, :STATUS)", conn);
			createSql.BindByName = true;

			// Update Command
			updateSql = new OracleCommand("UPDATE STUDENT SET " +
				"NAME = :NAME, " +
				"SEX = :SEX, " +
				"BIRTHOFDATE = :BIRTHOFDATE, " +
				"BIRTHLOCAL = :BIRTHLOCAL, " +
				"VNEID = :VNEID, " +
				"DATEOFISSUE = :DATEOFISSUE, " +
				"LOCALOFISSUE = :LOCALOFISSUE, " +
				"HOMETOWN = :HOMETOWN, " +
				"PLACEOFRESIDENCE = :PLACEOFRESIDENCE, " +
				"NUMBERPHONE = :NUMBERPHONE, " +
				"STATUS = :STATUS " +
				"WHERE STUDENTID = :STUDENTID_OLD", conn);
			updateSql.BindByName = true;

			// Delete Command
			deleteSql = new OracleCommand("DELETE FROM STUDENT WHERE STUDENTID = :STUDENTID", conn);
			deleteSql.BindByName = true;
			
			// Add parameters
			string[] columns = new[] { "STUDENTID", "NAME", "SEX", "BIRTHOFDATE", "BIRTHLOCAL", "VNEID", "DATEOFISSUE", "LOCALOFISSUE", "HOMETOWN", "PLACEOFRESIDENCE", "NUMBERPHONE", "STATUS" };
			foreach (string column in columns)
			{
				createSql.Parameters.Add(new OracleParameter { ParameterName = column, SourceColumn = column });
				updateSql.Parameters.Add(new OracleParameter { ParameterName = column, SourceColumn = column });
			}
			updateSql.Parameters.Add(new OracleParameter { ParameterName = "STUDENTID_OLD", SourceColumn = "STUDENTID" });
			deleteSql.Parameters.Add(new OracleParameter { ParameterName = "STUDENTID", SourceColumn = "STUDENTID" });

			_adapter = new OracleDataAdapter();
			_adapter.SelectCommand = fillSql;
			_adapter.InsertCommand = createSql;
			_adapter.UpdateCommand = updateSql;
			_adapter.DeleteCommand = deleteSql;
		}

		/// <summary>
		/// Loads the STUDENT table into the cache (only when it is empty or <paramref name="forceReload"/> is true)
		/// and returns it. Returns null when loading fails.
		/// </summary>
		public DataTable FillData(bool forceReload = false)
		{
			try
			{
				if (DBStudent == null || forceReload)
				{
					DBStudent = new DataTable("StudentDataTable");
					_adapter.Fill(DBStudent);
				}

				return DBStudent;
			}
			catch (Exception)
			{
				return null;
			}
			
		}

		/// <summary>
		/// Adds a new student row to the cache. The row is written to the database only when <see cref="SaveAll"/> is called.
		/// </summary>
		public bool CreateNewStudent(StudentModel student)
		{
			if (DBStudent == null)
			{
				FillData(true);
			}
			DataRow newRow = DBStudent.NewRow();
			SetRowValues(newRow, student);
			DBStudent.Rows.Add(newRow);
			
			return true;
		}

		/// <summary>
		/// Updates the cached row of the student with the given id. Returns false when the student is not found.
		/// </summary>
		public bool UpdateStudent(StudentModel student, string studentId)
		{
			DataRow updateRow = FindStudentById(studentId);
			if (updateRow != null)
			{
				SetRowValues(updateRow, student);
                return true;
			}
			else
			{
				return false;
			}

		}

		/// <summary>
		/// Marks the cached row of the student with the given id as deleted. Returns false when the student is not found.
		/// </summary>
		public bool DeleteStudent(string studentId)
		{
			DataRow deleteRow = FindStudentById(studentId);
			if (deleteRow != null)
			{
				deleteRow.Delete();
				return true;
			}
			return false;
		}

		/// <summary>
		/// Writes all pending changes (insert/update/delete) of the cache to the database.
		/// Returns false and sets <paramref name="errMessage"/> when the save fails.
		/// </summary>
		public bool SaveAll(out string errMessage)
		{
            errMessage = null;
            try
			{
				if (HasChanges())
				{
					_adapter.Update(DBStudent);
				}
				return true;
			}
			catch (Exception ex)
			{
                errMessage = "Lỗi khi lưu dữ liệu: " + ex.Message;
				return false;
			}
		}

		/// <summary>
		/// Checks whether the cache contains unsaved changes.
		/// </summary>
		public bool HasChanges()
		{
			return DBStudent != null && DBStudent.GetChanges() != null;
		}

		// Filter student data in table
		/// <summary>
		/// Returns a copy of the cache whose default view is filtered by name (contains) and sex.
		/// A sex value of -1 means no sex filter.
		/// </summary>
		public DataTable FilterStudent(string name = null, int sex = -1)
		{
			ArrayList filters = new ArrayList();
			if (sex >= 0)
			{
				filters.Add("SEX = " + sex);
			}
			if (name != null)
			{
				filters.Add("NAME LIKE '%" + name.Replace("'", "''") + "%'");
			}

			DataTable dataTable = DBStudent.Copy();
			string filterString = "";
			foreach (string filter in filters)
			{
				if (filterString != "")
				{
					filterString += " AND ";
				}
				filterString += filter;
			}
			dataTable.DefaultView.RowFilter = filterString;
			return dataTable;
		}

		/// <summary>
		/// Finds the non-deleted row with the given student id (loads the cache first if needed).
		/// Returns null when not found.
		/// </summary>
		public DataRow FindStudentById(string studentId)
		{
            if (DBStudent == null)
            {
                FillData(true);
            }
            foreach (DataRow studentRow in DBStudent.Rows)
			{
				if (studentRow.RowState == DataRowState.Deleted)
				{
					continue;
				}

				if (studentRow["STUDENTID"].ToString() == studentId)
				{
					return studentRow;
				}
			}

			return null;
		}

		/// <summary>
		/// Copies the values of a <see cref="StudentModel"/> into the given row.
		/// </summary>
		private void SetRowValues(DataRow row, StudentModel student)
		{
			row["STUDENTID"] = student.StudentId;
			row["NAME"] = student.Name;
			row["SEX"] = student.Sex;
			row["BIRTHOFDATE"] = student.BirthOfDate;
			row["BIRTHLOCAL"] = student.BirthLocal;
			row["VNEID"] = student.VneId;
			row["DATEOFISSUE"] = student.DateOfIssue;
			row["LOCALOFISSUE"] = student.LocalOfIssue;
			row["HOMETOWN"] = student.Hometown;
			row["PLACEOFRESIDENCE"] = student.PlaceOfResidence;
			row["NUMBERPHONE"] = student.NumberPhone;
			row["STATUS"] = student.Status;
		}
	}
}
