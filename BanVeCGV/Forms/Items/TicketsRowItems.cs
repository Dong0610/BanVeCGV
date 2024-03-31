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
	public partial class TicketsRowItems : Form
	{
		private DsVeBySuatChieu suatChieu;
		Action<DsVeBySuatChieu> Action;
		public TicketsRowItems(Models.DsVeBySuatChieu item, Action<DsVeBySuatChieu> value)
		{
			InitializeComponent();
			this.suatChieu = item;
			this.Action = value;
			LoadToView(suatChieu );

		}

		private void LoadToView(DsVeBySuatChieu suatChieu)
		{
			edtDge.Text = suatChieu.TenGhe ;
			edtMax.Text=suatChieu.VeId.ToString();
			edtNgTao.Text = suatChieu.HoTen;
			edtThanhTien.Text = suatChieu.TongTien.ToString();
			edtPhong.Text= suatChieu.TenPhong.ToString();
		}

		private void TicketsRowItems_Load(object sender, EventArgs e)
		{

		}

		private void SelectSC(object sender, EventArgs e)
		{
			Action.Invoke(suatChieu);
		}

		private void bunifuPanel1_Click(object sender, EventArgs e)
		{

		}
	}
}
