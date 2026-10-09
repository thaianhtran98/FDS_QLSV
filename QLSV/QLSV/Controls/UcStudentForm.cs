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
using QuanLySVBussiness;
using QuanLySVModel;

namespace QuanLySV.Controls
{
	public partial class UcStudentForm : UserControl
	{
		private StudentModel StudentCurrent;
		private StudentBussiness StudentBus;
		private StudentAcademicBussiness StudentAcademicBus;
		private bool IsEdit = false;
		private string StudentIdSelected = null;
		private bool Loading = false;

		public UcStudentForm()
		{
			Loading = true;
			StudentCurrent = new StudentModel();
			InitializeComponent();
			Loading = false;
		}

		public void InitLoad(StudentBussiness studentBussiness, StudentAcademicBussiness studentAcademicBussiness, string studentId = null)
		{
			Loading = true;
			StudentBus = studentBussiness;
			StudentAcademicBus = studentAcademicBussiness;
			
			if (studentId != null)
			{
				LoadStudentById(studentId);
			}
			Loading = false;
		}								

		private void LoadStudentById(string studentId)
		{
			Loading = true;
			StudentIdSelected = studentId;
			StudentCurrent = StudentBus.FindStudentById(studentId);

			if(StudentCurrent != null)
			{
				TbxName.Text = StudentCurrent.Name;
				TbxStudentId.Text = StudentCurrent.StudentId;
				TbxBirthLocal.Text = StudentCurrent.BirthLocal;
				MtxNumberphone.Text = StudentCurrent.NumberPhone;
				TbxVneId.Text = StudentCurrent.VneId;
				TbxLocalOfIssue.Text = StudentCurrent.LocalOfIssue;
				TbxHometown.Text = StudentCurrent.Hometown;
				TbxPlaceOfResidence.Text = StudentCurrent.PlaceOfResidence;
				DtpBirthOfDate.Value = StudentCurrent.BirthOfDate;
				DtpDateOfIssue.Value = StudentCurrent.DateOfIssue;
				foreach (Control ctl in PnlSex.Controls)
				{
					if (ctl is RadioButton)
					{
						RadioButton rbt = (RadioButton)ctl;
						if (rbt.Tag.ToString() == StudentCurrent.Sex.ToString())
						{
							rbt.Checked = true;
						}
					}
				}

				TbxStudentId.Enabled = false;
				ChkStatus.Visible = true;
                ChkStatus.Checked = StudentCurrent.Status == StudentModel.ACTIVE;

				IsEdit = true;
				LoadStudentAcademic(TbxStudentId.Text);
            }
			Loading = false;
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
						StudentCurrent.Sex = Convert.ToInt32(rbt.Tag);
                    }
				}
			}
		}

		// start StudentAcademic
		private void LoadStudentAcademic(string studentId)
		{
			DataTable studentAcademicDt = StudentAcademicBus.FillStudentAcademic(studentId);
			if (studentAcademicDt != null)
			{
				DgvLearningList.AutoGenerateColumns = false;
				DgvLearningList.DataSource = studentAcademicDt;
			}
		}
		
		// end StudentAcademic																   

		private void BtnSave_Click(object sender, EventArgs e)
		{
			string message = null;
            if (!Validator(out message))
			{
				MessageBox.Show(message);
				return;
			}

			StudentCurrent.Name = TbxName.Text;
			StudentCurrent.Status = StudentModel.ACTIVE;
			StudentCurrent.StudentId = TbxStudentId.Text;
			StudentCurrent.BirthOfDate = DtpBirthOfDate.Value;
			StudentCurrent.BirthLocal = TbxBirthLocal.Text;
			StudentCurrent.NumberPhone = MtxNumberphone.Text;
			StudentCurrent.VneId = TbxVneId.Text;
			StudentCurrent.DateOfIssue = DtpDateOfIssue.Value;
			StudentCurrent.LocalOfIssue = TbxLocalOfIssue.Text;
			StudentCurrent.Hometown = TbxHometown.Text;
			StudentCurrent.PlaceOfResidence = TbxPlaceOfResidence.Text;

			if (IsEdit)
			{
				StudentCurrent.Status = ChkStatus.Checked ? StudentModel.ACTIVE : StudentModel.INACTIVE;
				StudentBus.UpdateStudent(StudentCurrent, StudentIdSelected);
			}
			else
			{
				StudentBus.CreatNewStudent(StudentCurrent);
			}

			message = "Lưu thành công";
            MessageBox.Show(message);
		}

		private void BtnCreateLearning_Click(object sender, EventArgs e)
		{
			if (TbxStudentId.Text == null || TbxStudentId.Text == "")
			{
				MessageBox.Show("Hãy nhập mã SV");
				return;
			}
			string studentId = TbxStudentId.Text;
			StudentAcademicBus.FillStudentAcademic(studentId);
			FrmStudentAcademic fr = new FrmStudentAcademic(StudentAcademicBus, null, studentId);

			if (fr.ShowDialog() == DialogResult.OK)
			{
				fr.Dispose();
			}
		}

		private bool Validator(out string message)
		{
			message = "Lỗi:";
			string studentID = TbxStudentId.Text;
            if (studentID == "")
			{
				message += "\r\nVui lòng nhập MSSV";
			}
			if(TbxName.Text == "")
			{
				message += "\r\nVui lòng nhập Họ tên";
			}
			if (StudentBus.FindStudentById(studentID) != null && !IsEdit)
			{
				message += "\r\nMSSV đã tồn tại";
			}

			return message == "Lỗi:" ? true : false;  
		}

		private void TbxStudentId_TextChanged(object sender, EventArgs e)
		{
			if (Loading) return; 
			string studentId = TbxStudentId.Text;
			StudentAcademicBus.UpdateStudentId(studentId);
		}

		private void DgvLearningList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}

			DataGridViewRow row = DgvLearningList.Rows[e.RowIndex];

			if (e.ColumnIndex == ColEdit.Index)
			{
				DataRowView rowView = (DataRowView)row.DataBoundItem;
				DataRow r = rowView.Row;
				StudentAcademicModel studentMod = new StudentAcademicModel();
				studentMod.StudentId = r["StudentId"].ToString();
				studentMod.ClassId = r["ClassId"].ToString();
				studentMod.SchoolYearId = r["SchoolYearId"].ToString();
				studentMod.SubjectId = r["SubjectId"].ToString();
				studentMod.Semester = Convert.ToInt32(r["Semester"]);
				studentMod.Score = Convert.ToDecimal(r["Score"]);
				studentMod.ScoreLetter = r["Score_Letter"].ToString();
				studentMod.Note = r["Note"].ToString();
				studentMod.Status = StudentAcademicModel.ACTIVE;
				FrmStudentAcademic fr = new FrmStudentAcademic(StudentAcademicBus, studentMod, StudentIdSelected);
				if (fr.ShowDialog() == DialogResult.OK)
				{
					fr.Dispose();
				}
			}
		}
	}
}
