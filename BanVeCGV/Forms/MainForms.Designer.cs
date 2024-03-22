namespace BanVeCGV.Forms
{
	partial class MainForms
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForms));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
			this.pnMain = new Bunifu.UI.WinForms.BunifuPanel();
			this.pnTitle = new Bunifu.UI.WinForms.BunifuPanel();
			this.icMiniApp = new FontAwesome.Sharp.IconButton();
			this.icResizeApp = new FontAwesome.Sharp.IconButton();
			this.btnClose = new FontAwesome.Sharp.IconButton();
			this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
			this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bunifuPanel1.SuspendLayout();
			this.pnTitle.SuspendLayout();
			this.bunifuPanel2.SuspendLayout();
			this.bunifuPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 8;
			this.bunifuElipse1.TargetControl = this;
			// 
			// bunifuPanel1
			// 
			this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
			this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
			this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuPanel1.BorderColor = System.Drawing.Color.Navy;
			this.bunifuPanel1.BorderRadius = 8;
			this.bunifuPanel1.BorderThickness = 2;
			this.bunifuPanel1.Controls.Add(this.pnMain);
			this.bunifuPanel1.Controls.Add(this.pnTitle);
			this.bunifuPanel1.Controls.Add(this.bunifuPanel2);
			this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
			this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.bunifuPanel1.Name = "bunifuPanel1";
			this.bunifuPanel1.ShowBorders = true;
			this.bunifuPanel1.Size = new System.Drawing.Size(1400, 850);
			this.bunifuPanel1.TabIndex = 0;
			// 
			// pnMain
			// 
			this.pnMain.BackgroundColor = System.Drawing.Color.Transparent;
			this.pnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMain.BackgroundImage")));
			this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnMain.BorderColor = System.Drawing.Color.Transparent;
			this.pnMain.BorderRadius = 3;
			this.pnMain.BorderThickness = 1;
			this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnMain.Location = new System.Drawing.Point(225, 36);
			this.pnMain.Margin = new System.Windows.Forms.Padding(0);
			this.pnMain.Name = "pnMain";
			this.pnMain.ShowBorders = true;
			this.pnMain.Size = new System.Drawing.Size(1175, 814);
			this.pnMain.TabIndex = 2;
			// 
			// pnTitle
			// 
			this.pnTitle.BackgroundColor = System.Drawing.Color.MidnightBlue;
			this.pnTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnTitle.BackgroundImage")));
			this.pnTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnTitle.BorderColor = System.Drawing.Color.Transparent;
			this.pnTitle.BorderRadius = 8;
			this.pnTitle.BorderThickness = 0;
			this.pnTitle.Controls.Add(this.icMiniApp);
			this.pnTitle.Controls.Add(this.icResizeApp);
			this.pnTitle.Controls.Add(this.btnClose);
			this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnTitle.Location = new System.Drawing.Point(225, 0);
			this.pnTitle.Margin = new System.Windows.Forms.Padding(0);
			this.pnTitle.Name = "pnTitle";
			this.pnTitle.ShowBorders = true;
			this.pnTitle.Size = new System.Drawing.Size(1175, 36);
			this.pnTitle.TabIndex = 1;
			this.pnTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseDown);
			// 
			// icMiniApp
			// 
			this.icMiniApp.BackColor = System.Drawing.Color.Gold;
			this.icMiniApp.Dock = System.Windows.Forms.DockStyle.Right;
			this.icMiniApp.FlatAppearance.BorderSize = 0;
			this.icMiniApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.icMiniApp.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
			this.icMiniApp.IconColor = System.Drawing.Color.White;
			this.icMiniApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.icMiniApp.IconSize = 24;
			this.icMiniApp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.icMiniApp.Location = new System.Drawing.Point(1067, 0);
			this.icMiniApp.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
			this.icMiniApp.Name = "icMiniApp";
			this.icMiniApp.Size = new System.Drawing.Size(36, 36);
			this.icMiniApp.TabIndex = 10;
			this.icMiniApp.UseVisualStyleBackColor = false;
			this.icMiniApp.Click += new System.EventHandler(this.icMiniApp_Click);
			// 
			// icResizeApp
			// 
			this.icResizeApp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.icResizeApp.BackColor = System.Drawing.Color.Green;
			this.icResizeApp.Dock = System.Windows.Forms.DockStyle.Right;
			this.icResizeApp.FlatAppearance.BorderSize = 0;
			this.icResizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.icResizeApp.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
			this.icResizeApp.IconColor = System.Drawing.Color.White;
			this.icResizeApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.icResizeApp.IconSize = 24;
			this.icResizeApp.Location = new System.Drawing.Point(1103, 0);
			this.icResizeApp.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
			this.icResizeApp.Name = "icResizeApp";
			this.icResizeApp.Size = new System.Drawing.Size(36, 36);
			this.icResizeApp.TabIndex = 9;
			this.icResizeApp.UseVisualStyleBackColor = false;
			this.icResizeApp.Click += new System.EventHandler(this.icResizeApp_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Red;
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
			this.btnClose.IconColor = System.Drawing.Color.White;
			this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnClose.IconSize = 24;
			this.btnClose.Location = new System.Drawing.Point(1139, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(36, 36);
			this.btnClose.TabIndex = 8;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// bunifuPanel2
			// 
			this.bunifuPanel2.BackgroundColor = System.Drawing.Color.MidnightBlue;
			this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
			this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
			this.bunifuPanel2.BorderRadius = 10;
			this.bunifuPanel2.BorderThickness = 0;
			this.bunifuPanel2.Controls.Add(this.bunifuPanel4);
			this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
			this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.bunifuPanel2.Name = "bunifuPanel2";
			this.bunifuPanel2.ShowBorders = true;
			this.bunifuPanel2.Size = new System.Drawing.Size(225, 850);
			this.bunifuPanel2.TabIndex = 0;
			// 
			// bunifuPanel4
			// 
			this.bunifuPanel4.BackgroundColor = System.Drawing.Color.MidnightBlue;
			this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
			this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuPanel4.BorderColor = System.Drawing.Color.Transparent;
			this.bunifuPanel4.BorderRadius = 8;
			this.bunifuPanel4.BorderThickness = 0;
			this.bunifuPanel4.Controls.Add(this.pictureBox1);
			this.bunifuPanel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.bunifuPanel4.Location = new System.Drawing.Point(0, 0);
			this.bunifuPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.bunifuPanel4.Name = "bunifuPanel4";
			this.bunifuPanel4.ShowBorders = true;
			this.bunifuPanel4.Size = new System.Drawing.Size(225, 72);
			this.bunifuPanel4.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::BanVeCGV.Properties.Resources.user_icon_2048x2048_ihoxz4vq;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(40, 40);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// MainForms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1400, 850);
			this.Controls.Add(this.bunifuPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(1400, 850);
			this.Name = "MainForms";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForms";
			this.bunifuPanel1.ResumeLayout(false);
			this.pnTitle.ResumeLayout(false);
			this.bunifuPanel2.ResumeLayout(false);
			this.bunifuPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
		private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
		private Bunifu.UI.WinForms.BunifuPanel pnTitle;
		private FontAwesome.Sharp.IconButton btnClose;
		private FontAwesome.Sharp.IconButton icMiniApp;
		private FontAwesome.Sharp.IconButton icResizeApp;
		private Bunifu.UI.WinForms.BunifuPanel pnMain;
		private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}