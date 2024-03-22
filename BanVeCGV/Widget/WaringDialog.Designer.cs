namespace BanVeCGV.Widget
{
	partial class WaringDialog
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaringDialog));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panelMain = new Bunifu.UI.WinForms.BunifuPanel();
			this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
			this.txtMessage = new Bunifu.UI.WinForms.BunifuLabel();
			this.btnOk = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
			this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.panelMain.SuspendLayout();
			this.bunifuPanel1.SuspendLayout();
			this.bunifuPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 10;
			this.bunifuElipse1.TargetControl = this;
			// 
			// panelMain
			// 
			this.panelMain.BackgroundColor = System.Drawing.Color.White;
			this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
			this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelMain.BorderColor = System.Drawing.Color.LightGray;
			this.panelMain.BorderRadius = 10;
			this.panelMain.BorderThickness = 1;
			this.panelMain.Controls.Add(this.bunifuPanel1);
			this.panelMain.Controls.Add(this.btnOk);
			this.panelMain.Controls.Add(this.btnCancel);
			this.panelMain.Controls.Add(this.bunifuPanel2);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 0);
			this.panelMain.Margin = new System.Windows.Forms.Padding(0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Padding = new System.Windows.Forms.Padding(5);
			this.panelMain.ShowBorders = true;
			this.panelMain.Size = new System.Drawing.Size(500, 275);
			this.panelMain.TabIndex = 0;
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
			this.bunifuPanel1.Location = new System.Drawing.Point(23, 64);
			this.bunifuPanel1.Name = "bunifuPanel1";
			this.bunifuPanel1.ShowBorders = true;
			this.bunifuPanel1.Size = new System.Drawing.Size(449, 132);
			this.bunifuPanel1.TabIndex = 4;
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
			this.txtMessage.Location = new System.Drawing.Point(179, 56);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtMessage.Size = new System.Drawing.Size(90, 21);
			this.txtMessage.TabIndex = 4;
			this.txtMessage.Text = "Thành công";
			this.txtMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtMessage.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// btnOk
			// 
			this.btnOk.AllowAnimations = true;
			this.btnOk.AllowMouseEffects = true;
			this.btnOk.AllowToggling = false;
			this.btnOk.AnimationSpeed = 200;
			this.btnOk.AutoGenerateColors = false;
			this.btnOk.AutoRoundBorders = false;
			this.btnOk.AutoSizeLeftIcon = true;
			this.btnOk.AutoSizeRightIcon = true;
			this.btnOk.BackColor = System.Drawing.Color.Transparent;
			this.btnOk.BackColor1 = System.Drawing.Color.DodgerBlue;
			this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
			this.btnOk.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnOk.ButtonText = "OK";
			this.btnOk.ButtonTextMarginLeft = 0;
			this.btnOk.ColorContrastOnClick = 45;
			this.btnOk.ColorContrastOnHover = 45;
			this.btnOk.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges1.BottomLeft = true;
			borderEdges1.BottomRight = true;
			borderEdges1.TopLeft = true;
			borderEdges1.TopRight = true;
			this.btnOk.CustomizableEdges = borderEdges1;
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnOk.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnOk.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnOk.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnOk.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnOk.ForeColor = System.Drawing.Color.White;
			this.btnOk.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOk.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.btnOk.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.btnOk.IconMarginLeft = 11;
			this.btnOk.IconPadding = 10;
			this.btnOk.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOk.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.btnOk.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.btnOk.IconSize = 25;
			this.btnOk.IdleBorderColor = System.Drawing.Color.DodgerBlue;
			this.btnOk.IdleBorderRadius = 1;
			this.btnOk.IdleBorderThickness = 1;
			this.btnOk.IdleFillColor = System.Drawing.Color.DodgerBlue;
			this.btnOk.IdleIconLeftImage = null;
			this.btnOk.IdleIconRightImage = null;
			this.btnOk.IndicateFocus = false;
			this.btnOk.Location = new System.Drawing.Point(275, 211);
			this.btnOk.Name = "btnOk";
			this.btnOk.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnOk.OnDisabledState.BorderRadius = 1;
			this.btnOk.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnOk.OnDisabledState.BorderThickness = 1;
			this.btnOk.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnOk.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnOk.OnDisabledState.IconLeftImage = null;
			this.btnOk.OnDisabledState.IconRightImage = null;
			this.btnOk.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnOk.onHoverState.BorderRadius = 1;
			this.btnOk.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnOk.onHoverState.BorderThickness = 1;
			this.btnOk.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnOk.onHoverState.ForeColor = System.Drawing.Color.White;
			this.btnOk.onHoverState.IconLeftImage = null;
			this.btnOk.onHoverState.IconRightImage = null;
			this.btnOk.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnOk.OnIdleState.BorderRadius = 1;
			this.btnOk.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnOk.OnIdleState.BorderThickness = 1;
			this.btnOk.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
			this.btnOk.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.btnOk.OnIdleState.IconLeftImage = null;
			this.btnOk.OnIdleState.IconRightImage = null;
			this.btnOk.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnOk.OnPressedState.BorderRadius = 1;
			this.btnOk.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnOk.OnPressedState.BorderThickness = 1;
			this.btnOk.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnOk.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.btnOk.OnPressedState.IconLeftImage = null;
			this.btnOk.OnPressedState.IconRightImage = null;
			this.btnOk.Size = new System.Drawing.Size(150, 39);
			this.btnOk.TabIndex = 3;
			this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnOk.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnOk.TextMarginLeft = 0;
			this.btnOk.TextPadding = new System.Windows.Forms.Padding(0);
			this.btnOk.UseDefaultRadiusAndThickness = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.AllowAnimations = true;
			this.btnCancel.AllowMouseEffects = true;
			this.btnCancel.AllowToggling = false;
			this.btnCancel.AnimationSpeed = 200;
			this.btnCancel.AutoGenerateColors = false;
			this.btnCancel.AutoRoundBorders = false;
			this.btnCancel.AutoSizeLeftIcon = true;
			this.btnCancel.AutoSizeRightIcon = true;
			this.btnCancel.BackColor = System.Drawing.Color.Transparent;
			this.btnCancel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
			this.btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
			this.btnCancel.ButtonText = "Thoát";
			this.btnCancel.ButtonTextMarginLeft = 0;
			this.btnCancel.ColorContrastOnClick = 45;
			this.btnCancel.ColorContrastOnHover = 45;
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges2.BottomLeft = true;
			borderEdges2.BottomRight = true;
			borderEdges2.TopLeft = true;
			borderEdges2.TopRight = true;
			this.btnCancel.CustomizableEdges = borderEdges2;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnCancel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnCancel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnCancel.ForeColor = System.Drawing.Color.Black;
			this.btnCancel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.btnCancel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.btnCancel.IconMarginLeft = 11;
			this.btnCancel.IconPadding = 10;
			this.btnCancel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.btnCancel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.btnCancel.IconSize = 25;
			this.btnCancel.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCancel.IdleBorderRadius = 1;
			this.btnCancel.IdleBorderThickness = 1;
			this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCancel.IdleIconLeftImage = null;
			this.btnCancel.IdleIconRightImage = null;
			this.btnCancel.IndicateFocus = false;
			this.btnCancel.Location = new System.Drawing.Point(63, 211);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnCancel.OnDisabledState.BorderRadius = 1;
			this.btnCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnCancel.OnDisabledState.BorderThickness = 1;
			this.btnCancel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnCancel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnCancel.OnDisabledState.IconLeftImage = null;
			this.btnCancel.OnDisabledState.IconRightImage = null;
			this.btnCancel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnCancel.onHoverState.BorderRadius = 1;
			this.btnCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnCancel.onHoverState.BorderThickness = 1;
			this.btnCancel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnCancel.onHoverState.ForeColor = System.Drawing.Color.White;
			this.btnCancel.onHoverState.IconLeftImage = null;
			this.btnCancel.onHoverState.IconRightImage = null;
			this.btnCancel.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCancel.OnIdleState.BorderRadius = 1;
			this.btnCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
			this.btnCancel.OnIdleState.BorderThickness = 1;
			this.btnCancel.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCancel.OnIdleState.ForeColor = System.Drawing.Color.Black;
			this.btnCancel.OnIdleState.IconLeftImage = null;
			this.btnCancel.OnIdleState.IconRightImage = null;
			this.btnCancel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnCancel.OnPressedState.BorderRadius = 1;
			this.btnCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnCancel.OnPressedState.BorderThickness = 1;
			this.btnCancel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.btnCancel.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.btnCancel.OnPressedState.IconLeftImage = null;
			this.btnCancel.OnPressedState.IconRightImage = null;
			this.btnCancel.Size = new System.Drawing.Size(150, 39);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnCancel.TextMarginLeft = 0;
			this.btnCancel.TextPadding = new System.Windows.Forms.Padding(0);
			this.btnCancel.UseDefaultRadiusAndThickness = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
			this.bunifuPanel2.Size = new System.Drawing.Size(490, 39);
			this.bunifuPanel2.TabIndex = 1;
			// 
			// bunifuLabel1
			// 
			this.bunifuLabel1.AllowParentOverrides = false;
			this.bunifuLabel1.AutoEllipsis = false;
			this.bunifuLabel1.CursorType = null;
			this.bunifuLabel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.bunifuLabel1.Location = new System.Drawing.Point(36, 0);
			this.bunifuLabel1.Name = "bunifuLabel1";
			this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bunifuLabel1.Size = new System.Drawing.Size(90, 21);
			this.bunifuLabel1.TabIndex = 3;
			this.bunifuLabel1.Text = "Thành công";
			this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// iconButton1
			// 
			this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
			this.iconButton1.FlatAppearance.BorderSize = 0;
			this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Bell;
			this.iconButton1.IconColor = System.Drawing.Color.Black;
			this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton1.IconSize = 32;
			this.iconButton1.Location = new System.Drawing.Point(0, 0);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Size = new System.Drawing.Size(36, 39);
			this.iconButton1.TabIndex = 0;
			this.iconButton1.UseVisualStyleBackColor = true;
			// 
			// WaringDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(500, 275);
			this.Controls.Add(this.panelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "WaringDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panelMain.ResumeLayout(false);
			this.bunifuPanel1.ResumeLayout(false);
			this.bunifuPanel1.PerformLayout();
			this.bunifuPanel2.ResumeLayout(false);
			this.bunifuPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.UI.WinForms.BunifuPanel panelMain;
		private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
		private FontAwesome.Sharp.IconButton iconButton1;
		private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOk;
		private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
		private Bunifu.UI.WinForms.BunifuLabel txtMessage;
	}
}
