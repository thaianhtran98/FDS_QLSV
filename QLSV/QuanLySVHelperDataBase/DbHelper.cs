using System;
using System.Data;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace QuanLySVHelperDataBase
{
    /// <summary>
    /// Provides helper members to access the Oracle database.
    /// </summary>
    public class DBHelper
    {
		/// <summary>
		/// Reads the "OracleConnection" connection string from the application config.
		/// Returns an empty string when it is not configured.
		/// </summary>
		private static string _ConnectionString
		{
			get
			{
				var connSetting = ConfigurationManager.ConnectionStrings["OracleConnection"];
				return connSetting != null ? connSetting.ConnectionString : string.Empty;
			}
		}

		/// <summary>
		/// Gets the Oracle connection string of the application.
		/// </summary>
		public static string ConnectionString
		{
			get
			{
				return _ConnectionString;
			}
		}

		/// <summary>
		/// Executes a SELECT query (with optional bound parameters) and returns the result as a <see cref="DataTable"/>.
		/// </summary>
		public static DataTable ExecuteQuery(string query, OracleParameter[] parameters = null)
		{
			DataTable dataTable = new DataTable();

			using (OracleConnection conn = new OracleConnection(_ConnectionString))
			{
				using (OracleCommand cmd = new OracleCommand(query, conn))
				{
					cmd.BindByName = true;

					if (parameters != null)
					{
						cmd.Parameters.AddRange(parameters);
					}

					using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
					{
						conn.Open();
						adapter.Fill(dataTable);
					}
				}
			}

			return dataTable;
		}

		/// <summary>
		/// Executes an INSERT/UPDATE/DELETE statement (with optional bound parameters)
		/// and returns the number of affected rows.
		/// </summary>
		public static int ExecuteNonQuery(string query, OracleParameter[] parameters = null)
		{
			using (OracleConnection conn = new OracleConnection(_ConnectionString))
			{
				using (OracleCommand cmd = new OracleCommand(query, conn))
				{
					cmd.BindByName = true;

					if (parameters != null)
					{
						cmd.Parameters.AddRange(parameters);
					}

					conn.Open();
					return cmd.ExecuteNonQuery();
				}
			}
		}
	}
}
