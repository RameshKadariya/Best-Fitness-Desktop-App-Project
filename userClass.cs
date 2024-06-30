using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace fitnessProject.Classes
{
	public class userClass
	{
		SqlConnection conn = new SqlConnection(connectionClass.connectionString);
		public bool manageUsers(int userID,String userName,String password,int Mode)
		{
			bool result = false;
			try
			{
				String txtSql = "";
				if (Mode ==1)
				{
					txtSql = @"insert into userTable(userName,password)
                     values(@userName,@password)";

				}
				if (Mode ==2)
				{
					txtSql=@"update userTable set userName=@userName,
                password=@password where userID=@userID";
				}
				if (Mode ==3)
				{
					txtSql=@"delete from userTable where userID=@userID";
                          
				}
				SqlCommand cmd = new SqlCommand(txtSql, conn);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@userID", userID);
				cmd.Parameters.AddWithValue("@userName",userName);
				cmd.Parameters.AddWithValue("@password", password);
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
			finally{ conn.Close(); }
			return result;
		}
		public DataTable userList()
		{
			DataTable dt = new DataTable();
			try
			{
				SqlCommand cmd = new SqlCommand("Select * from userTable", conn);
				conn.Open();
				SqlDataReader dr = cmd.ExecuteReader();
				dt.Load(dr);
				conn.Close();
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally{ conn.Close(); }
			return dt;
		}
		public bool login (String userName, String password)
		{
			try
			{
				bool rs = false;
				DataTable dt = new DataTable();
				SqlCommand cmd = new SqlCommand(@"Select * from userTable where userName = @userName and password = @password", conn);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@userName", userName);
				cmd.Parameters.AddWithValue("@password", password);
				conn.Open();
				SqlDataReader dr = cmd.ExecuteReader();
				dt.Load(dr);
				conn.Close() ;
				if (dt.Rows.Count>0)
					rs = true;
				else rs= false;
				return rs;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally { conn.Close(); }
		}
	}
}
