namespace BanVeCGV.Forms.ChildForm
{
	partial class HomeForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.listPnViewMovie = new System.Windows.Forms.FlowLayoutPanel();
			this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
			this.edtSearchKey = new Bunifu.UI.WinForms.BunifuTextBox();
			this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
			this.icReload = new FontAwesome.Sharp.IconButton();
			this.icSearch = new FontAwesome.Sharp.IconButton();
			this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
			this.dtgvMovie = new Bunifu.UI.WinForms.BunifuDataGridView();
			this.bunifuPanel1.SuspendLayout();
			this.bunifuPanel2.SuspendLayout();
			this.bunifuPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvMovie)).BeginInit();
			this.SuspendLayout();
			// 
			// listPnViewMovie
			// 
			this.listPnViewMovie.AutoScroll = true;
			this.listPnViewMovie.Dock = System.Windows.Forms.DockStyle.Top;
			this.listPnViewMovie.Location = new System.Drawing.Point(0, 0);
			this.listPnViewMovie.Margin = new System.Windows.Forms.Padding(0);
			this.listPnViewMovie.Name = "listPnViewMovie";
			this.listPnViewMovie.Size = new System.Drawing.Size(1175, 252);
			this.listPnViewMovie.TabIndex = 3;
			this.listPnViewMovie.WrapContents = false;
			this.listPnViewMovie.Paint += new System.Windows.Forms.PaintEventHandler(this.listPnViewMovie_Paint);
			// 
			// bunifuPanel1
			// 
			this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
			this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
			this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuPanel1.BorderColor = System.Drawing.Color.Gainsboro;
			this.bunifuPanel1.BorderRadius = 3;
			this.bunifuPanel1.BorderThickness = 1;
			this.bunifuPanel1.Controls.Add(this.listPnViewMovie);
			this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
			this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.bunifuPanel1.Name = "bunifuPanel1";
			this.bunifuPanel1.ShowBorders = true;
			this.bunifuPanel1.Size = new System.Drawing.Size(1175, 252);
			this.bunifuPanel1.TabIndex = 1;
			this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
			// 
			// edtSearchKey
			// 
			this.edtSearchKey.AcceptsReturn = false;
			this.edtSearchKey.AcceptsTab = false;
			this.edtSearchKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.edtSearchKey.AnimationSpeed = 200;
			this.edtSearchKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.edtSearchKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.edtSearchKey.BackColor = System.Drawing.Color.White;
			this.edtSearchKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edtSearchKey.BackgroundImage")));
			this.edtSearchKey.BorderColorActive = System.Drawing.Color.Blue;
			this.edtSearchKey.BorderColorDisabled = System.Drawing.Color.Silver;
			this.edtSearchKey.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.edtSearchKey.BorderColorIdle = System.Drawing.Color.Silver;
			this.edtSearchKey.BorderRadius = 5;
			this.edtSearchKey.BorderThickness = 1;
			this.edtSearchKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.edtSearchKey.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.edtSearchKey.DefaultFont = new System.Drawing.Font("Segoe UI", 11F);
			this.edtSearchKey.DefaultText = "";
			this.edtSearchKey.FillColor = System.Drawing.Color.White;
			this.edtSearchKey.HideSelection = true;
			this.edtSearchKey.IconLeft = null;
			this.edtSearchKey.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.edtSearchKey.IconPadding = 10;
			this.edtSearchKey.IconRight = null;
			this.edtSearchKey.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.edtSearchKey.Lines = new string[0];
			this.edtSearchKey.Location = new System.Drawing.Point(12, 16);
			this.edtSearchKey.MaxLength = 32767;
			this.edtSearchKey.MinimumSize = new System.Drawing.Size(1, 1);
			this.edtSearchKey.Modified = false;
			this.edtSearchKey.Multiline = false;
			this.edtSearchKey.Name = "edtSearchKey";
			stateProperties1.BorderColor = System.Drawing.Color.Blue;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.edtSearchKey.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.Silver;
			stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.edtSearchKey.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.edtSearchKey.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Silver;
			stateProperties4.FillColor = System.Drawing.Color.White;
			stateProperties4.ForeColor = System.Drawing.Color.Empty;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.edtSearchKey.OnIdleState = stateProperties4;
			this.edtSearchKey.Padding = new System.Windows.Forms.Padding(3);
			this.edtSearchKey.PasswordChar = '\0';
			this.edtSearchKey.PlaceholderForeColor = System.Drawing.Color.DimGray;
			this.edtSearchKey.PlaceholderText = "Tìm kiếm...";
			this.edtSearchKey.ReadOnly = false;
			this.edtSearchKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.edtSearchKey.SelectedText = "";
			this.edtSearchKey.SelectionLength = 0;
			this.edtSearchKey.SelectionStart = 0;
			this.edtSearchKey.ShortcutsEnabled = true;
			this.edtSearchKey.Size = new System.Drawing.Size(410, 40);
			this.edtSearchKey.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.edtSearchKey.TabIndex = 7;
			this.edtSearchKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.edtSearchKey.TextMarginBottom = 0;
			this.edtSearchKey.TextMarginLeft = 3;
			this.edtSearchKey.TextMarginTop = 0;
			this.edtSearchKey.TextPlaceholder = "Tìm kiếm...";
			this.edtSearchKey.UseSystemPasswordChar = false;
			this.edtSearchKey.WordWrap = true;
			this.edtSearchKey.TextChanged += new System.EventHandler(this.edtSearchKey_TextChanged);
			this.edtSearchKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtSearchKey_KeyDown);
			// 
			// bunifuPanel2
			// 
			this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
			this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
			this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuPanel2.BorderColor = System.Drawing.Color.Gainsboro;
			this.bunifuPanel2.BorderRadius = 3;
			this.bunifuPanel2.BorderThickness = 1;
			this.bunifuPanel2.Controls.Add(this.icReload);
			this.bunifuPanel2.Controls.Add(this.icSearch);
			this.bunifuPanel2.Controls.Add(this.edtSearchKey);
			this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.bunifuPanel2.Location = new System.Drawing.Point(0, 252);
			this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.bunifuPanel2.Name = "bunifuPanel2";
			this.bunifuPanel2.ShowBorders = true;
			this.bunifuPanel2.Size = new System.Drawing.Size(1175, 72);
			this.bunifuPanel2.TabIndex = 2;
			this.bunifuPanel2.Click += new System.EventHandler(this.bunifuPanel2_Click);
			// 
			// icReload
			// 
			this.icReload.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.icReload.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
			this.icReload.IconColor = System.Drawing.Color.Black;
			this.icReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.icReload.IconSize = 32;
			this.icReload.Location = new System.Drawing.Point(474, 16);
			this.icReload.Name = "icReload";
			this.icReload.Size = new System.Drawing.Size(40, 40);
			this.icReload.TabIndex = 9;
			this.icReload.UseVisualStyleBackColor = true;
			this.icReload.Click += new System.EventHandler(this.icReload_Click);
			// 
			// icSearch
			// 
			this.icSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.icSearch.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
			this.icSearch.IconColor = System.Drawing.Color.Black;
			this.icSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.icSearch.IconSize = 32;
			this.icSearch.Location = new System.Drawing.Point(428, 16);
			this.icSearch.Name = "icSearch";
			this.icSearch.Size = new System.Drawing.Size(40, 40);
			this.icSearch.TabIndex = 8;
			this.icSearch.UseVisualStyleBackColor = true;
			this.icSearch.Click += new System.EventHandler(this.icSearch_Click);
			// 
			// bunifuPanel3
			// 
			this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
			this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
			this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuPanel3.BorderColor = System.Drawing.Color.Silver;
			this.bunifuPanel3.BorderRadius = 4;
			this.bunifuPanel3.BorderThickness = 1;
			this.bunifuPanel3.Controls.Add(this.dtgvMovie);
			this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bunifuPanel3.Location = new System.Drawing.Point(0, 324);
			this.bunifuPanel3.Name = "bunifuPanel3";
			this.bunifuPanel3.Padding = new System.Windows.Forms.Padding(6);
			this.bunifuPanel3.ShowBorders = true;
			this.bunifuPanel3.Size = new System.Drawing.Size(1175, 490);
			this.bunifuPanel3.TabIndex = 3;
			// 
			// dtgvMovie
			// 
			this.dtgvMovie.AllowCustomTheming = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.dtgvMovie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dtgvMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgvMovie.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dtgvMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dtgvMovie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dtgvMovie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvMovie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dtgvMovie.ColumnHeadersHeight = 40;
			this.dtgvMovie.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
			this.dtgvMovie.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.dtgvMovie.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
			this.dtgvMovie.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
			this.dtgvMovie.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dtgvMovie.CurrentTheme.BackColor = System.Drawing.Color.DarkViolet;
			this.dtgvMovie.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
			this.dtgvMovie.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkViolet;
			this.dtgvMovie.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			this.dtgvMovie.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dtgvMovie.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(168)))));
			this.dtgvMovie.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dtgvMovie.CurrentTheme.Name = null;
			this.dtgvMovie.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
			this.dtgvMovie.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.dtgvMovie.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.dtgvMovie.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
			this.dtgvMovie.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtgvMovie.DefaultCellStyle = dataGridViewCellStyle3;
			this.dtgvMovie.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgvMovie.EnableHeadersVisualStyles = false;
			this.dtgvMovie.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
			this.dtgvMovie.HeaderBackColor = System.Drawing.Color.DarkViolet;
			this.dtgvMovie.HeaderBgColor = System.Drawing.Color.Empty;
			this.dtgvMovie.HeaderForeColor = System.Drawing.Color.White;
			this.dtgvMovie.Location = new System.Drawing.Point(6, 6);
			this.dtgvMovie.Margin = new System.Windows.Forms.Padding(10);
			this.dtgvMovie.Name = "dtgvMovie";
			this.dtgvMovie.ReadOnly = true;
			this.dtgvMovie.RowHeadersVisible = false;
			this.dtgvMovie.RowTemplate.Height = 40;
			this.dtgvMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgvMovie.Size = new System.Drawing.Size(1163, 478);
			this.dtgvMovie.TabIndex = 3;
			this.dtgvMovie.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkViolet;
			// 
			// HomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1175, 814);
			this.Controls.Add(this.bunifuPanel3);
			this.Controls.Add(this.bunifuPanel2);
			this.Controls.Add(this.bunifuPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "HomeForm";
			this.Text = "HomeForm";
			this.bunifuPanel1.ResumeLayout(false);
			this.bunifuPanel2.ResumeLayout(false);
			this.bunifuPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgvMovie)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel listPnViewMovie;
		private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
		private Bunifu.UI.WinForms.BunifuTextBox edtSearchKey;
		private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
		private FontAwesome.Sharp.IconButton icReload;
		private FontAwesome.Sharp.IconButton icSearch;
		private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
		private Bunifu.UI.WinForms.BunifuDataGridView dtgvMovie;
	}
}