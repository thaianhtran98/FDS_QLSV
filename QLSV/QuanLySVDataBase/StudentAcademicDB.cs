using System;
using System.Collections;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using QuanLySVHelperDataBase;
using QuanLySVModel;

namespace QuanLySVDataBase
{
	/// <summary>
	/// Data access for the STUDENT_ACADEMIC table (joined with CLASS, SCHOOL_YEAR and SUBJECT for display names).
	/// Keeps an in-memory cache of all records and pushes pending changes to Oracle through an <see cref="OracleDataAdapter"/>.
	/// </summary>
	public class StudentAcademicDB
	{
		private DBHelper DBHelper = new DBHelper();
		/// <summary>
		/// Gets or sets the cached STUDENT_ACADEMIC table (records of all students).
		/// </summary>
		public DataTable DBStudentAcademic
		{
			get; set;
		}

		private OracleDataAdapter _adapter;
		private OracleCommand fillSql;
		private OracleCommand createSql;
		private OracleCommand updateSql;
		private OracleCommand deleteSql;

		/// <summary>
		/// Creates the SELECT/INSERT/UPDATE/DELETE commands and binds them to the data adapter.
		/// </summary>
		public StudentAcademicDB()
		{
			OracleConnection conn = new OracleConnection(DBHelper.ConnectionString);

			// Select Command (join to get display names)
			fillSql = new OracleCommand("SELECT SA.ACADEMICID, SA.STUDENTID, SA.CLASSID, C.CLASSNAME, " +
				"SA.SCHOOLYEARID, SY.SCHOOLYEARNAME, SA.SUBJECTID, SJ.SUBJECTNAME, " +
				"SA.SCORE, SA.SCORE_LETTER, SA.SEMESTER, SA.NOTE, SA.STATUS " +
				"FROM STUDENT_ACADEMIC SA " +
				"LEFT JOIN CLASS C ON C.CLASSID = SA.CLASSID " +
				"LEFT JOIN SCHOOL_YEAR SY ON SY.SCHOOLYEARID = SA.SCHOOLYEARID " +
				"LEFT JOIN SUBJECT SJ ON SJ.SUBJECTID = SA.SUBJECTID", conn);
			fillSql.BindByName = true;

			// Insert Command
			createSql = new OracleCommand("INSERT INTO STUDENT_ACADEMIC (ACADEMICID, STUDENTID, CLASSID, SCHOOLYEARID, SUBJECTID, SCORE, SCORE_LETTER, SEMESTER, NOTE, STATUS) " +
				"VALUES (:ACADEMICID, :STUDENTID, :CLASSID, :SCHOOLYEARID, :SUBJECTID, :SCORE, :SCORE_LETTER, :SEMESTER, :NOTE, :STATUS)", conn);
			createSql.BindByName = true;

			// Update Command
			updateSql = new OracleCommand("UPDATE STUDENT_ACADEMIC SET " +
				"STUDENTID = :STUDENTID, " +
				"CLASSID = :CLASSID, " +
				"SCHOOLYEARID = :SCHOOLYEARID, " +
				"SUBJECTID = :SUBJECTID, " +
				"SCORE = :SCORE, " +
				"SCORE_LETTER = :SCORE_LETTER, " +
				"SEMESTER = :SEMESTER, " +
				"NOTE = :NOTE, " +
				"STATUS = :STATUS " +
				"WHERE ACADEMICID = :ACADEMICID", conn);
			updateSql.BindByName = true;

			// Delete Command
			deleteSql = new OracleCommand("DELETE FROM STUDENT_ACADEMIC WHERE ACADEMICID = :ACADEMICID", conn);
			deleteSql.BindByName = true;

			// Add parameters
			string[] columns = new[] { "ACADEMICID", "STUDENTID", "CLASSID", "SCHOOLYEARID", "SUBJECTID", "SCORE", "SCORE_LETTER", "SEMESTER", "NOTE", "STATUS" };
			foreach (string column in columns)
			{
				createSql.Parameters.Add(new OracleParameter { ParameterName = column, SourceColumn = column });
				updateSql.Parameters.Add(new OracleParameter { ParameterName = column, SourceColumn = column });
			}
			deleteSql.Parameters.Add(new OracleParameter { ParameterName = "ACADEMICID", SourceColumn = "ACADEMICID", SourceVersion = DataRowVersion.Original });

			_adapter = new OracleDataAdapter();
			_adapter.SelectCommand = fillSql;
			_adapter.InsertCommand = createSql;
			_adapter.UpdateCommand = updateSql;
			_adapter.DeleteCommand = deleteSql;
		}

