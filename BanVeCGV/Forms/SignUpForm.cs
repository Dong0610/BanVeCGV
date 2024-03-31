using BanVeCGV.Models;
using BanVeCGV.Repo;
using BanVeCGV.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
			string name = edtName.Text.ToString();
			string email = edtEmail.Text.ToString();
			string pass = edtPass.Text.ToString();
			if (CheckAllValue(name, email, pass))
			{
				if (TaiKhoanRepo.isResigter(name, email, pass))
				{
					TaiKhoan us= TaiKhoanRepo.LogginApp(email,pass);
					new SuccessDialog("Đăng kí tài khoản thành công", () =>
					{
						this.Hide();
						new MainForms(us).ShowDialog();
						this.Close();

					}).Show();
				}
			}
			else
			{
				new ErrorDialog("Kiểm tra lại dữ liệu đầu vào").Show();
			}
		}



		private bool CheckAllValue(string name, string email, string pass)
		{
			if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
			{
				return false;
			}

			if (!IsValidEmail(email))
			{
				return false;
			}

			return true;
		}

		private bool IsValidEmail(string email)
		{
			try
			{
				string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
				return Regex.IsMatch(email, pattern);
			}
			catch (RegexMatchTimeoutException)
			{
				return false;
			}
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			this.Hide();
			new SignInForm().ShowDialog();
			this.Close();
		}
	}
}
