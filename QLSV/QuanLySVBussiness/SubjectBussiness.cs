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
	public class SubjectBussiness
	{
		SubjectDB _SubjectDB = new SubjectDB();

		public DataTable FillSubject(bool forceReload = false)
		{
			return _SubjectDB.FillData(forceReload);
		}

		public bool CreatNewSubject(SubjectModel subject)
		{
			return _SubjectDB.CreateNewSubject(subject);
		}

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

		public bool UpdateSubject(SubjectModel subject, string subjectId)
		{
			return _SubjectDB.UpdateSubject(subject, subjectId);
		}

		public bool DeleteSubject(string subjectId)
		{
			return _SubjectDB.DeleteSubject(subjectId);
		}

		public bool HasChanges()
		{
			return _SubjectDB.HasChanges();
		}

		public bool SaveAll()
		{
			return _SubjectDB.SaveAll();
		}
	}
}
