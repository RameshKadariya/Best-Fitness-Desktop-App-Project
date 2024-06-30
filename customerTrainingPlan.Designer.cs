namespace fitnessProject
{
	partial class customerTrainingPlan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerTrainingPlan));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblCustomerID = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvCustomerDetails = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbPlanName = new System.Windows.Forms.ComboBox();
			this.btnAddPlan = new System.Windows.Forms.Button();
			this.btnEditPlan = new System.Windows.Forms.Button();
			this.btnDeletePlan = new System.Windows.Forms.Button();
			this.dgvSelectedPlanDetails = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUnits = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtRemarks = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSelectedPlanDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(77, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(622, 54);
			this.label1.TabIndex = 0;
			this.label1.Text = "Training Plan For Customer";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(43, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(226, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Customer Name:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(833, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(282, 147);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// lblCustomerID
			// 
			this.lblCustomerID.AutoSize = true;
			this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerID.Location = new System.Drawing.Point(781, 110);
			this.lblCustomerID.Name = "lblCustomerID";
			this.lblCustomerID.Size = new System.Drawing.Size(30, 32);
			this.lblCustomerID.TabIndex = 3;
			this.lblCustomerID.Text = "0";
			this.lblCustomerID.Click += new System.EventHandler(this.lblCustomerID_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(584, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(178, 32);
			this.label4.TabIndex = 4;
			this.label4.Text = "Customer ID:";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(275, 110);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(256, 30);
			this.txtCustomerName.TabIndex = 5;
			this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvCustomerDetails);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(49, 165);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1081, 195);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Please choose a customer";
			// 
			// dgvCustomerDetails
			// 
			this.dgvCustomerDetails.AllowUserToAddRows = false;
			this.dgvCustomerDetails.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvCustomerDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCustomerDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCustomerDetails.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCustomerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCustomerDetails.Location = new System.Drawing.Point(3, 30);
			this.dgvCustomerDetails.Name = "dgvCustomerDetails";
			this.dgvCustomerDetails.ReadOnly = true;
			this.dgvCustomerDetails.RowHeadersWidth = 51;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvCustomerDetails.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvCustomerDetails.RowTemplate.Height = 24;
			this.dgvCustomerDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCustomerDetails.Size = new System.Drawing.Size(1075, 162);
			this.dgvCustomerDetails.TabIndex = 0;
			this.dgvCustomerDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerDetails_CellClick);
			this.dgvCustomerDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 382);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 25);
			this.label5.TabIndex = 7;
			this.label5.Text = "Select Plan:";
			// 
			// cmbPlanName
			// 
			this.cmbPlanName.FormattingEnabled = true;
			this.cmbPlanName.Location = new System.Drawing.Point(269, 374);
			this.cmbPlanName.Name = "cmbPlanName";
			this.cmbPlanName.Size = new System.Drawing.Size(399, 33);
			this.cmbPlanName.TabIndex = 8;
			// 
			// btnAddPlan
			// 
			this.btnAddPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnAddPlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAddPlan.Location = new System.Drawing.Point(728, 374);
			this.btnAddPlan.Name = "btnAddPlan";
			this.btnAddPlan.Size = new System.Drawing.Size(167, 66);
			this.btnAddPlan.TabIndex = 9;
			this.btnAddPlan.Text = "Add Plan";
			this.btnAddPlan.UseVisualStyleBackColor = false;
			this.btnAddPlan.Click += new System.EventHandler(this.btnAddPlan_Click);
			// 
			// btnEditPlan
			// 
			this.btnEditPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnEditPlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEditPlan.Location = new System.Drawing.Point(728, 456);
			this.btnEditPlan.Name = "btnEditPlan";
			this.btnEditPlan.Size = new System.Drawing.Size(167, 60);
			this.btnEditPlan.TabIndex = 10;
			this.btnEditPlan.Text = "Edit Plan";
			this.btnEditPlan.UseVisualStyleBackColor = false;
			this.btnEditPlan.Click += new System.EventHandler(this.btnEditPlan_Click);
			// 
			// btnDeletePlan
			// 
			this.btnDeletePlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnDeletePlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDeletePlan.Location = new System.Drawing.Point(937, 374);
			this.btnDeletePlan.Name = "btnDeletePlan";
			this.btnDeletePlan.Size = new System.Drawing.Size(178, 66);
			this.btnDeletePlan.TabIndex = 11;
			this.btnDeletePlan.Text = "Delete Plan";
			this.btnDeletePlan.UseVisualStyleBackColor = false;
			this.btnDeletePlan.Click += new System.EventHandler(this.btnDeletePlan_Click);
			// 
			// dgvSelectedPlanDetails
			// 
			this.dgvSelectedPlanDetails.AllowUserToAddRows = false;
			this.dgvSelectedPlanDetails.AllowUserToDeleteRows = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvSelectedPlanDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvSelectedPlanDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSelectedPlanDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSelectedPlanDetails.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvSelectedPlanDetails.Location = new System.Drawing.Point(43, 590);
			this.dgvSelectedPlanDetails.Name = "dgvSelectedPlanDetails";
			this.dgvSelectedPlanDetails.ReadOnly = true;
			this.dgvSelectedPlanDetails.RowHeadersWidth = 51;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvSelectedPlanDetails.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvSelectedPlanDetails.RowTemplate.Height = 24;
			this.dgvSelectedPlanDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSelectedPlanDetails.Size = new System.Drawing.Size(1072, 205);
			this.dgvSelectedPlanDetails.TabIndex = 12;
			this.dgvSelectedPlanDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectedPlanDetails_CellClick);
			this.dgvSelectedPlanDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectedPlanDetails_CellContentClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 430);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(213, 25);
			this.label3.TabIndex = 13;
			this.label3.Text = "Number of Hour/Week:";
			// 
			// txtUnits
			// 
			this.txtUnits.Location = new System.Drawing.Point(269, 425);
			this.txtUnits.Name = "txtUnits";
			this.txtUnits.Size = new System.Drawing.Size(340, 30);
			this.txtUnits.TabIndex = 14;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Red;
			this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.Location = new System.Drawing.Point(937, 456);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(178, 60);
			this.btnClose.TabIndex = 15;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(44, 474);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 25);
			this.label6.TabIndex = 16;
			this.label6.Text = "Remarks:";
			// 
			// txtRemarks
			// 
			this.txtRemarks.Location = new System.Drawing.Point(269, 474);
			this.txtRemarks.Multiline = true;
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.Size = new System.Drawing.Size(340, 56);
			this.txtRemarks.TabIndex = 17;
			// 
			// customerTrainingPlan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 789);
			this.Controls.Add(this.txtRemarks);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.txtUnits);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgvSelectedPlanDetails);
			this.Controls.Add(this.btnDeletePlan);
			this.Controls.Add(this.btnEditPlan);
			this.Controls.Add(this.btnAddPlan);
			this.Controls.Add(this.cmbPlanName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblCustomerID);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "customerTrainingPlan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Best Fitness Customer Management  System";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSelectedPlanDetails)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblCustomerID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvCustomerDetails;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbPlanName;
		private System.Windows.Forms.Button btnAddPlan;
		private System.Windows.Forms.Button btnEditPlan;
		private System.Windows.Forms.Button btnDeletePlan;
		private System.Windows.Forms.DataGridView dgvSelectedPlanDetails;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUnits;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtRemarks;
	}
}