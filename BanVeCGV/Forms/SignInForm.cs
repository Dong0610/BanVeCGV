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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeCGV.Forms
{
	public partial class SignInForm : Form
	{
		public SignInForm()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnDangKi_Click(object sender, EventArgs e)
		{
			this.Hide();
			new SignUpForm().ShowDialog();
			this.Close();
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			Users us =   UserRepo.LogginApp(edtEmail.Text.ToString(), edtPass.Text.ToString());
			if (us!=null)
			{
				new SuccessDialog("Đăng nhập thành công", () =>
				{
					this.Hide();
					new MainForms(us).ShowDialog();
					this.Close();
				}).ShowDialog();
			}
			else
			{
				new ErrorDialog("Tài khoản không tồn tại hoặc sai mật khẩu").ShowDialog();
			}

		}
	}
}
