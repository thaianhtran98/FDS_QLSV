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
		private StudentBussiness StudentBus;
		private StudentAcademicBussiness StudentAcademicBus;

		private class GenderItem
		{
			public int Value { get; set; }
			public string Text { get; set; }
		}

		public UcStudentList()
		{
			InitializeComponent();
        }

		public void InitLoad(StudentBussiness studentBussiness, StudentAcademicBussiness studentAcademicBussiness)
		{
			StudentAcademicBus = studentAcademicBussiness;
			StudentBus = studentBussiness;
			LoadData();
			LoadFilterList();
		}

		private void LoadData(bool forceReload = false)
		{
			DataTable dt = StudentBus.FillStudent(forceReload);
			DgvStudentList.AutoGenerateColumns = false;
            DgvStudentList.DataSource = dt;

			if (StudentBus.HasChanges())
			{
				BtnSave.Visible = true;
				LblNotification.Text = "Có thay đổi chưa được lưu";
			}
			else
			{
				BtnSave.Visible = false;
				LblNotification.Text = "";
			}
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
			string name = TbxNameFilter.Text;
			int sex = (int)CbxSex.SelectedValue;
			DataTable dt = StudentBus.Filter(name, sex);
			DgvStudentList.DataSource = dt;
		}

		private void CbxSex_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			filter();
		}

		private void TbxNameFilter_TextChanged(object sender, EventArgs e)
		{
			filter();
        }

		private void filter()
		{
			string name = TbxNameFilter.Text;
			int sex = -1;
			if (CbxSex.SelectedValue is int)
			{
				sex = (int)CbxSex.SelectedValue;
			}
			DataTable dt = StudentBus.Filter(name, sex);
			DgvStudentList.DataSource = dt;
		}

		private void DgvStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}

			string studentId = DgvStudentList.Rows[e.RowIndex].Cells[StudentId.Index].Value.ToString();
			string studentName = DgvStudentList.Rows[e.RowIndex].Cells[StudentName.Index].Value.ToString();

			if (e.ColumnIndex == DgvColEdit.Index)
			{
				UcStudentForm uc = new UcStudentForm();
				uc.InitLoad(StudentBus, StudentAcademicBus, studentId);
				uc.Dock = DockStyle.Fill;

				Control parent = this.Parent;
				parent.Controls.Clear();
				parent.Controls.Add(uc);
			}
			else if (e.ColumnIndex == DgvColDelete.Index)
			{
				if (MessageBox.Show("Xóa sinh viên " + studentName + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					StudentBus.DeleteStudent(studentId);
					LoadData();
				}
			}
		}

		private void DgvStudentList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			DataGridViewRow gridRow = DgvStudentList.Rows[e.RowIndex];
			DataRowView rowView = gridRow.DataBoundItem as DataRowView;
			if (rowView == null)
			{
				return;
			}

			switch (rowView.Row.RowState)
			{
				case DataRowState.Added:
					gridRow.DefaultCellStyle.BackColor = Color.LightGreen;
					break;
				case DataRowState.Modified:
					gridRow.DefaultCellStyle.BackColor = Color.LightYellow;
					break;
				default:
					gridRow.DefaultCellStyle.BackColor = Color.White;
					break;
			}
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
            string errMessage = null;

            if (StudentBus.SaveAll(out errMessage))
            {
			    LoadData(true);
                MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show(errMessage);
            }
        }

		private void DgvStudentList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.ColumnIndex != Sex.Index || e.Value == null || e.Value == DBNull.Value)
			{
				return;
			}

			int sex = Convert.ToInt32(e.Value);
			if (sex == StudentModel.MALE)
			{
				e.Value = "Nam";
			}
			else
			{
				e.Value = "Nữ";
			}

			e.FormattingApplied = true;
		}
	}
}