		/// <summary>
		/// Loads all academic records into the cache (only when it is empty or <paramref name="forceReload"/> is true)
		/// and returns a view of the current rows of the given student. Returns null when loading fails.
		/// </summary>
		public DataView FillData(string studentId, bool forceReload = false)
		{
			try
			{
				if (DBStudentAcademic == null || forceReload)
				{
					DBStudentAcademic = new DataTable("StudentAcademicDataTable");
					_adapter.Fill(DBStudentAcademic);
				}

				string filter = "STUDENTID = '" + (studentId ?? "").Replace("'", "''") + "'";
				return new DataView(DBStudentAcademic, filter, "", DataViewRowState.CurrentRows);
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Adds a new academic record row to the cache.
		/// </summary>
		public bool CreateRowStudentAcademic(StudentAcademicModel academic)
		{
			DataRow newRow = DBStudentAcademic.NewRow();
			SetRowValues(newRow, academic);
			DBStudentAcademic.Rows.Add(newRow);
			return true;
        }

		/// <summary>
		/// Overwrites the given cached row with the values of the academic model.
		/// </summary>
		public bool UpdateRowStudentAcademic(StudentAcademicModel academic, DataRow RowEditing)
		{
			SetRowValues(RowEditing, academic);
			return true;
		}

		/// <summary>
		/// Sets the STUDENTID column of every cached row to <paramref name="newStudentId"/>.
		/// </summary>
		public void UpdateStudentId(string newStudentId)
		{
			if (DBStudentAcademic == null)
			{
				return;
			}
			foreach (DataRow r in DBStudentAcademic.Rows)
			{
				r["STUDENTID"] = newStudentId;
			}
		}

		/// <summary>
		/// Writes all pending changes (insert/update/delete) of the cache to the database. Exceptions are rethrown.
		/// </summary>
		public bool SaveAll()
		{
			try
			{
				_adapter.Update(DBStudentAcademic);
				return true;
			} 
			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Marks the given academic record row as deleted.
		/// </summary>
		public bool DeleteStudentAcademic(DataRow RowDelete)
		{
			RowDelete.Delete();
			return true;
		}

		/// <summary>
		/// Copies the values of a <see cref="StudentAcademicModel"/> into the given row
		/// (AcademicId 0 and a missing score are stored as DBNull).
		/// </summary>
		private void SetRowValues(DataRow row, StudentAcademicModel academic)
		{
			row["ACADEMICID"] = academic.AcademicId == 0 ? DBNull.Value : (object)academic.AcademicId;
			row["STUDENTID"] = academic.StudentId;
			row["CLASSID"] = academic.ClassId;
			row["CLASSNAME"] = academic.ClassName;
			row["SCHOOLYEARID"] = academic.SchoolYearId;
			row["SCHOOLYEARNAME"] = academic.SchoolYearName;
			row["SUBJECTID"] = academic.SubjectId;
			row["SUBJECTNAME"] = academic.SubjectName;
			row["SCORE"] = academic.Score.HasValue ? (object)academic.Score.Value : DBNull.Value;
			row["SCORE_LETTER"] = academic.ScoreLetter;
			row["SEMESTER"] = academic.Semester;
			row["NOTE"] = academic.Note;
			row["STATUS"] = academic.Status;
		}
	}
}
