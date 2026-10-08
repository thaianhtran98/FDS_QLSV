using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySVBussiness;
using QuanLySVModel;

namespace QuanLySV.Controls
{
	public enum TrainingInfoTab
	{
		Class = 0,
		SchoolYear = 1,
		Subject = 2,
		AllTab = 3
	}

	public partial class UcTrainingInfo : UserControl
	{
		// Define
		private ClassInfoBussiness ClassInfoBus;
		private ClassInfoModel ClassInfoCurrent;
		private SchoolYearBussiness SchoolYearBus;
		private SchoolYearModel SchoolYearCurrent;
		private bool ClassFormEditing = false;
		private bool SchoolFormEditing = false;

		public UcTrainingInfo()
		{
			InitializeComponent();
			LoadInit();
        }

		private void LoadInit()
		{
			DtpStartYear.Value = DateTime.Today;
			DtpEndYear.Value = DtpStartYear.Value.AddYears(1);
			TbxSchoolYearName.Text = DtpStartYear.Value.ToString("yyyy") + " - " + DtpEndYear.Value.ToString("yyyy");
		}

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

		public void LoadBussiness(ClassInfoBussiness classInfoBussiness, SchoolYearBussiness schoolYearBussiness)
		{
			ClassInfoBus = classInfoBussiness;
			ClassInfoCurrent = new ClassInfoModel();
			LoadClassData(true);

			SchoolYearBus = schoolYearBussiness;
			SchoolYearCurrent = new SchoolYearModel();
			LoadSchoolYearData(true);
        }
		// End define

		// ClassInfo
		private void LoadClassData(bool forceReload = false)
		{
			DataTable dt = ClassInfoBus.FillClassInfo(forceReload);
			DgvListClass.AutoGenerateColumns = false;
			DgvListClass.DataSource = dt;
		}

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
				ClassInfoBus.CreatNewClassInfo(ClassInfoCurrent);
            }

