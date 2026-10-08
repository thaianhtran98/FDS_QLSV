namespace QuanLySV.Controls
{
	partial class UcStudentList
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
			this.DgvStudentList = new System.Windows.Forms.DataGridView();
			this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BirthOfDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VneId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DgvColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.DgvColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.PnlFilter = new System.Windows.Forms.Panel();
			this.LblNotification = new System.Windows.Forms.Label();
			this.CbxSex = new System.Windows.Forms.ComboBox();
			this.TbxNameFilter = new System.Windows.Forms.TextBox();
			this.LblSex = new System.Windows.Forms.Label();
			this.LblNameFilter = new System.Windows.Forms.Label();
			this.PnlStudentList = new System.Windows.Forms.Panel();
			this.BtnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DgvStudentList)).BeginInit();
			this.PnlFilter.SuspendLayout();
			this.PnlStudentList.SuspendLayout();
			this.SuspendLayout();
			// 
			// DgvStudentList
			// 
			this.DgvStudentList.AllowUserToAddRows = false;
			this.DgvStudentList.AllowUserToDeleteRows = false;
			this.DgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.Sex,
            this.BirthOfDate,
            this.VneId,
            this.DgvColEdit,
            this.DgvColDelete});
			this.DgvStudentList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DgvStudentList.Location = new System.Drawing.Point(0, 0);
			this.DgvStudentList.Name = "DgvStudentList";
			this.DgvStudentList.ReadOnly = true;
			this.DgvStudentList.Size = new System.Drawing.Size(1053, 369);
			this.DgvStudentList.TabIndex = 0;
			this.DgvStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStudentList_CellContentClick);
			this.DgvStudentList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvStudentList_CellFormatting);
			this.DgvStudentList.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DgvStudentList_RowPrePaint);
			// 
			// StudentId
			// 
			this.StudentId.DataPropertyName = "StudentId";
			this.StudentId.FillWeight = 47.71573F;
			this.StudentId.HeaderText = "MSSV";
			this.StudentId.MinimumWidth = 100;
			this.StudentId.Name = "StudentId";
			this.StudentId.ReadOnly = true;
			// 
			// StudentName
			// 
			this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.StudentName.DataPropertyName = "Name";
			this.StudentName.FillWeight = 152.2843F;
			this.StudentName.HeaderText = "Họ Tên";
			this.StudentName.MinimumWidth = 150;
			this.StudentName.Name = "StudentName";
			this.StudentName.ReadOnly = true;
			// 
			// Sex
			// 
			this.Sex.DataPropertyName = "Sex";
			this.Sex.HeaderText = "Giới tính";
			this.Sex.Name = "Sex";
			this.Sex.ReadOnly = true;
			// 
			// BirthOfDate
			// 
			this.BirthOfDate.DataPropertyName = "BirthOfDate";
			this.BirthOfDate.HeaderText = "Ngày sinh";
			this.BirthOfDate.MinimumWidth = 200;
			this.BirthOfDate.Name = "BirthOfDate";
			this.BirthOfDate.ReadOnly = true;
			this.BirthOfDate.Width = 200;
			// 
			// VneId
			// 
			this.VneId.DataPropertyName = "VneId";
			this.VneId.HeaderText = "CCCD";
			this.VneId.MinimumWidth = 200;
			this.VneId.Name = "VneId";
			this.VneId.ReadOnly = true;
			this.VneId.Width = 200;
			// 
			// DgvColEdit
			// 
			this.DgvColEdit.HeaderText = "Sửa";
			this.DgvColEdit.Name = "DgvColEdit";
			this.DgvColEdit.ReadOnly = true;
			this.DgvColEdit.Text = "Sửa";
			this.DgvColEdit.UseColumnTextForButtonValue = true;
			this.DgvColEdit.Width = 50;
			// 
			// DgvColDelete
			// 
			this.DgvColDelete.HeaderText = "Xóa";
			this.DgvColDelete.Name = "DgvColDelete";
			this.DgvColDelete.ReadOnly = true;
			this.DgvColDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.DgvColDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.DgvColDelete.Text = "Xóa";
			this.DgvColDelete.UseColumnTextForButtonValue = true;
			this.DgvColDelete.Width = 50;
			// 
			// PnlFilter
			// 
			this.PnlFilter.Controls.Add(this.BtnSave);
			this.PnlFilter.Controls.Add(this.LblNotification);
			this.PnlFilter.Controls.Add(this.CbxSex);
			this.PnlFilter.Controls.Add(this.TbxNameFilter);
			this.PnlFilter.Controls.Add(this.LblSex);
			this.PnlFilter.Controls.Add(this.LblNameFilter);
			this.PnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlFilter.Location = new System.Drawing.Point(0, 0);
			this.PnlFilter.Name = "PnlFilter";
			this.PnlFilter.Size = new System.Drawing.Size(1053, 40);
			this.PnlFilter.TabIndex = 0;
			// 
			// LblNotification
			// 
			this.LblNotification.AutoSize = true;
			this.LblNotification.Location = new System.Drawing.Point(420, 10);
			this.LblNotification.Name = "LblNotification";
			this.LblNotification.Size = new System.Drawing.Size(0, 13);
			this.LblNotification.TabIndex = 3;
			// 
			// CbxSex
			// 
			this.CbxSex.FormattingEnabled = true;
			this.CbxSex.Location = new System.Drawing.Point(205, 5);
			this.CbxSex.Name = "CbxSex";
			this.CbxSex.Size = new System.Drawing.Size(121, 21);
			this.CbxSex.TabIndex = 2;
			this.CbxSex.SelectedIndexChanged += new System.EventHandler(this.CbxSex_SelectedIndexChanged_1);
			// 
			// TbxNameFilter
			// 
			this.TbxNameFilter.Location = new System.Drawing.Point(25, 5);
			this.TbxNameFilter.Name = "TbxNameFilter";
			this.TbxNameFilter.Size = new System.Drawing.Size(100, 20);
			this.TbxNameFilter.TabIndex = 1;
			this.TbxNameFilter.TextChanged += new System.EventHandler(this.TbxNameFilter_TextChanged);
			// 
			// LblSex
			// 
			this.LblSex.AutoSize = true;
			this.LblSex.Location = new System.Drawing.Point(155, 10);
			this.LblSex.Name = "LblSex";
			this.LblSex.Size = new System.Drawing.Size(47, 13);
			this.LblSex.TabIndex = 0;
			this.LblSex.Text = "Giới tính";
			// 
			// LblNameFilter
			// 
			this.LblNameFilter.AutoSize = true;
			this.LblNameFilter.Location = new System.Drawing.Point(0, 10);
			this.LblNameFilter.Name = "LblNameFilter";
			this.LblNameFilter.Size = new System.Drawing.Size(26, 13);
			this.LblNameFilter.TabIndex = 0;
			this.LblNameFilter.Text = "Tên";
			// 
			// PnlStudentList
			// 
			this.PnlStudentList.Controls.Add(this.DgvStudentList);
			this.PnlStudentList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlStudentList.Location = new System.Drawing.Point(0, 40);
			this.PnlStudentList.Name = "PnlStudentList";
			this.PnlStudentList.Size = new System.Drawing.Size(1053, 369);
			this.PnlStudentList.TabIndex = 1;
			// 
			// BtnSave
			// 
			this.BtnSave.Location = new System.Drawing.Point(335, 5);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(75, 23);
			this.BtnSave.TabIndex = 4;
			this.BtnSave.Text = "Lưu";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Visible = false;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// UcStudentList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.PnlStudentList);
			this.Controls.Add(this.PnlFilter);
			this.Name = "UcStudentList";
			this.Size = new System.Drawing.Size(1053, 409);
			((System.ComponentModel.ISupportInitialize)(this.DgvStudentList)).EndInit();
			this.PnlFilter.ResumeLayout(false);
			this.PnlFilter.PerformLayout();
			this.PnlStudentList.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PnlFilter;
		private System.Windows.Forms.ComboBox CbxSex;
		private System.Windows.Forms.TextBox TbxNameFilter;
		private System.Windows.Forms.Label LblSex;
		private System.Windows.Forms.Label LblNameFilter;
		private System.Windows.Forms.Panel PnlStudentList;
		private System.Windows.Forms.DataGridView DgvStudentList;
		private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
		private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
		private System.Windows.Forms.DataGridViewTextBoxColumn BirthOfDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn VneId;
		private System.Windows.Forms.DataGridViewButtonColumn DgvColEdit;
		private System.Windows.Forms.DataGridViewButtonColumn DgvColDelete;
		private System.Windows.Forms.Label LblNotification;
		private System.Windows.Forms.Button BtnSave;
	}
}
