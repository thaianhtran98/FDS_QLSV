using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySVModel
{
    public class StudentAcademicModel
    {
		/// <summary>
		/// The active.
		/// </summary>
		public static int ACTIVE = 1;
		/// <summary>
		/// The inactive.
		/// </summary>
		public static int INACTIVE = 0;

		/// <summary>
		/// Gets or sets the academic id.
		/// </summary>
		public long AcademicId { get; set; }
		/// <summary>
		/// Gets or sets the student id.
		/// </summary>
		public string StudentId { get; set; }
		/// <summary>
		/// Gets or sets the class id.
		/// </summary>
		public string ClassId { get; set; }
		/// <summary>
		/// Gets or sets the class name.
		/// </summary>
		public string ClassName { get; set; }       // join display
		/// <summary>
		/// Gets or sets the school year id.
		/// </summary>
		public string SchoolYearId { get; set; }
		/// <summary>
		/// Gets or sets the school year name.
		/// </summary>
		public string SchoolYearName { get; set; }  // join display
		/// <summary>
		/// Gets or sets the subject id.
		/// </summary>
		public string SubjectId { get; set; }
		/// <summary>
		/// Gets or sets the subject name.
		/// </summary>
		public string SubjectName { get; set; }     // join display
		/// <summary>
		/// Gets or sets the score.
		/// </summary>
		public decimal? Score { get; set; }
		/// <summary>
		/// Gets or sets the score letter.
		/// </summary>
		public string ScoreLetter { get; set; }
		/// <summary>
		/// Gets or sets the semester.
		/// </summary>
		public int Semester { get; set; }
		/// <summary>
		/// Gets or sets the note.
		/// </summary>
		public string Note { get; set; }
		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		public int Status { get; set; }
	}
}
