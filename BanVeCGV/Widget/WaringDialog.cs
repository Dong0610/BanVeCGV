﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeCGV.Interface;

namespace BanVeCGV.Widget
{
	public partial class WaringDialog :Form
	{
		private Action okAction;

		public WaringDialog(String mess,Action ok)
		{
			InitializeComponent();
			this.okAction = ok;
			txtMessage.Text = mess;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			okAction.Invoke();
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public  void Show(String mess,Action ev)
		{
			WaringDialog dialog = new WaringDialog(mess,ev);
			dialog.ShowDialog();
		}
	}
}
