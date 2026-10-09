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

		private const int HK1 = 1;
		private const int HK2 = 2;
		private const int HK3 = 3;

		public FrmStudentAcademic(StudentAcademicBussiness studentAcademicBussiness, StudentAcademicModel studentAcademic, string studentId)
		{
			ClassBus = new ClassInfoBussiness();
			SchoolYearBus = new SchoolYearBussiness();
			SubjectBus = new SubjectBussiness();
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
			string message = null;
			if (!Validator(out message))
			{
				MessageBox.Show(message);
				return;
			}

			message = "Thêm thành công";
			if (IsEditing)
			{
				SetFormToStudentAcademiCurrent();
				StudentAcademicBus.CreateRowStudentAcademic(StudentAcademiCurrent);
				resetForm();
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
			StudentAcademiCurrent.Score = Convert.ToDecimal(TbxScore.Text);
			StudentAcademiCurrent.ScoreLetter = TbxScoreLetter.Text;
			StudentAcademiCurrent.Semester = Convert.ToInt32(CbxSemester.SelectedValue);
			StudentAcademiCurrent.Note = TbxNote.Text;
			StudentAcademiCurrent.Status = StudentAcademicModel.ACTIVE;
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
			if (CbxSchoolYear.Text == "")
			{
				errMessage += "\r\nVui lòng chọn Năm học";
			}
			if (CbxSemester.Text == "")
			{
				errMessage += "\r\nVui lòng chọn Học kỳ";
			}
			if (CbxClassName.Text == "")
			{
				errMessage += "\r\nVui lòng chọn Lớp";
			}
			if (CbxSubjectName.Text == "")
			{
				errMessage += "\r\nVui lòng chọn Môn học";
			}

			return errMessage == "Lỗi:" ? true : false;
		}

		private void LoadDataComboBox()
		{
			DataTable classDt = ClassBus.FillClassInfo();
			DataRow r1 = classDt.NewRow();
			r1["ClassId"] = "";
			r1["ClassName"] = "-- Chọn lớp --";
			classDt.Rows.InsertAt(r1, 0);
			CbxClassName.DataSource = classDt;
			CbxClassName.DisplayMember = "ClassName";
			CbxClassName.ValueMember = "ClassId";

			DataTable schoolYearDt = SchoolYearBus.FillSchoolYear();
			DataRow r2 = schoolYearDt.NewRow();
			r2["SchoolYearId"] = "";
			r2["SchoolYearName"] = "-- Chọn Năm học --";
			schoolYearDt.Rows.InsertAt(r2, 0);
			CbxSchoolYear.DataSource = schoolYearDt;
			CbxSchoolYear.DisplayMember = "SchoolYearName";
			CbxSchoolYear.ValueMember = "SchoolYearId";

			DataTable subjectDt = SubjectBus.FillSubject();
			DataRow r3 = subjectDt.NewRow();
			r3["SubjectId"] = "";
			r3["SubjectName"] = "-- Chọn Môn học --";
			subjectDt.Rows.InsertAt(r3, 0);
			CbxSubjectName.DataSource = subjectDt;
			CbxSubjectName.DisplayMember = "SubjectName";
			CbxSubjectName.ValueMember = "SubjectId";

			CbxSemester.DataSource = new int[] { HK1, HK2, HK3 };
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
