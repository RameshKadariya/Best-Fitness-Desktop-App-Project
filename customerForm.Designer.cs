namespace fitnessProject
{
	partial class customerForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtTargetWeight = new System.Windows.Forms.TextBox();
			this.txtCurrentWeight = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtContact = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpDOB = new System.Windows.Forms.DateTimePicker();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAddCustomer = new System.Windows.Forms.Button();
			this.btnEditCustomer = new System.Windows.Forms.Button();
			this.btnDeleteCustomer = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.dgvCustomerDetails = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(33, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(784, 57);
			this.label1.TabIndex = 0;
			this.label1.Text = "Customer Management Form";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(849, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(194, 137);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtTargetWeight);
			this.groupBox1.Controls.Add(this.txtCurrentWeight);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtContact);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dtpDOB);
			this.groupBox1.Controls.Add(this.txtAddress);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtCustomerName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(43, 78);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(602, 339);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Make sure to fill all the details";
			// 
			// txtTargetWeight
			// 
			this.txtTargetWeight.Location = new System.Drawing.Point(314, 299);
			this.txtTargetWeight.Name = "txtTargetWeight";
			this.txtTargetWeight.Size = new System.Drawing.Size(119, 30);
			this.txtTargetWeight.TabIndex = 13;
			// 
			// txtCurrentWeight
			// 
			this.txtCurrentWeight.Location = new System.Drawing.Point(24, 299);
			this.txtCurrentWeight.Name = "txtCurrentWeight";
			this.txtCurrentWeight.Size = new System.Drawing.Size(119, 30);
			this.txtCurrentWeight.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(309, 254);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(142, 25);
			this.label8.TabIndex = 11;
			this.label8.Text = "Target Weight:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(19, 254);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(150, 25);
			this.label7.TabIndex = 10;
			this.label7.Text = "Current Weight:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(252, 207);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(260, 30);
			this.txtEmail.TabIndex = 9;
			this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 207);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 25);
			this.label6.TabIndex = 8;
			this.label6.Text = "Email:";
			// 
			// txtContact
			// 
			this.txtContact.Location = new System.Drawing.Point(252, 167);
			this.txtContact.Name = "txtContact";
			this.txtContact.Size = new System.Drawing.Size(260, 30);
			this.txtContact.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 170);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 25);
			this.label5.TabIndex = 6;
			this.label5.Text = "Contact:";
			// 
			// dtpDOB
			// 
			this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDOB.Location = new System.Drawing.Point(252, 131);
			this.dtpDOB.Name = "dtpDOB";
			this.dtpDOB.Size = new System.Drawing.Size(260, 30);
			this.dtpDOB.TabIndex = 5;
			this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(252, 83);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(260, 30);
			this.txtAddress.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(219, 25);
			this.label4.TabIndex = 3;
			this.label4.Text = "Customer Date Of Birth:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(181, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Customer Address:";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(252, 36);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(260, 30);
			this.txtCustomerName.TabIndex = 1;
			this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Customer Name:";
			// 
			// btnAddCustomer
			// 
			this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnAddCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAddCustomer.Location = new System.Drawing.Point(681, 222);
			this.btnAddCustomer.Name = "btnAddCustomer";
			this.btnAddCustomer.Size = new System.Drawing.Size(186, 82);
			this.btnAddCustomer.TabIndex = 14;
			this.btnAddCustomer.Text = "Add Customer";
			this.btnAddCustomer.UseVisualStyleBackColor = false;
			this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
			// 
			// btnEditCustomer
			// 
			this.btnEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnEditCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEditCustomer.Location = new System.Drawing.Point(897, 222);
			this.btnEditCustomer.Name = "btnEditCustomer";
			this.btnEditCustomer.Size = new System.Drawing.Size(190, 82);
			this.btnEditCustomer.TabIndex = 15;
			this.btnEditCustomer.Text = "Edit Customer";
			this.btnEditCustomer.UseVisualStyleBackColor = false;
			this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
			// 
			// btnDeleteCustomer
			// 
			this.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnDeleteCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDeleteCustomer.Location = new System.Drawing.Point(681, 332);
			this.btnDeleteCustomer.Name = "btnDeleteCustomer";
			this.btnDeleteCustomer.Size = new System.Drawing.Size(199, 82);
			this.btnDeleteCustomer.TabIndex = 16;
			this.btnDeleteCustomer.Text = "Delete Customer";
			this.btnDeleteCustomer.UseVisualStyleBackColor = false;
			this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Red;
			this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.Location = new System.Drawing.Point(897, 332);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(199, 82);
			this.btnClose.TabIndex = 17;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// dgvCustomerDetails
			// 
			this.dgvCustomerDetails.AllowUserToAddRows = false;
			this.dgvCustomerDetails.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.dgvCustomerDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCustomerDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomerDetails.Location = new System.Drawing.Point(12, 423);
			this.dgvCustomerDetails.Name = "dgvCustomerDetails";
			this.dgvCustomerDetails.ReadOnly = true;
			this.dgvCustomerDetails.RowHeadersWidth = 51;
			this.dgvCustomerDetails.RowTemplate.Height = 24;
			this.dgvCustomerDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCustomerDetails.Size = new System.Drawing.Size(1067, 341);
			this.dgvCustomerDetails.TabIndex = 18;
			this.dgvCustomerDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerDetails_CellClick);
			// 
			// customerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1098, 801);
			this.Controls.Add(this.dgvCustomerDetails);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnDeleteCustomer);
			this.Controls.Add(this.btnEditCustomer);
			this.Controls.Add(this.btnAddCustomer);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "customerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Best Fitness Customer Management System";
			this.Load += new System.EventHandler(this.customerForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtTargetWeight;
		private System.Windows.Forms.TextBox txtCurrentWeight;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtContact;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpDOB;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAddCustomer;
		private System.Windows.Forms.Button btnEditCustomer;
		private System.Windows.Forms.Button btnDeleteCustomer;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridView dgvCustomerDetails;
	}
}