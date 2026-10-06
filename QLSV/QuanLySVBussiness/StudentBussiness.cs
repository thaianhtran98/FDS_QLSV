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
	public class StudentBussiness
	{
		StudentDB _StudentDB = new StudentDB();

		public DataTable FillStudent(bool forceReload = false)
		{
			return _StudentDB.FillData();
		}

		public DataTable Filter(string name, int sex)
		{
			return _StudentDB.FilterStudent(name, sex);
        }

		public bool CreatNewStudent(StudentModel student)
		{
			return _StudentDB.CreatNewStudent(student);
		}

		public StudentModel FindStudentById(string studentId)
		{
			DataRow studentRow = _StudentDB.FindStudentById(studentId);
			StudentModel student = null;
			if (studentRow != null)
			{
				student = new StudentModel();
				student.StudentId = studentRow["STUDENTID"].ToString();
				student.Name = studentRow["NAME"].ToString();
				student.Sex = Convert.ToInt32(studentRow["SEX"]);
				student.BirthOfDate = (DateTime)studentRow["BIRTHOFDATE"];
				student.BirthLocal = studentRow["BIRTHLOCAL"].ToString();
				student.VneId = studentRow["VNEID"].ToString();
				student.DateOfIssue = (DateTime)studentRow["DATEOFISSUE"];
				student.LocalOfIssue = studentRow["LOCALOFISSUE"].ToString();
				student.Hometown = studentRow["HOMETOWN"].ToString();
				student.PlaceOfResidence = studentRow["PLACEOFRESIDENCE"].ToString();
				student.NumberPhone = studentRow["NUMBERPHONE"].ToString();
				student.Status = Convert.ToInt32(studentRow["STATUS"]);
			}
			
			return student;
		}

		public bool UpdateStudent(StudentModel student, string studentId)
		{
			return _StudentDB.UpdateStudent(student, studentId);
		}

		public bool DeleteStudent(string studentId)
		{
			return _StudentDB.DeleteStudent(studentId);
		}

		public bool HasChanges()
		{
			return _StudentDB.HasChanges();
		}

		public bool SaveAll()
		{
			return _StudentDB.SaveAll();
		}
	}
}
