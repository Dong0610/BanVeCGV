using BanVeCGV.Forms.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BanVeCGV.Forms
{
	public partial class MainForms : Form
	{
		public MainForms(Models.Users us)
		{
			InitializeComponent();
			this.MinimumSize = new System.Drawing.Size(1400, 850);

			OpenChildForm(new HomeForm());

		}
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);




		private void pnTitle_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}


		private void icMiniApp_Click(object sender, EventArgs e)
		{
		//	try
		//	{
		//		WindowState = FormWindowState.Minimized;
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}
		}

		private void icResizeApp_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Normal)
			{
				// Maximize the form to cover the working area (excluding taskbar)
				this.MaximumSize = GetTotalWorkingArea();
				this.WindowState = FormWindowState.Maximized;
			}
			else
			{
				// Restore to normal state
				this.WindowState = FormWindowState.Normal;
				this.MaximumSize = new Size(0, 0); // Reset the maximum size
			}
		}

		private Size GetTotalWorkingArea()
		{
			Rectangle bounds = new Rectangle();
			foreach (Screen screen in Screen.AllScreens)
			{
				bounds = Rectangle.Union(bounds, screen.WorkingArea);
			}
			return bounds.Size;
		}


		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		Form form = null;

		void OpenChildForm(Form childForm)
		{
			if (form != null)
			{
				form.Close();
			}
			form = childForm;
			form.TopLevel = false;
			form.FormBorderStyle = FormBorderStyle.None;
			form.Dock = DockStyle.Fill;
			pnMain.Controls.Add(form);
			form.Show();
		}


	}
}


