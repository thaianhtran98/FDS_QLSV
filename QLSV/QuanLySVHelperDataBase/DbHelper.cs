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
	}
}
