namespace QuanLySV.Forms
{
	partial class FrmTrainngInfo
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
			this.PnlMain = new System.Windows.Forms.Panel();
			this.UcTrainingInfo = new QuanLySV.Controls.UcTrainingInfo();
			this.PnlMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// PnlMain
			// 
			this.PnlMain.Controls.Add(this.UcTrainingInfo);
			this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlMain.Location = new System.Drawing.Point(0, 0);
			this.PnlMain.Name = "PnlMain";
			this.PnlMain.Size = new System.Drawing.Size(1033, 548);
			this.PnlMain.TabIndex = 3;
			// 
			// UcTrainingInfo
			// 
			this.UcTrainingInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UcTrainingInfo.Location = new System.Drawing.Point(0, 0);
			this.UcTrainingInfo.Name = "UcTrainingInfo";
			this.UcTrainingInfo.Size = new System.Drawing.Size(1033, 548);
			this.UcTrainingInfo.TabIndex = 1;
			// 
			// FrmTrainngInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1033, 548);
			this.Controls.Add(this.PnlMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmTrainngInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmTrainngInfo";
			this.PnlMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel PnlMain;
		private Controls.UcTrainingInfo UcTrainingInfo;
	}
}