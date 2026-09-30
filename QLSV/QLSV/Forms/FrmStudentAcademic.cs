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
			MessageBox.Show("Thành công");
		}
	}
}
