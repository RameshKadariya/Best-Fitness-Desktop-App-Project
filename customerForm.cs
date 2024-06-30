using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace fitnessProject
{
	public partial class customerForm : Form
	{
		string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[0-zA-Z]{2,9})$";
		public customerForm()
		{
			InitializeComponent();
			dgvCustomerDetails.DataSource= cc.customerList();//Displaying the list of added customer on the form list
		}
		Classes.customerClass cc = new Classes.customerClass();

		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			try
			{
				bool result = cc.manageCustomers(customerID,
					txtCustomerName.Text,
					DateTime.Parse(dtpDOB.Text),
					txtAddress.Text,txtContact.Text,
					txtEmail.Text,
					int.Parse(txtCurrentWeight.Text),
					int.Parse(txtTargetWeight.Text),
					1);
				if (result == true)
				{
					MessageBox.Show("Customer has been successfully added to the list ");
					dgvCustomerDetails.DataSource= cc.customerList();
				}
				else
				{
					MessageBox.Show("Required operation cannot be performed with error");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}

			
		}
		int customerID = 0;
		private void dgvCustomerDetails_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			customerID = int.Parse(dgvCustomerDetails.SelectedRows[0].Cells["customerID"].Value.ToString());
			txtCustomerName.Text= dgvCustomerDetails.SelectedRows[0].Cells["customerName"].Value.ToString();
			dtpDOB.Text= dgvCustomerDetails.SelectedRows[0].Cells["DOB"].Value.ToString();
			txtAddress.Text= dgvCustomerDetails.SelectedRows[0].Cells["address"].Value.ToString();
			txtContact.Text= dgvCustomerDetails.SelectedRows[0].Cells["contact"].Value.ToString();
			txtEmail.Text= dgvCustomerDetails.SelectedRows[0].Cells["email"].Value.ToString();
			txtCurrentWeight.Text= dgvCustomerDetails.SelectedRows[0].Cells["currentWeight"].Value.ToString();
			txtTargetWeight.Text= dgvCustomerDetails.SelectedRows[0].Cells["targetWeight"].Value.ToString();
		}

		private void btnEditCustomer_Click(object sender, EventArgs e)
		{
			try
			{
				bool result = cc.manageCustomers(customerID,
					txtCustomerName.Text,
					DateTime.Parse(dtpDOB.Text),
					txtAddress.Text, txtContact.Text,
					txtEmail.Text,
					int.Parse(txtCurrentWeight.Text),
					int.Parse(txtTargetWeight.Text),
					2);
				if (result == true)
				{
					MessageBox.Show("Customer has been successfully updated to the list ");
					dgvCustomerDetails.DataSource= cc.customerList();
				}
				else
				{
					MessageBox.Show("Required operation cannot be performed with error");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void btnDeleteCustomer_Click(object sender, EventArgs e)
		{
			try
			{
				bool result = cc.manageCustomers(customerID,
					txtCustomerName.Text,
					DateTime.Parse(dtpDOB.Text),
					txtAddress.Text, txtContact.Text,
					txtEmail.Text,
					int.Parse(txtCurrentWeight.Text),
					int.Parse(txtTargetWeight.Text),
					3);
				if (result == true)
				{
					MessageBox.Show("Customer has been successfully deleted");
					dgvCustomerDetails.DataSource= cc.customerList();
				}
				else
				{
					MessageBox.Show("Required operation cannot be performed with error");
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

		private void customerForm_Load(object sender, EventArgs e)
		{

		}

		private void dtpDOB_ValueChanged(object sender, EventArgs e)
		{

			if (DateTime.Today.AddYears(-16)<dtpDOB.Value.Date)
			{
				MessageBox.Show("The minimum age required is 16", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dtpDOB.Focus();
				return;
			}
		}

		private void txtEmail_TextChanged(object sender, EventArgs e)
		{
			if (Regex.IsMatch(txtEmail.Text, pattern)== false)
			{
				MessageBox.Show("Invalid email over space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtEmail.Focus();
				return;
			}
		}


		private void txtCustomerName_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
