namespace QuanLySV.Controls
{
	partial class UcTrainingInfo
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
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.TabTraingInfo = new System.Windows.Forms.TabControl();
            this.TpgClass = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvListClass = new System.Windows.Forms.DataGridView();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColActionDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PnlClassForm = new System.Windows.Forms.Panel();
            this.BtnTempSaveClass = new System.Windows.Forms.Button();
            this.ChkStatusClass = new System.Windows.Forms.CheckBox();
            this.TbxDescriptionClass = new System.Windows.Forms.TextBox();
            this.TbxClassId = new System.Windows.Forms.TextBox();
            this.TbxClassName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblRequired = new System.Windows.Forms.Label();
            this.LblClassName = new System.Windows.Forms.Label();
            this.TpgSchoolYear = new System.Windows.Forms.TabPage();
            this.DgvListSchoolYear = new System.Windows.Forms.DataGridView();
            this.SchoolYearName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColActionDeleteSchoolYear = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PnlSchoolYearForm = new System.Windows.Forms.Panel();
            this.DtpEndYear = new System.Windows.Forms.DateTimePicker();
            this.DtpStartYear = new System.Windows.Forms.DateTimePicker();
            this.BtnTempSaveSchoolYear = new System.Windows.Forms.Button();
            this.ChkStatusSchoolYear = new System.Windows.Forms.CheckBox();
            this.TbxSchoolYearName = new System.Windows.Forms.TextBox();
            this.LblRequiredEndYear = new System.Windows.Forms.Label();
            this.LblRequriedStartYear = new System.Windows.Forms.Label();
            this.LblRequriedSchoolYearName = new System.Windows.Forms.Label();
            this.LblEndYear = new System.Windows.Forms.Label();
            this.LblStartYear = new System.Windows.Forms.Label();
            this.LblSchoolYearName = new System.Windows.Forms.Label();
            this.TpgSubject = new System.Windows.Forms.TabPage();
            this.DgvSubject = new System.Windows.Forms.DataGridView();
            this.PnlSubjectForm = new System.Windows.Forms.Panel();
            this.NumSubjectCredit = new System.Windows.Forms.NumericUpDown();
            this.BtnTempSaveSubject = new System.Windows.Forms.Button();
            this.ChkSubjectStatus = new System.Windows.Forms.CheckBox();
            this.TbxSubjectDescription = new System.Windows.Forms.TextBox();
            this.TbxSubjectName = new System.Windows.Forms.TextBox();
            this.LblSubjectDescription = new System.Windows.Forms.Label();
            this.LblRequiredSubjectCredit = new System.Windows.Forms.Label();
            this.LblSubjectCredit = new System.Windows.Forms.Label();
            this.LblRequired1 = new System.Windows.Forms.Label();
            this.LblSubjectName = new System.Windows.Forms.Label();
            this.DgvColSchoolYearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColSubjectAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LblSubjectId = new System.Windows.Forms.Label();
            this.LblRequiredSubjectId = new System.Windows.Forms.Label();
            this.TbxSubjectId = new System.Windows.Forms.TextBox();
            this.PnlFooter.SuspendLayout();
            this.PnlMain.SuspendLayout();
            this.TabTraingInfo.SuspendLayout();
            this.TpgClass.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListClass)).BeginInit();
            this.PnlClassForm.SuspendLayout();
            this.TpgSchoolYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListSchoolYear)).BeginInit();
            this.PnlSchoolYearForm.SuspendLayout();
            this.TpgSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSubject)).BeginInit();
            this.PnlSubjectForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumSubjectCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlFooter
            // 
            this.PnlFooter.Controls.Add(this.BtnSave);
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.Location = new System.Drawing.Point(0, 305);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(521, 32);
            this.PnlFooter.TabIndex = 1;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(440, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Lưu";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.TabTraingInfo);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(521, 305);
            this.PnlMain.TabIndex = 2;
            // 
            // TabTraingInfo
            // 
            this.TabTraingInfo.Controls.Add(this.TpgClass);
            this.TabTraingInfo.Controls.Add(this.TpgSchoolYear);
            this.TabTraingInfo.Controls.Add(this.TpgSubject);
            this.TabTraingInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabTraingInfo.Location = new System.Drawing.Point(0, 0);
            this.TabTraingInfo.Name = "TabTraingInfo";
            this.TabTraingInfo.SelectedIndex = 0;
            this.TabTraingInfo.Size = new System.Drawing.Size(521, 305);
            this.TabTraingInfo.TabIndex = 1;
            // 
            // TpgClass
            // 
            this.TpgClass.Controls.Add(this.panel2);
            this.TpgClass.Controls.Add(this.PnlClassForm);
            this.TpgClass.Location = new System.Drawing.Point(4, 22);
            this.TpgClass.Name = "TpgClass";
            this.TpgClass.Padding = new System.Windows.Forms.Padding(3);
            this.TpgClass.Size = new System.Drawing.Size(513, 279);
            this.TpgClass.TabIndex = 0;
            this.TpgClass.Text = "Lóp học";
            this.TpgClass.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvListClass);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(195, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 273);
            this.panel2.TabIndex = 1;
            // 
            // DgvListClass
            // 
            this.DgvListClass.AllowUserToAddRows = false;
            this.DgvListClass.AllowUserToDeleteRows = false;
            this.DgvListClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassId,
            this.ClassName,
            this.Description,
            this.DgvColActionDelete});
            this.DgvListClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListClass.Location = new System.Drawing.Point(0, 0);
            this.DgvListClass.Name = "DgvListClass";
            this.DgvListClass.ReadOnly = true;
            this.DgvListClass.Size = new System.Drawing.Size(315, 273);
            this.DgvListClass.TabIndex = 0;
            this.DgvListClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListClass_CellContentClick);
            this.DgvListClass.SelectionChanged += new System.EventHandler(this.DgvListClass_SelectionChanged);
            // 
            // ClassId
            // 
            this.ClassId.DataPropertyName = "ClassId";
            this.ClassId.HeaderText = "Mã lớp";
            this.ClassId.Name = "ClassId";
            this.ClassId.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "Tên lớp";
            this.ClassName.MinimumWidth = 150;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Mô tả";
            this.Description.MinimumWidth = 150;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // DgvColActionDelete
            // 
            this.DgvColActionDelete.HeaderText = "";
            this.DgvColActionDelete.Name = "DgvColActionDelete";
            this.DgvColActionDelete.ReadOnly = true;
            this.DgvColActionDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvColActionDelete.Text = "Xóa";
            this.DgvColActionDelete.UseColumnTextForButtonValue = true;
            this.DgvColActionDelete.Width = 50;
            // 
            // PnlClassForm
            // 
            this.PnlClassForm.Controls.Add(this.BtnTempSaveClass);
            this.PnlClassForm.Controls.Add(this.ChkStatusClass);
            this.PnlClassForm.Controls.Add(this.TbxDescriptionClass);
            this.PnlClassForm.Controls.Add(this.TbxClassId);
            this.PnlClassForm.Controls.Add(this.TbxClassName);
            this.PnlClassForm.Controls.Add(this.label2);
            this.PnlClassForm.Controls.Add(this.LblDescription);
            this.PnlClassForm.Controls.Add(this.label1);
            this.PnlClassForm.Controls.Add(this.LblRequired);
            this.PnlClassForm.Controls.Add(this.LblClassName);
            this.PnlClassForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlClassForm.Location = new System.Drawing.Point(3, 3);
            this.PnlClassForm.Name = "PnlClassForm";
            this.PnlClassForm.Size = new System.Drawing.Size(192, 273);
            this.PnlClassForm.TabIndex = 0;
            // 
            // BtnTempSaveClass
            // 
            this.BtnTempSaveClass.Location = new System.Drawing.Point(110, 160);
            this.BtnTempSaveClass.Name = "BtnTempSaveClass";
            this.BtnTempSaveClass.Size = new System.Drawing.Size(75, 23);
            this.BtnTempSaveClass.TabIndex = 0;
            this.BtnTempSaveClass.Text = "Thêm";
            this.BtnTempSaveClass.UseVisualStyleBackColor = true;
            this.BtnTempSaveClass.Click += new System.EventHandler(this.BtnTempSaveClass_Click);
            // 
            // ChkStatusClass
            // 
            this.ChkStatusClass.AutoSize = true;
            this.ChkStatusClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChkStatusClass.Location = new System.Drawing.Point(5, 135);
            this.ChkStatusClass.Name = "ChkStatusClass";
            this.ChkStatusClass.Size = new System.Drawing.Size(146, 17);
            this.ChkStatusClass.TabIndex = 2;
            this.ChkStatusClass.Text = "Trạng thái hoạt động";
            this.ChkStatusClass.UseVisualStyleBackColor = true;
            // 
            // TbxDescriptionClass
            // 
            this.TbxDescriptionClass.Location = new System.Drawing.Point(5, 105);
            this.TbxDescriptionClass.Name = "TbxDescriptionClass";
            this.TbxDescriptionClass.Size = new System.Drawing.Size(180, 20);
            this.TbxDescriptionClass.TabIndex = 1;
            // 
            // TbxClassId
            // 
            this.TbxClassId.Location = new System.Drawing.Point(5, 20);
            this.TbxClassId.Name = "TbxClassId";
            this.TbxClassId.Size = new System.Drawing.Size(180, 20);
            this.TbxClassId.TabIndex = 1;
            // 
            // TbxClassName
            // 
            this.TbxClassName.Location = new System.Drawing.Point(5, 60);
            this.TbxClassName.Name = "TbxClassName";
            this.TbxClassName.Size = new System.Drawing.Size(180, 20);
            this.TbxClassName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(65, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblDescription.Location = new System.Drawing.Point(0, 90);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(39, 13);
            this.LblDescription.TabIndex = 0;
            this.LblDescription.Text = "Mô tả";
            this.LblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp học";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblRequired
            // 
            this.LblRequired.AutoSize = true;
            this.LblRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblRequired.ForeColor = System.Drawing.Color.Red;
            this.LblRequired.Location = new System.Drawing.Point(70, 45);
            this.LblRequired.Name = "LblRequired";
            this.LblRequired.Size = new System.Drawing.Size(12, 13);
            this.LblRequired.TabIndex = 0;
            this.LblRequired.Text = "*";
            this.LblRequired.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblClassName
            // 
            this.LblClassName.AutoSize = true;
            this.LblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblClassName.Location = new System.Drawing.Point(0, 45);
            this.LblClassName.Name = "LblClassName";
            this.LblClassName.Size = new System.Drawing.Size(75, 13);
            this.LblClassName.TabIndex = 0;
            this.LblClassName.Text = "Tên lớp học";
            this.LblClassName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TpgSchoolYear
            // 
            this.TpgSchoolYear.Controls.Add(this.DgvListSchoolYear);
            this.TpgSchoolYear.Controls.Add(this.PnlSchoolYearForm);
            this.TpgSchoolYear.Location = new System.Drawing.Point(4, 22);
            this.TpgSchoolYear.Name = "TpgSchoolYear";
            this.TpgSchoolYear.Padding = new System.Windows.Forms.Padding(3);
            this.TpgSchoolYear.Size = new System.Drawing.Size(513, 279);
            this.TpgSchoolYear.TabIndex = 1;
            this.TpgSchoolYear.Text = "Năm học";
            this.TpgSchoolYear.UseVisualStyleBackColor = true;
            // 
            // DgvListSchoolYear
            // 
            this.DgvListSchoolYear.AllowUserToAddRows = false;
            this.DgvListSchoolYear.AllowUserToDeleteRows = false;
            this.DgvListSchoolYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListSchoolYear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SchoolYearName,
            this.Start_Year,
            this.End_Year,
            this.DgvColActionDeleteSchoolYear});
            this.DgvListSchoolYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListSchoolYear.Location = new System.Drawing.Point(195, 3);
            this.DgvListSchoolYear.Name = "DgvListSchoolYear";
            this.DgvListSchoolYear.ReadOnly = true;
            this.DgvListSchoolYear.Size = new System.Drawing.Size(315, 273);
            this.DgvListSchoolYear.TabIndex = 1;
            this.DgvListSchoolYear.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListSchoolYear_CellContentClick);
            this.DgvListSchoolYear.SelectionChanged += new System.EventHandler(this.DgvListSchoolYear_SelectionChanged);
            // 
            // SchoolYearName
            // 
            this.SchoolYearName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SchoolYearName.DataPropertyName = "SchoolYearName";
            this.SchoolYearName.HeaderText = "Năm học";
            this.SchoolYearName.MinimumWidth = 150;
            this.SchoolYearName.Name = "SchoolYearName";
            this.SchoolYearName.ReadOnly = true;
            // 
            // Start_Year
            // 
            this.Start_Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Start_Year.DataPropertyName = "Start_Year";
            this.Start_Year.HeaderText = "Năm bắt đầu";
            this.Start_Year.MinimumWidth = 150;
            this.Start_Year.Name = "Start_Year";
            this.Start_Year.ReadOnly = true;
            // 
            // End_Year
            // 
            this.End_Year.DataPropertyName = "End_Year";
            this.End_Year.HeaderText = "Năm kết thúc";
            this.End_Year.Name = "End_Year";
            this.End_Year.ReadOnly = true;
            // 
            // DgvColActionDeleteSchoolYear
            // 
            this.DgvColActionDeleteSchoolYear.HeaderText = "";
            this.DgvColActionDeleteSchoolYear.Name = "DgvColActionDeleteSchoolYear";
            this.DgvColActionDeleteSchoolYear.ReadOnly = true;
            this.DgvColActionDeleteSchoolYear.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvColActionDeleteSchoolYear.Text = "Xóa";
            this.DgvColActionDeleteSchoolYear.UseColumnTextForButtonValue = true;
            this.DgvColActionDeleteSchoolYear.Width = 50;
            // 
            // PnlSchoolYearForm
            // 
            this.PnlSchoolYearForm.Controls.Add(this.DtpEndYear);
            this.PnlSchoolYearForm.Controls.Add(this.DtpStartYear);
            this.PnlSchoolYearForm.Controls.Add(this.BtnTempSaveSchoolYear);
            this.PnlSchoolYearForm.Controls.Add(this.ChkStatusSchoolYear);
            this.PnlSchoolYearForm.Controls.Add(this.TbxSchoolYearName);
            this.PnlSchoolYearForm.Controls.Add(this.LblRequiredEndYear);
            this.PnlSchoolYearForm.Controls.Add(this.LblRequriedStartYear);
            this.PnlSchoolYearForm.Controls.Add(this.LblRequriedSchoolYearName);
            this.PnlSchoolYearForm.Controls.Add(this.LblEndYear);
            this.PnlSchoolYearForm.Controls.Add(this.LblStartYear);
            this.PnlSchoolYearForm.Controls.Add(this.LblSchoolYearName);
            this.PnlSchoolYearForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSchoolYearForm.Location = new System.Drawing.Point(3, 3);
            this.PnlSchoolYearForm.Name = "PnlSchoolYearForm";
            this.PnlSchoolYearForm.Size = new System.Drawing.Size(192, 273);
            this.PnlSchoolYearForm.TabIndex = 2;
            // 
            // DtpEndYear
            // 
            this.DtpEndYear.CustomFormat = "yyyy";
            this.DtpEndYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpEndYear.Location = new System.Drawing.Point(5, 65);
            this.DtpEndYear.Name = "DtpEndYear";
            this.DtpEndYear.Size = new System.Drawing.Size(65, 20);
            this.DtpEndYear.TabIndex = 3;
            this.DtpEndYear.Value = new System.DateTime(2026, 9, 30, 0, 0, 0, 0);
            this.DtpEndYear.ValueChanged += new System.EventHandler(this.DtpEndYear_ValueChanged);
            // 
            // DtpStartYear
            // 
            this.DtpStartYear.CustomFormat = "yyyy";
            this.DtpStartYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpStartYear.Location = new System.Drawing.Point(5, 20);
            this.DtpStartYear.Name = "DtpStartYear";
            this.DtpStartYear.Size = new System.Drawing.Size(65, 20);
            this.DtpStartYear.TabIndex = 3;
            this.DtpStartYear.Value = new System.DateTime(2025, 9, 30, 0, 0, 0, 0);
            this.DtpStartYear.ValueChanged += new System.EventHandler(this.DtpStartYear_ValueChanged);
            // 
            // BtnTempSaveSchoolYear
            // 
            this.BtnTempSaveSchoolYear.Location = new System.Drawing.Point(110, 165);
            this.BtnTempSaveSchoolYear.Name = "BtnTempSaveSchoolYear";
            this.BtnTempSaveSchoolYear.Size = new System.Drawing.Size(75, 23);
            this.BtnTempSaveSchoolYear.TabIndex = 0;
            this.BtnTempSaveSchoolYear.Text = "Thêm";
            this.BtnTempSaveSchoolYear.UseVisualStyleBackColor = true;
            this.BtnTempSaveSchoolYear.Click += new System.EventHandler(this.BtnTempSaveSchoolYear_Click);
            // 
            // ChkStatusSchoolYear
            // 
            this.ChkStatusSchoolYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChkStatusSchoolYear.Location = new System.Drawing.Point(5, 140);
            this.ChkStatusSchoolYear.Name = "ChkStatusSchoolYear";
            this.ChkStatusSchoolYear.Size = new System.Drawing.Size(146, 17);
            this.ChkStatusSchoolYear.TabIndex = 2;
            this.ChkStatusSchoolYear.Text = "Trạng thái hoạt động";
            this.ChkStatusSchoolYear.UseVisualStyleBackColor = true;
            // 
            // TbxSchoolYearName
            // 
            this.TbxSchoolYearName.Enabled = false;
            this.TbxSchoolYearName.Location = new System.Drawing.Point(5, 110);
            this.TbxSchoolYearName.Name = "TbxSchoolYearName";
            this.TbxSchoolYearName.Size = new System.Drawing.Size(180, 20);
            this.TbxSchoolYearName.TabIndex = 1;
            // 
            // LblRequiredEndYear
            // 
            this.LblRequiredEndYear.AutoSize = true;
            this.LblRequiredEndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblRequiredEndYear.ForeColor = System.Drawing.Color.Red;
            this.LblRequiredEndYear.Location = new System.Drawing.Point(105, 50);
            this.LblRequiredEndYear.Name = "LblRequiredEndYear";
            this.LblRequiredEndYear.Size = new System.Drawing.Size(12, 13);
            this.LblRequiredEndYear.TabIndex = 0;
            this.LblRequiredEndYear.Text = "*";
            this.LblRequiredEndYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblRequriedStartYear
            // 
            this.LblRequriedStartYear.AutoSize = true;
            this.LblRequriedStartYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblRequriedStartYear.ForeColor = System.Drawing.Color.Red;
            this.LblRequriedStartYear.Location = new System.Drawing.Point(100, 5);
            this.LblRequriedStartYear.Name = "LblRequriedStartYear";
            this.LblRequriedStartYear.Size = new System.Drawing.Size(12, 13);
            this.LblRequriedStartYear.TabIndex = 0;
            this.LblRequriedStartYear.Text = "*";
            this.LblRequriedStartYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblRequriedSchoolYearName
            // 
            this.LblRequriedSchoolYearName.AutoSize = true;
            this.LblRequriedSchoolYearName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblRequriedSchoolYearName.ForeColor = System.Drawing.Color.Red;
            this.LblRequriedSchoolYearName.Location = new System.Drawing.Point(55, 95);
            this.LblRequriedSchoolYearName.Name = "LblRequriedSchoolYearName";
            this.LblRequriedSchoolYearName.Size = new System.Drawing.Size(12, 13);
            this.LblRequriedSchoolYearName.TabIndex = 0;
            this.LblRequriedSchoolYearName.Text = "*";
            this.LblRequriedSchoolYearName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblEndYear
            // 
            this.LblEndYear.AutoSize = true;
            this.LblEndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblEndYear.Location = new System.Drawing.Point(0, 50);
            this.LblEndYear.Name = "LblEndYear";
            this.LblEndYear.Size = new System.Drawing.Size(108, 13);
            this.LblEndYear.TabIndex = 0;
            this.LblEndYear.Text = "Năm học kết thúc";
            this.LblEndYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblStartYear
            // 
            this.LblStartYear.AutoSize = true;
            this.LblStartYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblStartYear.Location = new System.Drawing.Point(0, 5);
            this.LblStartYear.Name = "LblStartYear";
            this.LblStartYear.Size = new System.Drawing.Size(105, 13);
            this.LblStartYear.TabIndex = 0;
            this.LblStartYear.Text = "Năm học bắt đầu";
            this.LblStartYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblSchoolYearName
            // 
            this.LblSchoolYearName.AutoSize = true;
            this.LblSchoolYearName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblSchoolYearName.Location = new System.Drawing.Point(0, 95);
            this.LblSchoolYearName.Name = "LblSchoolYearName";
            this.LblSchoolYearName.Size = new System.Drawing.Size(57, 13);
            this.LblSchoolYearName.TabIndex = 0;
            this.LblSchoolYearName.Text = "Năm học";
            this.LblSchoolYearName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TpgSubject
            // 
            this.TpgSubject.Controls.Add(this.DgvSubject);
            this.TpgSubject.Controls.Add(this.PnlSubjectForm);
            this.TpgSubject.Location = new System.Drawing.Point(4, 22);
            this.TpgSubject.Name = "TpgSubject";
            this.TpgSubject.Padding = new System.Windows.Forms.Padding(3);
            this.TpgSubject.Size = new System.Drawing.Size(513, 279);
            this.TpgSubject.TabIndex = 2;
            this.TpgSubject.Text = "Môn học";
            this.TpgSubject.UseVisualStyleBackColor = true;
            // 
            // DgvSubject
            // 
            this.DgvSubject.AllowUserToAddRows = false;
            this.DgvSubject.AllowUserToDeleteRows = false;
            this.DgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectId,
            this.SubjectName,
            this.SubjectCredit,
            this.SubjectDescription,
            this.DgvColSubjectAction});
            this.DgvSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSubject.Location = new System.Drawing.Point(195, 3);
            this.DgvSubject.Name = "DgvSubject";
            this.DgvSubject.ReadOnly = true;
            this.DgvSubject.Size = new System.Drawing.Size(315, 273);
            this.DgvSubject.TabIndex = 1;
            this.DgvSubject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSubject_CellContentClick);
            this.DgvSubject.SelectionChanged += new System.EventHandler(this.DgvSubject_SelectionChanged);
            // 
            // PnlSubjectForm
            // 
            this.PnlSubjectForm.Controls.Add(this.NumSubjectCredit);
            this.PnlSubjectForm.Controls.Add(this.BtnTempSaveSubject);
            this.PnlSubjectForm.Controls.Add(this.ChkSubjectStatus);
            this.PnlSubjectForm.Controls.Add(this.TbxSubjectDescription);
            this.PnlSubjectForm.Controls.Add(this.TbxSubjectId);
            this.PnlSubjectForm.Controls.Add(this.TbxSubjectName);
            this.PnlSubjectForm.Controls.Add(this.LblSubjectDescription);
            this.PnlSubjectForm.Controls.Add(this.LblRequiredSubjectCredit);
            this.PnlSubjectForm.Controls.Add(this.LblRequiredSubjectId);
            this.PnlSubjectForm.Controls.Add(this.LblSubjectCredit);
            this.PnlSubjectForm.Controls.Add(this.LblSubjectId);
            this.PnlSubjectForm.Controls.Add(this.LblRequired1);
            this.PnlSubjectForm.Controls.Add(this.LblSubjectName);
            this.PnlSubjectForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSubjectForm.Location = new System.Drawing.Point(3, 3);
            this.PnlSubjectForm.Name = "PnlSubjectForm";
            this.PnlSubjectForm.Size = new System.Drawing.Size(192, 273);
            this.PnlSubjectForm.TabIndex = 2;
            // 
            // NumSubjectCredit
            // 
            this.NumSubjectCredit.Location = new System.Drawing.Point(6, 108);
            this.NumSubjectCredit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumSubjectCredit.Name = "NumSubjectCredit";
            this.NumSubjectCredit.Size = new System.Drawing.Size(180, 20);
            this.NumSubjectCredit.TabIndex = 3;
            this.NumSubjectCredit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnTempSaveSubject
            // 
            this.BtnTempSaveSubject.Location = new System.Drawing.Point(111, 243);
            this.BtnTempSaveSubject.Name = "BtnTempSaveSubject";
            this.BtnTempSaveSubject.Size = new System.Drawing.Size(75, 23);
            this.BtnTempSaveSubject.TabIndex = 0;
            this.BtnTempSaveSubject.Text = "Thêm";
            this.BtnTempSaveSubject.UseVisualStyleBackColor = true;
            this.BtnTempSaveSubject.Click += new System.EventHandler(this.BtnTempSaveSubject_Click);
            // 
            // ChkSubjectStatus
            // 
            this.ChkSubjectStatus.AutoSize = true;
            this.ChkSubjectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChkSubjectStatus.Location = new System.Drawing.Point(6, 218);
            this.ChkSubjectStatus.Name = "ChkSubjectStatus";
            this.ChkSubjectStatus.Size = new System.Drawing.Size(146, 17);
            this.ChkSubjectStatus.TabIndex = 2;
            this.ChkSubjectStatus.Text = "Trạng thái hoạt động";
            this.ChkSubjectStatus.UseVisualStyleBackColor = true;
            // 
            // TbxSubjectDescription
            // 
            this.TbxSubjectDescription.AcceptsReturn = true;
            this.TbxSubjectDescription.Location = new System.Drawing.Point(6, 153);
            this.TbxSubjectDescription.Multiline = true;
            this.TbxSubjectDescription.Name = "TbxSubjectDescription";
            this.TbxSubjectDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbxSubjectDescription.Size = new System.Drawing.Size(180, 60);
            this.TbxSubjectDescription.TabIndex = 1;
            // 
            // TbxSubjectName
            // 
            this.TbxSubjectName.Location = new System.Drawing.Point(6, 63);
            this.TbxSubjectName.Name = "TbxSubjectName";
            this.TbxSubjectName.Size = new System.Drawing.Size(180, 20);
            this.TbxSubjectName.TabIndex = 1;
            // 
            // LblSubjectDescription
            // 
            this.LblSubjectDescription.AutoSize = true;
            this.LblSubjectDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblSubjectDescription.Location = new System.Drawing.Point(1, 138);
            this.LblSubjectDescription.Name = "LblSubjectDescription";
            this.LblSubjectDescription.Size = new System.Drawing.Size(39, 13);
            this.LblSubjectDescription.TabIndex = 0;
            this.LblSubjectDescription.Text = "Mô tả";
            this.LblSubjectDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblRequiredSubjectCredit
            // 
            this.LblRequiredSubjectCredit.AutoSize = true;
            this.LblRequiredSubjectCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblRequiredSubjectCredit.ForeColor = System.Drawing.Color.Red;
            this.LblRequiredSubjectCredit.Location = new System.Drawing.Point(66, 93);
            this.LblRequiredSubjectCredit.Name = "LblRequiredSubjectCredit";
            this.LblRequiredSubjectCredit.Size = new System.Drawing.Size(12, 13);
            this.LblRequiredSubjectCredit.TabIndex = 0;
            this.LblRequiredSubjectCredit.Text = "*";
            this.LblRequiredSubjectCredit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblSubjectCredit
            // 
            this.LblSubjectCredit.AutoSize = true;
            this.LblSubjectCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblSubjectCredit.Location = new System.Drawing.Point(1, 93);
            this.LblSubjectCredit.Name = "LblSubjectCredit";
            this.LblSubjectCredit.Size = new System.Drawing.Size(63, 13);
            this.LblSubjectCredit.TabIndex = 0;
            this.LblSubjectCredit.Text = "Số tín chỉ";
            this.LblSubjectCredit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblRequired1
            // 
            this.LblRequired1.AutoSize = true;
            this.LblRequired1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblRequired1.ForeColor = System.Drawing.Color.Red;
            this.LblRequired1.Location = new System.Drawing.Point(81, 48);
            this.LblRequired1.Name = "LblRequired1";
            this.LblRequired1.Size = new System.Drawing.Size(12, 13);
            this.LblRequired1.TabIndex = 0;
            this.LblRequired1.Text = "*";
            this.LblRequired1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblSubjectName
            // 
            this.LblSubjectName.AutoSize = true;
            this.LblSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblSubjectName.Location = new System.Drawing.Point(1, 48);
            this.LblSubjectName.Name = "LblSubjectName";
            this.LblSubjectName.Size = new System.Drawing.Size(81, 13);
            this.LblSubjectName.TabIndex = 0;
            this.LblSubjectName.Text = "Tên môn học";
            this.LblSubjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DgvColSchoolYearId
            // 
            this.DgvColSchoolYearId.Name = "DgvColSchoolYearId";
            // 
            // SubjectId
            // 
            this.SubjectId.DataPropertyName = "SubjectId";
            this.SubjectId.HeaderText = "Mã môn học";
            this.SubjectId.Name = "SubjectId";
            this.SubjectId.ReadOnly = true;
            // 
            // SubjectName
            // 
            this.SubjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Tên Môn học";
            this.SubjectName.MinimumWidth = 150;
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // SubjectCredit
            // 
            this.SubjectCredit.DataPropertyName = "Credits";
            this.SubjectCredit.HeaderText = "Số tín chỉ";
            this.SubjectCredit.Name = "SubjectCredit";
            this.SubjectCredit.ReadOnly = true;
            // 
            // SubjectDescription
            // 
            this.SubjectDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectDescription.DataPropertyName = "Description";
            this.SubjectDescription.HeaderText = "Mô tả";
            this.SubjectDescription.MinimumWidth = 150;
            this.SubjectDescription.Name = "SubjectDescription";
            this.SubjectDescription.ReadOnly = true;
            // 
            // DgvColSubjectAction
            // 
            this.DgvColSubjectAction.HeaderText = "";
            this.DgvColSubjectAction.Name = "DgvColSubjectAction";
            this.DgvColSubjectAction.ReadOnly = true;
            this.DgvColSubjectAction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvColSubjectAction.Text = "Xóa";
            this.DgvColSubjectAction.UseColumnTextForButtonValue = true;
            this.DgvColSubjectAction.Width = 50;
            // 
            // LblSubjectId
            // 
            this.LblSubjectId.AutoSize = true;
            this.LblSubjectId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblSubjectId.Location = new System.Drawing.Point(3, 7);
            this.LblSubjectId.Name = "LblSubjectId";
            this.LblSubjectId.Size = new System.Drawing.Size(76, 13);
            this.LblSubjectId.TabIndex = 0;
            this.LblSubjectId.Text = "Mã môn học";
            this.LblSubjectId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblRequiredSubjectId
            // 
            this.LblRequiredSubjectId.AutoSize = true;
            this.LblRequiredSubjectId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblRequiredSubjectId.ForeColor = System.Drawing.Color.Red;
            this.LblRequiredSubjectId.Location = new System.Drawing.Point(81, 7);
            this.LblRequiredSubjectId.Name = "LblRequiredSubjectId";
            this.LblRequiredSubjectId.Size = new System.Drawing.Size(12, 13);
            this.LblRequiredSubjectId.TabIndex = 0;
            this.LblRequiredSubjectId.Text = "*";
            this.LblRequiredSubjectId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbxSubjectId
            // 
            this.TbxSubjectId.Location = new System.Drawing.Point(6, 23);
            this.TbxSubjectId.Name = "TbxSubjectId";
            this.TbxSubjectId.Size = new System.Drawing.Size(180, 20);
            this.TbxSubjectId.TabIndex = 1;
            // 
            // UcTrainingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PnlFooter);
            this.Name = "UcTrainingInfo";
            this.Size = new System.Drawing.Size(521, 337);
            this.PnlFooter.ResumeLayout(false);
            this.PnlMain.ResumeLayout(false);
            this.TabTraingInfo.ResumeLayout(false);
            this.TpgClass.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListClass)).EndInit();
            this.PnlClassForm.ResumeLayout(false);
            this.PnlClassForm.PerformLayout();
            this.TpgSchoolYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListSchoolYear)).EndInit();
            this.PnlSchoolYearForm.ResumeLayout(false);
            this.PnlSchoolYearForm.PerformLayout();
            this.TpgSubject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSubject)).EndInit();
            this.PnlSubjectForm.ResumeLayout(false);
            this.PnlSubjectForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumSubjectCredit)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PnlFooter;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.Panel PnlMain;
		private System.Windows.Forms.TabControl TabTraingInfo;
		private System.Windows.Forms.TabPage TpgClass;
		private System.Windows.Forms.TabPage TpgSchoolYear;
		private System.Windows.Forms.TabPage TpgSubject;
		private System.Windows.Forms.Panel PnlClassForm;
		private System.Windows.Forms.Label LblClassName;
		private System.Windows.Forms.TextBox TbxDescriptionClass;
		private System.Windows.Forms.TextBox TbxClassName;
		private System.Windows.Forms.Label LblDescription;
		private System.Windows.Forms.Label LblRequired;
		private System.Windows.Forms.CheckBox ChkStatusClass;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView DgvListClass;
		private System.Windows.Forms.Button BtnTempSaveClass;
		private System.Windows.Forms.DataGridView DgvListSchoolYear;
		private System.Windows.Forms.Panel PnlSchoolYearForm;
		private System.Windows.Forms.Button BtnTempSaveSchoolYear;
		private System.Windows.Forms.CheckBox ChkStatusSchoolYear;
		private System.Windows.Forms.TextBox TbxSchoolYearName;
		private System.Windows.Forms.Label LblRequriedSchoolYearName;
		private System.Windows.Forms.Label LblSchoolYearName;
		private System.Windows.Forms.DataGridView DgvSubject;
		private System.Windows.Forms.Panel PnlSubjectForm;
		private System.Windows.Forms.Button BtnTempSaveSubject;
		private System.Windows.Forms.CheckBox ChkSubjectStatus;
		private System.Windows.Forms.TextBox TbxSubjectDescription;
		private System.Windows.Forms.TextBox TbxSubjectName;
		private System.Windows.Forms.Label LblSubjectDescription;
		private System.Windows.Forms.Label LblRequired1;
		private System.Windows.Forms.Label LblSubjectName;
		private System.Windows.Forms.Label LblRequriedStartYear;
		private System.Windows.Forms.Label LblStartYear;
		private System.Windows.Forms.Label LblRequiredEndYear;
		private System.Windows.Forms.Label LblEndYear;
		private System.Windows.Forms.DateTimePicker DtpEndYear;
		private System.Windows.Forms.DateTimePicker DtpStartYear;
		private System.Windows.Forms.DataGridViewTextBoxColumn DgvColSchoolYearId;
		private System.Windows.Forms.NumericUpDown NumSubjectCredit;
		private System.Windows.Forms.Label LblRequiredSubjectCredit;
		private System.Windows.Forms.Label LblSubjectCredit;
		private System.Windows.Forms.TextBox TbxClassId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewButtonColumn DgvColActionDelete;
		private System.Windows.Forms.DataGridViewTextBoxColumn SchoolYearName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Start_Year;
		private System.Windows.Forms.DataGridViewTextBoxColumn End_Year;
		private System.Windows.Forms.DataGridViewButtonColumn DgvColActionDeleteSchoolYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectDescription;
        private System.Windows.Forms.DataGridViewButtonColumn DgvColSubjectAction;
        private System.Windows.Forms.TextBox TbxSubjectId;
        private System.Windows.Forms.Label LblRequiredSubjectId;
        private System.Windows.Forms.Label LblSubjectId;
    }
}
