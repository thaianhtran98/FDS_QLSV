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
			this.PnlMain = new System.Windows.Forms.Panel();
			this.PnlFooter = new System.Windows.Forms.FlowLayoutPanel();
			this.BtnTempSave = new System.Windows.Forms.Button();
			this.BtnSave = new System.Windows.Forms.Button();
			this.PnlFooter.SuspendLayout();
			this.SuspendLayout();
			// 
			// PnlMain
			// 
			this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlMain.Location = new System.Drawing.Point(0, 0);
			this.PnlMain.Name = "PnlMain";
			this.PnlMain.Size = new System.Drawing.Size(643, 488);
			this.PnlMain.TabIndex = 0;
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
			// 
			// BtnSave
			// 
			this.BtnSave.Location = new System.Drawing.Point(84, 3);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(76, 22);
			this.BtnSave.TabIndex = 1;
			this.BtnSave.Text = "Lưu vào DB";
			this.BtnSave.UseVisualStyleBackColor = true;
			// 
			// UcStudentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.PnlFooter);
			this.Controls.Add(this.PnlMain);
			this.Name = "UcStudentForm";
			this.Size = new System.Drawing.Size(643, 488);
			this.PnlFooter.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PnlMain;
		private System.Windows.Forms.FlowLayoutPanel PnlFooter;
		private System.Windows.Forms.Button BtnTempSave;
		private System.Windows.Forms.Button BtnSave;
	}
}
