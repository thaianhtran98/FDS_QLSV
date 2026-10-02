using System;
using System.Data;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace QuanLySVHelperDataBase
{
    public class DBHelper
    {
		private static string ConnectionString
		{
			get
			{
				var connSetting = ConfigurationManager.ConnectionStrings["OracleConnection"];
				return connSetting != null ? connSetting.ConnectionString : string.Empty;
			}
		}

		/// <summary>
		/// Handles the execute query logic.
		/// </summary>
		public static DataTable ExecuteQuery(string query, OracleParameter[] parameters = null)
		{
			DataTable dataTable = new DataTable();

			using (OracleConnection conn = new OracleConnection(ConnectionString))
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
	}
}
