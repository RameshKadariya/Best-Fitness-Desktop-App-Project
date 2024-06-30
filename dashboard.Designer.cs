namespace fitnessProject
{
	partial class dashboard
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customerRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trainingPlansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customerTrainingPlansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnClose = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblDateTime = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button2 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cmbTrainingPlan = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvCustomerDetails = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvCustomerPlanDetails = new System.Windows.Forms.DataGridView();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerPlanDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Lime;
			this.menuStrip1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.customerRegistrationToolStripMenuItem,
            this.trainingPlansToolStripMenuItem,
            this.customerTrainingPlansToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1406, 51);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(139, 47);
			this.usersToolStripMenuItem.Text = "Users";
			this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
			// 
			// customerRegistrationToolStripMenuItem
			// 
			this.customerRegistrationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.customerRegistrationToolStripMenuItem.Name = "customerRegistrationToolStripMenuItem";
			this.customerRegistrationToolStripMenuItem.Size = new System.Drawing.Size(437, 47);
			this.customerRegistrationToolStripMenuItem.Text = "Customer Registration";
			this.customerRegistrationToolStripMenuItem.Click += new System.EventHandler(this.customerRegistrationToolStripMenuItem_Click);
			// 
			// trainingPlansToolStripMenuItem
			// 
			this.trainingPlansToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.trainingPlansToolStripMenuItem.Name = "trainingPlansToolStripMenuItem";
			this.trainingPlansToolStripMenuItem.Size = new System.Drawing.Size(289, 47);
			this.trainingPlansToolStripMenuItem.Text = "Training Plans";
			this.trainingPlansToolStripMenuItem.Click += new System.EventHandler(this.trainingPlansToolStripMenuItem_Click);
			// 
			// customerTrainingPlansToolStripMenuItem
			// 
			this.customerTrainingPlansToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.customerTrainingPlansToolStripMenuItem.Name = "customerTrainingPlansToolStripMenuItem";
			this.customerTrainingPlansToolStripMenuItem.Size = new System.Drawing.Size(473, 47);
			this.customerTrainingPlansToolStripMenuItem.Text = "Customer Training Plans";
			this.customerTrainingPlansToolStripMenuItem.Click += new System.EventHandler(this.customerTrainingPlansToolStripMenuItem_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Red;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(1831, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(67, 40);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Lime;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.lblDateTime);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 795);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1406, 50);
			this.panel1.TabIndex = 3;
			// 
			// lblDateTime
			// 
			this.lblDateTime.AutoSize = true;
			this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDateTime.Location = new System.Drawing.Point(10, 14);
			this.lblDateTime.Name = "lblDateTime";
			this.lblDateTime.Size = new System.Drawing.Size(85, 29);
			this.lblDateTime.TabIndex = 0;
			this.lblDateTime.Text = "label1";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Red;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(1480, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(60, 43);
			this.button2.TabIndex = 5;
			this.button2.Text = "X";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cmbTrainingPlan);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.txtCustomerName);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 51);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1406, 51);
			this.panel2.TabIndex = 6;
			// 
			// cmbTrainingPlan
			// 
			this.cmbTrainingPlan.FormattingEnabled = true;
			this.cmbTrainingPlan.Location = new System.Drawing.Point(967, 12);
			this.cmbTrainingPlan.Name = "cmbTrainingPlan";
			this.cmbTrainingPlan.Size = new System.Drawing.Size(436, 33);
			this.cmbTrainingPlan.TabIndex = 1;
			this.cmbTrainingPlan.SelectedIndexChanged += new System.EventHandler(this.cmbTrainingPlan_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(751, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Training Plan Name:";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(259, 14);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(434, 30);
			this.txtCustomerName.TabIndex = 1;
			this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(75, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Customer Name:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvCustomerDetails);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 102);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1406, 308);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Customer Details";
			// 
			// dgvCustomerDetails
			// 
			this.dgvCustomerDetails.AllowUserToAddRows = false;
			this.dgvCustomerDetails.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.dgvCustomerDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCustomerDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCustomerDetails.Location = new System.Drawing.Point(3, 26);
			this.dgvCustomerDetails.Name = "dgvCustomerDetails";
			this.dgvCustomerDetails.ReadOnly = true;
			this.dgvCustomerDetails.RowHeadersWidth = 51;
			this.dgvCustomerDetails.RowTemplate.Height = 24;
			this.dgvCustomerDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCustomerDetails.Size = new System.Drawing.Size(1400, 279);
			this.dgvCustomerDetails.TabIndex = 0;
			this.dgvCustomerDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerDetails_CellClick);
			this.dgvCustomerDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvCustomerPlanDetails);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox2.Location = new System.Drawing.Point(0, 409);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1406, 386);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Customer Training Plan Details";
			// 
			// dgvCustomerPlanDetails
			// 
			this.dgvCustomerPlanDetails.AllowUserToAddRows = false;
			this.dgvCustomerPlanDetails.AllowUserToDeleteRows = false;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.dgvCustomerPlanDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCustomerPlanDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCustomerPlanDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomerPlanDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCustomerPlanDetails.Location = new System.Drawing.Point(3, 26);
			this.dgvCustomerPlanDetails.Name = "dgvCustomerPlanDetails";
			this.dgvCustomerPlanDetails.ReadOnly = true;
			this.dgvCustomerPlanDetails.RowHeadersWidth = 51;
			this.dgvCustomerPlanDetails.RowTemplate.Height = 24;
			this.dgvCustomerPlanDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCustomerPlanDetails.Size = new System.Drawing.Size(1400, 357);
			this.dgvCustomerPlanDetails.TabIndex = 0;
			this.dgvCustomerPlanDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerPlanDetails_CellContentClick);
			// 
			// dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1406, 845);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "dashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fitness Club Customer Management System";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.dashboard_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerPlanDetails)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customerRegistrationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trainingPlansToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customerTrainingPlansToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblDateTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvCustomerDetails;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dgvCustomerPlanDetails;
		private System.Windows.Forms.ComboBox cmbTrainingPlan;
	}
}