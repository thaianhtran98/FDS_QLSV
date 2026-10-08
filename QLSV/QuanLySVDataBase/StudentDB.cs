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
	/// Represents the student.
	/// </summary>
	public class StudentDB
	{
		private DBHelper DBHelper = new DBHelper();
		private StudentModel StudentMod;
		public DataTable DBStudent
		{
			get; set;
		}

		private OracleDataAdapter _adapter;
		private OracleCommand fillSql;
		private OracleCommand createSql;
		private OracleCommand updateSql;
		private OracleCommand deteleSql;

		public StudentDB()
		{
			StudentMod = new StudentModel();
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
			deteleSql = new OracleCommand("DELETE FROM STUDENT WHERE STUDENTID = :STUDENTID", conn);
			deteleSql.BindByName = true;
			
			// Add parameters
			string[] columns = new[] { "STUDENTID", "NAME", "SEX", "BIRTHOFDATE", "BIRTHLOCAL", "VNEID", "DATEOFISSUE", "LOCALOFISSUE", "HOMETOWN", "PLACEOFRESIDENCE", "NUMBERPHONE", "STATUS" };
			foreach (string column in columns)
			{
				createSql.Parameters.Add(new OracleParameter { ParameterName = column, SourceColumn = column });
				updateSql.Parameters.Add(new OracleParameter { ParameterName = column, SourceColumn = column });
			}
			updateSql.Parameters.Add(new OracleParameter { ParameterName = "STUDENTID_OLD", SourceColumn = "STUDENTID" });
			deteleSql.Parameters.Add(new OracleParameter { ParameterName = "STUDENTID", SourceColumn = "STUDENTID" });

			_adapter = new OracleDataAdapter();
			_adapter.SelectCommand = fillSql;
			_adapter.InsertCommand = createSql;
			_adapter.UpdateCommand = updateSql;
			_adapter.DeleteCommand = deteleSql;
		}

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

		public bool CreatNewStudent(StudentModel student)
		{
			if (DBStudent == null)
			{
				FillData();
			}
			DataRow newRow = DBStudent.NewRow();
			SetRowValues(newRow, student);
			DBStudent.Rows.Add(newRow);
			
			return true;
		}

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

		public bool SaveAll(out string errMessage) {
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

		public bool HasChanges()
		{
			return DBStudent != null && DBStudent.GetChanges() != null;
		}

		// Filter student data in table
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

		public DataRow FindStudentById(string studentId)
		{
            if (DBStudent == null)
            {
                FillData();
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
