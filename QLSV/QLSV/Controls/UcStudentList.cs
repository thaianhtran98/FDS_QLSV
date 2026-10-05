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
using QuanLySVModel;

namespace QuanLySV.Controls
{
	public partial class UcStudentList : UserControl
	{
		private StudentBussiness StudentBus = new StudentBussiness();

		private class GenderItem
		{
			public int Value { get; set; }
			public string Text { get; set; }
		}

		public UcStudentList()
		{
			InitializeComponent();
			LoadData();
			LoadFilterList();
        }

		public void InitLoad(StudentBussiness studentBussiness)
		{
			StudentBus = studentBussiness;
        }

		private void LoadData()
		{
			DataTable dt = StudentBus.FillStudent();
			DgvStudentList.AutoGenerateColumns = false;
            DgvStudentList.DataSource = dt;
        }

		private void LoadFilterList()
		{
			ArrayList gender = new ArrayList();
			gender.Add(new GenderItem { Text = "Chọn giới tính", Value = -1 });
			gender.Add(new GenderItem { Text = "Nữ", Value = 0 });
			gender.Add(new GenderItem { Text = "Nam", Value = 1 });

			CbxSex.DisplayMember = "Text";
			CbxSex.ValueMember = "Value";
			CbxSex.DataSource = gender;
		}

		private void CbxSex_SelectedIndexChanged(object sender, EventArgs e)
		{
			string name = TxtNameFilter.Text;
			int sex = (int)CbxSex.SelectedValue;
			DataTable dt = StudentBus.Filter(name, sex);
			DgvStudentList.DataSource = dt;
		}

		private void CbxSex_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			filter();
		}

		private void TxtNameFilter_TextChanged(object sender, EventArgs e)
		{
			filter();
        }

		private void filter()
		{
			string name = TxtNameFilter.Text;
			int sex = -1;
			if (CbxSex.SelectedValue is int)
			{
				sex = (int)CbxSex.SelectedValue;
			}
			DataTable dt = StudentBus.Filter(name, sex);
			DgvStudentList.DataSource = dt;
		}


	}
}
