namespace BanVeCGV.Widget
{
	partial class ItemMovieView
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemMovieView));
			this.ImgTraler = new System.Windows.Forms.PictureBox();
			this.pnItemView = new Bunifu.UI.WinForms.BunifuPanel();
			this.pnView = new System.Windows.Forms.AlphaGradientPanel();
			this.colorWithAlpha1 = new System.Windows.Forms.ColorWithAlpha();
			this.colorWithAlpha2 = new System.Windows.Forms.ColorWithAlpha();
			this.txtThoiLuong = new Bunifu.UI.WinForms.BunifuLabel();
			this.txtTheLoai = new Bunifu.UI.WinForms.BunifuLabel();
			this.txtNameMovie = new Bunifu.UI.WinForms.BunifuLabel();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ImgTraler)).BeginInit();
			this.pnItemView.SuspendLayout();
			this.pnView.SuspendLayout();
			this.SuspendLayout();
			// 
			// ImgTraler
			// 
			this.ImgTraler.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ImgTraler.Location = new System.Drawing.Point(6, 6);
			this.ImgTraler.Margin = new System.Windows.Forms.Padding(0);
			this.ImgTraler.Name = "ImgTraler";
			this.ImgTraler.Size = new System.Drawing.Size(388, 218);
			this.ImgTraler.TabIndex = 1;
			this.ImgTraler.TabStop = false;
			this.ImgTraler.Click += new System.EventHandler(this.pnView_Click);
			// 
			// pnItemView
			// 
			this.pnItemView.BackgroundColor = System.Drawing.Color.Transparent;
			this.pnItemView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnItemView.BackgroundImage")));
			this.pnItemView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnItemView.BorderColor = System.Drawing.Color.MidnightBlue;
			this.pnItemView.BorderRadius = 10;
			this.pnItemView.BorderThickness = 1;
			this.pnItemView.Controls.Add(this.pnView);
			this.pnItemView.Controls.Add(this.ImgTraler);
			this.pnItemView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnItemView.Location = new System.Drawing.Point(0, 0);
			this.pnItemView.Name = "pnItemView";
			this.pnItemView.Padding = new System.Windows.Forms.Padding(6);
			this.pnItemView.ShowBorders = true;
			this.pnItemView.Size = new System.Drawing.Size(400, 230);
			this.pnItemView.TabIndex = 1;
			// 
			// pnView
			// 
			this.pnView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnView.BackColor = System.Drawing.Color.Cornsilk;
			this.pnView.Border = true;
			this.pnView.BorderColor = System.Drawing.Color.White;
			this.pnView.Colors.Add(this.colorWithAlpha1);
			this.pnView.Colors.Add(this.colorWithAlpha2);
			this.pnView.ContentPadding = new System.Windows.Forms.Padding(0);
			this.pnView.Controls.Add(this.txtThoiLuong);
			this.pnView.Controls.Add(this.txtTheLoai);
			this.pnView.Controls.Add(this.txtNameMovie);
			this.pnView.CornerRadius = 10;
			this.pnView.Corners = ((System.Windows.Forms.Corner)((((System.Windows.Forms.Corner.TopLeft | System.Windows.Forms.Corner.TopRight) 
            | System.Windows.Forms.Corner.BottomLeft) 
            | System.Windows.Forms.Corner.BottomRight)));
			this.pnView.Gradient = true;
			this.pnView.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.pnView.GradientOffset = 1F;
			this.pnView.GradientSize = new System.Drawing.Size(0, 0);
			this.pnView.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
			this.pnView.Grayscale = false;
			this.pnView.Image = null;
			this.pnView.ImageAlpha = 75;
			this.pnView.ImagePadding = new System.Windows.Forms.Padding(5);
			this.pnView.ImagePosition = System.Windows.Forms.ImagePosition.BottomRight;
			this.pnView.ImageSize = new System.Drawing.Size(48, 48);
			this.pnView.Location = new System.Drawing.Point(24, 23);
			this.pnView.Name = "pnView";
			this.pnView.Rounded = true;
			this.pnView.Size = new System.Drawing.Size(346, 187);
			this.pnView.TabIndex = 2;
			this.pnView.Click += new System.EventHandler(this.pnView_Click);
			// 
			// colorWithAlpha1
			// 
			this.colorWithAlpha1.Alpha = 60;
			this.colorWithAlpha1.Color = System.Drawing.SystemColors.HighlightText;
			this.colorWithAlpha1.Parent = this.pnView;
			// 
			// colorWithAlpha2
			// 
			this.colorWithAlpha2.Alpha = 60;
			this.colorWithAlpha2.Color = System.Drawing.SystemColors.ButtonHighlight;
			this.colorWithAlpha2.Parent = this.pnView;
			// 
			// txtThoiLuong
			// 
			this.txtThoiLuong.AllowParentOverrides = false;
			this.txtThoiLuong.AutoEllipsis = false;
			this.txtThoiLuong.CursorType = null;
			this.txtThoiLuong.Font = new System.Drawing.Font("Segoe UI", 13F);
			this.txtThoiLuong.Location = new System.Drawing.Point(16, 112);
			this.txtThoiLuong.Name = "txtThoiLuong";
			this.txtThoiLuong.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtThoiLuong.Size = new System.Drawing.Size(46, 23);
			this.txtThoiLuong.TabIndex = 9;
			this.txtThoiLuong.Text = "Name";
			this.txtThoiLuong.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.txtThoiLuong.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// txtTheLoai
			// 
			this.txtTheLoai.AllowParentOverrides = false;
			this.txtTheLoai.AutoEllipsis = false;
			this.txtTheLoai.CursorType = null;
			this.txtTheLoai.Font = new System.Drawing.Font("Segoe UI", 13F);
			this.txtTheLoai.Location = new System.Drawing.Point(16, 72);
			this.txtTheLoai.Name = "txtTheLoai";
			this.txtTheLoai.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTheLoai.Size = new System.Drawing.Size(46, 23);
			this.txtTheLoai.TabIndex = 8;
			this.txtTheLoai.Text = "Name";
			this.txtTheLoai.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.txtTheLoai.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// txtNameMovie
			// 
			this.txtNameMovie.AllowParentOverrides = false;
			this.txtNameMovie.AutoEllipsis = false;
			this.txtNameMovie.CursorType = null;
			this.txtNameMovie.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.txtNameMovie.Location = new System.Drawing.Point(16, 12);
			this.txtNameMovie.Name = "txtNameMovie";
			this.txtNameMovie.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtNameMovie.Size = new System.Drawing.Size(52, 25);
			this.txtNameMovie.TabIndex = 6;
			this.txtNameMovie.Text = "Name";
			this.txtNameMovie.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.txtNameMovie.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 10;
			this.bunifuElipse1.TargetControl = this;
			// 
			// ItemMovieView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(400, 230);
			this.Controls.Add(this.pnItemView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ItemMovieView";
			this.Text = "ItemMovieView";
			((System.ComponentModel.ISupportInitialize)(this.ImgTraler)).EndInit();
			this.pnItemView.ResumeLayout(false);
			this.pnView.ResumeLayout(false);
			this.pnView.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox ImgTraler;
		private Bunifu.UI.WinForms.BunifuPanel pnItemView;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.AlphaGradientPanel pnView;
		private System.Windows.Forms.ColorWithAlpha colorWithAlpha1;
		private System.Windows.Forms.ColorWithAlpha colorWithAlpha2;
		private Bunifu.UI.WinForms.BunifuLabel txtNameMovie;
		private Bunifu.UI.WinForms.BunifuLabel txtTheLoai;
		private Bunifu.UI.WinForms.BunifuLabel txtThoiLuong;
	}
}