using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySVBusiness;
using System.Collections;
using QuanLySVModel;

namespace QuanLySV.Controls
{
	/// <summary>
	/// User control listing the students with name/sex filters and edit, delete and save actions.
	/// </summary>
	public partial class UcStudentList : UserControl
	{
		private StudentBusiness StudentBus;
		private StudentAcademicBusiness StudentAcademicBus;

		/// <summary>
		/// Item of the sex filter combo box (display text and value).
		/// </summary>
		private class GenderItem
		{
			public int Value { get; set; }
			public string Text { get; set; }
		}

		/// <summary>
		/// Initializes the control components.
		/// </summary>
		public UcStudentList()
		{
			InitializeComponent();
        }

		/// <summary>
		/// Injects the business objects, then loads the student grid and the sex filter list.
		/// </summary>
		public void InitLoad(StudentBusiness studentBusiness, StudentAcademicBusiness studentAcademicBusiness)
		{
			StudentAcademicBus = studentAcademicBusiness;
			StudentBus = studentBusiness;
			LoadData();
			LoadFilterList();
		}

		/// <summary>
		/// Binds the student table to the grid and shows the save button/notification when there are unsaved changes.
		/// </summary>
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

		/// <summary>
		/// Fills the sex filter combo box (all / female / male).
		/// </summary>
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

		/// <summary>
		/// Re-applies the filter when the selected sex changes.
		/// </summary>
		private void CbxSex_SelectedIndexChanged(object sender, EventArgs e)
		{
			filter();
		}

		/// <summary>
		/// Re-applies the filter when the name filter text changes.
		/// </summary>
		private void TbxNameFilter_TextChanged(object sender, EventArgs e)
		{
			filter();
        }

		/// <summary>
		/// Filters the student grid by the name text and the selected sex (-1 = all).
		/// </summary>
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

		/// <summary>
		/// Handles the Edit/Delete buttons: opens the student form (edit mode) in the parent container,
		/// or marks the student as deleted after confirmation.
		/// </summary>
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

		/// <summary>
		/// Colors each row by its state: added = light green, modified = light yellow, otherwise white.
		/// </summary>
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

		/// <summary>
		/// Saves pending student and academic record changes to the database, then reloads the grid.
		/// </summary>
		private void BtnSave_Click(object sender, EventArgs e)
		{
            string errMessage = null;

            if (StudentBus.SaveAll(out errMessage) && StudentAcademicBus.SaveAll())
            {
			    LoadData(true);
                MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show(errMessage);
            }
        }

		/// <summary>
		/// Displays the sex column as "Nam"/"Nữ" instead of 1/0.
		/// </summary>
		private void DgvStudentList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}
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
