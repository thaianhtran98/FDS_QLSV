namespace QLSV.Controls
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
			this.PnlMain = new System.Windows.Forms.Panel();
			this.TabCtlTrainingInfo = new System.Windows.Forms.TabControl();
			this.TabClass = new System.Windows.Forms.TabPage();
			this.TabSchoolYear = new System.Windows.Forms.TabPage();
			this.TabSubject = new System.Windows.Forms.TabPage();
			this.BtnTempSave = new System.Windows.Forms.Button();
			this.BtnSave = new System.Windows.Forms.Button();
			this.PnlFooter.SuspendLayout();
			this.PnlMain.SuspendLayout();
			this.TabCtlTrainingInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// PnlFooter
			// 
			this.PnlFooter.Controls.Add(this.BtnSave);
			this.PnlFooter.Controls.Add(this.BtnTempSave);
			this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PnlFooter.Location = new System.Drawing.Point(0, 305);
			this.PnlFooter.Name = "PnlFooter";
			this.PnlFooter.Size = new System.Drawing.Size(521, 32);
			this.PnlFooter.TabIndex = 1;
			// 
			// PnlMain
			// 
			this.PnlMain.Controls.Add(this.TabCtlTrainingInfo);
			this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlMain.Location = new System.Drawing.Point(0, 0);
			this.PnlMain.Name = "PnlMain";
			this.PnlMain.Size = new System.Drawing.Size(521, 305);
			this.PnlMain.TabIndex = 2;
			// 
			// TabCtlTrainingInfo
			// 
			this.TabCtlTrainingInfo.Controls.Add(this.TabClass);
			this.TabCtlTrainingInfo.Controls.Add(this.TabSchoolYear);
			this.TabCtlTrainingInfo.Controls.Add(this.TabSubject);
			this.TabCtlTrainingInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabCtlTrainingInfo.Location = new System.Drawing.Point(0, 0);
			this.TabCtlTrainingInfo.Name = "TabCtlTrainingInfo";
			this.TabCtlTrainingInfo.SelectedIndex = 0;
			this.TabCtlTrainingInfo.Size = new System.Drawing.Size(521, 305);
			this.TabCtlTrainingInfo.TabIndex = 1;
			// 
			// TabClass
			// 
			this.TabClass.Location = new System.Drawing.Point(4, 22);
			this.TabClass.Name = "TabClass";
			this.TabClass.Padding = new System.Windows.Forms.Padding(3);
			this.TabClass.Size = new System.Drawing.Size(513, 279);
			this.TabClass.TabIndex = 0;
			this.TabClass.Text = "Lóp học";
			this.TabClass.UseVisualStyleBackColor = true;
			// 
			// TabSchoolYear
			// 
			this.TabSchoolYear.Location = new System.Drawing.Point(4, 22);
			this.TabSchoolYear.Name = "TabSchoolYear";
			this.TabSchoolYear.Padding = new System.Windows.Forms.Padding(3);
			this.TabSchoolYear.Size = new System.Drawing.Size(513, 74);
			this.TabSchoolYear.TabIndex = 1;
			this.TabSchoolYear.Text = "Năm học";
			this.TabSchoolYear.UseVisualStyleBackColor = true;
			// 
			// TabSubject
			// 
			this.TabSubject.Location = new System.Drawing.Point(4, 22);
			this.TabSubject.Name = "TabSubject";
			this.TabSubject.Padding = new System.Windows.Forms.Padding(3);
			this.TabSubject.Size = new System.Drawing.Size(513, 74);
			this.TabSubject.TabIndex = 2;
			this.TabSubject.Text = "Môn học";
			this.TabSubject.UseVisualStyleBackColor = true;
			// 
			// BtnTempSave
			// 
			this.BtnTempSave.Location = new System.Drawing.Point(0, 5);
			this.BtnTempSave.Name = "BtnTempSave";
			this.BtnTempSave.Size = new System.Drawing.Size(75, 23);
			this.BtnTempSave.TabIndex = 0;
			this.BtnTempSave.Text = "Lưu tạm";
			this.BtnTempSave.UseVisualStyleBackColor = true;
			// 
			// BtnSave
			// 
			this.BtnSave.Location = new System.Drawing.Point(80, 5);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(75, 23);
			this.BtnSave.TabIndex = 0;
			this.BtnSave.Text = "Lưu vào DB";
			this.BtnSave.UseVisualStyleBackColor = true;
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
			this.TabCtlTrainingInfo.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PnlFooter;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.Button BtnTempSave;
		private System.Windows.Forms.Panel PnlMain;
		private System.Windows.Forms.TabControl TabCtlTrainingInfo;
		private System.Windows.Forms.TabPage TabClass;
		private System.Windows.Forms.TabPage TabSchoolYear;
		private System.Windows.Forms.TabPage TabSubject;
	}
}
