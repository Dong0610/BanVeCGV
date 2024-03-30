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

namespace BanVeCGV.Forms.Items
{
	public partial class ItemBillSelet : UserControl
	{
		private Invoices Invoices;
		Action<Invoices> Action;
		public ItemBillSelet(Invoices invoices,Action<Invoices> iv)
		{
			InitializeComponent();
			this.Invoices = invoices;
			this.Action = iv;
			LoadDataToView(invoices);

		}

		private void LoadDataToView(Invoices invoices)
		{
			edtBillId.Text= invoices.MovieId.ToString();
			edtName.Text = invoices.CustomerName;
			edtPhone.Text = Invoices.CustomerPhome;
			edtUSCresate.Text= ((Users)UserRepo.getUserById(invoices.CreatUsId)).UsName.ToString();
			txtTimeCreate.Text= invoices.CreatedTime.ToString();
		}

		private void bunifuPanel1_Click(object sender, EventArgs e)
		{
			Action.Invoke(Invoices);
		}
	}
}
