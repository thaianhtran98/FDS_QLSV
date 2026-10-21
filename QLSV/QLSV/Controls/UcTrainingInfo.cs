using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySVBusiness;
using QuanLySVModel;

namespace QuanLySV.Controls
{
	/// <summary>
	/// Tabs of the training info screen. <see cref="AllTab"/> is used to validate every tab at once.
	/// </summary>
	public enum TrainingInfoTab
	{
		Class = 0,
		SchoolYear = 1,
		Subject = 2,
		AllTab = 3
	}

	/// <summary>
	/// User control to manage classes, school years and subjects, each on its own tab.
	/// </summary>
	public partial class UcTrainingInfo : UserControl
	{
		// Define
		private ClassInfoBusiness ClassInfoBus;
		private ClassInfoModel ClassInfoCurrent;
		private SchoolYearBusiness SchoolYearBus;
		private SchoolYearModel SchoolYearCurrent;
		private SubjectBusiness SubjectBus;
		private SubjectModel SubjectCurrent;
		private bool ClassFormEditing = false;
		private bool SchoolFormEditing = false;
		private bool SubjectFormEditing = false;

		/// <summary>
		/// Initializes the components and the default school year values.
		/// </summary>
		public UcTrainingInfo()
		{
			InitializeComponent();
			LoadInit();
        }

		/// <summary>
		/// Sets the default school year range (this year to next year) and its display name.
		/// </summary>
		private void LoadInit()
		{
			DtpStartYear.Value = DateTime.Today;
			DtpEndYear.Value = DtpStartYear.Value.AddYears(1);
			TbxSchoolYearName.Text = DtpStartYear.Value.ToString("yyyy") + " - " + DtpEndYear.Value.ToString("yyyy");
		}

		/// <summary>
		/// Selects the tab shown first.
		/// </summary>
		public void Initialize(TrainingInfoTab initialTab = TrainingInfoTab.Class)
		{
			switch (initialTab)
			{
				case TrainingInfoTab.Class:
					TabTraingInfo.SelectedTab = TpgClass;
					break;
				case TrainingInfoTab.SchoolYear:
					TabTraingInfo.SelectedTab = TpgSchoolYear;
					break;
				case TrainingInfoTab.Subject:
					TabTraingInfo.SelectedTab = TpgSubject;
					break;
			}
		}

		/// <summary>
		/// Injects the business objects, creates empty current models and reloads the three grids from the database.
		/// </summary>
		public void LoadBusiness(ClassInfoBusiness classInfoBusiness, SchoolYearBusiness schoolYearBusiness, SubjectBusiness subjectBusiness)
		{
			ClassInfoBus = classInfoBusiness;
			ClassInfoCurrent = new ClassInfoModel();
			LoadClassData(true);

			SchoolYearBus = schoolYearBusiness;
			SchoolYearCurrent = new SchoolYearModel();
			LoadSchoolYearData(true);

			SubjectBus = subjectBusiness;
			SubjectCurrent = new SubjectModel();
			LoadSubjectData(true);
        }
		// End define

		// ClassInfo
		/// <summary>
		/// Binds the class table to the class grid.
		/// </summary>
		private void LoadClassData(bool forceReload = false)
		{
			DataTable dt = ClassInfoBus.FillClassInfo(forceReload);
			DgvListClass.AutoGenerateColumns = false;
			DgvListClass.DataSource = dt;
		}

		/// <summary>
		/// Validates the class form, then updates the selected class or adds a new one to the cache.
		/// </summary>
		private void BtnTempSaveClass_Click(object sender, EventArgs e)
		{
			string message = null;
			if (!Validator(TrainingInfoTab.Class, out message))
			{
				MessageBox.Show(message);
				return;
			}

			if (ClassFormEditing)
			{
				string oldClassId = ClassInfoCurrent.ClassId;
				// Update class after edit
				SetClassCurrent();
				ClassInfoBus.UpdateClassInfo(ClassInfoCurrent, oldClassId);
				ClassFormEditing = false;
			}
			else
			{
				SetClassCurrent();
				ClassInfoBus.CreateNewClassInfo(ClassInfoCurrent);
            }

			ResetForm(TrainingInfoTab.Class);
			message = "Thành công";
			MessageBox.Show(message);
		}

