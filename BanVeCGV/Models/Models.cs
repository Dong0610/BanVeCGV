using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeCGV.Models
{



	public class Users
	{
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Phone { get; set; }
		public int AccountType { get; set; }

		public Users(int userID, string userName, string email, string password, string phone, int accountType)
		{
			UserID = userID;
			UserName = userName;
			Email = email;
			Password = password;
			Phone = phone;
			AccountType = accountType;
		}

		public Users(DataRow row)
		{
			if (row == null)
				throw new ArgumentNullException(nameof(row));

			UserID = Convert.ToInt32(row["UserID"]);
			UserName = Convert.ToString(row["UserName"]);
			Email = Convert.ToString(row["Email"]);
			Password = Convert.ToString(row["Password"]);
			Phone = Convert.ToString(row["Phone"]);
			AccountType = Convert.ToInt32(row["AccountType"]);
		}

		public Users()
		{
		}
	}


	public class Movie
	{
		public int MovieID { get; set; }
		public string MovieName { get; set; }
		public string Genre { get; set; }
		public string Director { get; set; }
		public string Actors { get; set; }
		public string Description { get; set; }
		public string TrailerLink { get; set; }

		// Constructor to create a Movie object from a DataRow
		public Movie(DataRow row)
		{
			if (row == null)
				throw new ArgumentNullException(nameof(row));

			MovieID = Convert.ToInt32(row["MovieID"]);
			MovieName = Convert.ToString(row["MovieName"]);
			Genre = Convert.ToString(row["Genre"]);
			Director = Convert.ToString(row["Director"]);
			Actors = Convert.ToString(row["Actors"]);
			Description = Convert.ToString(row["Description"]);
			TrailerLink = Convert.ToString(row["TrailerLink"]);
		}

		public Movie(int movieID, string movieName, string genre, string director, string actors, string description, string trailerLink)
		{
			MovieID = movieID;
			MovieName = movieName;
			Genre = genre;
			Director = director;
			Actors = actors;
			Description = description;
			TrailerLink = trailerLink;
		}
	}

	public class Screening
	{
		public int ScreeningID { get; set; }
		public int MovieID { get; set; }
		public string Room { get; set; }
		public string DateTime { get; set; }
		public int RemainingSeats { get; set; }

		public Screening(int screeningID, int movieID, string room, string dateTime, int remainingSeats)
		{
			ScreeningID = screeningID;
			MovieID = movieID;
			Room = room;
			DateTime = dateTime;
			RemainingSeats = remainingSeats;
		}

		public Screening(DataRow row)
		{
			if (row == null)
				throw new ArgumentNullException(nameof(row));

			ScreeningID = Convert.ToInt32(row["ScreeningID"]);
			MovieID = Convert.ToInt32(row["MovieID"]);
			Room = Convert.ToString(row["Room"]);
			DateTime = Convert.ToString(row["string"]);
			RemainingSeats = Convert.ToInt32(row["RemainingSeats"]);
		}
	}

	public class Ticket
	{
		public int TicketID { get; set; }
		public int ScreeningID { get; set; }
		public int UserID { get; set; }
		public string SeatNumber { get; set; }
		public int Status { get; set; }

		public Ticket(int ticketID, int screeningID, int userID, string seatNumber, int status)
		{
			TicketID = ticketID;
			ScreeningID = screeningID;
			UserID = userID;
			SeatNumber = seatNumber;
			Status = status;
		}

		// Constructor to create a Ticket object from a DataRow
		public Ticket(DataRow row)
		{
			if (row == null)
				throw new ArgumentNullException(nameof(row));

			TicketID = Convert.ToInt32(row["TicketID"]);
			ScreeningID = Convert.ToInt32(row["ScreeningID"]);
			UserID = Convert.ToInt32(row["UserID"]);
			SeatNumber = Convert.ToString(row["SeatNumber"]);
			Status = Convert.ToInt32(row["Status"]);
		}
	}

	public class Invoice
	{
		public int InvoiceID { get; set; }
		public int UserID { get; set; }
		public string CustomerName { get; set; }
		public string CustomerPhone { get; set; }
		public decimal TotalAmount { get; set; }
		public string CreatedTime { get; set; }

		// Constructor from DataRow
		public Invoice(DataRow row)
		{
			if (row == null)
				throw new ArgumentNullException(nameof(row));

			InvoiceID = Convert.ToInt32(row["InvoiceID"]);
			UserID = Convert.ToInt32(row["UserID"]);
			CustomerName = row["CustomerName"].ToString();
			CustomerPhone = row["CustomerPhone"].ToString();
			TotalAmount = Convert.ToDecimal(row["TotalAmount"]);
			CreatedTime = Convert.ToString(row["CreatedTime"]);
		}

		// Constructor for creating new Invoice objects
		public Invoice(int invoiceID, int userID, string customerName, string customerPhone, decimal totalAmount, string createdTime)
		{
			InvoiceID = invoiceID;
			UserID = userID;
			CustomerName = customerName;
			CustomerPhone = customerPhone;
			TotalAmount = totalAmount;
			CreatedTime = createdTime;
		}
	}

	public class InvoiceDetail
	{
		public int InvoiceDetailID { get; set; }
		public int InvoiceID { get; set; }
		public int TicketID { get; set; }
		public string ItemName { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }

		public InvoiceDetail(int invoiceDetailID, int invoiceID, int ticketID, string itemName, int quantity, decimal price)
		{
			InvoiceDetailID = invoiceDetailID;
			InvoiceID = invoiceID;
			TicketID = ticketID;
			ItemName = itemName;
			Quantity = quantity;
			Price = price;
		}

		// Constructor to create an InvoiceDetail object from a DataRow
		public InvoiceDetail(DataRow row)
		{
			if (row == null)
				throw new ArgumentNullException(nameof(row));

			InvoiceDetailID = Convert.ToInt32(row["InvoiceDetailID"]);
			InvoiceID = Convert.ToInt32(row["InvoiceID"]);
			TicketID = Convert.ToInt32(row["TicketID"]);
			ItemName = Convert.ToString(row["ItemName"]);
			Quantity = Convert.ToInt32(row["Quantity"]);
			Price = Convert.ToDecimal(row["Price"]);
		}
	}



}
