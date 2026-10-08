using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySV.Forms;
using System.Collections;
using QuanLySVBussiness;
using QuanLySVModel;

namespace QuanLySV.Controls
{
	public partial class UcStudentForm : UserControl
	{
		private StudentModel StudentCurrent;
		private StudentBussiness StudentBus;
		private bool IsEdit = false;
		private string StudentIdSelected = null;

		public UcStudentForm()
		{
			StudentCurrent = new StudentModel();
			InitializeComponent();
		}

		public void InitLoad(StudentBussiness studentBussiness, string studentId = null)
		{
			StudentBus = studentBussiness;
			if (studentId != null)
			{
				LoadStudentById(studentId);
			}
        }								

		private void LoadStudentById(string studentId)
		{
			StudentIdSelected = studentId;
			StudentCurrent = StudentBus.FindStudentById(studentId);

			if(StudentCurrent != null)
			{
				TbxName.Text = StudentCurrent.Name;
				TbxStudentId.Text = StudentCurrent.StudentId;
				TbxBirthLocal.Text = StudentCurrent.BirthLocal;
				MtxNumberphone.Text = StudentCurrent.NumberPhone;
				TbxVneId.Text = StudentCurrent.VneId;
				TbxLocalOfIssue.Text = StudentCurrent.LocalOfIssue;
				TbxHometown.Text = StudentCurrent.Hometown;
				TbxPlaceOfResidence.Text = StudentCurrent.PlaceOfResidence;
				DtpBirthOfDate.Value = StudentCurrent.BirthOfDate;
				DtpDateOfIssue.Value = StudentCurrent.DateOfIssue;
				foreach (Control ctl in PnlSex.Controls)
				{
					if (ctl is RadioButton)
					{
						RadioButton rbt = (RadioButton)ctl;
						if (rbt.Tag.ToString() == StudentCurrent.Sex.ToString())
						{
							rbt.Checked = true;
						}
					}
				}

				TbxStudentId.Enabled = false;
				ChkStatus.Visible = true;
                ChkStatus.Checked = StudentCurrent.Status == StudentModel.ACTIVE;

				IsEdit = true;
            }
		}

		private void SexCheckedChanged(object sender, EventArgs e)
		{
			foreach (Control ctl in PnlSex.Controls)
			{
				if (ctl is RadioButton)
				{
					RadioButton rbt = (RadioButton)ctl;
					if (rbt.Checked)
					{
						StudentCurrent.Sex = Convert.ToInt32(rbt.Tag);
                    }
				}
			}
		}																   

		private void BtnSave_Click(object sender, EventArgs e)
		{
			string message = null;
            if (!Validator(out message))
			{
				MessageBox.Show(message);
				return;
			}

			StudentCurrent.Name = TbxName.Text;
			StudentCurrent.Status = StudentModel.ACTIVE;
			StudentCurrent.StudentId = TbxStudentId.Text;
			StudentCurrent.BirthOfDate = DtpBirthOfDate.Value;
			StudentCurrent.BirthLocal = TbxBirthLocal.Text;
			StudentCurrent.NumberPhone = MtxNumberphone.Text;
			StudentCurrent.VneId = TbxVneId.Text;
			StudentCurrent.DateOfIssue = DtpDateOfIssue.Value;
			StudentCurrent.LocalOfIssue = TbxLocalOfIssue.Text;
			StudentCurrent.Hometown = TbxHometown.Text;
			StudentCurrent.PlaceOfResidence = TbxPlaceOfResidence.Text;

			if (IsEdit)
			{
				StudentCurrent.Status = ChkStatus.Checked ? StudentModel.ACTIVE : StudentModel.INACTIVE;
				StudentBus.UpdateStudent(StudentCurrent, StudentIdSelected);
			}
			else
			{
				StudentBus.CreatNewStudent(StudentCurrent);
			}

			message = "Lưu thành công";
            MessageBox.Show(message);
		}

		private void BtnCreateLearning_Click(object sender, EventArgs e)
		{
			FrmStudentAcademic fr = new FrmStudentAcademic();
			
			if (fr.ShowDialog() == DialogResult.OK)
			{
				fr.Dispose();
			}
		}

		private bool Validator(out string message)
		{
			message = "Lỗi:";
			string studentID = TbxStudentId.Text;
            if (studentID == "")
			{
				message += "\r\nVui lòng nhập MSSV";
			}
			if(TbxName.Text == "")
			{
				message += "\r\nVui lòng nhập Họ tên";
			}
			if (StudentBus.FindStudentById(studentID) != null && !IsEdit)
			{
				message += "\r\nMSSV đã tồn tại";
			}

			return message == "Lỗi:" ? true : false;  
		}
	}
}
