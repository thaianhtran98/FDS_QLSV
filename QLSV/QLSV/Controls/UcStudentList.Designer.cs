namespace QLSV.Controls
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
			this.PnlFilter = new System.Windows.Forms.Panel();
			this.PnlStudentList = new System.Windows.Forms.Panel();
			this.LblNameFilter = new System.Windows.Forms.Label();
			this.TxtNameFilter = new System.Windows.Forms.TextBox();
			this.LblSex = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.PnlFilter.SuspendLayout();
			this.PnlStudentList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// PnlFilter
			// 
			this.PnlFilter.Controls.Add(this.comboBox1);
			this.PnlFilter.Controls.Add(this.TxtNameFilter);
			this.PnlFilter.Controls.Add(this.LblSex);
			this.PnlFilter.Controls.Add(this.LblNameFilter);
			this.PnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlFilter.Location = new System.Drawing.Point(0, 0);
			this.PnlFilter.Name = "PnlFilter";
			this.PnlFilter.Size = new System.Drawing.Size(684, 40);
			this.PnlFilter.TabIndex = 0;
			// 
			// PnlStudentList
			// 
			this.PnlStudentList.Controls.Add(this.dataGridView1);
			this.PnlStudentList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlStudentList.Location = new System.Drawing.Point(0, 40);
			this.PnlStudentList.Name = "PnlStudentList";
			this.PnlStudentList.Size = new System.Drawing.Size(684, 409);
			this.PnlStudentList.TabIndex = 1;
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
			// TxtNameFilter
			// 
			this.TxtNameFilter.Location = new System.Drawing.Point(25, 5);
			this.TxtNameFilter.Name = "TxtNameFilter";
			this.TxtNameFilter.Size = new System.Drawing.Size(100, 20);
			this.TxtNameFilter.TabIndex = 1;
			this.TxtNameFilter.TextChanged += new System.EventHandler(this.TxtNameFilter_TextChanged);
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
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
			this.comboBox1.Location = new System.Drawing.Point(205, 5);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(684, 409);
			this.dataGridView1.TabIndex = 0;
			// 
			// UcStudentList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.PnlStudentList);
			this.Controls.Add(this.PnlFilter);
			this.Name = "UcStudentList";
			this.Size = new System.Drawing.Size(684, 449);
			this.PnlFilter.ResumeLayout(false);
			this.PnlFilter.PerformLayout();
			this.PnlStudentList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PnlFilter;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox TxtNameFilter;
		private System.Windows.Forms.Label LblSex;
		private System.Windows.Forms.Label LblNameFilter;
		private System.Windows.Forms.Panel PnlStudentList;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
