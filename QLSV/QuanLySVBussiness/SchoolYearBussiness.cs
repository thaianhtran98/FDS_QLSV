using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLySVDataBase;
using QuanLySVModel;

namespace QuanLySVBussiness
{
	public class SchoolYearBussiness
	{
		SchoolYearDB _SchoolYearDB = new SchoolYearDB();

		public DataTable FillSchoolYear(bool forceReload = false)
		{
			return _SchoolYearDB.FillData(forceReload);
		}

		public bool CreatNewSchoolYear(SchoolYearModel schoolYear)
		{
			return _SchoolYearDB.CreateNewSchoolYear(schoolYear);
		}

		public SchoolYearModel FindSchoolYearById(string schoolYearId)
		{
			DataRow schoolYearRow = _SchoolYearDB.FindSchoolYearById(schoolYearId);
			SchoolYearModel schoolYear = null;
			if (schoolYearRow != null)
			{
				schoolYear = new SchoolYearModel();
				schoolYear.SchoolYearId = schoolYearRow["SCHOOLYEARID"].ToString();
				schoolYear.SchoolYearName = schoolYearRow["SCHOOLYEARNAME"].ToString();
				schoolYear.StartYear = Convert.ToInt32(schoolYearRow["START_YEAR"]);
				schoolYear.EndYear = Convert.ToInt32(schoolYearRow["END_YEAR"]);
				schoolYear.Status = Convert.ToInt32(schoolYearRow["STATUS"]);
			}

			return schoolYear;
		}

		public bool UpdateSchoolYear(SchoolYearModel schoolYear, string schoolYearId)
		{
			return _SchoolYearDB.UpdateSchoolYear(schoolYear, schoolYearId);
		}

		public bool DeleteSchoolYear(string schoolYearId)
		{
			return _SchoolYearDB.DeleteSchoolYear(schoolYearId);
		}

		public bool HasChanges()
		{
			return _SchoolYearDB.HasChanges();
		}

		public bool SaveAll()
		{
			return _SchoolYearDB.SaveAll();
		}
	}
}
