using System;
using System.Collections;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using QuanLySVHelperDataBase;
using QuanLySVModel;

namespace QuanLySVDataBase
{
	/// <summary>
	/// Represents the school year.
	/// </summary>
	public class SchoolYearDB
	{
		private DBHelper DBHelper = new DBHelper();
		public DataTable DBSchoolYear
		{
			get; set;
		}

		private OracleDataAdapter _adapter;
		private OracleCommand fillSql;
		private OracleCommand createSql;
		private OracleCommand updateSql;
		private OracleCommand deleteSql;

		public SchoolYearDB()
		{
			OracleConnection conn = new OracleConnection(DBHelper.ConnectionString);

			// Select Command
			fillSql = new OracleCommand("SELECT SCHOOLYEARID, SCHOOLYEARNAME, START_YEAR, END_YEAR, STATUS " +
				"FROM SCHOOL_YEAR ORDER BY START_YEAR", conn);

			// Insert Command
			createSql = new OracleCommand("INSERT INTO SCHOOL_YEAR (SCHOOLYEARID, SCHOOLYEARNAME, START_YEAR, END_YEAR, STATUS) " +
				"VALUES (:SCHOOLYEARID, :SCHOOLYEARNAME, :START_YEAR, :END_YEAR, :STATUS)", conn);
			createSql.BindByName = true;

			// Update Command
			updateSql = new OracleCommand("UPDATE SCHOOL_YEAR SET " +
				"SCHOOLYEARID = :SCHOOLYEARID, " +
				"SCHOOLYEARNAME = :SCHOOLYEARNAME, " +
				"START_YEAR = :START_YEAR, " +
				"END_YEAR = :END_YEAR, " +
				"STATUS = :STATUS " +
				"WHERE SCHOOLYEARID = :SCHOOLYEARID_OLD", conn);
			updateSql.BindByName = true;

			// Delete Command
			deleteSql = new OracleCommand("DELETE FROM SCHOOL_YEAR WHERE SCHOOLYEARID = :SCHOOLYEARID", conn);
			deleteSql.BindByName = true;

			// Add parameters
			string[] columns = new[] { "SCHOOLYEARID", "SCHOOLYEARNAME", "START_YEAR", "END_YEAR", "STATUS" };
			foreach (string column in columns)
			{
				createSql.Parameters.Add(new OracleParameter { ParameterName = column, SourceColumn = column });
				updateSql.Parameters.Add(new OracleParameter { ParameterName = column, SourceColumn = column });
			}
			updateSql.Parameters.Add(new OracleParameter { ParameterName = "SCHOOLYEARID_OLD", SourceColumn = "SCHOOLYEARID", SourceVersion = DataRowVersion.Original });
			deleteSql.Parameters.Add(new OracleParameter { ParameterName = "SCHOOLYEARID", SourceColumn = "SCHOOLYEARID", SourceVersion = DataRowVersion.Original });

			_adapter = new OracleDataAdapter();
			_adapter.SelectCommand = fillSql;
			_adapter.InsertCommand = createSql;
			_adapter.UpdateCommand = updateSql;
			_adapter.DeleteCommand = deleteSql;
		}

		public DataTable FillData(bool forceReload = false)
		{
			if (DBSchoolYear == null || forceReload)
			{
				DBSchoolYear = new DataTable("SchoolYearDataTable");
				_adapter.Fill(DBSchoolYear);
			}

			return DBSchoolYear;
		}

		public bool CreateNewSchoolYear(SchoolYearModel schoolYear)
		{
			if (DBSchoolYear == null)
			{
				FillData();
			}
			DataRow newRow = DBSchoolYear.NewRow();
			newRow["SCHOOLYEARID"] = schoolYear.SchoolYearId;
			newRow["SCHOOLYEARNAME"] = schoolYear.SchoolYearName;
			newRow["START_YEAR"] = schoolYear.StartYear;
			newRow["END_YEAR"] = schoolYear.EndYear;
			newRow["STATUS"] = schoolYear.Status;
			DBSchoolYear.Rows.Add(newRow);

			return true;
		}

		public bool UpdateSchoolYear(SchoolYearModel schoolYear, string schoolYearId)
		{
			DataRow updateRow = FindSchoolYearById(schoolYearId);
			if (updateRow != null)
			{
				updateRow["SCHOOLYEARID"] = schoolYear.SchoolYearId;
				updateRow["SCHOOLYEARNAME"] = schoolYear.SchoolYearName;
				updateRow["START_YEAR"] = schoolYear.StartYear;
				updateRow["END_YEAR"] = schoolYear.EndYear;
				updateRow["STATUS"] = schoolYear.Status;
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool DeleteSchoolYear(string schoolYearId)
		{
			DataRow deleteRow = FindSchoolYearById(schoolYearId);
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
				_adapter.Update(DBSchoolYear);
			}
			return true;
		}

		public bool HasChanges()
		{
			return DBSchoolYear != null && DBSchoolYear.GetChanges() != null;
		}

		// Filter school year data in table
		public DataTable FilterSchoolYear(string schoolYearName = null, int status = -1)
		{
			ArrayList filters = new ArrayList();
			if (status >= 0)
			{
				filters.Add("STATUS = " + status);
			}
			if (schoolYearName != null)
			{
				filters.Add("SCHOOLYEARNAME LIKE '%" + schoolYearName.Replace("'", "''") + "%'");
			}

			DataTable dataTable = DBSchoolYear.Copy();
			dataTable.DefaultView.RowFilter = string.Join(" AND ", filters.ToArray());
			return dataTable;
		}

		public DataRow FindSchoolYearById(string schoolYearId)
		{
			foreach (DataRow schoolYearRow in DBSchoolYear.Rows)
			{
				if (schoolYearRow.RowState == DataRowState.Deleted)
				{
					continue;
				}

				if (schoolYearRow["SCHOOLYEARID"].ToString() == schoolYearId)
				{
					return schoolYearRow;
				}
			}

			return null;
		}
	}
}
