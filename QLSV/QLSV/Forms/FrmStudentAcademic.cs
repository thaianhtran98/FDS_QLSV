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
using QuanLySVBussiness;
using QuanLySVModel;

namespace QuanLySV.Forms
{
	public partial class FrmStudentAcademic : Form
	{
		private ClassInfoBussiness ClassBus;
		private SchoolYearBussiness SchoolYearBus;
		private SubjectBussiness SubjectBus;
		private StudentAcademicBussiness StudentAcademicBus;
		private StudentAcademicModel StudentAcademiCurrent;
		private string StudentId;
		private bool IsEditing = false;
		private DataRow RowEditing;

		private const int HK1 = 1;
		private const int HK2 = 2;
		private const int HK3 = 3;

		public FrmStudentAcademic(StudentAcademicBussiness studentAcademicBussiness, StudentAcademicModel studentAcademic, string studentId, DataRow row = null)
		{
			ClassBus = new ClassInfoBussiness();
			SchoolYearBus = new SchoolYearBussiness();
			SubjectBus = new SubjectBussiness();
			RowEditing = row;
			StudentAcademicBus = studentAcademicBussiness;
			InitializeComponent();
			LoadDataComboBox();
			StudentId = studentId;
			if (studentAcademic == null)
			{
				StudentAcademiCurrent = new StudentAcademicModel();
			}
			else
			{
				StudentAcademiCurrent = studentAcademic;
				SetStudentAcademiCurrentToForm();
				IsEditing = true;
				BtnSave.Text = "Cập nhật";
            }
		}

		private void ShowDialogAddTrainingInfo(TrainingInfoTab tabInit)
		{
			FrmTrainngInfo fr = new FrmTrainngInfo(tabInit, ClassBus, SchoolYearBus, SubjectBus);
			fr.ShowDialog();
			fr.Dispose();
			LoadDataComboBox();
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
			string message = null;
			if (!Validator(out message))
			{
				MessageBox.Show(message);
				return;
			}

			message = "Thêm thành công";
			if (IsEditing)
			{
				message = "Cập nhật thành công";
				SetFormToStudentAcademiCurrent();								
				StudentAcademicBus.UpdateRowStudentAcademic(StudentAcademiCurrent, RowEditing);
				resetForm();
				this.Close();
			}
			else
			{
				SetFormToStudentAcademiCurrent();
				StudentAcademicBus.CreateRowStudentAcademic(StudentAcademiCurrent);
				resetForm();
			}
			

			MessageBox.Show(message);
		}

		private void SetFormToStudentAcademiCurrent()
		{
			StudentAcademiCurrent.StudentId = StudentId;
			StudentAcademiCurrent.ClassId = CbxClassName.SelectedValue.ToString();
			StudentAcademiCurrent.ClassName = CbxClassName.Text;
			StudentAcademiCurrent.SchoolYearId = CbxSchoolYear.SelectedValue.ToString();
			StudentAcademiCurrent.SchoolYearName = CbxSchoolYear.Text;
			StudentAcademiCurrent.SubjectId = CbxSubjectName.SelectedValue.ToString();
			StudentAcademiCurrent.SubjectName = CbxSubjectName.Text;
			StudentAcademiCurrent.ScoreLetter = TbxScoreLetter.Text;
			StudentAcademiCurrent.Note = TbxNote.Text;
			StudentAcademiCurrent.Status = StudentAcademicModel.ACTIVE;
			if (TbxScore.Text != "")
			{
				StudentAcademiCurrent.Score = Convert.ToDecimal(TbxScore.Text);
			}
			if (CbxSemester.Text != "")
			{
				StudentAcademiCurrent.Semester = Convert.ToInt32(CbxSemester.SelectedValue);
			}
		}

		private void SetStudentAcademiCurrentToForm()
		{
			CbxClassName.SelectedValue = StudentAcademiCurrent.ClassId;
			CbxSchoolYear.SelectedValue = StudentAcademiCurrent.SchoolYearId;
			CbxSubjectName.SelectedValue = StudentAcademiCurrent.SubjectId;
			CbxSemester.SelectedItem = StudentAcademiCurrent.Semester;
			TbxNote.Text = StudentAcademiCurrent.Note;
			TbxScore.Text = StudentAcademiCurrent.Score.ToString();
			TbxScoreLetter.Text = StudentAcademiCurrent.ScoreLetter;
		}

