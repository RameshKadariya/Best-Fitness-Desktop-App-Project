﻿namespace fitnessProject
{
	partial class userForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		//private void GetV()
		//{
		//	return this.btnEditUser.Click += new System.EventHandler(this.btnEditUser);
		//}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnDeleteUser = new System.Windows.Forms.Button();
			this.btnEditUser = new System.Windows.Forms.Button();
			this.btnCreateUser = new System.Windows.Forms.Button();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvUsers = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(49, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(726, 57);
			this.label1.TabIndex = 0;
			this.label1.Text = "USER MANAGEMENT FORM";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(827, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(121, 110);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnClose);
			this.groupBox1.Controls.Add(this.btnDeleteUser);
			this.groupBox1.Controls.Add(this.btnEditUser);
			this.groupBox1.Controls.Add(this.btnCreateUser);
			this.groupBox1.Controls.Add(this.txtConfirmPassword);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.txtUserName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(40, 72);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(726, 287);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Please make sure to fill all credentials";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Red;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(564, 214);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(111, 62);
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnDeleteUser
			// 
			this.btnDeleteUser.BackColor = System.Drawing.Color.Yellow;
			this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteUser.Location = new System.Drawing.Point(371, 214);
			this.btnDeleteUser.Name = "btnDeleteUser";
			this.btnDeleteUser.Size = new System.Drawing.Size(132, 62);
			this.btnDeleteUser.TabIndex = 9;
			this.btnDeleteUser.Text = "Delete User";
			this.btnDeleteUser.UseVisualStyleBackColor = false;
			this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click_1);
			// 
			// btnEditUser
			// 
			this.btnEditUser.BackColor = System.Drawing.Color.Fuchsia;
			this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditUser.Location = new System.Drawing.Point(194, 214);
			this.btnEditUser.Name = "btnEditUser";
			this.btnEditUser.Size = new System.Drawing.Size(111, 62);
			this.btnEditUser.TabIndex = 8;
			this.btnEditUser.Text = "Edit User";
			this.btnEditUser.UseVisualStyleBackColor = false;
			this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click_1);
			// 
			// btnCreateUser
			// 
			this.btnCreateUser.BackColor = System.Drawing.Color.Lime;
			this.btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreateUser.Location = new System.Drawing.Point(32, 214);
			this.btnCreateUser.Name = "btnCreateUser";
			this.btnCreateUser.Size = new System.Drawing.Size(139, 62);
			this.btnCreateUser.TabIndex = 7;
			this.btnCreateUser.Text = "Create User";
			this.btnCreateUser.UseVisualStyleBackColor = false;
			this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Location = new System.Drawing.Point(246, 167);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.Size = new System.Drawing.Size(315, 30);
			this.txtConfirmPassword.TabIndex = 6;
			this.txtConfirmPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(246, 102);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(315, 30);
			this.txtPassword.TabIndex = 5;
			this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(246, 39);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(315, 30);
			this.txtUserName.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(177, 25);
			this.label4.TabIndex = 2;
			this.label4.Text = "Confirm Password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 25);
			this.label3.TabIndex = 1;
			this.label3.Text = "Password:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "User Name:";
			// 
			// dgvUsers
			// 
			this.dgvUsers.AllowUserToAddRows = false;
			this.dgvUsers.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
			this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsers.Location = new System.Drawing.Point(-2, 365);
			this.dgvUsers.Name = "dgvUsers";
			this.dgvUsers.ReadOnly = true;
			this.dgvUsers.RowHeadersWidth = 51;
			this.dgvUsers.RowTemplate.Height = 24;
			this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsers.Size = new System.Drawing.Size(1024, 146);
			this.dgvUsers.TabIndex = 3;
			this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
			// 
			// userForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1022, 510);
			this.Controls.Add(this.dgvUsers);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "userForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Best Fitness Customer Management System";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnDeleteUser;
		private System.Windows.Forms.Button btnEditUser;
		private System.Windows.Forms.Button btnCreateUser;
		private System.Windows.Forms.DataGridView dgvUsers;
	}
}