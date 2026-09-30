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

namespace QuanLySV.Controls
{
	public partial class UcStudentForm : UserControl
	{													

		public UcStudentForm(string studentId = "")
		{
			InitializeComponent();
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
			MessageBox.Show("Lưu tạm thành công");
		}

		private void BtnCreateLearning_Click(object sender, EventArgs e)
		{
			FrmStudentAcademic fr = new FrmStudentAcademic();
			
			if (fr.ShowDialog() == DialogResult.OK)
			{
				fr.Dispose();
			}
		}
	}
}
