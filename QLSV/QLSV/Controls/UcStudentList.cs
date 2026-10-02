using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySVBussiness;
using System.Collections;

namespace QuanLySV.Controls
{
	public partial class UcStudentList : UserControl
	{
		private StudentBussiness StudentBussiness = new StudentBussiness();
		 
		public UcStudentList()
		{
			InitializeComponent();
			LoadData();
		}

		private void LoadData()
		{
			DataTable dt = StudentBussiness.FillStudent();
			DgvStudentList.AutoGenerateColumns = false;
            DgvStudentList.DataSource = dt;
        }
	}
}
