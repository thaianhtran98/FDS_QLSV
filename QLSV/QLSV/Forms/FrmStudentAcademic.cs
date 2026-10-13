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
	/// <summary>
	/// Dialog to add or edit an academic record (class, school year, subject, semester, score) of a student.
	/// </summary>
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

		/// <summary>
		/// Initializes the dialog and loads the combo boxes.
		/// When <paramref name="studentAcademic"/> is null the dialog is in add mode; otherwise the form is filled
		/// with the record and switched to edit mode (<paramref name="row"/> is the cached row being edited).
		/// </summary>
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

		/// <summary>
		/// Opens the training info dialog on the given tab, then reloads the combo boxes so new items appear.
		/// </summary>
		private void ShowDialogAddTrainingInfo(TrainingInfoTab tabInit)
		{
			FrmTrainngInfo fr = new FrmTrainngInfo(tabInit, ClassBus, SchoolYearBus, SubjectBus);
			fr.ShowDialog();
			fr.Dispose();
			LoadDataComboBox();
		}

		/// <summary>
		/// Opens the training info dialog on the School Year tab.
		/// </summary>
		private void BtnAddSchoolYear_Click(object sender, EventArgs e)
		{
			ShowDialogAddTrainingInfo(TrainingInfoTab.SchoolYear);
        }

		/// <summary>
		/// Opens the training info dialog on the Class tab.
		/// </summary>
		private void BtnAddClass_Click(object sender, EventArgs e)
		{
			ShowDialogAddTrainingInfo(TrainingInfoTab.Class);
		}

		/// <summary>
		/// Opens the training info dialog on the Subject tab.
		/// </summary>
		private void BtnAddSubject_Click(object sender, EventArgs e)
		{
			ShowDialogAddTrainingInfo(TrainingInfoTab.Subject);
		}

		/// <summary>
		/// Validates the form, then adds a new academic row or updates the edited row.
		/// The dialog is closed after an update; in add mode the form is reset for the next record.
		/// </summary>
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

		/// <summary>
		/// Copies the values of the form controls into <c>StudentAcademiCurrent</c>.
		/// </summary>
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

		/// <summary>
		/// Fills the form controls with the values of <c>StudentAcademiCurrent</c>.
		/// </summary>
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

		/// <summary>
		/// Checks that school year, semester, class and subject are selected.
		/// Returns false and the error list in <paramref name="errMessage"/> when validation fails.
		/// </summary>
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

		/// <summary>
		/// Binds the class, school year and subject combo boxes (with a placeholder item on top)
		/// and the semester list, keeping the current selections.
		/// </summary>
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

		/// <summary>
		/// Clears the form controls and switches the save button back to add mode.
		/// </summary>
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

		/// <summary>
		/// Recalculates the letter grade whenever the score changes.
		/// </summary>
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
