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

		public StudentDB()
		{
			StudentMod = new StudentModel();
			OracleConnection conn = new OracleConnection(DBHelper.ConnectionString);

			fillSql =  new OracleCommand("SELECT STUDENTID, NAME, SEX, BIRTHOFDATE, BIRTHLOCAL, VNEID, " +
				"DATEOFISSUE, LOCALOFISSUE, LOCAL, PLACEOFRESIDENCE, NUMBERPHONE, STATUS " +
				"FROM STUDENT ", conn);
			createSql = new OracleCommand("INSERT INTO STUDENT (STUDENTID, NAME, SEX, BIRTHOFDATE, BIRTHLOCAL, VNEID, DATEOFISSUE, LOCALOFISSUE, LOCAL, PLACEOFRESIDENCE, NUMBERPHONE, STATUS) " +
				"VALUES (:STUDENTID, :NAME, :SEX, :BIRTHOFDATE, :BIRTHLOCAL, :VNEID, :DATEOFISSUE, :LOCALOFISSUE, :LOCAL, :PLACEOFRESIDENCE, :NUMBERPHONE, :STATUS)", conn);
			createSql.BindByName = true;
			foreach (string column in new[] { "STUDENTID", "NAME", "SEX", "BIRTHOFDATE", "BIRTHLOCAL", "VNEID",
				"DATEOFISSUE", "LOCALOFISSUE", "LOCAL", "PLACEOFRESIDENCE", "NUMBERPHONE", "STATUS" })
			{
				// SourceColumn lets the adapter copy each value from the new DataRow into the INSERT
				createSql.Parameters.Add(new OracleParameter { ParameterName = column, SourceColumn = column });
			}

			updateSql = new OracleCommand("UPDATE STUDENT SET " +
				"NAME = :NAME, " +
				"SEX = :SEX, " +
				"BIRTHOFDATE = :BIRTHOFDATE, " +
				"BIRTHLOCAL = :BIRTHLOCAL, " +
				"VNEID = :VNEID, " +
				"DATEOFISSUE = :DATEOFISSUE, " +
				"LOCALOFISSUE = :LOCALOFISSUE, " +
				"LOCAL = :LOCAL, " +
				"PLACEOFRESIDENCE = :PLACEOFRESIDENCE, " +
				"NUMBERPHONE = :NUMBERPHONE, " +
				"STATUS = :STATUS " +
				"WHERE STUDENTID = :STUDENTID_OLD", conn);
			updateSql.Parameters.Add(":STUDENTID", "");
			updateSql.Parameters.Add(":NAME", "");
			updateSql.Parameters.Add(":SEX", "");
			updateSql.Parameters.Add(":BIRTHOFDATE", "");
			updateSql.Parameters.Add(":BIRTHLOCAL", "");
			updateSql.Parameters.Add(":VNEID", "");
			updateSql.Parameters.Add(":DATEOFISSUE", "");
			updateSql.Parameters.Add(":LOCALOFISSUE", "");
			updateSql.Parameters.Add(":LOCAL", "");
			updateSql.Parameters.Add(":PLACEOFRESIDENCE", "");
			updateSql.Parameters.Add(":NUMBERPHONE", "");
			updateSql.Parameters.Add(":STATUS", "");

			_adapter = new OracleDataAdapter();
			_adapter.SelectCommand = fillSql;
			_adapter.InsertCommand = createSql;
			_adapter.UpdateCommand = updateSql;
		}

		public DataTable FillData()
		{
			DBStudent = new DataTable("StudentDataTable");
			_adapter.Fill(DBStudent);
			return DBStudent;
		}

		public bool CreatNewStudent(StudentModel student)
		{
			DataRow newRow = DBStudent.NewRow();
			newRow["STUDENTID"] = student.StudentId;
			newRow["NAME"] = student.Name;
			newRow["SEX"] = student.Sex;
			newRow["BIRTHOFDATE"] = student.BirthOfDate;
			newRow["BIRTHLOCAL"] = student.BirthLocal;
			newRow["VNEID"] = student.VneId;
			newRow["DATEOFISSUE"] = student.DateOfIssue;
			newRow["LOCALOFISSUE"] = student.LocalOfIssue;
			newRow["LOCAL"] = student.Hometown;
			newRow["PLACEOFRESIDENCE"] = student.PlaceOfResidence;
			newRow["NUMBERPHONE"] = student.NumberPhone;
			newRow["STATUS"] = student.Status;
			DBStudent.Rows.Add(newRow);
			
			_adapter.Update(DBStudent);
			
			return true;
		}

		public bool UpdateStudent(StudentModel student)
		{
			DataRow newRow = DBStudent.NewRow();
			
			return true;
		}

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
	}
}
