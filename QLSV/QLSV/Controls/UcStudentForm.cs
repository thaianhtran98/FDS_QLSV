using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.Models;

namespace QLSV.Controls
{
	public partial class UcStudentForm : UserControl
	{
		private Student StudentCurrent; 

		public UcStudentForm(string studentId = "")
		{
			InitializeComponent();
			LoadInit(studentId);
        }

		private void LoadInit(string studentId = "")
		{
			 if (studentId.Contains(""))
			{
				StudentCurrent = new Student();
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
						if (rbt.Text == "Nam")
						{
							StudentCurrent.Sex = Student.MALE;
						}
						else
						{
							StudentCurrent.Sex = Student.FEMALE;
						}
					}
				}
			}
		}

		private void MapFormToStudent()
		{
			StudentCurrent.Name = TxtName.Text;
			StudentCurrent.BirthOfDate = DtpBirthOfDate.Value;
			StudentCurrent.BirthLocal = TxtBirthLocal.Text;
			StudentCurrent.VneId = TxtPlaceOfResidence.Text;
			StudentCurrent.LocalOfIssue = TxtLocalOfIssue.Text;
			StudentCurrent.DateOfIssue = DtpDateOfIssue.Value;
			StudentCurrent.PlaceOfResidence = TxtPlaceOfResidence.Text;
			StudentCurrent.Hometown = TxtHometown.Text;
		}

		private void BtnTempSave_Click(object sender, EventArgs e)
		{
			MapFormToStudent();
            MessageBox.Show("Lưu tạm thành công: " + StudentCurrent.Name.ToString());
			return;
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			MapFormToStudent();
			MessageBox.Show("Lưu tạm thành công: " + StudentCurrent.Name.ToString());
			return;
		}
	}
}
