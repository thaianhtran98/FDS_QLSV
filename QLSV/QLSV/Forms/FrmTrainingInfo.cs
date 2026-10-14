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
using QuanLySVBusiness;

namespace QuanLySV.Forms
{
	/// <summary>
	/// Dialog hosting <see cref="UcTrainingInfo"/> to manage classes, school years and subjects.
	/// </summary>
	public partial class FrmTrainingInfo : Form
	{
		/// <summary>
		/// Initializes the dialog, selects <paramref name="initTab"/> and loads the business objects into the user control.
		/// </summary>
		public FrmTrainingInfo(TrainingInfoTab initTab, ClassInfoBusiness classInfoBusiness, SchoolYearBusiness schoolYearBusiness, SubjectBusiness subjectBusiness)
		{
			InitializeComponent();
			UcTrainingInfo.Initialize(initTab);
			UcTrainingInfo.LoadBusiness(classInfoBusiness, schoolYearBusiness, subjectBusiness);
		}
	}
}
