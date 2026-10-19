using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLySVDataBase;
using QuanLySVModel;

namespace QuanLySVBusiness
{
	/// <summary>
	/// Business layer for student academic records; forwards calls to <see cref="StudentAcademicDB"/>.
	/// </summary>
	public class StudentAcademicBusiness
	{
		StudentAcademicDB _StudentAcademicDB = new StudentAcademicDB();

		/// <summary>
		/// Returns a view of the academic records of the given student.
		/// </summary>
		public DataView FillStudentAcademic(string studentId, bool forceReload = false)
		{
			return _StudentAcademicDB.FillData(studentId, forceReload);
		}

		/// <summary>
		/// Adds a new academic record to the cache (not saved to the database yet).
		/// </summary>
		public bool CreateRowStudentAcademic(StudentAcademicModel academic)
		{
			_StudentAcademicDB.CreateRowStudentAcademic(academic);
			return true;
		}

		/// <summary>
		/// Updates the given cached academic record row with the values of the model.
		/// </summary>
		public bool UpdateRowStudentAcademic(StudentAcademicModel academic, DataRow RowEditing)
		{
			_StudentAcademicDB.UpdateRowStudentAcademic(academic, RowEditing);
			return true;
		}

		// Convert score (scale 10) to letter grade (A, B, C, D, F)
		/// <summary>
		/// Converts a score on the 10-point scale to a letter grade:
		/// A (&gt;= 8.5), B (&gt;= 7.0), C (&gt;= 5.5), D (&gt;= 4.0), otherwise F. Returns null when the score is null.
		/// </summary>
		public string ConvertScoreToLetter(decimal? score)
		{
			if (!score.HasValue)
			{
				return null;
			}

			if (score >= 8.5m) return "A";
			if (score >= 7.0m) return "B";
			if (score >= 5.5m) return "C";
			if (score >= 4.0m) return "D";
			return "F";
		}

		/// <summary>
		/// Sets the student id of the cached academic records to <paramref name="newStudentId"/>.
		/// </summary>
		public void UpdateStudentId(string newStudentId, string oldStudentId)
		{
			_StudentAcademicDB.UpdateStudentId(newStudentId, oldStudentId);
        }

		/// <summary>
		/// Saves all pending academic record changes to the database.
		/// </summary>
		public bool SaveAll(out string errMessage)
		{
			errMessage = null;
            _StudentAcademicDB.SaveAll(out errMessage);
			return true;
		}
		
		/// <summary>
		/// Marks the given academic record row as deleted.
		/// </summary>
		public bool DeleteStudentAcademic(DataRow RowDelete)
		{
			return _StudentAcademicDB.DeleteStudentAcademic(RowDelete);
		}
    }
}
