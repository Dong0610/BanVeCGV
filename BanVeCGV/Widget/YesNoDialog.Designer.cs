namespace BanVeCGV.Widget
{
	partial class YesNoDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YesNoDialog));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
			this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.txtMessage = new Bunifu.UI.WinForms.BunifuLabel();
			this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
			this.panelMain = new Bunifu.UI.WinForms.BunifuPanel();
			this.bnnNo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.bunifuPanel2.SuspendLayout();
			this.bunifuPanel1.SuspendLayout();
			this.panelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// bunifuPanel2
			// 
			this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
			this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
			this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
			this.bunifuPanel2.BorderRadius = 3;
			this.bunifuPanel2.BorderThickness = 1;
			this.bunifuPanel2.Controls.Add(this.bunifuLabel1);
			this.bunifuPanel2.Controls.Add(this.iconButton1);
			this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.bunifuPanel2.Location = new System.Drawing.Point(5, 5);
			this.bunifuPanel2.Name = "bunifuPanel2";
			this.bunifuPanel2.ShowBorders = true;
			this.bunifuPanel2.Size = new System.Drawing.Size(465, 39);
			this.bunifuPanel2.TabIndex = 1;
			// 
			// bunifuLabel1
			// 
			this.bunifuLabel1.AllowParentOverrides = false;
			this.bunifuLabel1.AutoEllipsis = false;
			this.bunifuLabel1.CursorType = null;
			this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.bunifuLabel1.ForeColor = System.Drawing.Color.Blue;
			this.bunifuLabel1.Location = new System.Drawing.Point(42, 15);
			this.bunifuLabel1.Name = "bunifuLabel1";
			this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bunifuLabel1.Size = new System.Drawing.Size(70, 21);
			this.bunifuLabel1.TabIndex = 3;
			this.bunifuLabel1.Text = "Xác nhận";
			this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
			this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// iconButton1
			// 
			this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
			this.iconButton1.FlatAppearance.BorderSize = 0;
			this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
			this.iconButton1.IconColor = System.Drawing.Color.Blue;
			this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton1.IconSize = 30;
			this.iconButton1.Location = new System.Drawing.Point(0, 0);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Size = new System.Drawing.Size(36, 39);
			this.iconButton1.TabIndex = 0;
			this.iconButton1.UseVisualStyleBackColor = true;
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 10;
			this.bunifuElipse1.TargetControl = this;
			// 
			// txtMessage
			// 
			this.txtMessage.AllowParentOverrides = false;
			this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMessage.AutoEllipsis = false;
			this.txtMessage.CursorType = null;
			this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.txtMessage.Location = new System.Drawing.Point(3, 3);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtMessage.Size = new System.Drawing.Size(90, 21);
			this.txtMessage.TabIndex = 4;
			this.txtMessage.Text = "Thành công";
			this.txtMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtMessage.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// bunifuPanel1
			// 
			this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
			this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
			this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
			this.bunifuPanel1.BorderRadius = 3;
			this.bunifuPanel1.BorderThickness = 1;
			this.bunifuPanel1.Controls.Add(this.txtMessage);
			this.bunifuPanel1.Location = new System.Drawing.Point(24, 60);
			this.bunifuPanel1.Name = "bunifuPanel1";
			this.bunifuPanel1.ShowBorders = true;
			this.bunifuPanel1.Size = new System.Drawing.Size(424, 112);
			this.bunifuPanel1.TabIndex = 4;
			// 
			// panelMain
			// 
			this.panelMain.BackgroundColor = System.Drawing.Color.White;
			this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
			this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelMain.BorderColor = System.Drawing.Color.Blue;
			this.panelMain.BorderRadius = 10;
			this.panelMain.BorderThickness = 2;
			this.panelMain.Controls.Add(this.bnnNo);
			this.panelMain.Controls.Add(this.bunifuButton1);
			this.panelMain.Controls.Add(this.bunifuPanel1);
			this.panelMain.Controls.Add(this.bunifuPanel2);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 0);
			this.panelMain.Margin = new System.Windows.Forms.Padding(0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Padding = new System.Windows.Forms.Padding(5);
			this.panelMain.ShowBorders = true;
			this.panelMain.Size = new System.Drawing.Size(475, 255);
			this.panelMain.TabIndex = 1;
			// 
			// bnnNo
			// 
			this.bnnNo.AllowAnimations = true;
			this.bnnNo.AllowMouseEffects = true;
			this.bnnNo.AllowToggling = false;
			this.bnnNo.AnimationSpeed = 200;
			this.bnnNo.AutoGenerateColors = false;
			this.bnnNo.AutoRoundBorders = false;
			this.bnnNo.AutoSizeLeftIcon = true;
			this.bnnNo.AutoSizeRightIcon = true;
			this.bnnNo.BackColor = System.Drawing.Color.Transparent;
			this.bnnNo.BackColor1 = System.Drawing.Color.White;
			this.bnnNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnnNo.BackgroundImage")));
			this.bnnNo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.bnnNo.ButtonText = "Không";
			this.bnnNo.ButtonTextMarginLeft = 0;
			this.bnnNo.ColorContrastOnClick = 45;
			this.bnnNo.ColorContrastOnHover = 45;
			this.bnnNo.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges1.BottomLeft = true;
			borderEdges1.BottomRight = true;
			borderEdges1.TopLeft = true;
			borderEdges1.TopRight = true;
			this.bnnNo.CustomizableEdges = borderEdges1;
			this.bnnNo.DialogResult = System.Windows.Forms.DialogResult.None;
			this.bnnNo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.bnnNo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.bnnNo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.bnnNo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.bnnNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.bnnNo.ForeColor = System.Drawing.Color.Black;
			this.bnnNo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnnNo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.bnnNo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.bnnNo.IconMarginLeft = 11;
			this.bnnNo.IconPadding = 10;
			this.bnnNo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnnNo.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.bnnNo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.bnnNo.IconSize = 25;
			this.bnnNo.IdleBorderColor = System.Drawing.Color.Gray;
			this.bnnNo.IdleBorderRadius = 5;
			this.bnnNo.IdleBorderThickness = 1;
			this.bnnNo.IdleFillColor = System.Drawing.Color.White;
			this.bnnNo.IdleIconLeftImage = null;
			this.bnnNo.IdleIconRightImage = null;
			this.bnnNo.IndicateFocus = false;
			this.bnnNo.Location = new System.Drawing.Point(54, 195);
			this.bnnNo.Name = "bnnNo";
			this.bnnNo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.bnnNo.OnDisabledState.BorderRadius = 5;
			this.bnnNo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.bnnNo.OnDisabledState.BorderThickness = 1;
			this.bnnNo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.bnnNo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.bnnNo.OnDisabledState.IconLeftImage = null;
			this.bnnNo.OnDisabledState.IconRightImage = null;
			this.bnnNo.onHoverState.BorderColor = System.Drawing.Color.Silver;
			this.bnnNo.onHoverState.BorderRadius = 5;
			this.bnnNo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.bnnNo.onHoverState.BorderThickness = 1;
			this.bnnNo.onHoverState.FillColor = System.Drawing.Color.Gray;
			this.bnnNo.onHoverState.ForeColor = System.Drawing.Color.White;
			this.bnnNo.onHoverState.IconLeftImage = null;
			this.bnnNo.onHoverState.IconRightImage = null;
			this.bnnNo.OnIdleState.BorderColor = System.Drawing.Color.Gray;
			this.bnnNo.OnIdleState.BorderRadius = 5;
			this.bnnNo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.bnnNo.OnIdleState.BorderThickness = 1;
			this.bnnNo.OnIdleState.FillColor = System.Drawing.Color.White;
			this.bnnNo.OnIdleState.ForeColor = System.Drawing.Color.Black;
			this.bnnNo.OnIdleState.IconLeftImage = null;
			this.bnnNo.OnIdleState.IconRightImage = null;
			this.bnnNo.OnPressedState.BorderColor = System.Drawing.Color.Silver;
			this.bnnNo.OnPressedState.BorderRadius = 5;
			this.bnnNo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.bnnNo.OnPressedState.BorderThickness = 1;
			this.bnnNo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bnnNo.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.bnnNo.OnPressedState.IconLeftImage = null;
			this.bnnNo.OnPressedState.IconRightImage = null;
			this.bnnNo.Size = new System.Drawing.Size(150, 39);
			this.bnnNo.TabIndex = 7;
			this.bnnNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bnnNo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.bnnNo.TextMarginLeft = 0;
			this.bnnNo.TextPadding = new System.Windows.Forms.Padding(0);
			this.bnnNo.UseDefaultRadiusAndThickness = true;
			this.bnnNo.Click += new System.EventHandler(this.bnnNo_Click);
			// 
			// bunifuButton1
			// 
			this.bunifuButton1.AllowAnimations = true;
			this.bunifuButton1.AllowMouseEffects = true;
			this.bunifuButton1.AllowToggling = false;
			this.bunifuButton1.AnimationSpeed = 200;
			this.bunifuButton1.AutoGenerateColors = false;
			this.bunifuButton1.AutoRoundBorders = false;
			this.bunifuButton1.AutoSizeLeftIcon = true;
			this.bunifuButton1.AutoSizeRightIcon = true;
			this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuButton1.BackColor1 = System.Drawing.Color.Blue;
			this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
			this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.bunifuButton1.ButtonText = "Có";
			this.bunifuButton1.ButtonTextMarginLeft = 0;
			this.bunifuButton1.ColorContrastOnClick = 45;
			this.bunifuButton1.ColorContrastOnHover = 45;
			this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges2.BottomLeft = true;
			borderEdges2.BottomRight = true;
			borderEdges2.TopLeft = true;
			borderEdges2.TopRight = true;
			this.bunifuButton1.CustomizableEdges = borderEdges2;
			this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
			this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.bunifuButton1.ForeColor = System.Drawing.Color.White;
			this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.bunifuButton1.IconMarginLeft = 11;
			this.bunifuButton1.IconPadding = 10;
			this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.bunifuButton1.IconSize = 25;
			this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Blue;
			this.bunifuButton1.IdleBorderRadius = 5;
			this.bunifuButton1.IdleBorderThickness = 1;
			this.bunifuButton1.IdleFillColor = System.Drawing.Color.Blue;
			this.bunifuButton1.IdleIconLeftImage = null;
			this.bunifuButton1.IdleIconRightImage = null;
			this.bunifuButton1.IndicateFocus = false;
			this.bunifuButton1.Location = new System.Drawing.Point(255, 195);
			this.bunifuButton1.Name = "bunifuButton1";
			this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.bunifuButton1.OnDisabledState.BorderRadius = 5;
			this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.bunifuButton1.OnDisabledState.BorderThickness = 1;
			this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.bunifuButton1.OnDisabledState.IconLeftImage = null;
			this.bunifuButton1.OnDisabledState.IconRightImage = null;
			this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.bunifuButton1.onHoverState.BorderRadius = 5;
			this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.bunifuButton1.onHoverState.BorderThickness = 1;
			this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.Blue;
			this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
			this.bunifuButton1.onHoverState.IconLeftImage = null;
			this.bunifuButton1.onHoverState.IconRightImage = null;
			this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Blue;
			this.bunifuButton1.OnIdleState.BorderRadius = 5;
			this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.bunifuButton1.OnIdleState.BorderThickness = 1;
			this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.Blue;
			this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.bunifuButton1.OnIdleState.IconLeftImage = null;
			this.bunifuButton1.OnIdleState.IconRightImage = null;
			this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.bunifuButton1.OnPressedState.BorderRadius = 5;
			this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.bunifuButton1.OnPressedState.BorderThickness = 1;
			this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.Navy;
			this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.bunifuButton1.OnPressedState.IconLeftImage = null;
			this.bunifuButton1.OnPressedState.IconRightImage = null;
			this.bunifuButton1.Size = new System.Drawing.Size(150, 39);
			this.bunifuButton1.TabIndex = 6;
			this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.bunifuButton1.TextMarginLeft = 0;
			this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
			this.bunifuButton1.UseDefaultRadiusAndThickness = true;
			this.bunifuButton1.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// YesNoDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(475, 255);
			this.Controls.Add(this.panelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "YesNoDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WarningDialog";
			this.bunifuPanel2.ResumeLayout(false);
			this.bunifuPanel2.PerformLayout();
			this.bunifuPanel1.ResumeLayout(false);
			this.bunifuPanel1.PerformLayout();
			this.panelMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
		private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
		private FontAwesome.Sharp.IconButton iconButton1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.UI.WinForms.BunifuPanel panelMain;
		private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
		private Bunifu.UI.WinForms.BunifuLabel txtMessage;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton bnnNo;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
	}
}