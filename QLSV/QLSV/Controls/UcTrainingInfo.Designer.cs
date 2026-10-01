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
			this.DgvColClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DgvColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DgvColActionDelete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.PnlClassForm = new System.Windows.Forms.Panel();
			this.BtnTempSaveClass = new System.Windows.Forms.Button();
			this.ChkStatusClass = new System.Windows.Forms.CheckBox();
			this.TxtDescriptionClass = new System.Windows.Forms.TextBox();
			this.TxtClassName = new System.Windows.Forms.TextBox();
			this.LblDescription = new System.Windows.Forms.Label();
			this.LblRequired = new System.Windows.Forms.Label();
			this.LblClassName = new System.Windows.Forms.Label();
			this.TpgSchoolYear = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.DgvColSchoolYearName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DgvColStartYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DgvColEndYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DgvColActionDeleteSchoolYear = new System.Windows.Forms.DataGridViewButtonColumn();
			this.PnlSchoolYearForm = new System.Windows.Forms.Panel();
			this.DtpEndYear = new System.Windows.Forms.DateTimePicker();
			this.DtpStartYear = new System.Windows.Forms.DateTimePicker();
			this.BtnTempSaveSchoolYear = new System.Windows.Forms.Button();
			this.ChkStatusSchoolYear = new System.Windows.Forms.CheckBox();
			this.TxtSchoolYearName = new System.Windows.Forms.TextBox();
			this.LblRequiredEndYear = new System.Windows.Forms.Label();
			this.LblRequriedStartYear = new System.Windows.Forms.Label();
			this.LblRequriedSchoolYearName = new System.Windows.Forms.Label();
			this.LblEndYear = new System.Windows.Forms.Label();
			this.LblStartYear = new System.Windows.Forms.Label();
			this.LblSchoolYearName = new System.Windows.Forms.Label();
			this.TpgSubject = new System.Windows.Forms.TabPage();
			this.DgvSubject = new System.Windows.Forms.DataGridView();
			this.DgvColSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DgvColSubjectCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DgvColSubjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DgvColSubjectAction = new System.Windows.Forms.DataGridViewButtonColumn();
			this.PnlSubjectForm = new System.Windows.Forms.Panel();
			this.NumSubjectCredit = new System.Windows.Forms.NumericUpDown();
			this.BtnTempSaveSubject = new System.Windows.Forms.Button();
			this.ChkSubjectStatus = new System.Windows.Forms.CheckBox();
			this.TxtSubjectDescription = new System.Windows.Forms.TextBox();
			this.TxtSubjectName = new System.Windows.Forms.TextBox();
			this.LblSubjectDescription = new System.Windows.Forms.Label();
			this.LblRequiredSubjectCredit = new System.Windows.Forms.Label();
			this.LblSubjectCredit = new System.Windows.Forms.Label();
			this.LblRequired1 = new System.Windows.Forms.Label();
			this.LblSubjectName = new System.Windows.Forms.Label();
			this.PnlFooter.SuspendLayout();
			this.PnlMain.SuspendLayout();
			this.TabTraingInfo.SuspendLayout();
			this.TpgClass.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvListClass)).BeginInit();
			this.PnlClassForm.SuspendLayout();
			this.TpgSchoolYear.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.DgvColClassName,
            this.DgvColDescription,
            this.DgvColActionDelete});
			this.DgvListClass.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DgvListClass.Location = new System.Drawing.Point(0, 0);
			this.DgvListClass.Name = "DgvListClass";
			this.DgvListClass.ReadOnly = true;
			this.DgvListClass.Size = new System.Drawing.Size(315, 273);
			this.DgvListClass.TabIndex = 0;
			// 
			// DgvColClassName
			// 
			this.DgvColClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DgvColClassName.HeaderText = "Tên lớp";
			this.DgvColClassName.MinimumWidth = 150;
			this.DgvColClassName.Name = "DgvColClassName";
			this.DgvColClassName.ReadOnly = true;
			// 
			// DgvColDescription
			// 
			this.DgvColDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DgvColDescription.HeaderText = "Mô tả";
			this.DgvColDescription.MinimumWidth = 150;
			this.DgvColDescription.Name = "DgvColDescription";
			this.DgvColDescription.ReadOnly = true;
			// 
			// DgvColActionDelete
			// 
			this.DgvColActionDelete.HeaderText = "";
			this.DgvColActionDelete.Name = "DgvColActionDelete";
			this.DgvColActionDelete.ReadOnly = true;
			this.DgvColActionDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.DgvColActionDelete.Width = 50;
			// 
			// PnlClassForm
			// 
			this.PnlClassForm.Controls.Add(this.BtnTempSaveClass);
			this.PnlClassForm.Controls.Add(this.ChkStatusClass);
			this.PnlClassForm.Controls.Add(this.TxtDescriptionClass);
			this.PnlClassForm.Controls.Add(this.TxtClassName);
			this.PnlClassForm.Controls.Add(this.LblDescription);
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
			this.BtnTempSaveClass.Location = new System.Drawing.Point(110, 120);
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
			this.ChkStatusClass.Location = new System.Drawing.Point(5, 95);
			this.ChkStatusClass.Name = "ChkStatusClass";
			this.ChkStatusClass.Size = new System.Drawing.Size(146, 17);
			this.ChkStatusClass.TabIndex = 2;
			this.ChkStatusClass.Text = "Trạng thái hoạt động";
			this.ChkStatusClass.UseVisualStyleBackColor = true;
			// 
			// TxtDescriptionClass
			// 
			this.TxtDescriptionClass.Location = new System.Drawing.Point(5, 65);
			this.TxtDescriptionClass.Name = "TxtDescriptionClass";
			this.TxtDescriptionClass.Size = new System.Drawing.Size(180, 20);
			this.TxtDescriptionClass.TabIndex = 1;
			// 
			// TxtClassName
			// 
			this.TxtClassName.Location = new System.Drawing.Point(5, 20);
			this.TxtClassName.Name = "TxtClassName";
			this.TxtClassName.Size = new System.Drawing.Size(180, 20);
			this.TxtClassName.TabIndex = 1;
			// 
			// LblDescription
			// 
			this.LblDescription.AutoSize = true;
			this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.LblDescription.Location = new System.Drawing.Point(0, 50);
			this.LblDescription.Name = "LblDescription";
			this.LblDescription.Size = new System.Drawing.Size(39, 13);
			this.LblDescription.TabIndex = 0;
			this.LblDescription.Text = "Mô tả";
			this.LblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblRequired
			// 
			this.LblRequired.AutoSize = true;
			this.LblRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.LblRequired.ForeColor = System.Drawing.Color.Red;
			this.LblRequired.Location = new System.Drawing.Point(70, 5);
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
			this.LblClassName.Location = new System.Drawing.Point(0, 5);
			this.LblClassName.Name = "LblClassName";
			this.LblClassName.Size = new System.Drawing.Size(75, 13);
			this.LblClassName.TabIndex = 0;
			this.LblClassName.Text = "Tên lớp học";
			this.LblClassName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TpgSchoolYear
			// 
			this.TpgSchoolYear.Controls.Add(this.dataGridView1);
			this.TpgSchoolYear.Controls.Add(this.PnlSchoolYearForm);
			this.TpgSchoolYear.Location = new System.Drawing.Point(4, 22);
			this.TpgSchoolYear.Name = "TpgSchoolYear";
			this.TpgSchoolYear.Padding = new System.Windows.Forms.Padding(3);
			this.TpgSchoolYear.Size = new System.Drawing.Size(513, 279);
			this.TpgSchoolYear.TabIndex = 1;
			this.TpgSchoolYear.Text = "Năm học";
			this.TpgSchoolYear.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvColSchoolYearName,
            this.DgvColStartYear,
            this.DgvColEndYear,
            this.DgvColActionDeleteSchoolYear});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(195, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(315, 273);
			this.dataGridView1.TabIndex = 1;
			// 
			// DgvColSchoolYearName
			// 
			this.DgvColSchoolYearName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DgvColSchoolYearName.HeaderText = "Năm học";
			this.DgvColSchoolYearName.MinimumWidth = 150;
			this.DgvColSchoolYearName.Name = "DgvColSchoolYearName";
			this.DgvColSchoolYearName.ReadOnly = true;
			// 
			// DgvColStartYear
			// 
			this.DgvColStartYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DgvColStartYear.HeaderText = "Năm bắt đầu";
			this.DgvColStartYear.MinimumWidth = 150;
			this.DgvColStartYear.Name = "DgvColStartYear";
			this.DgvColStartYear.ReadOnly = true;
			// 
			// DgvColEndYear
			// 
			this.DgvColEndYear.HeaderText = "Năm kết thúc";
			this.DgvColEndYear.Name = "DgvColEndYear";
			this.DgvColEndYear.ReadOnly = true;
			// 
			// DgvColActionDeleteSchoolYear
			// 
			this.DgvColActionDeleteSchoolYear.HeaderText = "";
			this.DgvColActionDeleteSchoolYear.Name = "DgvColActionDeleteSchoolYear";
			this.DgvColActionDeleteSchoolYear.ReadOnly = true;
			this.DgvColActionDeleteSchoolYear.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.DgvColActionDeleteSchoolYear.Width = 50;
			// 
			// PnlSchoolYearForm
			// 
			this.PnlSchoolYearForm.Controls.Add(this.DtpEndYear);
			this.PnlSchoolYearForm.Controls.Add(this.DtpStartYear);
			this.PnlSchoolYearForm.Controls.Add(this.BtnTempSaveSchoolYear);
			this.PnlSchoolYearForm.Controls.Add(this.ChkStatusSchoolYear);
			this.PnlSchoolYearForm.Controls.Add(this.TxtSchoolYearName);
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
			// TxtSchoolYearName
			// 
			this.TxtSchoolYearName.Enabled = false;
			this.TxtSchoolYearName.Location = new System.Drawing.Point(5, 110);
			this.TxtSchoolYearName.Name = "TxtSchoolYearName";
			this.TxtSchoolYearName.Size = new System.Drawing.Size(180, 20);
			this.TxtSchoolYearName.TabIndex = 1;
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
            this.DgvColSubjectName,
            this.DgvColSubjectCredit,
            this.DgvColSubjectDescription,
            this.DgvColSubjectAction});
			this.DgvSubject.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DgvSubject.Location = new System.Drawing.Point(195, 3);
			this.DgvSubject.Name = "DgvSubject";
			this.DgvSubject.ReadOnly = true;
			this.DgvSubject.Size = new System.Drawing.Size(315, 273);
			this.DgvSubject.TabIndex = 1;
			// 
			// DgvColSubjectName
			// 
			this.DgvColSubjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DgvColSubjectName.HeaderText = "Tên Môn học";
			this.DgvColSubjectName.MinimumWidth = 150;
			this.DgvColSubjectName.Name = "DgvColSubjectName";
			this.DgvColSubjectName.ReadOnly = true;
			// 
			// DgvColSubjectCredit
			// 
			this.DgvColSubjectCredit.HeaderText = "Số tín chỉ";
			this.DgvColSubjectCredit.Name = "DgvColSubjectCredit";
			this.DgvColSubjectCredit.ReadOnly = true;
			// 
			// DgvColSubjectDescription
			// 
			this.DgvColSubjectDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DgvColSubjectDescription.HeaderText = "Mô tả";
			this.DgvColSubjectDescription.MinimumWidth = 150;
			this.DgvColSubjectDescription.Name = "DgvColSubjectDescription";
			this.DgvColSubjectDescription.ReadOnly = true;
			// 
			// DgvColSubjectAction
			// 
			this.DgvColSubjectAction.HeaderText = "";
			this.DgvColSubjectAction.Name = "DgvColSubjectAction";
			this.DgvColSubjectAction.ReadOnly = true;
			this.DgvColSubjectAction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.DgvColSubjectAction.Width = 50;
			// 
			// PnlSubjectForm
			// 
			this.PnlSubjectForm.Controls.Add(this.NumSubjectCredit);
			this.PnlSubjectForm.Controls.Add(this.BtnTempSaveSubject);
			this.PnlSubjectForm.Controls.Add(this.ChkSubjectStatus);
			this.PnlSubjectForm.Controls.Add(this.TxtSubjectDescription);
			this.PnlSubjectForm.Controls.Add(this.TxtSubjectName);
			this.PnlSubjectForm.Controls.Add(this.LblSubjectDescription);
			this.PnlSubjectForm.Controls.Add(this.LblRequiredSubjectCredit);
			this.PnlSubjectForm.Controls.Add(this.LblSubjectCredit);
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
			this.NumSubjectCredit.Location = new System.Drawing.Point(5, 65);
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
			this.BtnTempSaveSubject.Location = new System.Drawing.Point(110, 200);
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
			this.ChkSubjectStatus.Location = new System.Drawing.Point(5, 175);
			this.ChkSubjectStatus.Name = "ChkSubjectStatus";
			this.ChkSubjectStatus.Size = new System.Drawing.Size(146, 17);
			this.ChkSubjectStatus.TabIndex = 2;
			this.ChkSubjectStatus.Text = "Trạng thái hoạt động";
			this.ChkSubjectStatus.UseVisualStyleBackColor = true;
			// 
			// TxtSubjectDescription
			// 
			this.TxtSubjectDescription.AcceptsReturn = true;
			this.TxtSubjectDescription.Location = new System.Drawing.Point(5, 110);
			this.TxtSubjectDescription.Multiline = true;
			this.TxtSubjectDescription.Name = "TxtSubjectDescription";
			this.TxtSubjectDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TxtSubjectDescription.Size = new System.Drawing.Size(180, 60);
			this.TxtSubjectDescription.TabIndex = 1;
			// 
			// TxtSubjectName
			// 
			this.TxtSubjectName.Location = new System.Drawing.Point(5, 20);
			this.TxtSubjectName.Name = "TxtSubjectName";
			this.TxtSubjectName.Size = new System.Drawing.Size(180, 20);
			this.TxtSubjectName.TabIndex = 1;
			// 
			// LblSubjectDescription
			// 
			this.LblSubjectDescription.AutoSize = true;
			this.LblSubjectDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.LblSubjectDescription.Location = new System.Drawing.Point(0, 95);
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
			this.LblRequiredSubjectCredit.Location = new System.Drawing.Point(65, 50);
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
			this.LblSubjectCredit.Location = new System.Drawing.Point(0, 50);
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
			this.LblRequired1.Location = new System.Drawing.Point(80, 5);
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
			this.LblSubjectName.Location = new System.Drawing.Point(0, 5);
			this.LblSubjectName.Name = "LblSubjectName";
			this.LblSubjectName.Size = new System.Drawing.Size(81, 13);
			this.LblSubjectName.TabIndex = 0;
			this.LblSubjectName.Text = "Tên môn học";
			this.LblSubjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
		private System.Windows.Forms.TextBox TxtDescriptionClass;
		private System.Windows.Forms.TextBox TxtClassName;
		private System.Windows.Forms.Label LblDescription;
		private System.Windows.Forms.Label LblRequired;
		private System.Windows.Forms.CheckBox ChkStatusClass;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView DgvListClass;
		private System.Windows.Forms.DataGridViewTextBoxColumn DgvColClassName;
		private System.Windows.Forms.DataGridViewTextBoxColumn DgvColDescription;
		private System.Windows.Forms.DataGridViewButtonColumn DgvColActionDelete;
		private System.Windows.Forms.Button BtnTempSaveClass;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel PnlSchoolYearForm;
		private System.Windows.Forms.Button BtnTempSaveSchoolYear;
		private System.Windows.Forms.CheckBox ChkStatusSchoolYear;
		private System.Windows.Forms.TextBox TxtSchoolYearName;
		private System.Windows.Forms.Label LblRequriedSchoolYearName;
		private System.Windows.Forms.Label LblSchoolYearName;
		private System.Windows.Forms.DataGridView DgvSubject;
		private System.Windows.Forms.Panel PnlSubjectForm;
		private System.Windows.Forms.Button BtnTempSaveSubject;
		private System.Windows.Forms.CheckBox ChkSubjectStatus;
		private System.Windows.Forms.TextBox TxtSubjectDescription;
		private System.Windows.Forms.TextBox TxtSubjectName;
		private System.Windows.Forms.Label LblSubjectDescription;
		private System.Windows.Forms.Label LblRequired1;
		private System.Windows.Forms.Label LblSubjectName;
		private System.Windows.Forms.Label LblRequriedStartYear;
		private System.Windows.Forms.Label LblStartYear;
		private System.Windows.Forms.Label LblRequiredEndYear;
		private System.Windows.Forms.Label LblEndYear;
		private System.Windows.Forms.DateTimePicker DtpEndYear;
		private System.Windows.Forms.DateTimePicker DtpStartYear;
		private System.Windows.Forms.DataGridViewTextBoxColumn DgvColSchoolYearName;
		private System.Windows.Forms.DataGridViewTextBoxColumn DgvColStartYear;
		private System.Windows.Forms.DataGridViewTextBoxColumn DgvColEndYear;
		private System.Windows.Forms.DataGridViewButtonColumn DgvColActionDeleteSchoolYear;
		private System.Windows.Forms.NumericUpDown NumSubjectCredit;
		private System.Windows.Forms.Label LblRequiredSubjectCredit;
		private System.Windows.Forms.Label LblSubjectCredit;
		private System.Windows.Forms.DataGridViewTextBoxColumn DgvColSubjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn DgvColSubjectCredit;
		private System.Windows.Forms.DataGridViewTextBoxColumn DgvColSubjectDescription;
		private System.Windows.Forms.DataGridViewButtonColumn DgvColSubjectAction;
	}
}
