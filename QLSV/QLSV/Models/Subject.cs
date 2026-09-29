using System;

namespace QLSV.Models
{
	/// <summary>
	/// Represents the subject.
	/// </summary>
	public class Subject
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
		/// Gets or sets the subject id.
		/// </summary>
		public string SubjectId { get; set; }
		/// <summary>
		/// Gets or sets the subject name.
		/// </summary>
		public string SubjectName { get; set; }
		/// <summary>
		/// Gets or sets the credits.
		/// </summary>
		public int Credits { get; set; }
		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		public int Status { get; set; }

		/// <summary>
		/// Handles the to string logic.
		/// </summary>
		public override string ToString() { return SubjectName; }
	}
}
