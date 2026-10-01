using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySV.Forms;
using QuanLySV.Controls;

namespace QuanLySV.Forms
{
	public partial class FrmStudentAcademic : Form
	{
		public FrmStudentAcademic()
		{
			InitializeComponent();
		}

		private void ShowDialogAddTrainingInfo(TrainingInfoTab tabInit)
		{
			FrmTrainngInfo fr = new FrmTrainngInfo(tabInit);

			if (fr.ShowDialog() == DialogResult.OK)
			{
				
				fr.Dispose();
			}
		}

		private void BtnAddSchoolYear_Click(object sender, EventArgs e)
		{
			ShowDialogAddTrainingInfo(TrainingInfoTab.SchoolYear);
        }

		private void BtnAddClass_Click(object sender, EventArgs e)
		{
			ShowDialogAddTrainingInfo(TrainingInfoTab.Class);
		}

		private void BtnAddSubject_Click(object sender, EventArgs e)
		{
			ShowDialogAddTrainingInfo(TrainingInfoTab.Subject);
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			string message = null;
			if (!Validator(out message))
			{
				MessageBox.Show(message);
				return;
			}

			message = "Lưu tạm thành công";
			MessageBox.Show(message);
		}

		private bool Validator(out string errMessage)
		{
			errMessage = "Lỗi:";
			if (CbxSchoolYear.Text == "")
			{
				errMessage += "\r\nVui lòng chọn Năm học";
			}
			if (CbxSemester.Text == "")
			{
				errMessage += "\r\nVui lòng chọn Học kỳ";
			}
			if (CbxClassName.Text == "")
			{
				errMessage += "\r\nVui lòng chọn Lớp";
			}
			if (CbxSubjectName.Text == "")
			{
				errMessage += "\r\nVui lòng chọn Môn học";
			}

			return errMessage == "Lỗi:" ? true : false;
		}
	}
}
