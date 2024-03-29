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
			this.alphaGradientPanel1 = new System.Windows.Forms.AlphaGradientPanel();
			this.colorWithAlpha1 = new System.Windows.Forms.ColorWithAlpha();
			this.colorWithAlpha2 = new System.Windows.Forms.ColorWithAlpha();
			this.txtDoanhThu = new Bunifu.UI.WinForms.BunifuLabel();
			this.txtNameMovie = new Bunifu.UI.WinForms.BunifuLabel();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ImgTraler)).BeginInit();
			this.pnItemView.SuspendLayout();
			this.alphaGradientPanel1.SuspendLayout();
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
			this.ImgTraler.Click += new System.EventHandler(this._DetailMovies);
			// 
			// pnItemView
			// 
			this.pnItemView.BackgroundColor = System.Drawing.Color.Transparent;
			this.pnItemView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnItemView.BackgroundImage")));
			this.pnItemView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnItemView.BorderColor = System.Drawing.Color.MidnightBlue;
			this.pnItemView.BorderRadius = 10;
			this.pnItemView.BorderThickness = 1;
			this.pnItemView.Controls.Add(this.alphaGradientPanel1);
			this.pnItemView.Controls.Add(this.ImgTraler);
			this.pnItemView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnItemView.Location = new System.Drawing.Point(0, 0);
			this.pnItemView.Name = "pnItemView";
			this.pnItemView.Padding = new System.Windows.Forms.Padding(6);
			this.pnItemView.ShowBorders = true;
			this.pnItemView.Size = new System.Drawing.Size(400, 230);
			this.pnItemView.TabIndex = 1;
			// 
			// alphaGradientPanel1
			// 
			this.alphaGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.alphaGradientPanel1.BackColor = System.Drawing.Color.Cornsilk;
			this.alphaGradientPanel1.Border = true;
			this.alphaGradientPanel1.BorderColor = System.Drawing.Color.White;
			this.alphaGradientPanel1.Colors.Add(this.colorWithAlpha1);
			this.alphaGradientPanel1.Colors.Add(this.colorWithAlpha2);
			this.alphaGradientPanel1.ContentPadding = new System.Windows.Forms.Padding(0);
			this.alphaGradientPanel1.Controls.Add(this.txtDoanhThu);
			this.alphaGradientPanel1.Controls.Add(this.txtNameMovie);
			this.alphaGradientPanel1.CornerRadius = 10;
			this.alphaGradientPanel1.Corners = ((System.Windows.Forms.Corner)((((System.Windows.Forms.Corner.TopLeft | System.Windows.Forms.Corner.TopRight) 
            | System.Windows.Forms.Corner.BottomLeft) 
            | System.Windows.Forms.Corner.BottomRight)));
			this.alphaGradientPanel1.Gradient = true;
			this.alphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.alphaGradientPanel1.GradientOffset = 1F;
			this.alphaGradientPanel1.GradientSize = new System.Drawing.Size(0, 0);
			this.alphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
			this.alphaGradientPanel1.Grayscale = false;
			this.alphaGradientPanel1.Image = null;
			this.alphaGradientPanel1.ImageAlpha = 75;
			this.alphaGradientPanel1.ImagePadding = new System.Windows.Forms.Padding(5);
			this.alphaGradientPanel1.ImagePosition = System.Windows.Forms.ImagePosition.BottomRight;
			this.alphaGradientPanel1.ImageSize = new System.Drawing.Size(48, 48);
			this.alphaGradientPanel1.Location = new System.Drawing.Point(24, 23);
			this.alphaGradientPanel1.Name = "alphaGradientPanel1";
			this.alphaGradientPanel1.Rounded = true;
			this.alphaGradientPanel1.Size = new System.Drawing.Size(346, 187);
			this.alphaGradientPanel1.TabIndex = 2;
			this.alphaGradientPanel1.Click += new System.EventHandler(this._DetailMovies);
			// 
			// colorWithAlpha1
			// 
			this.colorWithAlpha1.Alpha = 60;
			this.colorWithAlpha1.Color = System.Drawing.SystemColors.HighlightText;
			this.colorWithAlpha1.Parent = this.alphaGradientPanel1;
			// 
			// colorWithAlpha2
			// 
			this.colorWithAlpha2.Alpha = 60;
			this.colorWithAlpha2.Color = System.Drawing.SystemColors.ButtonHighlight;
			this.colorWithAlpha2.Parent = this.alphaGradientPanel1;
			// 
			// txtDoanhThu
			// 
			this.txtDoanhThu.AllowParentOverrides = false;
			this.txtDoanhThu.AutoEllipsis = false;
			this.txtDoanhThu.CursorType = null;
			this.txtDoanhThu.Font = new System.Drawing.Font("Segoe UI", 13F);
			this.txtDoanhThu.Location = new System.Drawing.Point(16, 143);
			this.txtDoanhThu.Name = "txtDoanhThu";
			this.txtDoanhThu.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtDoanhThu.Size = new System.Drawing.Size(46, 23);
			this.txtDoanhThu.TabIndex = 8;
			this.txtDoanhThu.Text = "Name";
			this.txtDoanhThu.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.txtDoanhThu.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
			this.Load += new System.EventHandler(this.ItemMovieView_Load);
			((System.ComponentModel.ISupportInitialize)(this.ImgTraler)).EndInit();
			this.pnItemView.ResumeLayout(false);
			this.alphaGradientPanel1.ResumeLayout(false);
			this.alphaGradientPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox ImgTraler;
		private Bunifu.UI.WinForms.BunifuPanel pnItemView;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel1;
		private System.Windows.Forms.ColorWithAlpha colorWithAlpha1;
		private System.Windows.Forms.ColorWithAlpha colorWithAlpha2;
		private Bunifu.UI.WinForms.BunifuLabel txtNameMovie;
		private Bunifu.UI.WinForms.BunifuLabel txtDoanhThu;
	}
}