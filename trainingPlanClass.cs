using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnessProject.Classes
{
	public class trainingPlanClass
	{
		SqlConnection conn = new SqlConnection(connectionClass.connectionString);
		public bool manageTrainingPlans (int trainingPlanID,
			String trainingPlanName,String unit,Double rate, String remarks,int Mode)
		{
			try
			{
				bool result = false;
				String txtSql = "";
				if (Mode==1)
					txtSql=@"insert into trainingPlanTable
                    (trainingPlanName, unit,rate,remarks) values ( @trainingPlanName,@unit,@rate,@remarks)";
				if (Mode==2)
					txtSql=@"update trainingPlanTable set trainingPlanName=@trainingPlanName, 
                             unit=@unit,rate=@rate,remarks=@remarks where trainingPlanID=@trainingPlanID";
				if (Mode==3)
					txtSql=@"delete from TrainingPlanTable where trainingPlanID= @trainingPlanID";
				SqlCommand cmd = new SqlCommand(txtSql, conn);
				cmd.CommandType= CommandType.Text;
				cmd.Parameters.AddWithValue("@trainingPlanID", trainingPlanID);
				cmd.Parameters.AddWithValue("@trainingPlanName", trainingPlanName);
				cmd.Parameters.AddWithValue("@unit", unit);
				cmd.Parameters.AddWithValue("@rate", rate);
				cmd.Parameters.AddWithValue("@remarks", remarks);
				conn.Open();
				int rs = cmd.ExecuteNonQuery();
				conn.Close();
				if (rs>0)
					return true;
				else 
					return false;
				//return result;
			}
			catch (Exception ex )
			{

				throw ex;
			}

		}
		public DataTable getAllTrainingDetails()
		{
				DataTable dt = new DataTable();
			try
			{
				SqlCommand cmd = new SqlCommand("Select * from trainingPlanTable",conn);
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
