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
	public partial class FrmTrainngInfo : Form
	{
		public FrmTrainngInfo(TrainingInfoTab initTab, ClassInfoBussiness classInfoBussiness, SchoolYearBussiness schoolYearBussiness, SubjectBussiness subjectBussiness)
		{
			InitializeComponent();
			UcTrainingInfo.Initialize(initTab);
			UcTrainingInfo.LoadBussiness(classInfoBussiness, schoolYearBussiness, subjectBussiness);
		}
	}
}
