using System;
using System.Collections;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using QuanLySVHelperDataBase;
using QuanLySVModel;

namespace QuanLySVDataBase
{
	/// <summary>
	/// Represents the subject.
	/// </summary>
	public class SubjectDB
	{
		private DBHelper DBHelper = new DBHelper();
		public DataTable DBSubject
		{
			get; set;
		}

		private OracleDataAdapter _adapter;
		private OracleCommand fillSql;
		private OracleCommand createSql;
		private OracleCommand updateSql;
		private OracleCommand deleteSql;

		public SubjectDB()
		{
			OracleConnection conn = new OracleConnection(DBHelper.ConnectionString);

			// Select Command
			fillSql = new OracleCommand("SELECT SUBJECTID, SUBJECTNAME, CREDITS, DESCRIPTION, STATUS FROM SUBJECT ", conn);

			// Insert Command
			createSql = new OracleCommand("INSERT INTO SUBJECT (SUBJECTID, SUBJECTNAME, CREDITS, DESCRIPTION, STATUS) " +
				"VALUES (:SUBJECTID, :SUBJECTNAME, :CREDITS, :DESCRIPTION, :STATUS)", conn);
			createSql.BindByName = true;

			// Update Command
			updateSql = new OracleCommand("UPDATE SUBJECT SET " +
				"SUBJECTID = :SUBJECTID, " +
				"SUBJECTNAME = :SUBJECTNAME, " +
				"CREDITS = :CREDITS, " +
				"DESCRIPTION = :DESCRIPTION, " +
				"STATUS = :STATUS " +
				"WHERE SUBJECTID = :SUBJECTID_OLD", conn);
			updateSql.BindByName = true;

			// Delete Command
			deleteSql = new OracleCommand("DELETE FROM SUBJECT WHERE SUBJECTID = :SUBJECTID", conn);
			deleteSql.BindByName = true;

			// Add parameters
			string[] columns = new[] { "SUBJECTID", "SUBJECTNAME", "CREDITS", "DESCRIPTION", "STATUS" };
			foreach (string column in columns)
			{
				createSql.Parameters.Add(new OracleParameter { ParameterName = column, SourceColumn = column });
				updateSql.Parameters.Add(new OracleParameter { ParameterName = column, SourceColumn = column });
			}
			updateSql.Parameters.Add(new OracleParameter { ParameterName = "SUBJECTID_OLD", SourceColumn = "SUBJECTID", SourceVersion = DataRowVersion.Original });
			deleteSql.Parameters.Add(new OracleParameter { ParameterName = "SUBJECTID", SourceColumn = "SUBJECTID", SourceVersion = DataRowVersion.Original });

			_adapter = new OracleDataAdapter();
			_adapter.SelectCommand = fillSql;
			_adapter.InsertCommand = createSql;
			_adapter.UpdateCommand = updateSql;
			_adapter.DeleteCommand = deleteSql;
		}

		public DataTable FillData(bool forceReload = false)
		{
			if (DBSubject == null || forceReload)
			{
				DBSubject = new DataTable("SubjectDataTable");
				_adapter.Fill(DBSubject);
			}

			return DBSubject;
		}

		public bool CreateNewSubject(SubjectModel subject)
		{
			if (DBSubject == null)
			{
				FillData();
			}
			DataRow newRow = DBSubject.NewRow();
			newRow["SUBJECTID"] = subject.SubjectId;
			newRow["SUBJECTNAME"] = subject.SubjectName;
			newRow["CREDITS"] = subject.Credits;
			newRow["DESCRIPTION"] = subject.Description;
			newRow["STATUS"] = subject.Status;
			DBSubject.Rows.Add(newRow);

			return true;
		}

		public bool UpdateSubject(SubjectModel subject, string subjectId)
		{
			DataRow updateRow = FindSubjectById(subjectId);
			if (updateRow != null)
			{
				updateRow["SUBJECTID"] = subject.SubjectId;
				updateRow["SUBJECTNAME"] = subject.SubjectName;
				updateRow["CREDITS"] = subject.Credits;
				updateRow["DESCRIPTION"] = subject.Description;
				updateRow["STATUS"] = subject.Status;
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool DeleteSubject(string subjectId)
		{
			DataRow deleteRow = FindSubjectById(subjectId);
			if (deleteRow != null)
			{
				deleteRow.Delete();
				return true;
			}
			return false;
		}

		public bool SaveAll()
		{
			if (HasChanges())
			{
				_adapter.Update(DBSubject);
			}
			return true;
		}

		public bool HasChanges()
		{
			return DBSubject != null && DBSubject.GetChanges() != null;
		}

		// Filter subject data in table
		public DataTable FilterSubject(string subjectName = null, int status = -1)
		{
			ArrayList filters = new ArrayList();
			if (status >= 0)
			{
				filters.Add("STATUS = " + status);
			}
			if (subjectName != null)
			{
				filters.Add("SUBJECTNAME LIKE '%" + subjectName.Replace("'", "''") + "%'");
			}

			DataTable dataTable = DBSubject.Copy();
			dataTable.DefaultView.RowFilter = string.Join(" AND ", filters.ToArray());
			return dataTable;
		}

		public DataRow FindSubjectById(string subjectId)
		{
			foreach (DataRow subjectRow in DBSubject.Rows)
			{
				if (subjectRow.RowState == DataRowState.Deleted)
				{
					continue;
				}

				if (subjectRow["SUBJECTID"].ToString() == subjectId)
				{
					return subjectRow;
				}
			}

			return null;
		}
	}
}
