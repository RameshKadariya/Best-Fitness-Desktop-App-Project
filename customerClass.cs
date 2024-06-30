using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace fitnessProject.Classes
{
	public class customerClass
	{
		SqlConnection conn = new SqlConnection(connectionClass.connectionString);
		public bool manageCustomers (int customerID, String customerName,DateTime DOB, String address,String contact,
			String email, int currentWeight, int targetWeight, int Mode)
		{
			bool result = false;
			try
			{
				String txtSql = "";
				if (Mode == 1)
					txtSql =@"insert into customerTable 
                    (customerName,DOB,address,contact,email,currentWeight,targetWeight)  
                     values(@customerName,@DOB,@address,@contact, @email,@currentWeight,@targetWeight)";
				if (Mode ==2)
					txtSql =@"update customerTable set customerName=@customerName, 
                                     DOB=@DOB, 
                                     address=@address,
                                     contact=@contact, 
                                     email=@email,
						             currentWeight=@currentWeight,
                                     targetWeight=@targetWeight where customerID = @customerID";
				if (Mode == 3)
					txtSql = @"Delete From customerTable where customerID=@customerID";
				SqlCommand cmd = new SqlCommand(txtSql, conn);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@customerID", customerID);
				cmd.Parameters.AddWithValue("@customerName", customerName);
				cmd.Parameters.AddWithValue("@DOB", DOB);
				cmd.Parameters.AddWithValue("@address", address);
				cmd.Parameters.AddWithValue("@contact", contact);
				cmd.Parameters.AddWithValue("@email", email);
				cmd.Parameters.AddWithValue("@currentWeight", currentWeight);
				cmd.Parameters.AddWithValue("@targetWeight", targetWeight);
				conn.Open();
				int r = cmd.ExecuteNonQuery();
				conn.Close();
				if (r>0)
					result = true;
				else
					result = false;

				

			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				conn.Close();
			}
			return result;
		}
		public DataTable customerList()
		{
			DataTable dt = new DataTable();
			
			try
			{
				SqlCommand cmd = new SqlCommand("Select * from customerTable", conn);
				conn.Open();
				SqlDataReader dr = cmd.ExecuteReader();
				dt.Load(dr);
				conn.Close();
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally { conn.Close(); }
			return dt;
		}
		public DataTable customerListByName(String customerName)
		{
			DataTable dt = new DataTable();

			try
			{
				SqlCommand cmd = new SqlCommand(@"Select * from customerTable where customerName like '%' + @customerName + '%' ", conn);
				cmd.Parameters.AddWithValue("@customerName",customerName);
				conn.Open();
				SqlDataReader dr = cmd.ExecuteReader();
				dt.Load(dr);
				conn.Close();
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally { conn.Close(); }
			return dt;
		}


	}
}
