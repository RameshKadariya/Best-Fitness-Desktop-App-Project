using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnessProject
{
	public partial class customerTrainingPlan : Form
	{
		public customerTrainingPlan()
		{
			InitializeComponent();
			dgvCustomerDetails.DataSource= cc.customerList();//display all customer in form load
			cmbPlanName.DataSource= tpc.getAllTrainingDetails();//get all training plan
			cmbPlanName.DisplayMember="trainingPlanName";//displaying on the combobox
			cmbPlanName.ValueMember="trainingPlanID";//store in database
			cmbPlanName.SelectedIndex=-1; ;//wedonot want to show any data by default
			dgvSelectedPlanDetails.DataSource=ctp.allTrainigPlan();// display all the value of trainingPlan   
		}
		Classes.customerClass cc = new Classes.customerClass();
		Classes.trainingPlanClass tpc = new Classes.trainingPlanClass();
		Classes.customerTrainingPlan ctp = new Classes.customerTrainingPlan();
		int ID = 0;
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) 
		{

		}

		private void txtCustomerName_TextChanged(object sender, EventArgs e)
		{
			try
			{
				dgvCustomerDetails.DataSource= cc.customerListByName(txtCustomerName.Text);
			}
			catch (Exception)
			{

				
			}
		}

		private void dgvCustomerDetails_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtCustomerName.Text=dgvCustomerDetails.SelectedRows[0].Cells["customerName"].Value.ToString();
			lblCustomerID.Text=dgvCustomerDetails.SelectedRows[0].Cells["customerID"].Value.ToString();
			dgvSelectedPlanDetails.DataSource=ctp.getTrainingPlansByCustomerID(int.Parse(lblCustomerID.Text));
		}

		private void btnAddPlan_Click(object sender, EventArgs e)
		{
			try
			{
				bool rs = ctp.manageCustomerTrainingPlan(ID,
					int.Parse(lblCustomerID.Text),
					int.Parse(cmbPlanName.SelectedValue.ToString()),
					int.Parse(txtUnits.Text), txtRemarks.Text, 1);
				if (rs==true)
				{
					MessageBox.Show("Customer Plan Successfully selected");
					dgvSelectedPlanDetails.DataSource=ctp.getTrainingPlansByCustomerID(int.Parse(lblCustomerID.Text));
				}
				else
				{
					MessageBox.Show("Error in performing the required operation");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void btnEditPlan_Click(object sender, EventArgs e)
		{
			try
			{
				bool rs = ctp.manageCustomerTrainingPlan(ID,
					int.Parse(lblCustomerID.Text),
					int.Parse(cmbPlanName.SelectedValue.ToString()),
					int.Parse(txtUnits.Text), txtRemarks.Text, 2);
				if (rs==true)
				{
					MessageBox.Show("Customer Plan Deleted Sucessfully");
					dgvSelectedPlanDetails.DataSource=ctp.getTrainingPlansByCustomerID(int.Parse(lblCustomerID.Text));
				}
				else
				{
					MessageBox.Show("Error in performing the required operation");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void btnDeletePlan_Click(object sender, EventArgs e)
		{
			try
			{
				bool rs = ctp.manageCustomerTrainingPlan(ID,
					int.Parse(lblCustomerID.Text),
					int.Parse(cmbPlanName.SelectedValue.ToString()),
					int.Parse(txtUnits.Text), txtRemarks.Text, 3);
				if (rs==true)
				{
					MessageBox.Show("Customer Plan Deleted Successfully");
					dgvSelectedPlanDetails.DataSource=ctp.getTrainingPlansByCustomerID(int.Parse(lblCustomerID.Text));
				}
				else
				{
					MessageBox.Show("Error in performing the required operation");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void dgvSelectedPlanDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvSelectedPlanDetails_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ID=int.Parse(dgvSelectedPlanDetails.SelectedRows[0].Cells["ID"].Value.ToString());
			cmbPlanName.Text= dgvSelectedPlanDetails.SelectedRows[0].Cells["trainingPlanName"].Value.ToString();
			txtUnits.Text= dgvSelectedPlanDetails.SelectedRows[0].Cells["units"].Value.ToString();
			txtRemarks.Text= dgvSelectedPlanDetails.SelectedRows[0].Cells["remarks"].Value.ToString();
		}

		private void lblCustomerID_Click(object sender, EventArgs e)
		{

		}
	}
}
