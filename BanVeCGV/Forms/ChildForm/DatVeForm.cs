using BanVeCGV.Forms.Items;
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
	public partial class DatVeForm : Form
	{
		TimeScreening screenings;
		public DatVeForm(TimeScreening movies, Movies movies1)
		{
			InitializeComponent();
			screenings = movies;

			LoadDataToView(screenings);
		}

		private void LoadDataToView(TimeScreening screenings)
		{
            foreach (var item in TicketRepo.TicketByScreenID(screenings.Id))
            {
				RowItemTicket rowItem = new RowItemTicket(item,screenings, (data) =>{

				});
				
				flistItemView.Controls.Add(rowItem);
				rowItem.Show();
                
            };
		}

		private void bunifuLabel9_Click(object sender, EventArgs e)
		{

		}
	}
}
