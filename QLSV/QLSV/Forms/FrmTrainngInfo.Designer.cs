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
			this.BtnSelected = new System.Windows.Forms.Button();
			this.UcTrainingInfo = new QuanLySV.Controls.UcTrainingInfo();
			this.SuspendLayout();
			// 
			// BtnSelected
			// 
			this.BtnSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnSelected.Location = new System.Drawing.Point(765, 373);
			this.BtnSelected.Name = "BtnSelected";
			this.BtnSelected.Size = new System.Drawing.Size(75, 23);
			this.BtnSelected.TabIndex = 1;
			this.BtnSelected.Text = "Chọn";
			this.BtnSelected.UseVisualStyleBackColor = true;
			this.BtnSelected.Click += new System.EventHandler(this.BtnSelected_Click);
			// 
			// UcTrainingInfo
			// 
			this.UcTrainingInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UcTrainingInfo.Location = new System.Drawing.Point(0, 0);
			this.UcTrainingInfo.Name = "UcTrainingInfo";
			this.UcTrainingInfo.Size = new System.Drawing.Size(925, 400);
			this.UcTrainingInfo.TabIndex = 0;
			// 
			// FrmTrainngInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(925, 400);
			this.Controls.Add(this.BtnSelected);
			this.Controls.Add(this.UcTrainingInfo);
			this.Name = "FrmTrainngInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmTrainngInfo";
			this.ResumeLayout(false);

		}

		#endregion

		private QuanLySV.Controls.UcTrainingInfo UcTrainingInfo;
		private System.Windows.Forms.Button BtnSelected;
	}
}