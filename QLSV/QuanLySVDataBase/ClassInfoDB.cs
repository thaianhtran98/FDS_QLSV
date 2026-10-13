using System;
using System.Collections;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using QuanLySVHelperDataBase;
using QuanLySVModel;

namespace QuanLySVDataBase
{
	/// <summary>
	/// Data access for the CLASS table. Keeps an in-memory <see cref="DataTable"/> cache
	/// and pushes pending changes to Oracle through an <see cref="OracleDataAdapter"/>.
	/// </summary>
	public class ClassInfoDB
	{
		private DBHelper DBHelper = new DBHelper();
		/// <summary>
		/// Gets or sets the cached CLASS table.
		/// </summary>
		public DataTable DBClassInfo
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
		public ClassInfoDB()
		{
			OracleConnection conn = new OracleConnection(DBHelper.ConnectionString);

			// Select Command
			fillSql = new OracleCommand("SELECT CLASSID, CLASSNAME, DESCRIPTION, STATUS FROM CLASS ", conn);

			// Insert Command
			createSql = new OracleCommand("INSERT INTO CLASS (CLASSID, CLASSNAME, DESCRIPTION, STATUS) " +
				"VALUES (:CLASSID, :CLASSNAME, :DESCRIPTION, :STATUS)", conn);
			createSql.BindByName = true;

			// Update Command
			updateSql = new OracleCommand("UPDATE CLASS SET " +
				"CLASSID = :CLASSID, " +
				"CLASSNAME = :CLASSNAME, " +
				"DESCRIPTION = :DESCRIPTION, " +
				"STATUS = :STATUS " +
				"WHERE CLASSID = :CLASSID_OLD", conn);
			updateSql.BindByName = true;

			// Delete Command
			deleteSql = new OracleCommand("DELETE FROM CLASS WHERE CLASSID = :CLASSID", conn);
			deleteSql.BindByName = true;

			// Add parameters
			string[] columns = new[] { "CLASSID", "CLASSNAME", "DESCRIPTION", "STATUS" };
			foreach (string column in columns)
			{
				createSql.Parameters.Add(new OracleParameter { ParameterName = column, SourceColumn = column });
				updateSql.Parameters.Add(new OracleParameter { ParameterName = column, SourceColumn = column });
			}
			updateSql.Parameters.Add(new OracleParameter { ParameterName = "CLASSID_OLD", SourceColumn = "CLASSID", SourceVersion = DataRowVersion.Original });
			deleteSql.Parameters.Add(new OracleParameter { ParameterName = "CLASSID", SourceColumn = "CLASSID", SourceVersion = DataRowVersion.Original });

			_adapter = new OracleDataAdapter();
			_adapter.SelectCommand = fillSql;
			_adapter.InsertCommand = createSql;
			_adapter.UpdateCommand = updateSql;
			_adapter.DeleteCommand = deleteSql;
		}

		/// <summary>
		/// Loads the CLASS table into the cache (only when it is empty or <paramref name="forceReload"/> is true) and returns it.
		/// </summary>
		public DataTable FillData(bool forceReload = false)
		{
			if (DBClassInfo == null || forceReload)
			{
				DBClassInfo = new DataTable("ClassInfoDataTable");
				_adapter.Fill(DBClassInfo);
			}

			return DBClassInfo;
		}

		/// <summary>
		/// Adds a new class row to the cache. The row is written to the database only when <see cref="SaveAll"/> is called.
		/// </summary>
		public bool CreateNewClass(ClassInfoModel classInfo)
		{
			if (DBClassInfo == null)
			{
				FillData();
			}
			DataRow newRow = DBClassInfo.NewRow();
			newRow["CLASSID"] = classInfo.ClassId;
			newRow["CLASSNAME"] = classInfo.ClassName;
			newRow["DESCRIPTION"] = classInfo.Description;
			newRow["STATUS"] = classInfo.Status;
			DBClassInfo.Rows.Add(newRow);

			return true;
		}

		/// <summary>
		/// Updates the cached row of the class with the given id (the class id itself may change).
		/// Returns false when the class is not found.
		/// </summary>
		public bool UpdateClass(ClassInfoModel classInfo, string classId)
		{
			DataRow updateRow = FindClassById(classId);
			if (updateRow != null)
			{
				updateRow["CLASSID"] = classInfo.ClassId;
				updateRow["CLASSNAME"] = classInfo.ClassName;
				updateRow["DESCRIPTION"] = classInfo.Description;
				updateRow["STATUS"] = classInfo.Status;
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Marks the cached row of the class with the given id as deleted. Returns false when the class is not found.
		/// </summary>
		public bool DeleteClass(string classId)
		{
			DataRow deleteRow = FindClassById(classId);
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
				_adapter.Update(DBClassInfo);
			}
			return true;
		}

		/// <summary>
		/// Checks whether the cache contains unsaved changes.
		/// </summary>
		public bool HasChanges()
		{
			return DBClassInfo != null && DBClassInfo.GetChanges() != null;
		}

		// Filter class data in table
		/// <summary>
		/// Returns a copy of the cache whose default view is filtered by class name (contains) and status.
		/// A status value of -1 means no status filter.
		/// </summary>
		public DataTable FilterClass(string className = null, int status = -1)
		{
			ArrayList filters = new ArrayList();
			if (status >= 0)
			{
				filters.Add("STATUS = " + status);
			}
			if (className != null)
			{
				filters.Add("CLASSNAME LIKE '%" + className.Replace("'", "''") + "%'");
			}

			DataTable dataTable = DBClassInfo.Copy();
			dataTable.DefaultView.RowFilter = string.Join(" AND ", filters.ToArray());
			return dataTable;
		}

		/// <summary>
		/// Finds the non-deleted row with the given class id. Returns null when not found.
		/// </summary>
		public DataRow FindClassById(string classId)
		{
			foreach (DataRow classRow in DBClassInfo.Rows)
			{
				if (classRow.RowState == DataRowState.Deleted)
				{
					continue;
				}

				if (classRow["CLASSID"].ToString() == classId)
				{
					return classRow;
				}
			}

			return null;
		}
	}
}
