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
	public partial class DoanhThuForm : Form
	{
		private BindingSource BindingSource= new BindingSource();
		public DoanhThuForm(Models.Users users)
		{
			InitializeComponent();

			LoadToGridView();
		}

		private void LoadToGridView()
		{
			BindingSource.DataSource= RevenueRepo.GetRenuveDetail();
			dtgvInvoices.DataSource = BindingSource;
			
		}
	}
}
