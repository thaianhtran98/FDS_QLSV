using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySVModel
{
    public class ClassInfoModel
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
		/// Gets or sets the class id.
		/// </summary>
		public string ClassId { get; set; }
		/// <summary>
		/// Gets or sets the class name.
		/// </summary>
		public string ClassName { get; set; }
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
		public override string ToString() { return ClassName; }
	}
}
