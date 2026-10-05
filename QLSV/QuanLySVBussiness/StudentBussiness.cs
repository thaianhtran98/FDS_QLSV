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

		public DataTable FillStudent()
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
	}
}
