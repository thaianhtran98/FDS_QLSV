using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
		public UcTrainingInfo()
		{
			InitializeComponent();
			LoadInit();
        }

		private void LoadInit()
		{
			DtpStartYear.Value = DateTime.Today;
			DtpEndYear.Value = DtpStartYear.Value.AddYears(1);
			TxtSchoolYearName.Text = DtpStartYear.Value.ToString("yyyy") + " - " + DtpEndYear.Value.ToString("yyyy");
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

		private void DtpStartYear_ValueChanged(object sender, EventArgs e)
		{
			TxtSchoolYearName.Text = DtpStartYear.Value.ToString("yyyy") + " - " + DtpEndYear.Value.ToString("yyyy");
		}

		private void DtpEndYear_ValueChanged(object sender, EventArgs e)
		{
			TxtSchoolYearName.Text = DtpStartYear.Value.ToString("yyyy") + " - " + DtpEndYear.Value.ToString("yyyy");
		}

		private void BtnTempSaveClass_Click(object sender, EventArgs e)
		{
			string message = null;
			if (!Validator(TrainingInfoTab.Class, out message))
			{
				MessageBox.Show(message);
				return;
			}

			message = "Thành công";
			MessageBox.Show(message);
		}

		private void BtnTempSaveSchoolYear_Click(object sender, EventArgs e)
		{
			string message = null;
			if (!Validator(TrainingInfoTab.SchoolYear, out message))
			{
				MessageBox.Show(message);
				return;
			}

			message = "Thành công";
			MessageBox.Show(message);
		}

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
			string message = null;
			if (!Validator(TrainingInfoTab.AllTab, out message))
			{
				MessageBox.Show(message);
				return;
			}

			message = "Thành công";
			MessageBox.Show(message);
		}

		private bool Validator(TrainingInfoTab tabInfo, out string errMessage)
		{
			errMessage = "Lỗi:";
			if (tabInfo == TrainingInfoTab.AllTab || tabInfo == TrainingInfoTab.Class)
			{
				if (TxtClassName.Text == "")
				{
					errMessage += "\r\nVui lòng nhập Tên lớp";
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
				if (TxtSchoolYearName.Text == "")
				{
					errMessage += "\r\nVui lòng nhập Năm học";
				}
			}
			if (tabInfo == TrainingInfoTab.AllTab || tabInfo == TrainingInfoTab.Subject)
			{
				if (TxtSubjectName.Text == "")
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
	}
}
