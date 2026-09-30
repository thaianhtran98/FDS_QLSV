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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.LblClassName = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.LblSemester = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.LblSubjectName = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.LblScore = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.LblScoreLetter = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.LblNote = new System.Windows.Forms.Label();
			this.TxtNote = new System.Windows.Forms.TextBox();
			this.BtnSave = new System.Windows.Forms.Button();
			this.BtnAddSchoolYear = new System.Windows.Forms.Button();
			this.BtnAddClass = new System.Windows.Forms.Button();
			this.BtnAddSubject = new System.Windows.Forms.Button();
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
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(5, 15);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(145, 21);
			this.comboBox1.TabIndex = 1;
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
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(350, 15);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(140, 21);
			this.comboBox2.TabIndex = 1;
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
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
			this.comboBox3.Location = new System.Drawing.Point(180, 15);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(140, 21);
			this.comboBox3.TabIndex = 1;
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
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(5, 65);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(145, 21);
			this.comboBox4.TabIndex = 1;
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
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(180, 65);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(145, 20);
			this.textBox1.TabIndex = 2;
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
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(350, 65);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(160, 20);
			this.textBox2.TabIndex = 2;
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
			// TxtNote
			// 
			this.TxtNote.AcceptsReturn = true;
			this.TxtNote.Location = new System.Drawing.Point(5, 115);
			this.TxtNote.Multiline = true;
			this.TxtNote.Name = "TxtNote";
			this.TxtNote.Size = new System.Drawing.Size(505, 85);
			this.TxtNote.TabIndex = 2;
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
			// FrmStudentAcademic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 245);
			this.Controls.Add(this.BtnAddSubject);
			this.Controls.Add(this.BtnAddClass);
			this.Controls.Add(this.BtnAddSchoolYear);
			this.Controls.Add(this.BtnSave);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.TxtNote);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.LblSemester);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.LblClassName);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.LblNote);
			this.Controls.Add(this.LblScoreLetter);
			this.Controls.Add(this.LblScore);
			this.Controls.Add(this.LblSubjectName);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.LblSchoolYearName);
			this.Name = "FrmStudentAcademic";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thông tin học tập";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblSchoolYearName;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label LblClassName;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label LblSemester;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label LblSubjectName;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Label LblScore;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label LblScoreLetter;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label LblNote;
		private System.Windows.Forms.TextBox TxtNote;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.Button BtnAddSchoolYear;
		private System.Windows.Forms.Button BtnAddClass;
		private System.Windows.Forms.Button BtnAddSubject;
	}
}