			ResetForm(TrainingInfoTab.Class);
			message = "Thành công";
			MessageBox.Show(message);
		}

		private void DgvListClass_SelectionChanged(object sender, EventArgs e)
		{
			DataGridViewRow row = DgvListClass.CurrentRow;
			if (row == null)
            {
				ResetForm(TrainingInfoTab.Class);
				return;
			}

			string classId = row.Cells["ClassId"].Value.ToString();
			string className = row.Cells["ClassName"].Value.ToString();
			string description = row.Cells["Description"].Value.ToString();

			TbxClassId.Text = classId;
			TbxClassName.Text = className;
			TbxDescriptionClass.Text = description;
			ChkStatusClass.Checked = true;
			BtnTempSaveClass.Text = "Cập nhật";

			SetClassCurrent();
			ClassFormEditing = true;
		}

		private void DgvListClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = DgvListClass.Rows[e.RowIndex];

			if (e.ColumnIndex == DgvColActionDelete.Index)
			{ 
				string classId = row.Cells["ClassId"].Value.ToString();
				string className = row.Cells["ClassName"].Value.ToString();
				DeleteTrainingInfo(classId, className, TrainingInfoTab.Class);
				return;
			}
		}

		private void SetClassCurrent()
		{
			ClassInfoCurrent.ClassId = TbxClassId.Text;
			ClassInfoCurrent.ClassName = TbxClassName.Text;
			ClassInfoCurrent.Description = TbxDescriptionClass.Text;
			ClassInfoCurrent.Status = ChkStatusClass.Checked ? ClassInfoModel.ACTIVE : ClassInfoModel.INACTIVE;
		}
		// End ClassInfo

		// SchoolYear
		private void LoadSchoolYearData(bool forceReload = false)
		{
			DataTable dt = SchoolYearBus.FillSchoolYear(forceReload);
			DgvListSchoolYear.AutoGenerateColumns = false;
			DgvListSchoolYear.DataSource = dt;
		}

		private void DtpStartYear_ValueChanged(object sender, EventArgs e)
		{
			TbxSchoolYearName.Text = DtpStartYear.Value.ToString("yyyy") + " - " + DtpEndYear.Value.ToString("yyyy");
		}

		private void DtpEndYear_ValueChanged(object sender, EventArgs e)
		{
			TbxSchoolYearName.Text = DtpStartYear.Value.ToString("yyyy") + " - " + DtpEndYear.Value.ToString("yyyy");
		}

		private void BtnTempSaveSchoolYear_Click(object sender, EventArgs e)
		{
			string message = null;
			if (!Validator(TrainingInfoTab.SchoolYear, out message))
			{
				MessageBox.Show(message);
				return;
			}

			if (SchoolFormEditing)
			{
				string oldSchoolYearId = SchoolYearCurrent.SchoolYearId;
				// Update school year after edit
				SetSchoolYearCurrent();
				if (SchoolYearCurrent.SchoolYearId != oldSchoolYearId && SchoolYearBus.FindSchoolYearById(SchoolYearCurrent.SchoolYearId) != null)
				{
					SchoolYearCurrent.SchoolYearId = oldSchoolYearId;
					MessageBox.Show("Năm học " + SchoolYearCurrent.SchoolYearName + " đã tồn tại");
					return;
				}
				SchoolYearBus.UpdateSchoolYear(SchoolYearCurrent, oldSchoolYearId);
				SchoolFormEditing = false;
			}
			else
			{
				SetSchoolYearCurrent();
				if (SchoolYearBus.FindSchoolYearById(SchoolYearCurrent.SchoolYearId) != null)
				{
					MessageBox.Show("Năm học " + SchoolYearCurrent.SchoolYearName + " đã tồn tại");
					return;
				}
				SchoolYearBus.CreatNewSchoolYear(SchoolYearCurrent);
			}

			ResetForm(TrainingInfoTab.SchoolYear);
			message = "Thành công";
			MessageBox.Show(message);
		}

		private void SetSchoolYearCurrent()
		{
			SchoolYearCurrent.StartYear = DtpStartYear.Value.Year;
			SchoolYearCurrent.EndYear = DtpEndYear.Value.Year;
			SchoolYearCurrent.SchoolYearId = "NH" + SchoolYearCurrent.StartYear + "-" + SchoolYearCurrent.EndYear;
			SchoolYearCurrent.SchoolYearName = TbxSchoolYearName.Text;
			SchoolYearCurrent.Status = ChkStatusSchoolYear.Checked ? SchoolYearModel.ACTIVE : SchoolYearModel.INACTIVE;
		}

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

		private void DgvListSchoolYear_SelectionChanged(object sender, EventArgs e)
		{
			DataGridViewRow row = DgvListSchoolYear.CurrentRow;
			if (row == null)
			{
				ResetForm(TrainingInfoTab.SchoolYear);
				return;
			}

			DataRowView rowView = (DataRowView)row.DataBoundItem;
			int startYear = Convert.ToInt32(row.Cells["Start_Year"].Value);
			int endYear = Convert.ToInt32(row.Cells["End_Year"].Value);
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

		private void BtnTempSaveSubject_Click(object sender, EventArgs e)
		{
			string message = null;
			if (!Validator(TrainingInfoTab.Subject, out message))
			{
				MessageBox.Show(message);
				return;
			}

			message = "Thành công";
			MessageBox.Show(message);
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			string message = "Thành công";
			if (!ClassInfoBus.SaveAll() || !SchoolYearBus.SaveAll())
			{
				message = "Lưu thất bại";
			}

			MessageBox.Show(message);
		}

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
					break;
				case TrainingInfoTab.SchoolYear:
					DtpStartYear.Value = DateTime.Today;
					DtpEndYear.Value = DtpStartYear.Value.AddYears(1);
					ChkStatusSchoolYear.Checked = false;
					BtnTempSaveSchoolYear.Text = "Thêm";
					SchoolFormEditing = false;
					break;
				case TrainingInfoTab.Subject:
					TabTraingInfo.SelectedTab = TpgSubject;
					break;
			}
		}

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
					TabTraingInfo.SelectedTab = TpgSubject;
					break;
			}

			if (!success)
			{
				message = "Xóa thất bại!";
			} 

			MessageBox.Show(message);
		}
	}
}
