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

namespace BanVeCGV.Widget
{
	public partial class ErrorDialog :Form
	{
		
		public ErrorDialog(String mess)
		{
			InitializeComponent();
			txtMessage.Text = mess;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			
			this.Close();
		}
	}
}
