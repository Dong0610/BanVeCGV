﻿using BanVeCGV.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeCGV.Forms
{
	public partial class SignUpForm : Form
	{
		public SignUpForm()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnDangKi_Click(object sender, EventArgs e)
		{
			string name= edtName.Text.ToString();
			string email= edtEmail.Text.ToString();	
			string pass= edtPass.Text.ToString();
			if (CheckAllValue(name, email, pass))
			{

			}
			else
			{
				new ErrorDialog("Kiểm tra lại dữ liệu đầu vào").Show();
			}
		}

		private bool CheckAllValue(string name, string email, string pass)
		{
			return false;
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			this.Hide();
			new SignInForm().ShowDialog();
			this.Close();
		}
	}
}