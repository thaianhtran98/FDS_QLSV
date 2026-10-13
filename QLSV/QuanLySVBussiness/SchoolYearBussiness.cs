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
	/// <summary>
	/// Business layer for school years; forwards calls to <see cref="SchoolYearDB"/> and maps rows to <see cref="SchoolYearModel"/>.
	/// </summary>
	public class SchoolYearBussiness
	{
		SchoolYearDB _SchoolYearDB = new SchoolYearDB();

		/// <summary>
		/// Returns the cached school year table, reloading it from the database when <paramref name="forceReload"/> is true.
		/// </summary>
		public DataTable FillSchoolYear(bool forceReload = false)
		{
			return _SchoolYearDB.FillData(forceReload);
		}

		/// <summary>
		/// Adds a new school year to the cache (not saved to the database yet).
		/// </summary>
		public bool CreatNewSchoolYear(SchoolYearModel schoolYear)
		{
			return _SchoolYearDB.CreateNewSchoolYear(schoolYear);
		}

		/// <summary>
		/// Finds a school year by id and maps the row to a <see cref="SchoolYearModel"/>. Returns null when not found.
		/// </summary>
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

		/// <summary>
		/// Updates the cached school year with the given id.
		/// </summary>
		public bool UpdateSchoolYear(SchoolYearModel schoolYear, string schoolYearId)
		{
			return _SchoolYearDB.UpdateSchoolYear(schoolYear, schoolYearId);
		}

		/// <summary>
		/// Marks the school year with the given id as deleted in the cache.
		/// </summary>
		public bool DeleteSchoolYear(string schoolYearId)
		{
			return _SchoolYearDB.DeleteSchoolYear(schoolYearId);
		}

		/// <summary>
		/// Checks whether there are unsaved school year changes.
		/// </summary>
		public bool HasChanges()
		{
			return _SchoolYearDB.HasChanges();
		}

		/// <summary>
		/// Saves all pending school year changes to the database.
		/// </summary>
		public bool SaveAll()
		{
			return _SchoolYearDB.SaveAll();
		}
	}
}
