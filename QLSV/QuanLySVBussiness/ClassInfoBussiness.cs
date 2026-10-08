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
	public class ClassInfoBussiness
	{
		ClassInfoDB _ClassInfoDB = new ClassInfoDB();

		public DataTable FillClassInfo(bool forceReload = false)
		{
			return _ClassInfoDB.FillData();
		}

		public bool CreatNewClassInfo(ClassInfoModel classInfo)
		{
			return _ClassInfoDB.CreateNewClass(classInfo);
		}

		public ClassInfoModel FindClassInfoById(string classInfoId)
		{
			DataRow classInfoRow = _ClassInfoDB.FindClassById(classInfoId);
			ClassInfoModel classInfo = null;
			if (classInfoRow != null)
			{
				classInfo = new ClassInfoModel();
				classInfo.ClassId = classInfoRow["CLASSID"].ToString();
				classInfo.ClassName = classInfoRow["CLASSNAME"].ToString();
				classInfo.Description = classInfoRow["DESCRIPTION"].ToString();
				classInfo.Status = Convert.ToInt32(classInfoRow["STATUS"]);
			}

			return classInfo;
		}

		public bool UpdateClassInfo(ClassInfoModel classInfo, string classInfoId)
		{
			return _ClassInfoDB.UpdateClass(classInfo, classInfoId);
		}

		public bool DeleteClassInfo(string classInfoId)
		{
			return _ClassInfoDB.DeleteClass(classInfoId);
		}

		public bool HasChanges()
		{
			return _ClassInfoDB.HasChanges();
		}

		public bool SaveAll()
		{
			return _ClassInfoDB.SaveAll();
		}
	}
}
