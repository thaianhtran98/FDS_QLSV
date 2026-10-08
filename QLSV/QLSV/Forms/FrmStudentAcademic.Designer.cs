namespace QuanLySV.Forms
{
	partial class FrmStudentAcademic
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.LblSchoolYearName = new System.Windows.Forms.Label();
			this.CbxSchoolYear = new System.Windows.Forms.ComboBox();
			this.LblClassName = new System.Windows.Forms.Label();
			this.CbxClassName = new System.Windows.Forms.ComboBox();
			this.LblSemester = new System.Windows.Forms.Label();
			this.CbxSemester = new System.Windows.Forms.ComboBox();
			this.LblSubjectName = new System.Windows.Forms.Label();
			this.CbxSubjectName = new System.Windows.Forms.ComboBox();
			this.LblScore = new System.Windows.Forms.Label();
			this.TbxScore = new System.Windows.Forms.TextBox();
			this.LblScoreLetter = new System.Windows.Forms.Label();
			this.CbxScoreLetter = new System.Windows.Forms.TextBox();
			this.LblNote = new System.Windows.Forms.Label();
			this.TbxNote = new System.Windows.Forms.TextBox();
			this.BtnSave = new System.Windows.Forms.Button();
			this.BtnAddSchoolYear = new System.Windows.Forms.Button();
			this.BtnAddClass = new System.Windows.Forms.Button();
			this.BtnAddSubject = new System.Windows.Forms.Button();
			this.LblRequired1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LblSchoolYearName
			// 
			this.LblSchoolYearName.AutoSize = true;
			this.LblSchoolYearName.Location = new System.Drawing.Point(5, 0);
			this.LblSchoolYearName.Name = "LblSchoolYearName";
			this.LblSchoolYearName.Size = new System.Drawing.Size(50, 13);
			this.LblSchoolYearName.TabIndex = 0;
			this.LblSchoolYearName.Text = "Năm học";
			// 
			// CbxSchoolYear
			// 
			this.CbxSchoolYear.FormattingEnabled = true;
			this.CbxSchoolYear.Location = new System.Drawing.Point(5, 15);
			this.CbxSchoolYear.Name = "CbxSchoolYear";
			this.CbxSchoolYear.Size = new System.Drawing.Size(145, 21);
			this.CbxSchoolYear.TabIndex = 1;
			// 
			// LblClassName
			// 
			this.LblClassName.AutoSize = true;
			this.LblClassName.Location = new System.Drawing.Point(350, 0);
			this.LblClassName.Name = "LblClassName";
			this.LblClassName.Size = new System.Drawing.Size(46, 13);
			this.LblClassName.TabIndex = 0;
			this.LblClassName.Text = "Lớp học";
			// 
			// CbxClassName
			// 
			this.CbxClassName.FormattingEnabled = true;
			this.CbxClassName.Location = new System.Drawing.Point(350, 15);
			this.CbxClassName.Name = "CbxClassName";
			this.CbxClassName.Size = new System.Drawing.Size(140, 21);
			this.CbxClassName.TabIndex = 1;
			// 
			// LblSemester
			// 
			this.LblSemester.AutoSize = true;
			this.LblSemester.Location = new System.Drawing.Point(180, 0);
			this.LblSemester.Name = "LblSemester";
			this.LblSemester.Size = new System.Drawing.Size(41, 13);
			this.LblSemester.TabIndex = 0;
			this.LblSemester.Text = "Học kỳ";
			// 
			// CbxSemester
			// 
			this.CbxSemester.FormattingEnabled = true;
			this.CbxSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
			this.CbxSemester.Location = new System.Drawing.Point(180, 15);
			this.CbxSemester.Name = "CbxSemester";
			this.CbxSemester.Size = new System.Drawing.Size(140, 21);
			this.CbxSemester.TabIndex = 1;
			// 
			// LblSubjectName
			// 
			this.LblSubjectName.AutoSize = true;
			this.LblSubjectName.Location = new System.Drawing.Point(5, 50);
			this.LblSubjectName.Name = "LblSubjectName";
			this.LblSubjectName.Size = new System.Drawing.Size(49, 13);
			this.LblSubjectName.TabIndex = 0;
			this.LblSubjectName.Text = "Môn học";
			// 
			// CbxSubjectName
			// 
			this.CbxSubjectName.FormattingEnabled = true;
			this.CbxSubjectName.Location = new System.Drawing.Point(5, 65);
			this.CbxSubjectName.Name = "CbxSubjectName";
			this.CbxSubjectName.Size = new System.Drawing.Size(145, 21);
			this.CbxSubjectName.TabIndex = 1;
			// 
			// LblScore
			// 
			this.LblScore.AutoSize = true;
			this.LblScore.Location = new System.Drawing.Point(180, 50);
			this.LblScore.Name = "LblScore";
			this.LblScore.Size = new System.Drawing.Size(45, 13);
			this.LblScore.TabIndex = 0;
			this.LblScore.Text = "Điểm số";
			// 
			// TbxScore
			// 
			this.TbxScore.Location = new System.Drawing.Point(180, 65);
			this.TbxScore.Name = "TbxScore";
			this.TbxScore.Size = new System.Drawing.Size(145, 20);
			this.TbxScore.TabIndex = 2;
			// 
			// LblScoreLetter
			// 
			this.LblScoreLetter.AutoSize = true;
			this.LblScoreLetter.Location = new System.Drawing.Point(350, 50);
			this.LblScoreLetter.Name = "LblScoreLetter";
			this.LblScoreLetter.Size = new System.Drawing.Size(52, 13);
			this.LblScoreLetter.TabIndex = 0;
			this.LblScoreLetter.Text = "Điểm chữ";
			// 
			// CbxScoreLetter
			// 
			this.CbxScoreLetter.Enabled = false;
			this.CbxScoreLetter.Location = new System.Drawing.Point(350, 65);
			this.CbxScoreLetter.Name = "CbxScoreLetter";
			this.CbxScoreLetter.Size = new System.Drawing.Size(160, 20);
			this.CbxScoreLetter.TabIndex = 2;
			// 
			// LblNote
			// 
			this.LblNote.AutoSize = true;
			this.LblNote.Location = new System.Drawing.Point(5, 100);
			this.LblNote.Name = "LblNote";
			this.LblNote.Size = new System.Drawing.Size(44, 13);
			this.LblNote.TabIndex = 0;
			this.LblNote.Text = "Ghi chú";
			// 
			// TbxNote
			// 
			this.TbxNote.AcceptsReturn = true;
			this.TbxNote.Location = new System.Drawing.Point(5, 115);
			this.TbxNote.Multiline = true;
			this.TbxNote.Name = "TbxNote";
			this.TbxNote.Size = new System.Drawing.Size(505, 85);
			this.TbxNote.TabIndex = 2;
			// 
			// BtnSave
			// 
			this.BtnSave.Location = new System.Drawing.Point(5, 210);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(75, 23);
			this.BtnSave.TabIndex = 3;
			this.BtnSave.Text = "Thêm";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// BtnAddSchoolYear
			// 
			this.BtnAddSchoolYear.Location = new System.Drawing.Point(150, 15);
			this.BtnAddSchoolYear.Name = "BtnAddSchoolYear";
			this.BtnAddSchoolYear.Size = new System.Drawing.Size(21, 21);
			this.BtnAddSchoolYear.TabIndex = 4;
			this.BtnAddSchoolYear.Text = "+";
			this.BtnAddSchoolYear.UseVisualStyleBackColor = true;
			this.BtnAddSchoolYear.Click += new System.EventHandler(this.BtnAddSchoolYear_Click);
			// 
			// BtnAddClass
			// 
			this.BtnAddClass.Location = new System.Drawing.Point(490, 15);
			this.BtnAddClass.Name = "BtnAddClass";
			this.BtnAddClass.Size = new System.Drawing.Size(21, 21);
			this.BtnAddClass.TabIndex = 4;
			this.BtnAddClass.Text = "+";
			this.BtnAddClass.UseVisualStyleBackColor = true;
			this.BtnAddClass.Click += new System.EventHandler(this.BtnAddClass_Click);
			// 
			// BtnAddSubject
			// 
			this.BtnAddSubject.Location = new System.Drawing.Point(150, 65);
			this.BtnAddSubject.Name = "BtnAddSubject";
			this.BtnAddSubject.Size = new System.Drawing.Size(21, 21);
			this.BtnAddSubject.TabIndex = 4;
			this.BtnAddSubject.Text = "+";
			this.BtnAddSubject.UseVisualStyleBackColor = true;
			this.BtnAddSubject.Click += new System.EventHandler(this.BtnAddSubject_Click);
			// 
			// LblRequired1
			// 
			this.LblRequired1.AutoSize = true;
			this.LblRequired1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.LblRequired1.ForeColor = System.Drawing.Color.Red;
			this.LblRequired1.Location = new System.Drawing.Point(50, 50);
			this.LblRequired1.Name = "LblRequired1";
			this.LblRequired1.Size = new System.Drawing.Size(12, 13);
			this.LblRequired1.TabIndex = 5;
			this.LblRequired1.Text = "*";
			this.LblRequired1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(220, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "*";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(395, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(12, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "*";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(55, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(12, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "*";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FrmStudentAcademic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 243);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LblRequired1);
			this.Controls.Add(this.BtnAddSubject);
			this.Controls.Add(this.BtnAddClass);
			this.Controls.Add(this.BtnAddSchoolYear);
			this.Controls.Add(this.BtnSave);
			this.Controls.Add(this.CbxScoreLetter);
			this.Controls.Add(this.TbxNote);
			this.Controls.Add(this.TbxScore);
			this.Controls.Add(this.CbxSemester);
			this.Controls.Add(this.LblSemester);
			this.Controls.Add(this.CbxClassName);
			this.Controls.Add(this.LblClassName);
			this.Controls.Add(this.CbxSubjectName);
			this.Controls.Add(this.LblNote);
			this.Controls.Add(this.LblScoreLetter);
			this.Controls.Add(this.LblScore);
			this.Controls.Add(this.LblSubjectName);
			this.Controls.Add(this.CbxSchoolYear);
			this.Controls.Add(this.LblSchoolYearName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmStudentAcademic";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thông tin học tập";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblSchoolYearName;
		private System.Windows.Forms.ComboBox CbxSchoolYear;
		private System.Windows.Forms.Label LblClassName;
		private System.Windows.Forms.ComboBox CbxClassName;
		private System.Windows.Forms.Label LblSemester;
		private System.Windows.Forms.ComboBox CbxSemester;
		private System.Windows.Forms.Label LblSubjectName;
		private System.Windows.Forms.ComboBox CbxSubjectName;
		private System.Windows.Forms.Label LblScore;
		private System.Windows.Forms.TextBox TbxScore;
		private System.Windows.Forms.Label LblScoreLetter;
		private System.Windows.Forms.TextBox CbxScoreLetter;
		private System.Windows.Forms.Label LblNote;
		private System.Windows.Forms.TextBox TbxNote;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.Button BtnAddSchoolYear;
		private System.Windows.Forms.Button BtnAddClass;
		private System.Windows.Forms.Button BtnAddSubject;
		private System.Windows.Forms.Label LblRequired1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}