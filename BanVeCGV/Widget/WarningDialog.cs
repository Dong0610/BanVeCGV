﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeCGV.Widget
{
	public partial class WarningDialog : Form
	{
		
		public WarningDialog(String mess)
		{
			InitializeComponent();
			
			txtMessage.Text = mess;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			this.Close();
		}



		public void Show(String mess, Action ev)
		{
			SuccessDialog dialog = new SuccessDialog(mess, ev);
			dialog.ShowDialog();
		}
	}
}