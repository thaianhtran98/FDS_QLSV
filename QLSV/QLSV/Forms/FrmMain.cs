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
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}

		private void ShowUc(UserControl control)
		{
			PnlMain.Controls.Clear();
			control.Dock = DockStyle.Fill;
			control.Margin = Padding.Empty;
			PnlMain.Controls.Add(control);
			control.Focus();
		}

		private void MnuItemList_Click(object sender, EventArgs e)
		{
			UserControl uc = new UcStudentList();
			ShowUc(uc);
		}

		private void MnuItemCreate_Click(object sender, EventArgs e)
		{
			UserControl uc = new UcStudentForm();
			ShowUc(uc);
		}

		private void MnuQldm_Click(object sender, EventArgs e)
		{
			UserControl uc = new UcTrainingInfo();
			ShowUc(uc);
		}
	}
}
