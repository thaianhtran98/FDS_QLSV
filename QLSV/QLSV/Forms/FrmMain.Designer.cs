namespace QuanLySV.Forms
{
	partial class FrmMain
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
			this.PnlHeader = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.MnuQLSV = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuItemList = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuQldm = new System.Windows.Forms.ToolStripMenuItem();
			this.PnlMain = new System.Windows.Forms.Panel();
			this.LblMain = new System.Windows.Forms.Label();
			this.PnlHeader.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.PnlMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// PnlHeader
			// 
			this.PnlHeader.Controls.Add(this.menuStrip1);
			this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.PnlHeader.Location = new System.Drawing.Point(0, 0);
			this.PnlHeader.Name = "PnlHeader";
			this.PnlHeader.Size = new System.Drawing.Size(712, 25);
			this.PnlHeader.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuQLSV,
            this.MnuQldm});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(712, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// MnuQLSV
			// 
			this.MnuQLSV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemList,
            this.MnuItemCreate});
			this.MnuQLSV.Name = "MnuQLSV";
			this.MnuQLSV.Size = new System.Drawing.Size(110, 21);
			this.MnuQLSV.Text = "Quản lý sinh viên";
			// 
			// MnuItemList
			// 
			this.MnuItemList.Name = "MnuItemList";
			this.MnuItemList.Size = new System.Drawing.Size(152, 22);
			this.MnuItemList.Text = "Danh sách";
			this.MnuItemList.Click += new System.EventHandler(this.MnuItemList_Click);
			// 
			// MnuItemCreate
			// 
			this.MnuItemCreate.Name = "MnuItemCreate";
			this.MnuItemCreate.Size = new System.Drawing.Size(152, 22);
			this.MnuItemCreate.Text = "Thêm mới";
			this.MnuItemCreate.Click += new System.EventHandler(this.MnuItemCreate_Click);
			// 
			// MnuQldm
			// 
			this.MnuQldm.Name = "MnuQldm";
			this.MnuQldm.Size = new System.Drawing.Size(155, 21);
			this.MnuQldm.Text = "Quản lý thông tin đào tạo";
			this.MnuQldm.Click += new System.EventHandler(this.MnuQldm_Click);
			// 
			// PnlMain
			// 
			this.PnlMain.Controls.Add(this.LblMain);
			this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlMain.Location = new System.Drawing.Point(0, 25);
			this.PnlMain.Name = "PnlMain";
			this.PnlMain.Size = new System.Drawing.Size(712, 422);
			this.PnlMain.TabIndex = 1;
			// 
			// LblMain
			// 
			this.LblMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.LblMain.Location = new System.Drawing.Point(0, 0);
			this.LblMain.Name = "LblMain";
			this.LblMain.Size = new System.Drawing.Size(712, 422);
			this.LblMain.TabIndex = 0;
			this.LblMain.Text = "Phần mềm quản lý sinh viên";
			this.LblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(712, 447);
			this.Controls.Add(this.PnlMain);
			this.Controls.Add(this.PnlHeader);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý";
			this.PnlHeader.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.PnlMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PnlHeader;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem MnuQLSV;
		private System.Windows.Forms.ToolStripMenuItem MnuItemList;
		private System.Windows.Forms.ToolStripMenuItem MnuItemCreate;
		private System.Windows.Forms.ToolStripMenuItem MnuQldm;
		private System.Windows.Forms.Panel PnlMain;
		private System.Windows.Forms.Label LblMain;
	}
}