using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySVModel
{
    /// <summary>
    /// Represents a school year (e.g. 2024 - 2025).
    /// </summary>
    public class SchoolYearModel
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
		/// Gets or sets the school year id.
		/// </summary>
		public string SchoolYearId { get; set; }
		/// <summary>
		/// Gets or sets the school year name.
		/// </summary>
		public string SchoolYearName { get; set; }
		/// <summary>
		/// Gets or sets the start year.
		/// </summary>
		public int StartYear { get; set; }
		/// <summary>
		/// Gets or sets the end year.
		/// </summary>
		public int EndYear { get; set; }
		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		public int Status { get; set; }

		/// <summary>
		/// Returns the school year name (used as display text).
		/// </summary>
		public override string ToString() { return SchoolYearName; }
	}
}
