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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Classes.userClass uc = new Classes.userClass();
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool rs = uc.login(txtUserName.Text, txtPassword.Text);
				if (rs==true)
				{
					dashboard frm = new dashboard();
					frm.Show();
				}
				else
				{
					txtUserName.Clear();
					txtPassword.Clear();
					txtUserName.Focus();
					MessageBox.Show("Invalid Login Credentials. Please try with correct username or password");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Are you sure to exit",
				"Confirm exit",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			if (dr== DialogResult.Yes)
			{
				Close();
			}
			else
				return;
			

			
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
