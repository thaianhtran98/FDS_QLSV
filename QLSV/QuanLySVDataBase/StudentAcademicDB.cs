using System;
using System.Collections;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using QuanLySVHelperDataBase;
using QuanLySVModel;

namespace QuanLySVDataBase
{
	/// <summary>
	/// Represents the student academic.
	/// </summary>
	public class StudentAcademicDB
	{
		private DBHelper DBHelper = new DBHelper();
		public DataTable DBStudentAcademic
		{
			get; set;
		}

		private OracleDataAdapter _adapter;
		private OracleCommand fillSql;
		private OracleCommand createSql;
		private OracleCommand updateSql;
		private OracleCommand deleteSql;

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
				"LEFT JOIN SUBJECT SJ ON SJ.SUBJECTID = SA.SUBJECTID " +
				"WHERE SA.STUDENTID = :STUDENTID", conn);
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

		public DataTable FillData(string studentId, bool forceReload = false)
		{
			try
			{
				if (DBStudentAcademic == null || forceReload)
				{
					DBStudentAcademic = new DataTable("StudentAcademicDataTable");
					fillSql.Parameters.Add(new OracleParameter { ParameterName = ":STUDENTID", Value = studentId });
					_adapter.Fill(DBStudentAcademic);
				}

				return DBStudentAcademic;
			}
			catch (Exception)
			{
				return null;
			}
		}

		public bool CreateRowStudentAcademic(StudentAcademicModel academic)
		{
			DataRow newRow = DBStudentAcademic.NewRow();
			SetRowValues(newRow, academic);
			DBStudentAcademic.Rows.Add(newRow);
			return true;
        }

		public void UpdateStudentId(string newStudentId)
		{
			foreach (DataRow r in DBStudentAcademic.Rows)
			{
				r["STUDENTID"] = newStudentId;
			}
		}

		private void SetRowValues(DataRow row, StudentAcademicModel academic)
		{
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
