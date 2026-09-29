namespace QLSV.Controls
{
	partial class UcStudentForm
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.PnlMain = new System.Windows.Forms.Panel();
			this.TabStudent = new System.Windows.Forms.TabControl();
			this.TpgInfoStudent = new System.Windows.Forms.TabPage();
			this.DtpDateOfIssue = new System.Windows.Forms.DateTimePicker();
			this.DtpBirthOfDate = new System.Windows.Forms.DateTimePicker();
			this.PnlSex = new System.Windows.Forms.Panel();
			this.RbtFemale = new System.Windows.Forms.RadioButton();
			this.LblSex = new System.Windows.Forms.Label();
			this.RbtMale = new System.Windows.Forms.RadioButton();
			this.TxtHometown = new System.Windows.Forms.TextBox();
			this.TxtPlaceOfResidence = new System.Windows.Forms.TextBox();
			this.LblHometown = new System.Windows.Forms.Label();
			this.LblPlaceOfResidence = new System.Windows.Forms.Label();
			this.TxtLocalOfIssue = new System.Windows.Forms.TextBox();
			this.LblLocalOfIssue = new System.Windows.Forms.Label();
			this.TxtVneId = new System.Windows.Forms.TextBox();
			this.LblVneId = new System.Windows.Forms.Label();
			this.TxtBirthLocal = new System.Windows.Forms.TextBox();
			this.LblDateOfIssue = new System.Windows.Forms.Label();
			this.LblBirthLocal = new System.Windows.Forms.Label();
			this.LblBirthOfDate = new System.Windows.Forms.Label();
			this.TxtName = new System.Windows.Forms.TextBox();
			this.LblName = new System.Windows.Forms.Label();
			this.TxtStudentId = new System.Windows.Forms.TextBox();
			this.LblStudentId = new System.Windows.Forms.Label();
			this.TpgLearning = new System.Windows.Forms.TabPage();
			this.PnlBodyTpgLearning = new System.Windows.Forms.Panel();
			this.DgvLearningList = new System.Windows.Forms.DataGridView();
			this.SchoolYearName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ScoreLetter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
			this.PnlHeaderTpgLearning = new System.Windows.Forms.Panel();
			this.BtnCreateLearning = new System.Windows.Forms.Button();
			this.PnlFooter = new System.Windows.Forms.FlowLayoutPanel();
			this.BtnTempSave = new System.Windows.Forms.Button();
			this.BtnSave = new System.Windows.Forms.Button();
			this.PnlMain.SuspendLayout();
			this.TabStudent.SuspendLayout();
			this.TpgInfoStudent.SuspendLayout();
			this.PnlSex.SuspendLayout();
			this.TpgLearning.SuspendLayout();
			this.PnlBodyTpgLearning.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvLearningList)).BeginInit();
			this.PnlHeaderTpgLearning.SuspendLayout();
			this.PnlFooter.SuspendLayout();
			this.SuspendLayout();
			// 
			// PnlMain
			// 
			this.PnlMain.Controls.Add(this.TabStudent);
			this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlMain.Location = new System.Drawing.Point(0, 0);
			this.PnlMain.Name = "PnlMain";
			this.PnlMain.Size = new System.Drawing.Size(643, 488);
			this.PnlMain.TabIndex = 0;
			// 
			// TabStudent
			// 
			this.TabStudent.Controls.Add(this.TpgInfoStudent);
			this.TabStudent.Controls.Add(this.TpgLearning);
			this.TabStudent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabStudent.Location = new System.Drawing.Point(0, 0);
			this.TabStudent.Name = "TabStudent";
			this.TabStudent.SelectedIndex = 0;
			this.TabStudent.Size = new System.Drawing.Size(643, 488);
			this.TabStudent.TabIndex = 0;
			// 
			// TpgInfoStudent
			// 
			this.TpgInfoStudent.Controls.Add(this.DtpDateOfIssue);
			this.TpgInfoStudent.Controls.Add(this.DtpBirthOfDate);
			this.TpgInfoStudent.Controls.Add(this.PnlSex);
			this.TpgInfoStudent.Controls.Add(this.TxtHometown);
			this.TpgInfoStudent.Controls.Add(this.TxtPlaceOfResidence);
			this.TpgInfoStudent.Controls.Add(this.LblHometown);
			this.TpgInfoStudent.Controls.Add(this.LblPlaceOfResidence);
			this.TpgInfoStudent.Controls.Add(this.TxtLocalOfIssue);
			this.TpgInfoStudent.Controls.Add(this.LblLocalOfIssue);
			this.TpgInfoStudent.Controls.Add(this.TxtVneId);
			this.TpgInfoStudent.Controls.Add(this.LblVneId);
			this.TpgInfoStudent.Controls.Add(this.TxtBirthLocal);
			this.TpgInfoStudent.Controls.Add(this.LblDateOfIssue);
			this.TpgInfoStudent.Controls.Add(this.LblBirthLocal);
			this.TpgInfoStudent.Controls.Add(this.LblBirthOfDate);
			this.TpgInfoStudent.Controls.Add(this.TxtName);
			this.TpgInfoStudent.Controls.Add(this.LblName);
			this.TpgInfoStudent.Controls.Add(this.TxtStudentId);
			this.TpgInfoStudent.Controls.Add(this.LblStudentId);
			this.TpgInfoStudent.Location = new System.Drawing.Point(4, 22);
			this.TpgInfoStudent.Name = "TpgInfoStudent";
			this.TpgInfoStudent.Padding = new System.Windows.Forms.Padding(3);
			this.TpgInfoStudent.Size = new System.Drawing.Size(635, 462);
			this.TpgInfoStudent.TabIndex = 0;
			this.TpgInfoStudent.Text = "Thông tin sinh viên";
			this.TpgInfoStudent.UseVisualStyleBackColor = true;
			// 
			// DtpDateOfIssue
			// 
			this.DtpDateOfIssue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DtpDateOfIssue.Location = new System.Drawing.Point(490, 65);
			this.DtpDateOfIssue.Name = "DtpDateOfIssue";
			this.DtpDateOfIssue.Size = new System.Drawing.Size(130, 20);
			this.DtpDateOfIssue.TabIndex = 26;
			this.DtpDateOfIssue.Value = new System.DateTime(2026, 9, 29, 0, 0, 0, 0);
			// 
			// DtpBirthOfDate
			// 
			this.DtpBirthOfDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DtpBirthOfDate.Location = new System.Drawing.Point(60, 35);
			this.DtpBirthOfDate.Name = "DtpBirthOfDate";
			this.DtpBirthOfDate.Size = new System.Drawing.Size(140, 20);
			this.DtpBirthOfDate.TabIndex = 25;
			this.DtpBirthOfDate.Value = new System.DateTime(2026, 9, 29, 0, 0, 0, 0);
			// 
			// PnlSex
			// 
			this.PnlSex.Controls.Add(this.RbtFemale);
			this.PnlSex.Controls.Add(this.LblSex);
			this.PnlSex.Controls.Add(this.RbtMale);
			this.PnlSex.Location = new System.Drawing.Point(440, 5);
			this.PnlSex.Name = "PnlSex";
			this.PnlSex.Size = new System.Drawing.Size(165, 20);
			this.PnlSex.TabIndex = 24;
			// 
			// RbtFemale
			// 
			this.RbtFemale.Location = new System.Drawing.Point(115, 0);
			this.RbtFemale.Name = "RbtFemale";
			this.RbtFemale.Size = new System.Drawing.Size(50, 20);
			this.RbtFemale.TabIndex = 6;
			this.RbtFemale.Text = "Nữ";
			this.RbtFemale.UseVisualStyleBackColor = true;
			// 
			// LblSex
			// 
			this.LblSex.Location = new System.Drawing.Point(5, 0);
			this.LblSex.Name = "LblSex";
			this.LblSex.Size = new System.Drawing.Size(50, 20);
			this.LblSex.TabIndex = 2;
			this.LblSex.Text = "Giới tính: ";
			this.LblSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// RbtMale
			// 
			this.RbtMale.Checked = true;
			this.RbtMale.Location = new System.Drawing.Point(55, 0);
			this.RbtMale.Name = "RbtMale";
			this.RbtMale.Size = new System.Drawing.Size(60, 20);
			this.RbtMale.TabIndex = 5;
			this.RbtMale.TabStop = true;
			this.RbtMale.Text = "Nam";
			this.RbtMale.UseVisualStyleBackColor = true;
			// 
			// TxtHometown
			// 
			this.TxtHometown.Location = new System.Drawing.Point(90, 125);
			this.TxtHometown.Name = "TxtHometown";
			this.TxtHometown.Size = new System.Drawing.Size(530, 20);
			this.TxtHometown.TabIndex = 22;
			// 
			// TxtPlaceOfResidence
			// 
			this.TxtPlaceOfResidence.Location = new System.Drawing.Point(90, 95);
			this.TxtPlaceOfResidence.Name = "TxtPlaceOfResidence";
			this.TxtPlaceOfResidence.Size = new System.Drawing.Size(530, 20);
			this.TxtPlaceOfResidence.TabIndex = 21;
			// 
			// LblHometown
			// 
			this.LblHometown.Location = new System.Drawing.Point(5, 125);
			this.LblHometown.Name = "LblHometown";
			this.LblHometown.Size = new System.Drawing.Size(90, 20);
			this.LblHometown.TabIndex = 12;
			this.LblHometown.Text = "Quê quán:";
			this.LblHometown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblPlaceOfResidence
			// 
			this.LblPlaceOfResidence.Location = new System.Drawing.Point(5, 95);
			this.LblPlaceOfResidence.Name = "LblPlaceOfResidence";
			this.LblPlaceOfResidence.Size = new System.Drawing.Size(90, 20);
			this.LblPlaceOfResidence.TabIndex = 13;
			this.LblPlaceOfResidence.Text = "Nơi ở thường trú: ";
			this.LblPlaceOfResidence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtLocalOfIssue
			// 
			this.TxtLocalOfIssue.Location = new System.Drawing.Point(250, 65);
			this.TxtLocalOfIssue.Name = "TxtLocalOfIssue";
			this.TxtLocalOfIssue.Size = new System.Drawing.Size(160, 20);
			this.TxtLocalOfIssue.TabIndex = 20;
			// 
			// LblLocalOfIssue
			// 
			this.LblLocalOfIssue.Location = new System.Drawing.Point(205, 65);
			this.LblLocalOfIssue.Name = "LblLocalOfIssue";
			this.LblLocalOfIssue.Size = new System.Drawing.Size(50, 20);
			this.LblLocalOfIssue.TabIndex = 15;
			this.LblLocalOfIssue.Text = "Nơi cấp: ";
			this.LblLocalOfIssue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtVneId
			// 
			this.TxtVneId.Location = new System.Drawing.Point(60, 65);
			this.TxtVneId.Name = "TxtVneId";
			this.TxtVneId.Size = new System.Drawing.Size(140, 20);
			this.TxtVneId.TabIndex = 19;
			// 
			// LblVneId
			// 
			this.LblVneId.Location = new System.Drawing.Point(5, 65);
			this.LblVneId.Name = "LblVneId";
			this.LblVneId.Size = new System.Drawing.Size(50, 20);
			this.LblVneId.TabIndex = 16;
			this.LblVneId.Text = "CCCD: ";
			this.LblVneId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtBirthLocal
			// 
			this.TxtBirthLocal.Location = new System.Drawing.Point(250, 35);
			this.TxtBirthLocal.Name = "TxtBirthLocal";
			this.TxtBirthLocal.Size = new System.Drawing.Size(370, 20);
			this.TxtBirthLocal.TabIndex = 18;
			// 
			// LblDateOfIssue
			// 
			this.LblDateOfIssue.Location = new System.Drawing.Point(440, 65);
			this.LblDateOfIssue.Name = "LblDateOfIssue";
			this.LblDateOfIssue.Size = new System.Drawing.Size(70, 20);
			this.LblDateOfIssue.TabIndex = 14;
			this.LblDateOfIssue.Text = "Ngày cấp: ";
			this.LblDateOfIssue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblBirthLocal
			// 
			this.LblBirthLocal.Location = new System.Drawing.Point(205, 35);
			this.LblBirthLocal.Name = "LblBirthLocal";
			this.LblBirthLocal.Size = new System.Drawing.Size(50, 20);
			this.LblBirthLocal.TabIndex = 11;
			this.LblBirthLocal.Text = "Nơi sinh: ";
			this.LblBirthLocal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblBirthOfDate
			// 
			this.LblBirthOfDate.Location = new System.Drawing.Point(5, 35);
			this.LblBirthOfDate.Name = "LblBirthOfDate";
			this.LblBirthOfDate.Size = new System.Drawing.Size(70, 20);
			this.LblBirthOfDate.TabIndex = 10;
			this.LblBirthOfDate.Text = "Năm sinh: ";
			this.LblBirthOfDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtName
			// 
			this.TxtName.Location = new System.Drawing.Point(250, 5);
			this.TxtName.Name = "TxtName";
			this.TxtName.Size = new System.Drawing.Size(160, 20);
			this.TxtName.TabIndex = 17;
			// 
			// LblName
			// 
			this.LblName.Location = new System.Drawing.Point(205, 5);
			this.LblName.Name = "LblName";
			this.LblName.Size = new System.Drawing.Size(50, 20);
			this.LblName.TabIndex = 9;
			this.LblName.Text = "Họ tên: ";
			this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtStudentId
			// 
			this.TxtStudentId.Location = new System.Drawing.Point(60, 5);
			this.TxtStudentId.Name = "TxtStudentId";
			this.TxtStudentId.Size = new System.Drawing.Size(140, 20);
			this.TxtStudentId.TabIndex = 23;
			// 
			// LblStudentId
			// 
			this.LblStudentId.Location = new System.Drawing.Point(5, 5);
			this.LblStudentId.Name = "LblStudentId";
			this.LblStudentId.Size = new System.Drawing.Size(50, 20);
			this.LblStudentId.TabIndex = 8;
			this.LblStudentId.Text = "MSSV: ";
			this.LblStudentId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TpgLearning
			// 
			this.TpgLearning.Controls.Add(this.PnlBodyTpgLearning);
			this.TpgLearning.Controls.Add(this.PnlHeaderTpgLearning);
			this.TpgLearning.Location = new System.Drawing.Point(4, 22);
			this.TpgLearning.Name = "TpgLearning";
			this.TpgLearning.Padding = new System.Windows.Forms.Padding(3);
			this.TpgLearning.Size = new System.Drawing.Size(635, 462);
			this.TpgLearning.TabIndex = 1;
			this.TpgLearning.Text = "Thông tin học tập";
			this.TpgLearning.UseVisualStyleBackColor = true;
			// 
			// PnlBodyTpgLearning
			// 
			this.PnlBodyTpgLearning.Controls.Add(this.DgvLearningList);
			this.PnlBodyTpgLearning.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlBodyTpgLearning.Location = new System.Drawing.Point(3, 30);
			this.PnlBodyTpgLearning.Name = "PnlBodyTpgLearning";
			this.PnlBodyTpgLearning.Size = new System.Drawing.Size(629, 429);
			this.PnlBodyTpgLearning.TabIndex = 2;
			// 
			// DgvLearningList
			// 
			this.DgvLearningList.AllowUserToAddRows = false;
			this.DgvLearningList.AllowUserToDeleteRows = false;
			this.DgvLearningList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvLearningList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SchoolYearName,
            this.Semester,
            this.ClassName,
            this.SubjectName,
            this.Score,
            this.ScoreLetter,
            this.Action});
			this.DgvLearningList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DgvLearningList.Location = new System.Drawing.Point(0, 0);
			this.DgvLearningList.Name = "DgvLearningList";
			this.DgvLearningList.ReadOnly = true;
			this.DgvLearningList.Size = new System.Drawing.Size(629, 429);
			this.DgvLearningList.TabIndex = 0;
			// 
			// SchoolYearName
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.SchoolYearName.DefaultCellStyle = dataGridViewCellStyle1;
			this.SchoolYearName.HeaderText = "Năm học";
			this.SchoolYearName.Name = "SchoolYearName";
			this.SchoolYearName.ReadOnly = true;
			// 
			// Semester
			// 
			this.Semester.HeaderText = "Học kỳ";
			this.Semester.Name = "Semester";
			this.Semester.ReadOnly = true;
			// 
			// ClassName
			// 
			this.ClassName.HeaderText = "Lớp học";
			this.ClassName.Name = "ClassName";
			this.ClassName.ReadOnly = true;
			// 
			// SubjectName
			// 
			this.SubjectName.HeaderText = "Môn học";
			this.SubjectName.Name = "SubjectName";
			this.SubjectName.ReadOnly = true;
			// 
			// Score
			// 
			this.Score.HeaderText = "Điểm";
			this.Score.Name = "Score";
			this.Score.ReadOnly = true;
			// 
			// ScoreLetter
			// 
			this.ScoreLetter.HeaderText = "Điểm chữ";
			this.ScoreLetter.Name = "ScoreLetter";
			this.ScoreLetter.ReadOnly = true;
			// 
			// Action
			// 
			this.Action.HeaderText = "Sửa/Xóa";
			this.Action.Name = "Action";
			this.Action.ReadOnly = true;
			this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Action.Text = "";
			// 
			// PnlHeaderTpgLearning
			// 
			this.PnlHeaderTpgLearning.Controls.Add(this.BtnCreateLearning);
			this.PnlHeaderTpgLearning.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlHeaderTpgLearning.Location = new System.Drawing.Point(3, 3);
			this.PnlHeaderTpgLearning.Name = "PnlHeaderTpgLearning";
			this.PnlHeaderTpgLearning.Size = new System.Drawing.Size(629, 27);
			this.PnlHeaderTpgLearning.TabIndex = 0;
			// 
			// BtnCreateLearning
			// 
			this.BtnCreateLearning.Location = new System.Drawing.Point(0, 0);
			this.BtnCreateLearning.Name = "BtnCreateLearning";
			this.BtnCreateLearning.Size = new System.Drawing.Size(75, 25);
			this.BtnCreateLearning.TabIndex = 0;
			this.BtnCreateLearning.Text = "Thêm mới";
			this.BtnCreateLearning.UseVisualStyleBackColor = true;
			// 
			// PnlFooter
			// 
			this.PnlFooter.Controls.Add(this.BtnTempSave);
			this.PnlFooter.Controls.Add(this.BtnSave);
			this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PnlFooter.Location = new System.Drawing.Point(0, 460);
			this.PnlFooter.Name = "PnlFooter";
			this.PnlFooter.Size = new System.Drawing.Size(643, 28);
			this.PnlFooter.TabIndex = 1;
			// 
			// BtnTempSave
			// 
			this.BtnTempSave.Location = new System.Drawing.Point(3, 3);
			this.BtnTempSave.Name = "BtnTempSave";
			this.BtnTempSave.Size = new System.Drawing.Size(75, 23);
			this.BtnTempSave.TabIndex = 0;
			this.BtnTempSave.Text = "Lưu tạm";
			this.BtnTempSave.UseVisualStyleBackColor = true;
			this.BtnTempSave.Click += new System.EventHandler(this.BtnTempSave_Click);
			// 
			// BtnSave
			// 
			this.BtnSave.Location = new System.Drawing.Point(84, 3);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(76, 22);
			this.BtnSave.TabIndex = 1;
			this.BtnSave.Text = "Lưu vào DB";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// UcStudentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.PnlFooter);
			this.Controls.Add(this.PnlMain);
			this.Name = "UcStudentForm";
			this.Size = new System.Drawing.Size(643, 488);
			this.PnlMain.ResumeLayout(false);
			this.TabStudent.ResumeLayout(false);
			this.TpgInfoStudent.ResumeLayout(false);
			this.TpgInfoStudent.PerformLayout();
			this.PnlSex.ResumeLayout(false);
			this.TpgLearning.ResumeLayout(false);
			this.PnlBodyTpgLearning.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DgvLearningList)).EndInit();
			this.PnlHeaderTpgLearning.ResumeLayout(false);
			this.PnlFooter.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PnlMain;
		private System.Windows.Forms.FlowLayoutPanel PnlFooter;
		private System.Windows.Forms.Button BtnTempSave;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.TabControl TabStudent;
		private System.Windows.Forms.TabPage TpgInfoStudent;
		private System.Windows.Forms.DateTimePicker DtpDateOfIssue;
		private System.Windows.Forms.DateTimePicker DtpBirthOfDate;
		private System.Windows.Forms.Panel PnlSex;
		private System.Windows.Forms.RadioButton RbtFemale;
		private System.Windows.Forms.Label LblSex;
		private System.Windows.Forms.RadioButton RbtMale;
		private System.Windows.Forms.TextBox TxtHometown;
		private System.Windows.Forms.TextBox TxtPlaceOfResidence;
		private System.Windows.Forms.Label LblHometown;
		private System.Windows.Forms.Label LblPlaceOfResidence;
		private System.Windows.Forms.TextBox TxtLocalOfIssue;
		private System.Windows.Forms.Label LblLocalOfIssue;
		private System.Windows.Forms.TextBox TxtVneId;
		private System.Windows.Forms.Label LblVneId;
		private System.Windows.Forms.TextBox TxtBirthLocal;
		private System.Windows.Forms.Label LblDateOfIssue;
		private System.Windows.Forms.Label LblBirthLocal;
		private System.Windows.Forms.Label LblBirthOfDate;
		private System.Windows.Forms.TextBox TxtName;
		private System.Windows.Forms.Label LblName;
		private System.Windows.Forms.TextBox TxtStudentId;
		private System.Windows.Forms.Label LblStudentId;
		private System.Windows.Forms.TabPage TpgLearning;
		private System.Windows.Forms.Panel PnlBodyTpgLearning;
		private System.Windows.Forms.DataGridView DgvLearningList;
		private System.Windows.Forms.Panel PnlHeaderTpgLearning;
		private System.Windows.Forms.Button BtnCreateLearning;
		private System.Windows.Forms.DataGridViewTextBoxColumn SchoolYearName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Score;
		private System.Windows.Forms.DataGridViewTextBoxColumn ScoreLetter;
		private System.Windows.Forms.DataGridViewButtonColumn Action;
	}
}
