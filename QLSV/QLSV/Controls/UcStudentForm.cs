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


namespace QuanLySV.Controls
{
	public partial class UcStudentForm : UserControl
	{
		
		public UcStudentForm()
		{
			InitializeComponent();
        }
		
		public void Initialize(string studentId = "")
		{
			 if (studentId == "")
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
							return;
						}
						else
						{
							return;
						}
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
