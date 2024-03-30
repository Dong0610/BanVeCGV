using BanVeCGV.Models;
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
	public partial class RowSelectTicket : UserControl
	{
		private TicketSelect Tickets;
		Action<TicketSelect> action;

		public RowSelectTicket(TicketSelect item, Action<TicketSelect> value)
		{
			InitializeComponent();
			Tickets = item;
			action = value;
			if(item!=null) { LoadToView(Tickets); }
			
		}

		private void LoadToView(TicketSelect tickets)
		{
			edtSoghe.Text= "Số ghế: "+tickets.SoGhe.ToString();
			txtMaVe.Text= "Mã vé: "+ tickets.Id.ToString();
			txtMaGiamGia.Text="Voucher: "+ tickets.MaGiamGia.ToString();
			txtGiaVe.Text="Giá: "+ tickets.GiaVe.ToString();
			edtGiamGiaVe.Text="Giảm giá: "+ tickets.GiaVeGiam.ToString();
		}

		private void tbLayout_Click(object sender, EventArgs e)
		{
			action.Invoke(Tickets);
		}
	}
}
