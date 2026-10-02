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

namespace QuanLySVDataBase
{
	/// <summary>
	/// Represents the student.
	/// </summary>
	public class Student
	{
		private DBHelper DBHelper = new DBHelper();
		/// <summary>
		/// The male.
		/// </summary>
		public static int MALE = 1;
		/// <summary>
		/// The female.
		/// </summary>
		public static int FEMALE = 0;
		/// <summary>
		/// The active.
		/// </summary>
		public static int ACTIVE = 1;
		/// <summary>
		/// The inactive.
		/// </summary>
		public static int INACTIVE = 0;

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets the student id.
		/// </summary>
		public string StudentId { get; set; }
		/// <summary>
		/// Gets or sets the sex.
		/// </summary>
		public int Sex { get; set; }
		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		public int Status { get; set; }
		/// <summary>
		/// Gets or sets the birth of date.
		/// </summary>
		public DateTime BirthOfDate { get; set; }
		/// <summary>
		/// Gets or sets the date of issue.
		/// </summary>
		public DateTime DateOfIssue { get; set; }
		/// <summary>
		/// Gets or sets the birth local.
		/// </summary>
		public string BirthLocal { get; set; }
		/// <summary>
		/// Gets or sets the vne id.
		/// </summary>
		public string VneId { get; set; }
		/// <summary>
		/// Gets or sets the local of issue.
		/// </summary>
		public string LocalOfIssue { get; set; }
		/// <summary>
		/// Gets or sets the local.
		/// </summary>
		public string Hometown { get; set; }
		/// <summary>
		/// Gets or sets the place of residence.
		/// </summary>
		public string PlaceOfResidence { get; set; }
		/// <summary>
		/// Gets or sets the number phone.
		/// </summary>
		public string NumberPhone { get; set; }

		public DataTable FillData()
		{
			DataTable dt = new DataTable();
			string sql = "SELECT STUDENTID, NAME, SEX, BIRTHOFDATE, BIRTHLOCAL, VNEID, " +
				"DATEOFISSUE, LOCALOFISSUE, LOCAL, PLACEOFRESIDENCE, NUMBERPHONE, STATUS " +
				"FROM STUDENT ";

			string errMessage = null;
            	dt = DBHelper.ExecuteQuery(sql);

            return dt;
		}
	}
}
