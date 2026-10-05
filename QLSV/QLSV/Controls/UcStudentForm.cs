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

		public UcStudentForm()
		{
			StudentBus = new StudentBussiness();
			StudentCurrent = new StudentModel();
			InitializeComponent();
		}

		public void InitLoad(StudentBussiness studentBussiness)
		{
			StudentBus = studentBussiness;
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
						StudentCurrent.Sex = (int)rbt.Tag;
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

			StudentCurrent.Name = TxtName.Text;
			StudentCurrent.Status = StudentModel.ACTIVE;
			StudentCurrent.StudentId = TxtStudentId.Text;
			StudentCurrent.BirthOfDate = DtpBirthOfDate.Value;
			StudentCurrent.BirthLocal = TxtBirthLocal.Text;
			StudentCurrent.NumberPhone = MtxNumberphone.Text;
			StudentCurrent.VneId = TxtVneId.Text;
			StudentCurrent.DateOfIssue = DtpDateOfIssue.Value;
			StudentCurrent.LocalOfIssue = TxtLocalOfIssue.Text;
			StudentCurrent.Hometown = TxtHometown.Text;
			StudentCurrent.PlaceOfResidence = TxtPlaceOfResidence.Text;
			
			StudentBus.CreatNewStudent(StudentCurrent);

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
			if (TxtStudentId.Text == "")
			{
				message += "\r\nVui lòng nhập MSSV";
			}
			if(TxtName.Text == "")
			{
				message += "\r\nVui lòng nhập Họ tên";
			}

			return message == "Lỗi:" ? true : false;  
		}
	}
}
