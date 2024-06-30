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
	public partial class trainingPlanForm : Form
	{
		public trainingPlanForm()
		{
			InitializeComponent();
			dgvTrainingPlans.DataSource = tpc.getAllTrainingDetails();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		Classes.trainingPlanClass tpc = new Classes.trainingPlanClass();
		int trainingPlanID =0;
		private void btnCreate_Click(object sender, EventArgs e)
		{
			try
			{
				bool rs = tpc.manageTrainingPlans(trainingPlanID,
					txtTrainingPlanName.Text, 
					cmbUnitName.Text, 
					Double.Parse(txtRate.Text), 
					txtRemarks.Text,1);
				 if (rs==true)
				{
					MessageBox.Show("TrainingPlans Created Successfully");
					dgvTrainingPlans.DataSource = tpc.getAllTrainingDetails();
				}
				 else
				{
					MessageBox.Show("Error while performing Operation.");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			try
			{
				bool rs = tpc.manageTrainingPlans(trainingPlanID,
					txtTrainingPlanName.Text,
					cmbUnitName.Text,
					Double.Parse(txtRate.Text),
					txtRemarks.Text, 2);
				if (rs==true)
				{
					MessageBox.Show("TrainingPlans updated Successfully");
					dgvTrainingPlans.DataSource = tpc.getAllTrainingDetails();
				}
				else
				{
					MessageBox.Show("Error while performing Operation.");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void dgvTrainingPlans_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
					
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				bool rs = tpc.manageTrainingPlans(trainingPlanID,
					txtTrainingPlanName.Text,
					cmbUnitName.Text,
					Double.Parse(txtRate.Text),
					txtRemarks.Text, 3);
				if (rs==true)
				{
					MessageBox.Show("TrainingPlans deleted Successfully");
					dgvTrainingPlans.DataSource = tpc.getAllTrainingDetails();
				}
				else
				{
					MessageBox.Show("Error while performing Operation.");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void dgvTrainingPlans_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			{
				trainingPlanID =int.Parse(dgvTrainingPlans.SelectedRows[0].Cells["trainingPlanID"].Value.ToString());
				txtTrainingPlanName.Text =dgvTrainingPlans.SelectedRows[0].Cells["trainingPlanName"].Value.ToString();
				cmbUnitName.Text =dgvTrainingPlans.SelectedRows[0].Cells["unit"].Value.ToString();
				txtRate.Text =dgvTrainingPlans.SelectedRows[0].Cells["rate"].Value.ToString();
				txtRemarks.Text =dgvTrainingPlans.SelectedRows[0].Cells["remarks"].Value.ToString();
			}
		}

		private void txtTrainingPlanName_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
