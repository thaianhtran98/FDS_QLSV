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
		Subject = 2
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
			MessageBox.Show("Thành công");
		}

		private void BtnTempSaveSchoolYear_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Thành công");
		}

		private void BtnTempSaveSubject_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Thành công");
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Thành công");
		}
	}
}
