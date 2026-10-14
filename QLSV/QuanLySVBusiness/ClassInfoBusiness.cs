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
	/// Business layer for classes; forwards calls to <see cref="ClassInfoDB"/> and maps rows to <see cref="ClassInfoModel"/>.
	/// </summary>
	public class ClassInfoBusiness
	{
		ClassInfoDB _ClassInfoDB = new ClassInfoDB();

		/// <summary>
		/// Returns the cached class table, reloading it from the database when <paramref name="forceReload"/> is true.
		/// </summary>
		public DataTable FillClassInfo(bool forceReload = false)
		{
			return _ClassInfoDB.FillData(forceReload);
		}

		/// <summary>
		/// Adds a new class to the cache (not saved to the database yet).
		/// </summary>
		public bool CreateNewClassInfo(ClassInfoModel classInfo)
		{
			return _ClassInfoDB.CreateNewClass(classInfo);
		}

		/// <summary>
		/// Finds a class by id and maps the row to a <see cref="ClassInfoModel"/>. Returns null when not found.
		/// </summary>
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

		/// <summary>
		/// Updates the cached class with the given id.
		/// </summary>
		public bool UpdateClassInfo(ClassInfoModel classInfo, string classInfoId)
		{
			return _ClassInfoDB.UpdateClass(classInfo, classInfoId);
		}

		/// <summary>
		/// Marks the class with the given id as deleted in the cache.
		/// </summary>
		public bool DeleteClassInfo(string classInfoId)
		{
			return _ClassInfoDB.DeleteClass(classInfoId);
		}

		/// <summary>
		/// Checks whether there are unsaved class changes.
		/// </summary>
		public bool HasChanges()
		{
			return _ClassInfoDB.HasChanges();
		}

		/// <summary>
		/// Saves all pending class changes to the database.
		/// </summary>
		public bool SaveAll()
		{
			return _ClassInfoDB.SaveAll();
		}
	}
}
