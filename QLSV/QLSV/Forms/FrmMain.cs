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
using QuanLySVBussiness;

namespace QuanLySV.Forms
{
	/// <summary>
	/// Main window. Owns the shared business objects and shows each screen (user control) in <c>PnlMain</c>.
	/// </summary>
	public partial class FrmMain : Form
	{
		private StudentBussiness StudentBus;
		private ClassInfoBussiness ClassInfoBus;
		private SchoolYearBussiness SchoolYearBus;
		private SubjectBussiness SubjectBus;
		private StudentAcademicBussiness StudentAcademicBus;

		/// <summary>
		/// Creates the shared business objects and initializes the form components.
		/// </summary>
		public FrmMain()
		{
			StudentBus = new StudentBussiness();
			ClassInfoBus = new ClassInfoBussiness();
			SchoolYearBus = new SchoolYearBussiness();
			SubjectBus = new SubjectBussiness();
			StudentAcademicBus = new StudentAcademicBussiness();
			InitializeComponent();
		}

		/// <summary>
		/// Replaces the content of <c>PnlMain</c> with the given user control (docked to fill).
		/// </summary>
		private void ShowUc(UserControl control)
		{
			PnlMain.Controls.Clear();
			control.Dock = DockStyle.Fill;
			control.Margin = Padding.Empty;
			PnlMain.Controls.Add(control);
			control.Focus();
		}

		/// <summary>
		/// Opens the student list screen.
		/// </summary>
		private void MnuItemList_Click(object sender, EventArgs e)
		{
			UcStudentList uc = new UcStudentList();
			uc.InitLoad(StudentBus, StudentAcademicBus);
			ShowUc(uc);
		}

		/// <summary>
		/// Opens an empty student form to create a new student.
		/// </summary>
		private void MnuItemCreate_Click(object sender, EventArgs e)
		{
			UcStudentForm uc = new UcStudentForm();
			uc.InitLoad(StudentBus, StudentAcademicBus);
			ShowUc(uc);
        }

		/// <summary>
		/// Opens the training info screen (classes, school years, subjects).
		/// </summary>
		private void MnuQldm_Click(object sender, EventArgs e)
		{
			UcTrainingInfo uc = new UcTrainingInfo();
			uc.LoadBussiness(ClassInfoBus, SchoolYearBus, SubjectBus);
			ShowUc(uc);
		}
	}
}
