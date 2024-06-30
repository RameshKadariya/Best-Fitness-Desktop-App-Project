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
	public partial class userForm : Form
	{
		public userForm()
		{
			InitializeComponent();
			dgvUsers.DataSource = uc.userList();
		}
		int userId;
		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
		Classes.userClass uc = new Classes.userClass();
		private void btnCreateUser_Click(object sender, EventArgs e)
		{
			
			
			if (txtUserName.Text==""|| txtPassword.Text==""|| txtConfirmPassword.Text=="")
			{
				MessageBox.Show("The fields can not be left empty!");
				txtUserName.Focus();
			}
			else if (txtPassword.Text!=txtConfirmPassword.Text)
			{
				MessageBox.Show("Password donot match");
				txtPassword.Clear();
				txtConfirmPassword.Clear();
				txtUserName.Focus();
			}
			else
			{
				createUser();
			}
		}
		
		public void createUser()
		{
			try
			{
				bool r = uc.manageUsers(0, txtUserName.Text, txtPassword.Text, 1);
				if (r==true)
				{
					MessageBox.Show("User Added Successfully");
					dgvUsers.DataSource = uc.userList();
				}
				else
				{
					MessageBox.Show("Error while performing the required operation");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}
		private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			userId = int.Parse(dgvUsers.SelectedRows[0].Cells["userId"].Value.ToString());
			txtUserName.Text = dgvUsers.SelectedRows[0].Cells["userName"].Value.ToString();
			txtPassword.Text=dgvUsers.SelectedRows[0].Cells["password"].Value.ToString();
			txtConfirmPassword.Text= dgvUsers.SelectedRows[0].Cells["password"].Value.ToString();
		}

		private void btnDeleteUser_Click(object sender, EventArgs e)
		{
			
		}
		

		private void btnEditUser_Click_1(object sender, EventArgs e)
		{
			try
			{
				bool r = uc.manageUsers(userId, txtUserName.Text, txtPassword.Text, 2);
				if (r==true)
				{
					MessageBox.Show("User name updated");
					dgvUsers.DataSource = uc.userList();
				}
				else
				{
					MessageBox.Show("Error while performing the required operation");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void btnDeleteUser_Click_1(object sender, EventArgs e)
		{
			try
			{
				bool r = uc.manageUsers(userId, txtUserName.Text, txtPassword.Text, 3);
				if (r==true)
				{
					MessageBox.Show("User name deleted");
					dgvUsers.DataSource = uc.userList();
				}
				else
				{
					MessageBox.Show("Error while performing the required operation");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
