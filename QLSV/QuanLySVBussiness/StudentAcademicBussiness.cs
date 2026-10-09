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
	public class StudentAcademicBussiness
	{
		StudentAcademicDB _StudentAcademicDB = new StudentAcademicDB();

		public DataTable FillStudentAcademic(string studentId, bool forceReload = false)
		{
			return _StudentAcademicDB.FillData(studentId, forceReload);
		}

		public bool CreateRowStudentAcademic(StudentAcademicModel academic)
		{
			_StudentAcademicDB.CreateRowStudentAcademic(academic);
			return true;
		}

		public bool UpdateRowStudentAcademic(StudentAcademicModel academic)
		{
			_StudentAcademicDB.CreateRowStudentAcademic(academic);
			return true;
		}

		// Convert score (scale 10) to letter grade (A, B, C, D, F)
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

		public void UpdateStudentId(string newStudentId)
		{
			_StudentAcademicDB.UpdateStudentId(newStudentId);
        }
	}
}
