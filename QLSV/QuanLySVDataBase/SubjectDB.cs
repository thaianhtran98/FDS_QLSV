using System;
using System.Collections;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using QuanLySVHelperDataBase;
using QuanLySVModel;

namespace QuanLySVDataBase
{
	/// <summary>
	/// Data access for the SUBJECT table. Keeps an in-memory <see cref="DataTable"/> cache
	/// and pushes pending changes to Oracle through an <see cref="OracleDataAdapter"/>.
	/// </summary>
	public class SubjectDB
	{
		private DBHelper DBHelper = new DBHelper();
		/// <summary>
		/// Gets or sets the cached SUBJECT table.
		/// </summary>
		public DataTable DBSubject
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

		/// <summary>
		/// Loads the SUBJECT table into the cache (only when it is empty or <paramref name="forceReload"/> is true) and returns it.
		/// </summary>
		public DataTable FillData(bool forceReload = false)
		{
			if (DBSubject == null || forceReload)
			{
				DBSubject = new DataTable("SubjectDataTable");
				_adapter.Fill(DBSubject);
			}

			return DBSubject;
		}

		/// <summary>
		/// Adds a new subject row to the cache. The row is written to the database only when <see cref="SaveAll"/> is called.
		/// </summary>
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

		/// <summary>
		/// Updates the cached row of the subject with the given id. Returns false when the subject is not found.
		/// </summary>
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

		/// <summary>
		/// Marks the cached row of the subject with the given id as deleted. Returns false when the subject is not found.
		/// </summary>
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

		/// <summary>
		/// Writes all pending changes (insert/update/delete) of the cache to the database.
		/// </summary>
		public bool SaveAll()
		{
			if (HasChanges())
			{
				_adapter.Update(DBSubject);
			}
			return true;
		}

		/// <summary>
		/// Checks whether the cache contains unsaved changes.
		/// </summary>
		public bool HasChanges()
		{
			return DBSubject != null && DBSubject.GetChanges() != null;
		}

		// Filter subject data in table
		/// <summary>
		/// Returns a copy of the cache whose default view is filtered by subject name (contains) and status.
		/// A status value of -1 means no status filter.
		/// </summary>
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

		/// <summary>
		/// Finds the non-deleted row with the given subject id. Returns null when not found.
		/// </summary>
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
