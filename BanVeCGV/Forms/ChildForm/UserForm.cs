using BanVeCGV.Models;
using BanVeCGV.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeCGV.Forms.ChildForm
{
	public partial class UserForm : Form
	{
		private Users GetUsers;
		public UserForm(Models.Users users)
		{
			InitializeComponent();
			GetUsers = users;

			if (users.AccountType == 1) { InitAdmim(users); } else { InitUsers(users); }

		}

		private BindingSource BindingSource = new BindingSource();

		private void InitUsers(Users users)
		{
			BindingSource.DataSource = UserRepo.GetAll();

			dtgvUsers.DataSource = BindingSource;
			gbPass.Visible = false;

			dtgvUsers.Columns[0].HeaderText = "Mã nhân viên";
			dtgvUsers.Columns[1].HeaderText = "Tên nhân viên";
			dtgvUsers.Columns[2].HeaderText = "Email";
			dtgvUsers.Columns[3].Visible = false;
			dtgvUsers.Columns[3].HeaderText = "Mật khẩu";
			dtgvUsers.Columns[4].HeaderText = "Điện thoại";
			dtgvUsers.Columns[5].HeaderText = "Loại tài khoản";
			dtgvUsers.Columns[6].Visible = false;

			LoadBindingSource();

		}

		private void LoadBindingSource()
		{
			edtUserID.DataBindings.Add(new Binding("Text", dtgvUsers.DataSource, "UsId", true, DataSourceUpdateMode.Never));
			edtUserName.DataBindings.Add(new Binding("Text", dtgvUsers.DataSource, "UsName", true, DataSourceUpdateMode.Never));
			edtEmail.DataBindings.Add(new Binding("Text", dtgvUsers.DataSource, "Email", true, DataSourceUpdateMode.Never));
			edtPass.DataBindings.Add(new Binding("Text", dtgvUsers.DataSource, "Password", true, DataSourceUpdateMode.Never));
			edtPhone.DataBindings.Add(new Binding("Text", dtgvUsers.DataSource, "Phone", true, DataSourceUpdateMode.Never));
			edtAccounttype.DataBindings.Add(new Binding("Text", dtgvUsers.DataSource, "AccountType", true, DataSourceUpdateMode.Never));
		}

		private void InitAdmim(Users users)
		{
			BindingSource.DataSource = UserRepo.GetAll();

			dtgvUsers.DataSource = BindingSource;
			BindingSource.DataSource = UserRepo.GetAll();

			dtgvUsers.DataSource = BindingSource;

			dtgvUsers.Columns[0].HeaderText = "Mã nhân viên";
			dtgvUsers.Columns[1].HeaderText = "Tên nhân viên";
			dtgvUsers.Columns[2].HeaderText = "Email";
			dtgvUsers.Columns[3].Visible = true;
			dtgvUsers.Columns[3].HeaderText = "Mật khẩu";
			dtgvUsers.Columns[4].HeaderText = "Điện thoại";
			dtgvUsers.Columns[5].HeaderText = "Loại tài khoản";
			dtgvUsers.Columns[6].Visible = false;
			LoadBindingSource();
		}

		private void icChangePaass_Click(object sender, EventArgs e)
		{

		}

		private void btnAccouType_Click(object sender, EventArgs e)
		{

		}
	}
}
