using BanVeCGV.Forms.Items;
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

namespace BanVeCGV.Forms.ChildForm
{
	public partial class InvoicesForm : Form
	{
		private List<Invoices> GetInvoices;
		private BindingSource BindingSource = new BindingSource();
		private MainForms MainForms;
		Users GetUsers;

		public InvoicesForm(Users users)
		{
			InitializeComponent();

			GetInvoices = InvoiceRepo.GetAll().ToList();

			LoadToLayout(GetInvoices);
			GetUsers = users;
			btnCancelBill.Visible = GetUsers.AccountType == 1;


		}
		private Invoices inVoice;

		private void LoadDataToGridView(int id)
		{
			var data = DetailInvoiceRepo.GetByInvoiceId(id).ToList();
			ScreenId = TicketRepo.GetScreemIdByTicker(data[0].TicketId);
			BindingSource.DataSource = data;
			dtgvMovie.DataSource = BindingSource;
			dtgvMovie.Columns[0].Visible = false;
			dtgvMovie.Columns[1].HeaderText = "Mã vé";
			dtgvMovie.Columns[2].HeaderText = " Tên vé";
			dtgvMovie.Columns[3].HeaderText = "Số lượng";
			dtgvMovie.Columns[4].HeaderText = "Giá vé";
			dtgvMovie.Columns[5].Visible = false;
			dtgvMovie.Columns[6].Visible = false;
			double tongTien = 0;
			foreach (InvoiceDetails item in data)
			{
				tongTien += double.Parse(item.Price.ToString());
			}
			edtSumBill.Text = tongTien.ToString();
		}
		int ScreenId = 0;
		Invoices CurrentSelect = null;
		private void LoadToLayout(List<Invoices> getInvoices)
		{
			flistItemView.Controls.Clear();

			foreach (var item in getInvoices)
			{
				ItemBillSelet selet = new ItemBillSelet(item, (data) =>
				{
					CurrentSelect = data;
					LoadMoviewDetail(MovieRepo.GetModelById((int)data.MovieId));
					LoadDataToView(data);
					LoadDataToGridView(data.InvoiceId);

				});
				flistItemView.Controls.Add(selet);
				selet.Show();
			}
		}

		private void LoadMoviewDetail(Movies movies)
		{
			edtzMoviewName.Text = movies.Name;
			edtActor.Text = movies.Actor;
			edtDienVien.Text = movies.Director;
			edtDes.Text = movies.Descripion;
			edtToalMoney.Text = RevenueRepo.getTotalByMovies(movies.Id);
			edtCategory.Text = CategoryRepo.getNameById(movies.CategoryId);
		}


		private void LoadDataToView(Invoices invoices)
		{
			this.inVoice = invoices;
			edtBillId.Text = invoices.MovieId.ToString();
			edtUsname.Text = invoices.CustomerName;
			edtPhone.Text = invoices.CustomerPhome;
			edtUSCreate.Text = ((Users)UserRepo.getUserById(invoices.CreatUsId)).UsName.ToString();
			edtCreatTime.Text = invoices.CreatedTime.ToString();
		}

		private void btnThemVe_Click(object sender, EventArgs e)
		{
			new AddTicketToBill(inVoice, ScreenId, (data) =>
			{
				if (data != null)
				{
					new YesNoDialog("Bạn có xác nhận lưu lại dữ liệu này", (b) =>
					{
						if (b)
						{
							DetailInvoiceRepo.AddToData(inVoice, data);
							LoadDataToGridView(CurrentSelect.InvoiceId);
						}
					}).ShowDialog();
				}

			}).ShowDialog();
		}

		private void btnCancelBill_Click(object sender, EventArgs e)
		{

		}
	}
}
