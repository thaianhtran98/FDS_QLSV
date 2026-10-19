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
using QuanLySVBusiness;
using QuanLySVModel;

namespace QuanLySV.Forms
{
	/// <summary>
	/// Dialog to add or edit an academic record (class, school year, subject, semester, score) of a student.
	/// </summary>
	public partial class FrmStudentAcademic : Form
	{
		private ClassInfoBusiness ClassBus;
		private SchoolYearBusiness SchoolYearBus;
		private SubjectBusiness SubjectBus;
		private StudentAcademicBusiness StudentAcademicBus;
		private StudentAcademicModel StudentAcademicCurrent;
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
		public FrmStudentAcademic(StudentAcademicBusiness studentAcademicBusiness, StudentAcademicModel studentAcademic, string studentId, DataRow row = null)
		{
			ClassBus = new ClassInfoBusiness();
			SchoolYearBus = new SchoolYearBusiness();
			SubjectBus = new SubjectBusiness();
			RowEditing = row;
			StudentAcademicBus = studentAcademicBusiness;
			InitializeComponent();
			LoadDataComboBox();
			StudentId = studentId;
			if (studentAcademic == null)
			{
				StudentAcademicCurrent = new StudentAcademicModel();
			}
			else
			{
				StudentAcademicCurrent = studentAcademic;
				SetStudentAcademicCurrentToForm();
				IsEditing = true;
				BtnSave.Text = "Cập nhật";
            }
		}

		/// <summary>
		/// Opens the training info dialog on the given tab, then reloads the combo boxes so new items appear.
		/// </summary>
		private void ShowDialogAddTrainingInfo(TrainingInfoTab tabInit)
		{
			FrmTrainingInfo fr = new FrmTrainingInfo(tabInit, ClassBus, SchoolYearBus, SubjectBus);
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
				SetFormToStudentAcademicCurrent();								
				StudentAcademicBus.UpdateRowStudentAcademic(StudentAcademicCurrent, RowEditing);
				resetForm();
				this.Close();
			}
			else
			{
				SetFormToStudentAcademicCurrent();
				StudentAcademicBus.CreateRowStudentAcademic(StudentAcademicCurrent);
				resetForm();
			}
			

			MessageBox.Show(message);
		}

		/// <summary>
		/// Copies the values of the form controls into <c>StudentAcademicCurrent</c>.
		/// </summary>
		private void SetFormToStudentAcademicCurrent()
		{
			StudentAcademicCurrent.StudentId = StudentId;
			StudentAcademicCurrent.ClassId = CbxClassName.SelectedValue.ToString();
			StudentAcademicCurrent.ClassName = CbxClassName.Text;
			StudentAcademicCurrent.SchoolYearId = CbxSchoolYear.SelectedValue.ToString();
			StudentAcademicCurrent.SchoolYearName = CbxSchoolYear.Text;
			StudentAcademicCurrent.SubjectId = CbxSubjectName.SelectedValue.ToString();
			StudentAcademicCurrent.SubjectName = CbxSubjectName.Text;
			StudentAcademicCurrent.ScoreLetter = TbxScoreLetter.Text;
			StudentAcademicCurrent.Score = null;
            StudentAcademicCurrent.Note = TbxNote.Text;
			StudentAcademicCurrent.Status = StudentAcademicModel.ACTIVE;
			if (TbxScore.Text != "")
			{
				StudentAcademicCurrent.Score = Convert.ToDecimal(TbxScore.Text);
			}
			if (CbxSemester.Text != "")
			{
				StudentAcademicCurrent.Semester = Convert.ToInt32(CbxSemester.SelectedValue);
			}
		}

		/// <summary>
		/// Fills the form controls with the values of <c>StudentAcademicCurrent</c>.
		/// </summary>
		private void SetStudentAcademicCurrentToForm()
		{
			CbxClassName.SelectedValue = StudentAcademicCurrent.ClassId;
			CbxSchoolYear.SelectedValue = StudentAcademicCurrent.SchoolYearId;
			CbxSubjectName.SelectedValue = StudentAcademicCurrent.SubjectId;
			CbxSemester.SelectedItem = StudentAcademicCurrent.Semester;
			TbxNote.Text = StudentAcademicCurrent.Note;
			TbxScore.Text = StudentAcademicCurrent.Score.ToString();
			TbxScoreLetter.Text = StudentAcademicCurrent.ScoreLetter;
		}

		/// <summary>
		/// Checks that school year, semester, class and subject are selected.
		/// Returns false and the error list in <paramref name="errMessage"/> when validation fails.
		/// </summary>
		private bool Validator(out string errMessage)
		{
			errMessage = "Lỗi:";
			if (string.IsNullOrEmpty(Convert.ToString(CbxSchoolYear.SelectedValue)))
			{
				errMessage += "\r\nVui lòng chọn Năm học";
			}
			if (string.IsNullOrEmpty(Convert.ToString(CbxSemester.SelectedValue)))
			{
				errMessage += "\r\nVui lòng chọn Học kỳ";
			}
			if (string.IsNullOrEmpty(Convert.ToString(CbxClassName.SelectedValue)))
			{
				errMessage += "\r\nVui lòng chọn Lớp";
			}
			if (string.IsNullOrEmpty(Convert.ToString(CbxSubjectName.SelectedValue)))
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

			if (classId != null)
			{
				CbxClassName.SelectedValue = classId;
			}
			if (schoolYearId != null)
			{
				CbxSchoolYear.SelectedValue = schoolYearId;
			}
			if (subjectId != null)
			{
				CbxSubjectName.SelectedValue = subjectId;
			}

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
				decimal score;
				if (decimal.TryParse(TbxScore.Text, out score))
				{
					TbxScore.ForeColor = Color.Black;
					TbxScoreLetter.Text = StudentAcademicBus.ConvertScoreToLetter(score);
				}
				else
				{
					MessageBox.Show("Vui lòng nhập điểm hợp lệ");
					TbxScore.ForeColor = Color.Red;
				}
			}
        }

		private void BtnClose_Click(object sender, EventArgs e)
		{
			this.Close(); 
		}
	}
}
