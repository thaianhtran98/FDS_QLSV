using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLySVBussiness
{
	public class StudentBussiness
	{
		QuanLySVDataBase.Student StudentDB = new QuanLySVDataBase.Student();

		public DataTable FillStudent()
		{
			return StudentDB.FillData();
		}
	}
}
