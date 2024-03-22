using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeCGV.Models;
using System.Windows.Markup;

namespace BanVeCGV.Database
{
	internal class DBInstance
	{


		private static DBInstance instance;

		public String sqlString = @"Data Source=DongDong\sqlexpress;Initial Catalog=QuanlibanveCGV;Integrated Security=True";
		
		public static DBInstance Instance
		{
			get { if (instance == null) instance = new DBInstance(); return instance; }
			private set { instance = value; }
		}



		public DataTable ExcuteQuery(String query, object[] parameter = null)
		{
			DataTable data = new DataTable();
			using (SqlConnection connection = new SqlConnection(sqlString))
			{
				connection.Open();
				SqlCommand sqlCommand = new SqlCommand(query, connection);
				if (parameter != null)
				{
					String[] listParam = query.Split(' ');
					int i = 0;
					foreach (String param in listParam)
					{
						if (param.Contains('@'))
						{
							sqlCommand.Parameters.Add(param, parameter[i]);
							i++;
						}
					}
				}


				SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
				adapter.Fill(data);

				connection.Close();
			}
			return data;
		}

		public int ExcuteNoneQuery(String query, object[] parameter = null)
		{
			int data = 0;
			using (SqlConnection connection = new SqlConnection(sqlString))
			{
				connection.Open();
				SqlCommand sqlCommand = new SqlCommand(query, connection);
				if (parameter != null)
				{
					String[] listParam = query.Split(' ');
					int i = 0;
					foreach (String param in listParam)
					{
						if (param.Contains('@'))
						{
							sqlCommand.Parameters.Add(param, parameter[i]);
							i++;
						}
					}
				}

				data = sqlCommand.ExecuteNonQuery();

				connection.Close();
			}
			return data;
		}
		public object ExcuteScalar(string query, object[] parameter = null)
		{
			object data = new object();
			using (SqlConnection connection = new SqlConnection(sqlString))
			{
				connection.Open();
				SqlCommand sqlCommand = new SqlCommand(query, connection);
				if (parameter != null)
				{
					String[] listParam = query.Split(' ');
					int i = 0;
					foreach (String param in listParam)
					{
						if (param.Contains('@'))
						{
							sqlCommand.Parameters.Add(param, parameter[i]);
							i++;
						}
					}
				}
				data = sqlCommand.ExecuteScalar();

				connection.Close();
			}
			return data;

		}

		public SqlDataAdapter ExportReport(string query)
		{
			SqlDataAdapter adapter;
			using (SqlConnection connection = new SqlConnection(sqlString))
			{
				connection.Open();
				adapter = new SqlDataAdapter(query, connection);
				connection.Close();
			}
			return adapter;
		}

	}
}


