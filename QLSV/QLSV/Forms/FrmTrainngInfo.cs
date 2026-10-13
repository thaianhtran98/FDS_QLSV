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
	/// Dialog hosting <see cref="UcTrainingInfo"/> to manage classes, school years and subjects.
	/// </summary>
	public partial class FrmTrainngInfo : Form
	{
		/// <summary>
		/// Initializes the dialog, selects <paramref name="initTab"/> and loads the business objects into the user control.
		/// </summary>
		public FrmTrainngInfo(TrainingInfoTab initTab, ClassInfoBussiness classInfoBussiness, SchoolYearBussiness schoolYearBussiness, SubjectBussiness subjectBussiness)
		{
			InitializeComponent();
			UcTrainingInfo.Initialize(initTab);
			UcTrainingInfo.LoadBussiness(classInfoBussiness, schoolYearBussiness, subjectBussiness);
		}
	}
}
