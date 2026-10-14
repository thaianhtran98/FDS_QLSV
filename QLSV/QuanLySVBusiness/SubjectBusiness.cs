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
	/// Business layer for subjects; forwards calls to <see cref="SubjectDB"/> and maps rows to <see cref="SubjectModel"/>.
	/// </summary>
	public class SubjectBusiness
	{
		SubjectDB _SubjectDB = new SubjectDB();

		/// <summary>
		/// Returns the cached subject table, reloading it from the database when <paramref name="forceReload"/> is true.
		/// </summary>
		public DataTable FillSubject(bool forceReload = false)
		{
			return _SubjectDB.FillData(forceReload);
		}

		/// <summary>
		/// Adds a new subject to the cache (not saved to the database yet).
		/// </summary>
		public bool CreateNewSubject(SubjectModel subject)
		{
			return _SubjectDB.CreateNewSubject(subject);
		}

		/// <summary>
		/// Finds a subject by id and maps the row to a <see cref="SubjectModel"/>. Returns null when not found.
		/// </summary>
		public SubjectModel FindSubjectById(string subjectId)
		{
			DataRow subjectRow = _SubjectDB.FindSubjectById(subjectId);
			SubjectModel subject = null;
			if (subjectRow != null)
			{
				subject = new SubjectModel();
				subject.SubjectId = subjectRow["SUBJECTID"].ToString();
				subject.SubjectName = subjectRow["SUBJECTNAME"].ToString();
				subject.Credits = Convert.ToInt32(subjectRow["CREDITS"]);
				subject.Description = subjectRow["DESCRIPTION"].ToString();
				subject.Status = Convert.ToInt32(subjectRow["STATUS"]);
			}

			return subject;
		}

		// Generate next subject id (MH01, MH02, ...)
		/// <summary>
		/// Generates the next subject id (MH01, MH02, ...) from the highest existing MHxx id,
		/// including rows that are deleted but not saved yet.
		/// </summary>
		public string GenerateSubjectId()
		{
			DataTable dt = _SubjectDB.FillData();
			int maxNumber = 0;
			foreach (DataRow subjectRow in dt.Rows)
			{
				// Deleted rows still hold their id until saved
				string subjectId = subjectRow.RowState == DataRowState.Deleted
					? subjectRow["SUBJECTID", DataRowVersion.Original].ToString()
					: subjectRow["SUBJECTID"].ToString();

				int number;
				if (subjectId.StartsWith("MH") && int.TryParse(subjectId.Substring(2), out number) && number > maxNumber)
				{
					maxNumber = number;
				}
			}

			return "MH" + (maxNumber + 1).ToString("00");
		}

		/// <summary>
		/// Updates the cached subject with the given id.
		/// </summary>
		public bool UpdateSubject(SubjectModel subject, string subjectId)
		{
			return _SubjectDB.UpdateSubject(subject, subjectId);
		}

		/// <summary>
		/// Marks the subject with the given id as deleted in the cache.
		/// </summary>
		public bool DeleteSubject(string subjectId)
		{
			return _SubjectDB.DeleteSubject(subjectId);
		}

		/// <summary>
		/// Checks whether there are unsaved subject changes.
		/// </summary>
		public bool HasChanges()
		{
			return _SubjectDB.HasChanges();
		}

		/// <summary>
		/// Saves all pending subject changes to the database.
		/// </summary>
		public bool SaveAll()
		{
			return _SubjectDB.SaveAll();
		}
	}
}
