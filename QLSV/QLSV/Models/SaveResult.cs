using System.Collections.Generic;

namespace QLSV.Models
{
	/// <summary>
	/// Represents the save result.
	/// </summary>
	public class SaveResult
	{
		/// <summary>
		/// Gets or sets the success.
		/// </summary>
		public int Success { get; set; }
		/// <summary>
		/// Gets or sets the failed.
		/// </summary>
		public int Failed { get; set; }
		/// <summary>
		/// Gets or sets the total.
		/// </summary>
		public int Total { get { return Success + Failed; } }
		/// <summary>
		/// Gets or sets the errors.
		/// </summary>
		public List<string> Errors { get; set; }

		/// <summary>
		/// Gets or sets the has success.
		/// </summary>
		public bool HasSuccess { get { return Success > 0; } }

		/// <summary>
		/// Handles the save result logic.
		/// </summary>
		public SaveResult()
		{
			Errors = new List<string>();
		}

		/// <summary>
		/// Handles the to string logic.
		/// </summary>
		public override string ToString()
		{
			return string.Format("Thành công: {0} / {1}  |  Lỗi: {2}", Success, Total, Failed);
		}
	}
}
