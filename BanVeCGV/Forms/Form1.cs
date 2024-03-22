using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeCGV.Interface;
using BanVeCGV.Widget;
namespace BanVeCGV
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SuccessDialog dialog = new SuccessDialog("Bạn có muốn thoát không", () =>
			{


			});
			dialog.ShowDialog();
		}
	}
}
