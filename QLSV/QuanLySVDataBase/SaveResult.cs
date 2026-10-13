using System.Collections.Generic;

namespace QuanLySVDataBase
{
	/// <summary>
	/// Represents the result of a batch save: success/failure counts and error messages.
	/// </summary>
	public class SaveResult
	{
		/// <summary>
		/// Gets or sets the number of records saved successfully.
		/// </summary>
		public int Success { get; set; }
		/// <summary>
		/// Gets or sets the number of records that failed to save.
		/// </summary>
		public int Failed { get; set; }
		/// <summary>
		/// Gets the total number of processed records (<see cref="Success"/> + <see cref="Failed"/>).
		/// </summary>
		public int Total { get { return Success + Failed; } }
		/// <summary>
		/// Gets or sets the error messages collected during the save.
		/// </summary>
		public List<string> Errors { get; set; }

		/// <summary>
		/// Gets a value indicating whether at least one record was saved successfully.
		/// </summary>
		public bool HasSuccess { get { return Success > 0; } }

		/// <summary>
		/// Initializes a new instance with an empty error list.
		/// </summary>
		public SaveResult()
		{
			Errors = new List<string>();
		}

		/// <summary>
		/// Returns a readable summary of the result (successes / total | failures).
		/// </summary>
		public override string ToString()
		{
			return string.Format("Thành công: {0} / {1}  |  Lỗi: {2}", Success, Total, Failed);
		}
	}
}
