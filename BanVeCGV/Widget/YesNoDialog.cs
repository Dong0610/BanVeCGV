using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeCGV.Widget
{
	public partial class YesNoDialog : Form
	{
		Action<Boolean> Action= null;
		public YesNoDialog(String mess, Action<Boolean> action)
		{
			InitializeComponent();
			this.Action = action;
			txtMessage.Text = mess;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Action.Invoke(true);
			this.Close();
		}



		public void Show(String mess, Action ev)
		{
			SuccessDialog dialog = new SuccessDialog(mess, ev);
			dialog.ShowDialog();
		}

		private void bnnNo_Click(object sender, EventArgs e)
		{
			Action.Invoke(false);
			this.Close();
		}
	}
}
