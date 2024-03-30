namespace BanVeCGV.Forms.Items
{
	partial class RowItemTicket
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RowItemTicket));
			this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
			this.tbLayout = new System.Windows.Forms.TableLayoutPanel();
			this.txtPhong = new Bunifu.UI.WinForms.BunifuLabel();
			this.txtId = new Bunifu.UI.WinForms.BunifuLabel();
			this.txtSoghe = new Bunifu.UI.WinForms.BunifuLabel();
			this.txtTgChieu = new Bunifu.UI.WinForms.BunifuLabel();
			this.bunifuPanel1.SuspendLayout();
			this.tbLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// bunifuPanel1
			// 
			this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
			this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
			this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuPanel1.BorderColor = System.Drawing.Color.DarkViolet;
			this.bunifuPanel1.BorderRadius = 3;
			this.bunifuPanel1.BorderThickness = 1;
			this.bunifuPanel1.Controls.Add(this.tbLayout);
			this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
			this.bunifuPanel1.Name = "bunifuPanel1";
			this.bunifuPanel1.ShowBorders = true;
			this.bunifuPanel1.Size = new System.Drawing.Size(390, 80);
			this.bunifuPanel1.TabIndex = 24;
			// 
			// tbLayout
			// 
			this.tbLayout.BackColor = System.Drawing.Color.Transparent;
			this.tbLayout.ColumnCount = 2;
			this.tbLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tbLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tbLayout.Controls.Add(this.txtPhong, 0, 1);
			this.tbLayout.Controls.Add(this.txtId, 0, 0);
			this.tbLayout.Controls.Add(this.txtSoghe, 1, 0);
			this.tbLayout.Controls.Add(this.txtTgChieu, 1, 1);
			this.tbLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbLayout.Location = new System.Drawing.Point(0, 0);
			this.tbLayout.Margin = new System.Windows.Forms.Padding(0);
			this.tbLayout.Name = "tbLayout";
			this.tbLayout.RowCount = 2;
			this.tbLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tbLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tbLayout.Size = new System.Drawing.Size(390, 80);
			this.tbLayout.TabIndex = 0;
			this.tbLayout.Click += new System.EventHandler(this.tbLayout_Click);
			// 
			// txtPhong
			// 
			this.txtPhong.AllowParentOverrides = false;
			this.txtPhong.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtPhong.AutoEllipsis = false;
			this.txtPhong.CursorType = null;
			this.txtPhong.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtPhong.Location = new System.Drawing.Point(3, 49);
			this.txtPhong.Name = "txtPhong";
			this.txtPhong.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtPhong.Size = new System.Drawing.Size(42, 21);
			this.txtPhong.TabIndex = 27;
			this.txtPhong.Text = "Name";
			this.txtPhong.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.txtPhong.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// txtId
			// 
			this.txtId.AllowParentOverrides = false;
			this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtId.AutoEllipsis = false;
			this.txtId.CursorType = null;
			this.txtId.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtId.Location = new System.Drawing.Point(3, 9);
			this.txtId.Name = "txtId";
			this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtId.Size = new System.Drawing.Size(42, 21);
			this.txtId.TabIndex = 24;
			this.txtId.Text = "Name";
			this.txtId.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.txtId.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// txtSoghe
			// 
			this.txtSoghe.AllowParentOverrides = false;
			this.txtSoghe.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtSoghe.AutoEllipsis = false;
			this.txtSoghe.CursorType = null;
			this.txtSoghe.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtSoghe.Location = new System.Drawing.Point(198, 9);
			this.txtSoghe.Name = "txtSoghe";
			this.txtSoghe.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtSoghe.Size = new System.Drawing.Size(42, 21);
			this.txtSoghe.TabIndex = 26;
			this.txtSoghe.Text = "Name";
			this.txtSoghe.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.txtSoghe.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// txtTgChieu
			// 
			this.txtTgChieu.AllowParentOverrides = false;
			this.txtTgChieu.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtTgChieu.AutoEllipsis = false;
			this.txtTgChieu.CursorType = null;
			this.txtTgChieu.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtTgChieu.Location = new System.Drawing.Point(198, 49);
			this.txtTgChieu.Name = "txtTgChieu";
			this.txtTgChieu.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTgChieu.Size = new System.Drawing.Size(42, 21);
			this.txtTgChieu.TabIndex = 28;
			this.txtTgChieu.Text = "Name";
			this.txtTgChieu.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.txtTgChieu.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// RowItemTicket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bunifuPanel1);
			this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
			this.Name = "RowItemTicket";
			this.Size = new System.Drawing.Size(390, 80);
			this.bunifuPanel1.ResumeLayout(false);
			this.tbLayout.ResumeLayout(false);
			this.tbLayout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
		private System.Windows.Forms.TableLayoutPanel tbLayout;
		private Bunifu.UI.WinForms.BunifuLabel txtPhong;
		private Bunifu.UI.WinForms.BunifuLabel txtId;
		private Bunifu.UI.WinForms.BunifuLabel txtSoghe;
		private Bunifu.UI.WinForms.BunifuLabel txtTgChieu;
	}
}
