using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySV.Controls;

namespace QuanLySV.Forms
{
	public partial class FrmTrainngInfo : Form
	{
		public FrmTrainngInfo(TrainingInfoTab initTab)
		{
			InitializeComponent();
			UcTrainingInfo.Initialize(initTab);
		}

		private void BtnSelected_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Bạn đã chọn ...");
		}
	}
}
