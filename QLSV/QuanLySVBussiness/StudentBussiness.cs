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
	/// Business layer for students; forwards calls to <see cref="StudentDB"/> and maps rows to <see cref="StudentModel"/>.
	/// </summary>
	public class StudentBussiness
	{
		StudentDB _StudentDB = new StudentDB();

		/// <summary>
		/// Returns the cached student table (loaded from the database on first call).
		/// </summary>
		public DataTable FillStudent(bool forceReload = false)
		{
			return _StudentDB.FillData();
		}

		/// <summary>
		/// Returns the students filtered by name (contains) and sex (-1 = all).
		/// </summary>
		public DataTable Filter(string name, int sex)
		{
			return _StudentDB.FilterStudent(name, sex);
        }

		/// <summary>
		/// Adds a new student to the cache (not saved to the database yet).
		/// </summary>
		public bool CreatNewStudent(StudentModel student)
		{
			return _StudentDB.CreatNewStudent(student);
		}

		/// <summary>
		/// Finds a student by id and maps the row to a <see cref="StudentModel"/>. Returns null when not found.
		/// </summary>
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

		/// <summary>
		/// Updates the cached student with the given id.
		/// </summary>
		public bool UpdateStudent(StudentModel student, string studentId)
		{
			return _StudentDB.UpdateStudent(student, studentId);
		}

		/// <summary>
		/// Marks the student with the given id as deleted in the cache.
		/// </summary>
		public bool DeleteStudent(string studentId)
		{
			return _StudentDB.DeleteStudent(studentId);
		}

		/// <summary>
		/// Checks whether there are unsaved student changes.
		/// </summary>
		public bool HasChanges()
		{
			return _StudentDB.HasChanges();
		}

		/// <summary>
		/// Saves all pending student changes to the database. <paramref name="errMessage"/> receives the error when it fails.
		/// </summary>
		public bool SaveAll(out string errMessage)
		{
            return _StudentDB.SaveAll(out errMessage);
		}
	}
}
