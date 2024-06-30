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
	public partial class dashboard : Form
	{
		public dashboard()
		{
			InitializeComponent();
			lblDateTime.Text = DateTime.Now.ToString();
			//display the training Plan name in combo box
			cmbTrainingPlan.DataSource = training.getAllTrainingDetails();
			cmbTrainingPlan.DisplayMember =  "trainingPlanName";
			cmbTrainingPlan.ValueMember = "trainingPlanID";
			cmbTrainingPlan.SelectedIndex= -1;

			//displaying all the customer information
			dgvCustomerDetails.DataSource = cc.customerList();
			dgvCustomerPlanDetails.DataSource = customerTraining.allTrainigPlan();
		}
		Classes.customerClass cc = new Classes.customerClass();
		Classes.customerTrainingPlan customerTraining = new Classes.customerTrainingPlan();
		Classes.trainingPlanClass training = new Classes.trainingPlanClass();

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblDateTime.Text = DateTime.Now.ToString();
		}

		private void usersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			userForm frm = new userForm();
			frm.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void customerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			customerForm frm = new customerForm();
			frm.Show();
		}

		private void dashboard_Load(object sender, EventArgs e)
		{
					}

		private void trainingPlansToolStripMenuItem_Click(object sender, EventArgs e)
		{
			trainingPlanForm frm = new trainingPlanForm();
			frm.Show();
		}

		private void customerTrainingPlansToolStripMenuItem_Click(object sender, EventArgs e)
		{
			customerTrainingPlan frm = new customerTrainingPlan();
			frm.Show();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvCustomerDetails_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dgvCustomerPlanDetails.DataSource=customerTraining.getTrainingPlansByCustomerID(int.Parse(dgvCustomerDetails.SelectedRows[0].Cells["customerID"].Value.ToString()));
		}

		private void txtCustomerName_TextChanged(object sender, EventArgs e)
		{
			dgvCustomerDetails.DataSource=cc.customerListByName(txtCustomerName.Text);
		}

		private void cmbTrainingPlan_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				dgvCustomerPlanDetails.DataSource=customerTraining.getTrainingDetailsByName(cmbTrainingPlan.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				
			}
		}

		private void dgvCustomerPlanDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