		// CellClick only fires on user click, not when the grid is bound/reloaded
		/// <summary>
		/// Loads the clicked class row into the form and switches the class form to edit mode.
		/// </summary>
		private void DgvListClass_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// Header row or delete button (handled in CellContentClick)
			if (e.RowIndex < 0 || e.ColumnIndex == DgvColActionDelete.Index)
			{
				return;
			}

			DataRowView rowView = DgvListClass.Rows[e.RowIndex].DataBoundItem as DataRowView;
			if (rowView == null)
			{
				return;
			}

			TbxClassId.Text = rowView["CLASSID"].ToString();
			TbxClassName.Text = rowView["CLASSNAME"].ToString();
			TbxDescriptionClass.Text = rowView["DESCRIPTION"].ToString();
			ChkStatusClass.Checked = Convert.ToInt32(rowView["STATUS"]) == ClassInfoModel.ACTIVE;
			BtnTempSaveClass.Text = "Cập nhật";

			SetClassCurrent();
			ClassFormEditing = true;
		}

		/// <summary>
		/// Deletes the class when its delete button is clicked.
		/// </summary>
		private void DgvListClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}

			DataGridViewRow row = DgvListClass.Rows[e.RowIndex];

			if (e.ColumnIndex == DgvColActionDelete.Index)
			{ 
				string classId = row.Cells["ClassId"].Value.ToString();
				string className = row.Cells["ClassName"].Value.ToString();
				DeleteTrainingInfo(classId, className, TrainingInfoTab.Class);
				return;
			}
		}

		/// <summary>
		/// Copies the class form values into <c>ClassInfoCurrent</c>.
		/// </summary>
		private void SetClassCurrent()
		{
			ClassInfoCurrent.ClassId = TbxClassId.Text;
			ClassInfoCurrent.ClassName = TbxClassName.Text;
			ClassInfoCurrent.Description = TbxDescriptionClass.Text;
			ClassInfoCurrent.Status = ChkStatusClass.Checked ? ClassInfoModel.ACTIVE : ClassInfoModel.INACTIVE;
		}
		// End ClassInfo

		// SchoolYear
		/// <summary>
		/// Binds the school year table to the school year grid.
		/// </summary>
		private void LoadSchoolYearData(bool forceReload = false)
		{
			DataTable dt = SchoolYearBus.FillSchoolYear(forceReload);
			DgvListSchoolYear.AutoGenerateColumns = false;
			DgvListSchoolYear.DataSource = dt;
		}

		/// <summary>
		/// Updates the school year name when the start year changes.
		/// </summary>
		private void DtpStartYear_ValueChanged(object sender, EventArgs e)
		{
			TbxSchoolYearName.Text = DtpStartYear.Value.ToString("yyyy") + " - " + DtpEndYear.Value.ToString("yyyy");
		}

		/// <summary>
		/// Updates the school year name when the end year changes.
		/// </summary>
		private void DtpEndYear_ValueChanged(object sender, EventArgs e)
		{
			TbxSchoolYearName.Text = DtpStartYear.Value.ToString("yyyy") + " - " + DtpEndYear.Value.ToString("yyyy");
		}

		/// <summary>
		/// Validates the school year form, rejects duplicated ids, then updates the selected school year
		/// or adds a new one to the cache.
		/// </summary>
		private void BtnTempSaveSchoolYear_Click(object sender, EventArgs e)
		{
			string message = null;
			if (!Validator(TrainingInfoTab.SchoolYear, out message))
			{
				MessageBox.Show(message);
				return;
			}

			SetSchoolYearCurrent();
			if (SchoolFormEditing)
			{
				string oldSchoolYearId = SchoolYearCurrent.SchoolYearId;
				// Update school year after edit
				SchoolYearBus.UpdateSchoolYear(SchoolYearCurrent, oldSchoolYearId);
				SchoolFormEditing = false;
			}
			else
			{
				SchoolYearBus.CreateNewSchoolYear(SchoolYearCurrent);
			}

			ResetForm(TrainingInfoTab.SchoolYear);
			message = "Thành công";
			MessageBox.Show(message);
		}

		/// <summary>
		/// Copies the school year form values into <c>SchoolYearCurrent</c>; the id is built as NH{start}-{end}.
		/// </summary>
		private void SetSchoolYearCurrent()
		{
			SchoolYearCurrent.StartYear = DtpStartYear.Value.Year;
			SchoolYearCurrent.EndYear = DtpEndYear.Value.Year;
			SchoolYearCurrent.SchoolYearId = "NH" + SchoolYearCurrent.StartYear + "-" + SchoolYearCurrent.EndYear;
			SchoolYearCurrent.SchoolYearName = TbxSchoolYearName.Text;
			SchoolYearCurrent.Status = ChkStatusSchoolYear.Checked ? SchoolYearModel.ACTIVE : SchoolYearModel.INACTIVE;
		}

		/// <summary>
		/// Deletes the school year when its delete button is clicked.
		/// </summary>
		private void DgvListSchoolYear_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}

			DataGridViewRow row = DgvListSchoolYear.Rows[e.RowIndex];

			if (e.ColumnIndex == DgvColActionDeleteSchoolYear.Index)
			{
				DataRowView rowView = (DataRowView)row.DataBoundItem;
				string schoolYearId = rowView["SCHOOLYEARID"].ToString();
				string schoolYearName = row.Cells["SchoolYearName"].Value.ToString();
				DeleteTrainingInfo(schoolYearId, schoolYearName, TrainingInfoTab.SchoolYear);
				return;
			}
		}

		/// <summary>
		/// Loads the clicked school year row into the form and switches the school year form to edit mode.
		/// </summary>
		private void DgvListSchoolYear_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex == DgvColActionDeleteSchoolYear.Index)
			{
				return;
			}

			DataRowView rowView = DgvListSchoolYear.Rows[e.RowIndex].DataBoundItem as DataRowView;
			if (rowView == null)
			{
				return;
			}

			int startYear = Convert.ToInt32(rowView["START_YEAR"]);
			int endYear = Convert.ToInt32(rowView["END_YEAR"]);
			int status = Convert.ToInt32(rowView["STATUS"]);

			DtpStartYear.Value = new DateTime(startYear, 1, 1);
			DtpEndYear.Value = new DateTime(endYear, 1, 1);
			ChkStatusSchoolYear.Checked = status == SchoolYearModel.ACTIVE;
			BtnTempSaveSchoolYear.Text = "Cập nhật";

			SetSchoolYearCurrent();
			// Keep the original id so the update finds the right row
			SchoolYearCurrent.SchoolYearId = rowView["SCHOOLYEARID"].ToString();
			SchoolFormEditing = true;
		}
		// End SchoolYear

		// Subject
		/// <summary>
		/// Binds the subject table to the subject grid.
		/// </summary>
		private void LoadSubjectData(bool forceReload = false)
		{
			DataTable dt = SubjectBus.FillSubject(forceReload);
			DgvSubject.AutoGenerateColumns = false;
			DgvSubject.DataSource = dt;

			TbxSubjectId.Text = SubjectBus.GenerateSubjectId();
		}

		/// <summary>
		/// Validates the subject form, then updates the selected subject
		/// or adds a new one (with an auto-generated MHxx id) to the cache.
		/// </summary>
		private void BtnTempSaveSubject_Click(object sender, EventArgs e)
		{
			string message = null;
			if (!Validator(TrainingInfoTab.Subject, out message))
			{
				MessageBox.Show(message);
				return;
			}

			SetSubjectCurrent();
			if (SubjectFormEditing)
			{
				string oldSubjectId = SubjectCurrent.SubjectId;
				// Update subject after edit
				SubjectCurrent.SubjectId = oldSubjectId;
				SubjectBus.UpdateSubject(SubjectCurrent, oldSubjectId);
				SubjectFormEditing = false;
			}
			else
			{
				SubjectBus.CreateNewSubject(SubjectCurrent);
			}

			ResetForm(TrainingInfoTab.Subject);
			message = "Thành công";
			MessageBox.Show(message);
		}

		/// <summary>
		/// Copies the subject form values into <c>SubjectCurrent</c>.
		/// </summary>
		private void SetSubjectCurrent()
		{
			SubjectCurrent.SubjectId = TbxSubjectId.Text;
			SubjectCurrent.SubjectName = TbxSubjectName.Text;
            SubjectCurrent.Credits = Convert.ToInt32(NumSubjectCredit.Value);
			SubjectCurrent.Description = TbxSubjectDescription.Text;
			SubjectCurrent.Status = ChkSubjectStatus.Checked ? SubjectModel.ACTIVE : SubjectModel.INACTIVE;
		}

		/// <summary>
		/// Deletes the subject when its delete button is clicked.
		/// </summary>
		private void DgvSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}

			DataGridViewRow row = DgvSubject.Rows[e.RowIndex];

			if (e.ColumnIndex == DgvColSubjectAction.Index)
			{
				DataRowView rowView = (DataRowView)row.DataBoundItem;
				string subjectId = rowView["SUBJECTID"].ToString();
				string subjectName = rowView["SUBJECTNAME"].ToString();
				DeleteTrainingInfo(subjectId, subjectName, TrainingInfoTab.Subject);
				return;
			}
		}

		/// <summary>
		/// Loads the clicked subject row into the form and switches the subject form to edit mode.
		/// </summary>
		private void DgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex == DgvColSubjectAction.Index)
			{
				return;
			}

			DataRowView rowView = DgvSubject.Rows[e.RowIndex].DataBoundItem as DataRowView;
			if (rowView == null)
			{
				return;
			}

			int credits = Convert.ToInt32(rowView["CREDITS"]);

			TbxSubjectName.Text = rowView["SUBJECTNAME"].ToString();
			NumSubjectCredit.Value = Math.Max(NumSubjectCredit.Minimum, Math.Min(NumSubjectCredit.Maximum, credits));
			TbxSubjectDescription.Text = rowView["DESCRIPTION"].ToString();
			ChkSubjectStatus.Checked = Convert.ToInt32(rowView["STATUS"]) == SubjectModel.ACTIVE;
			BtnTempSaveSubject.Text = "Cập nhật";

			SetSubjectCurrent();
			// Keep the original id so the update finds the right row
			SubjectCurrent.SubjectId = rowView["SUBJECTID"].ToString();
			SubjectFormEditing = true;
		}
		// End Subject

		// Do not highlight the first row after binding, so the form starts empty
		/// <summary>
		/// Clears the default selection after binding so no row is highlighted.
		/// </summary>
		private void Dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			((DataGridView)sender).ClearSelection();
		}

		// Click on the empty area of the grid (no row/cell) -> clear selection and reset form
		/// <summary>
		/// Clicking the empty area of a grid clears the selection and resets the matching form.
		/// </summary>
		private void Dgv_MouseDown(object sender, MouseEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			if (dgv.HitTest(e.X, e.Y).Type != DataGridViewHitTestType.None)
			{
				return;
			}

			dgv.ClearSelection();
			if (dgv == DgvListClass)
			{
				ResetForm(TrainingInfoTab.Class);
			}
			else if (dgv == DgvListSchoolYear)
			{
				ResetForm(TrainingInfoTab.SchoolYear);
			}
			else if (dgv == DgvSubject)
			{
				ResetForm(TrainingInfoTab.Subject);
			}
		}

		/// <summary>
		/// Saves pending changes of classes, school years and subjects to the database.
		/// </summary>
		private void BtnSave_Click(object sender, EventArgs e)
		{
			string message = "Thành công";
			if (!ClassInfoBus.SaveAll() || !SchoolYearBus.SaveAll() || !SubjectBus.SaveAll())
			{
				message = "Lưu thất bại";
			}

			MessageBox.Show(message);
		}

		/// <summary>
		/// Validates the required fields of the given tab (or of every tab with <see cref="TrainingInfoTab.AllTab"/>).
		/// Returns false and the error list in <paramref name="errMessage"/> when validation fails.
		/// </summary>
		private bool Validator(TrainingInfoTab tabInfo, out string errMessage)
		{
			errMessage = "Lỗi:";
			if (tabInfo == TrainingInfoTab.AllTab || tabInfo == TrainingInfoTab.Class)
			{
				if (TbxClassId.Text == "")
				{
					errMessage += "\r\nVui lòng nhập Mã lớp học";
				}
				if (TbxClassName.Text == "")
				{
					errMessage += "\r\nVui lòng nhập Tên lớp học";
				}
			}
			if (tabInfo == TrainingInfoTab.AllTab || tabInfo == TrainingInfoTab.SchoolYear)
			{
				if (DtpStartYear.Text == "")
				{
					errMessage += "\r\nVui lòng nhập Năm bắt đầu";
				}
				if (DtpEndYear.Text == "")
				{
					errMessage += "\r\nVui lòng nhập Năm kết thúc";
				}
				if (TbxSchoolYearName.Text == "")
				{
					errMessage += "\r\nVui lòng nhập Năm học";
				}
				if (DtpEndYear.Value.Year <= DtpStartYear.Value.Year)
				{
					errMessage += "\r\nNăm kết thúc phải lớn hơn Năm bắt đầu";
				}
			}
			if (tabInfo == TrainingInfoTab.AllTab || tabInfo == TrainingInfoTab.Subject)
			{
				if (TbxSubjectName.Text == "")
				{
					errMessage += "\r\nVui lòng nhập Tên môn học";
				}
				if (NumSubjectCredit.Text == "")
				{
					errMessage += "\r\nVui lòng nhập Số tín chỉ";
				}
			}
			return errMessage == "Lỗi:" ? true : false;
		}

		/// <summary>
		/// Clears the form of the given tab and switches it back to add mode.
		/// </summary>
		private void ResetForm(TrainingInfoTab tab = TrainingInfoTab.Class)
		{
			switch (tab)
			{
				case TrainingInfoTab.Class:
					TbxClassId.Text = null;
					TbxClassName.Text = null;
					TbxDescriptionClass.Text = null;
					ChkStatusClass.Checked = false;
					BtnTempSaveClass.Text = "Thêm";
					ClassFormEditing = false;
					break;
				case TrainingInfoTab.SchoolYear:
					DtpStartYear.Value = DateTime.Today;
					DtpEndYear.Value = DtpStartYear.Value.AddYears(1);
					ChkStatusSchoolYear.Checked = false;
					BtnTempSaveSchoolYear.Text = "Thêm";
					SchoolFormEditing = false;
					break;
				case TrainingInfoTab.Subject:
					TbxSubjectId.Text = SubjectBus.GenerateSubjectId();
					TbxSubjectName.Text = null;
                    NumSubjectCredit.Value = NumSubjectCredit.Minimum;
					TbxSubjectDescription.Text = null;
					ChkSubjectStatus.Checked = false;
					BtnTempSaveSubject.Text = "Thêm";
					SubjectFormEditing = false;
					break;
			}
		}

		/// <summary>
		/// Asks for confirmation, then marks the class, school year or subject with the given id as deleted
		/// and shows the result.
		/// </summary>
		public void DeleteTrainingInfo(string trainingInfoId, string trainingInfoName, TrainingInfoTab tab = TrainingInfoTab.Class)
		{
			bool success = false;
			string message = "Xóa thành công!";

			switch (tab)
			{
				case TrainingInfoTab.Class:
					if (MessageBox.Show("Xóa lớp học " + trainingInfoName + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						if (ClassInfoBus.DeleteClassInfo(trainingInfoId))
						{
							ResetForm(tab);
							success = true;
						}
					}
					else
					{
						return;
					}
					break;
				case TrainingInfoTab.SchoolYear:
					if (MessageBox.Show("Xóa năm học " + trainingInfoName + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						if (SchoolYearBus.DeleteSchoolYear(trainingInfoId))
						{
							ResetForm(tab);
							success = true;
						}
					}
					else
					{
						return;
					}
					break;
				case TrainingInfoTab.Subject:
					if (MessageBox.Show("Xóa môn học " + trainingInfoName + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						if (SubjectBus.DeleteSubject(trainingInfoId))
						{
							ResetForm(tab);
							success = true;
						}
					}
					else
					{
						return;
					}
					break;
			}

			if (!success)
			{
				message = "Xóa thất bại!";
			} 

			MessageBox.Show(message);
		}

		/// <summary>
		/// Reloads the three grids from the database.
		/// </summary>
		public void LoadAllData()
		{
			LoadClassData(true);
			LoadSubjectData(true);
			LoadSchoolYearData(true);
        }
	}
}