		private bool Validator(out string errMessage)
		{
			errMessage = "Lỗi:";
			if (CbxSchoolYear.SelectedValue !=  null && CbxSchoolYear.SelectedValue.ToString() == "")
			{
				errMessage += "\r\nVui lòng chọn Năm học";
			}
			if (CbxSemester.SelectedValue != null && CbxSemester.SelectedValue.ToString() == "")
			{
				errMessage += "\r\nVui lòng chọn Học kỳ";
			}
			if (CbxClassName.SelectedValue !=  null && CbxClassName.SelectedValue.ToString() == "")
				{
				errMessage += "\r\nVui lòng chọn Lớp";
			}
			if (CbxSubjectName.SelectedValue !=  null && CbxSubjectName.SelectedValue.ToString() == "")
				{
				errMessage += "\r\nVui lòng chọn Môn học";
			}

			return errMessage == "Lỗi:" ? true : false;
		}

		private void LoadDataComboBox()
		{
			// Keep current selection so reloading does not clear what the user picked
			object classId = CbxClassName.SelectedValue;
			object schoolYearId = CbxSchoolYear.SelectedValue;
			object subjectId = CbxSubjectName.SelectedValue;

			// Copy() so the placeholder row is not added to the bussiness table (SaveAll would insert it)
			DataTable classDt = ClassBus.FillClassInfo().Copy();
			DataRow r1 = classDt.NewRow();
			r1["ClassId"] = "";
			r1["ClassName"] = "-- Chọn lớp --";
			classDt.Rows.InsertAt(r1, 0);
			CbxClassName.DisplayMember = "ClassName";
			CbxClassName.ValueMember = "ClassId";
			CbxClassName.DataSource = classDt;

			DataTable schoolYearDt = SchoolYearBus.FillSchoolYear().Copy();
			DataRow r2 = schoolYearDt.NewRow();
			r2["SchoolYearId"] = "";
			r2["SchoolYearName"] = "-- Chọn Năm học --";
			schoolYearDt.Rows.InsertAt(r2, 0);
			CbxSchoolYear.DisplayMember = "SchoolYearName";
			CbxSchoolYear.ValueMember = "SchoolYearId";
			CbxSchoolYear.DataSource = schoolYearDt;

			DataTable subjectDt = SubjectBus.FillSubject().Copy();
			DataRow r3 = subjectDt.NewRow();
			r3["SubjectId"] = "";
			r3["SubjectName"] = "-- Chọn Môn học --";
			subjectDt.Rows.InsertAt(r3, 0);
			CbxSubjectName.DisplayMember = "SubjectName";
			CbxSubjectName.ValueMember = "SubjectId";
			CbxSubjectName.DataSource = subjectDt;

			if (classId != null) CbxClassName.SelectedValue = classId;
			if (schoolYearId != null) CbxSchoolYear.SelectedValue = schoolYearId;
			if (subjectId != null) CbxSubjectName.SelectedValue = subjectId;

			if (CbxSemester.DataSource == null)
			{
				CbxSemester.DataSource = new int[] { HK1, HK2, HK3 };
			}
		}

		private void resetForm()
		{
			CbxClassName.SelectedValue = "";
			CbxSchoolYear.SelectedValue = "";
			CbxSubjectName.SelectedValue = "";
			CbxSemester.SelectedItem = HK1;
			TbxNote.Text = "";
			TbxScore.Text = "";
			TbxScoreLetter.Text = "";
			BtnSave.Text = "Thêm";
		}

		private void TbxScore_TextChanged(object sender, EventArgs e)
		{
			if (TbxScore != null && TbxScore.Text != null && TbxScore.Text != "")
			{
				decimal score = Convert.ToDecimal(TbxScore.Text);
				TbxScoreLetter.Text = StudentAcademicBus.ConvertScoreToLetter(score);
			}
        }
	}
}
