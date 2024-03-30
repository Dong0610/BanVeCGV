namespace BanVeCGV.Forms.ChildForm
{
	partial class DoanhThuForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoanhThuForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
			this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
			this.dtgvInvoices = new Bunifu.UI.WinForms.BunifuDataGridView();
			this.bunifuPanel3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.bunifuPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvInvoices)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuPanel3
			// 
			this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
			this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
			this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuPanel3.BorderColor = System.Drawing.Color.Tomato;
			this.bunifuPanel3.BorderRadius = 3;
			this.bunifuPanel3.BorderThickness = 1;
			this.bunifuPanel3.Controls.Add(this.tableLayoutPanel1);
			this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bunifuPanel3.Location = new System.Drawing.Point(0, 0);
			this.bunifuPanel3.Name = "bunifuPanel3";
			this.bunifuPanel3.ShowBorders = true;
			this.bunifuPanel3.Size = new System.Drawing.Size(1175, 814);
			this.bunifuPanel3.TabIndex = 17;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.19149F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.80851F));
			this.tableLayoutPanel1.Controls.Add(this.bunifuPanel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.bunifuPanel2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1175, 814);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// bunifuPanel1
			// 
			this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
			this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
			this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuPanel1.BorderColor = System.Drawing.Color.Silver;
			this.bunifuPanel1.BorderRadius = 5;
			this.bunifuPanel1.BorderThickness = 1;
			this.bunifuPanel1.Controls.Add(this.dtgvInvoices);
			this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bunifuPanel1.Location = new System.Drawing.Point(5, 412);
			this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(5);
			this.bunifuPanel1.Name = "bunifuPanel1";
			this.bunifuPanel1.Padding = new System.Windows.Forms.Padding(6);
			this.bunifuPanel1.ShowBorders = true;
			this.bunifuPanel1.Size = new System.Drawing.Size(1165, 397);
			this.bunifuPanel1.TabIndex = 3;
			// 
			// bunifuPanel2
			// 
			this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
			this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
			this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuPanel2.BorderColor = System.Drawing.Color.Silver;
			this.bunifuPanel2.BorderRadius = 5;
			this.bunifuPanel2.BorderThickness = 1;
			this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bunifuPanel2.Location = new System.Drawing.Point(5, 5);
			this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(5);
			this.bunifuPanel2.Name = "bunifuPanel2";
			this.bunifuPanel2.ShowBorders = true;
			this.bunifuPanel2.Size = new System.Drawing.Size(1165, 397);
			this.bunifuPanel2.TabIndex = 2;
			// 
			// dtgvInvoices
			// 
			this.dtgvInvoices.AllowCustomTheming = false;
			this.dtgvInvoices.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.dtgvInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dtgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgvInvoices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dtgvInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dtgvInvoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dtgvInvoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dtgvInvoices.ColumnHeadersHeight = 40;
			this.dtgvInvoices.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
			this.dtgvInvoices.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.dtgvInvoices.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
			this.dtgvInvoices.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
			this.dtgvInvoices.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dtgvInvoices.CurrentTheme.BackColor = System.Drawing.Color.DarkViolet;
			this.dtgvInvoices.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
			this.dtgvInvoices.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkViolet;
			this.dtgvInvoices.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			this.dtgvInvoices.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dtgvInvoices.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(168)))));
			this.dtgvInvoices.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dtgvInvoices.CurrentTheme.Name = null;
			this.dtgvInvoices.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
			this.dtgvInvoices.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.dtgvInvoices.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.dtgvInvoices.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
			this.dtgvInvoices.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtgvInvoices.DefaultCellStyle = dataGridViewCellStyle3;
			this.dtgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgvInvoices.EnableHeadersVisualStyles = false;
			this.dtgvInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
			this.dtgvInvoices.HeaderBackColor = System.Drawing.Color.DarkViolet;
			this.dtgvInvoices.HeaderBgColor = System.Drawing.Color.Empty;
			this.dtgvInvoices.HeaderForeColor = System.Drawing.Color.White;
			this.dtgvInvoices.Location = new System.Drawing.Point(6, 6);
			this.dtgvInvoices.Margin = new System.Windows.Forms.Padding(10);
			this.dtgvInvoices.Name = "dtgvInvoices";
			this.dtgvInvoices.ReadOnly = true;
			this.dtgvInvoices.RowHeadersVisible = false;
			this.dtgvInvoices.RowTemplate.Height = 40;
			this.dtgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgvInvoices.Size = new System.Drawing.Size(1153, 385);
			this.dtgvInvoices.TabIndex = 5;
			this.dtgvInvoices.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkViolet;
			// 
			// DoanhThuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1175, 814);
			this.Controls.Add(this.bunifuPanel3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DoanhThuForm";
			this.Text = "UserForm";
			this.bunifuPanel3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.bunifuPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgvInvoices)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
		private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
		private Bunifu.UI.WinForms.BunifuDataGridView dtgvInvoices;
	}
}