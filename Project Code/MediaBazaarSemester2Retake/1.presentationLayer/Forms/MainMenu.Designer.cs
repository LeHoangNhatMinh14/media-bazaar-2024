namespace MediaBazaarSemester2Retake
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panel1 = new Panel();
            button2 = new Button();
            lbRoleInput = new Label();
            lblMainmenuName = new Label();
            label2 = new Label();
            btnBack = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btnUpdateScheduleManagement = new Button();
            btnCreateScheduleManagement = new Button();
            btnCreateProductManagement = new Button();
            btnSchedule = new Button();
            btnupdateEmployeeManagement = new Button();
            btnUpdateProductManagement = new Button();
            btnProductManagement = new Button();
            btnCreateEmployee = new Button();
            btnStockManagement = new Button();
            btnScheduleManagementClicked = new Button();
            btnDepartmentManagement = new Button();
            EmployeeManagementClicked = new Button();
            btnEmployeeManagement = new Button();
            btnStockmanagementCLicked = new Button();
            btnWeeklyScheduleManagement = new Button();
            btnDeleteProductManagement = new Button();
            btnDeleteEMployeeManagement = new Button();
            PnlMainMenu = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(lbRoleInput);
            panel1.Controls.Add(lblMainmenuName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(1, -1);
            panel1.Margin = new Padding(1, 1, 1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 39);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(1446, 21);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(107, 33);
            button2.TabIndex = 3;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // lbRoleInput
            // 
            lbRoleInput.AutoSize = true;
            lbRoleInput.ForeColor = SystemColors.ActiveCaptionText;
            lbRoleInput.Location = new Point(951, 14);
            lbRoleInput.Margin = new Padding(2, 0, 2, 0);
            lbRoleInput.Name = "lbRoleInput";
            lbRoleInput.Size = new Size(38, 15);
            lbRoleInput.TabIndex = 5;
            lbRoleInput.Text = "label4";
            lbRoleInput.Click += lbRoleInput_Click;
            // 
            // lblMainmenuName
            // 
            lblMainmenuName.AutoSize = true;
            lblMainmenuName.Location = new Point(1039, 15);
            lblMainmenuName.Margin = new Padding(2, 0, 2, 0);
            lblMainmenuName.Name = "lblMainmenuName";
            lblMainmenuName.Size = new Size(38, 15);
            lblMainmenuName.TabIndex = 6;
            lblMainmenuName.Text = "label4";
            lblMainmenuName.Click += lblMainmenuName_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(915, 14);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Role:";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(13, 10);
            btnBack.Margin = new Padding(1, 1, 1, 1);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 20);
            btnBack.TabIndex = 2;
            btnBack.Text = "<--Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Visible = false;
            btnBack.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(104, 13);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "DashBoard";
            // 
            // panel2
            // 
            panel2.Location = new Point(1, 97);
            panel2.Margin = new Padding(1, 1, 1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 423);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(btnUpdateScheduleManagement);
            panel3.Controls.Add(btnCreateScheduleManagement);
            panel3.Controls.Add(btnCreateProductManagement);
            panel3.Controls.Add(btnSchedule);
            panel3.Controls.Add(btnupdateEmployeeManagement);
            panel3.Controls.Add(btnUpdateProductManagement);
            panel3.Controls.Add(btnProductManagement);
            panel3.Controls.Add(btnCreateEmployee);
            panel3.Controls.Add(btnStockManagement);
            panel3.Controls.Add(btnDepartmentManagement);
            panel3.Controls.Add(EmployeeManagementClicked);
            panel3.Controls.Add(btnEmployeeManagement);
            panel3.Controls.Add(btnStockmanagementCLicked);
            panel3.Controls.Add(btnScheduleManagementClicked);
            panel3.Controls.Add(btnWeeklyScheduleManagement);
            panel3.Controls.Add(btnDeleteProductManagement);
            panel3.Controls.Add(btnDeleteEMployeeManagement);
            panel3.Location = new Point(5, 41);
            panel3.Margin = new Padding(1, 1, 1, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 476);
            panel3.TabIndex = 1;
            // 
            // btnUpdateScheduleManagement
            // 
            btnUpdateScheduleManagement.Location = new Point(0, 235);
            btnUpdateScheduleManagement.Margin = new Padding(1, 1, 1, 1);
            btnUpdateScheduleManagement.Name = "btnUpdateScheduleManagement";
            btnUpdateScheduleManagement.Size = new Size(205, 119);
            btnUpdateScheduleManagement.TabIndex = 9;
            btnUpdateScheduleManagement.Text = "Update";
            btnUpdateScheduleManagement.UseVisualStyleBackColor = true;
            btnUpdateScheduleManagement.Visible = false;
            // 
            // btnCreateScheduleManagement
            // 
            btnCreateScheduleManagement.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnCreateScheduleManagement.FlatAppearance.BorderSize = 500;
            btnCreateScheduleManagement.Location = new Point(-1, 119);
            btnCreateScheduleManagement.Margin = new Padding(1, 0, 1, 0);
            btnCreateScheduleManagement.Name = "btnCreateScheduleManagement";
            btnCreateScheduleManagement.Size = new Size(205, 119);
            btnCreateScheduleManagement.TabIndex = 8;
            btnCreateScheduleManagement.Text = "Leave Requests";
            btnCreateScheduleManagement.UseVisualStyleBackColor = true;
            btnCreateScheduleManagement.Visible = false;
            btnCreateScheduleManagement.Click += btnCreateScheduleManagement_Click;
            // 
            // btnCreateProductManagement
            // 
            btnCreateProductManagement.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnCreateProductManagement.FlatAppearance.BorderSize = 500;
            btnCreateProductManagement.Location = new Point(0, 119);
            btnCreateProductManagement.Margin = new Padding(1, 1, 1, 1);
            btnCreateProductManagement.Name = "btnCreateProductManagement";
            btnCreateProductManagement.Size = new Size(204, 119);
            btnCreateProductManagement.TabIndex = 7;
            btnCreateProductManagement.Text = "Create";
            btnCreateProductManagement.UseVisualStyleBackColor = true;
            btnCreateProductManagement.Visible = false;
            btnCreateProductManagement.Click += btnCreateProductManagement_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(-1, 235);
            btnSchedule.Margin = new Padding(1, 1, 1, 1);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(205, 119);
            btnSchedule.TabIndex = 2;
            btnSchedule.Text = "Schedule";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnupdateEmployeeManagement
            // 
            btnupdateEmployeeManagement.Location = new Point(-1, 235);
            btnupdateEmployeeManagement.Margin = new Padding(1, 1, 1, 1);
            btnupdateEmployeeManagement.Name = "btnupdateEmployeeManagement";
            btnupdateEmployeeManagement.Size = new Size(205, 119);
            btnupdateEmployeeManagement.TabIndex = 11;
            btnupdateEmployeeManagement.Text = "Update";
            btnupdateEmployeeManagement.UseVisualStyleBackColor = true;
            btnupdateEmployeeManagement.Visible = false;
            // 
            // btnUpdateProductManagement
            // 
            btnUpdateProductManagement.Location = new Point(0, 235);
            btnUpdateProductManagement.Margin = new Padding(1, 1, 1, 1);
            btnUpdateProductManagement.Name = "btnUpdateProductManagement";
            btnUpdateProductManagement.Size = new Size(205, 119);
            btnUpdateProductManagement.TabIndex = 10;
            btnUpdateProductManagement.Text = "Update";
            btnUpdateProductManagement.UseVisualStyleBackColor = true;
            btnUpdateProductManagement.Visible = false;
            // 
            // btnProductManagement
            // 
            btnProductManagement.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnProductManagement.FlatAppearance.BorderSize = 500;
            btnProductManagement.Location = new Point(0, 119);
            btnProductManagement.Margin = new Padding(1, 1, 1, 1);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(204, 119);
            btnProductManagement.TabIndex = 1;
            btnProductManagement.Text = "Product Management";
            btnProductManagement.UseVisualStyleBackColor = true;
            btnProductManagement.Click += btnProductManagement_Click;
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnCreateEmployee.FlatAppearance.BorderSize = 500;
            btnCreateEmployee.Location = new Point(0, 119);
            btnCreateEmployee.Margin = new Padding(1, 1, 1, 1);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(204, 119);
            btnCreateEmployee.TabIndex = 15;
            btnCreateEmployee.Text = "Create";
            btnCreateEmployee.UseVisualStyleBackColor = true;
            btnCreateEmployee.Visible = false;
            btnCreateEmployee.Click += btnCreateEmployee_Click;
            // 
            // btnStockManagement
            // 
            btnStockManagement.Location = new Point(-1, 353);
            btnStockManagement.Margin = new Padding(1, 1, 1, 1);
            btnStockManagement.Name = "btnStockManagement";
            btnStockManagement.Size = new Size(205, 123);
            btnStockManagement.TabIndex = 3;
            btnStockManagement.Text = "Stock Management";
            btnStockManagement.UseVisualStyleBackColor = true;
            btnStockManagement.Click += button4_Click;
            // 
            // btnScheduleManagementClicked
            // 
            btnScheduleManagementClicked.BackColor = Color.DarkTurquoise;
            btnScheduleManagementClicked.FlatStyle = FlatStyle.System;
            btnScheduleManagementClicked.ForeColor = Color.CornflowerBlue;
            btnScheduleManagementClicked.Location = new Point(0, 0);
            btnScheduleManagementClicked.Margin = new Padding(1, 1, 1, 1);
            btnScheduleManagementClicked.Name = "btnScheduleManagementClicked";
            btnScheduleManagementClicked.Size = new Size(204, 119);
            btnScheduleManagementClicked.TabIndex = 6;
            btnScheduleManagementClicked.Text = "Schedule Management*";
            btnScheduleManagementClicked.UseVisualStyleBackColor = false;
            btnScheduleManagementClicked.Visible = false;
            btnScheduleManagementClicked.Click += btnScheduleManagementClicked_Click;
            // 
            // btnDepartmentManagement
            // 
            btnDepartmentManagement.BackColor = Color.DarkTurquoise;
            btnDepartmentManagement.FlatStyle = FlatStyle.System;
            btnDepartmentManagement.ForeColor = Color.CornflowerBlue;
            btnDepartmentManagement.Location = new Point(0, 0);
            btnDepartmentManagement.Margin = new Padding(1, 1, 1, 1);
            btnDepartmentManagement.Name = "btnDepartmentManagement";
            btnDepartmentManagement.Size = new Size(204, 119);
            btnDepartmentManagement.TabIndex = 5;
            btnDepartmentManagement.Text = "Product Management*";
            btnDepartmentManagement.UseVisualStyleBackColor = false;
            btnDepartmentManagement.Visible = false;
            btnDepartmentManagement.Click += btnDepartmentManagement_Click;
            // 
            // EmployeeManagementClicked
            // 
            EmployeeManagementClicked.BackColor = Color.DarkTurquoise;
            EmployeeManagementClicked.FlatStyle = FlatStyle.System;
            EmployeeManagementClicked.ForeColor = Color.CornflowerBlue;
            EmployeeManagementClicked.Location = new Point(0, 0);
            EmployeeManagementClicked.Margin = new Padding(1, 1, 1, 1);
            EmployeeManagementClicked.Name = "EmployeeManagementClicked";
            EmployeeManagementClicked.Size = new Size(204, 119);
            EmployeeManagementClicked.TabIndex = 4;
            EmployeeManagementClicked.Text = "Employee Management*";
            EmployeeManagementClicked.UseVisualStyleBackColor = false;
            EmployeeManagementClicked.Visible = false;
            EmployeeManagementClicked.Click += button2_Click;
            // 
            // btnEmployeeManagement
            // 
            btnEmployeeManagement.BackColor = Color.DarkTurquoise;
            btnEmployeeManagement.FlatStyle = FlatStyle.System;
            btnEmployeeManagement.ForeColor = Color.CornflowerBlue;
            btnEmployeeManagement.Location = new Point(0, 0);
            btnEmployeeManagement.Margin = new Padding(1, 1, 1, 1);
            btnEmployeeManagement.Name = "btnEmployeeManagement";
            btnEmployeeManagement.Size = new Size(204, 119);
            btnEmployeeManagement.TabIndex = 0;
            btnEmployeeManagement.Text = "Employee Management";
            btnEmployeeManagement.UseVisualStyleBackColor = false;
            btnEmployeeManagement.Click += button1_Click;
            // 
            // btnStockmanagementCLicked
            // 
            btnStockmanagementCLicked.BackColor = Color.DarkTurquoise;
            btnStockmanagementCLicked.FlatStyle = FlatStyle.System;
            btnStockmanagementCLicked.ForeColor = Color.CornflowerBlue;
            btnStockmanagementCLicked.Location = new Point(0, 0);
            btnStockmanagementCLicked.Margin = new Padding(1, 1, 1, 1);
            btnStockmanagementCLicked.Name = "btnStockmanagementCLicked";
            btnStockmanagementCLicked.Size = new Size(204, 119);
            btnStockmanagementCLicked.TabIndex = 16;
            btnStockmanagementCLicked.Text = "Stock Management*";
            btnStockmanagementCLicked.UseVisualStyleBackColor = false;
            btnStockmanagementCLicked.Visible = false;
            // 
            // btnWeeklyScheduleManagement
            // 
            btnWeeklyScheduleManagement.Location = new Point(-1, 352);
            btnWeeklyScheduleManagement.Margin = new Padding(1, 1, 1, 1);
            btnWeeklyScheduleManagement.Name = "btnWeeklyScheduleManagement";
            btnWeeklyScheduleManagement.Size = new Size(205, 123);
            btnWeeklyScheduleManagement.TabIndex = 14;
            btnWeeklyScheduleManagement.Text = "Weekly Schedule";
            btnWeeklyScheduleManagement.UseVisualStyleBackColor = true;
            btnWeeklyScheduleManagement.Visible = false;
            btnWeeklyScheduleManagement.Click += btnWeeklyScheduleManagement_Click;
            // 
            // btnDeleteProductManagement
            // 
            btnDeleteProductManagement.Location = new Point(-5, 352);
            btnDeleteProductManagement.Margin = new Padding(1, 1, 1, 1);
            btnDeleteProductManagement.Name = "btnDeleteProductManagement";
            btnDeleteProductManagement.Size = new Size(205, 123);
            btnDeleteProductManagement.TabIndex = 13;
            btnDeleteProductManagement.Text = "Delete";
            btnDeleteProductManagement.UseVisualStyleBackColor = true;
            btnDeleteProductManagement.Visible = false;
            // 
            // btnDeleteEMployeeManagement
            // 
            btnDeleteEMployeeManagement.Location = new Point(-1, 352);
            btnDeleteEMployeeManagement.Margin = new Padding(1, 1, 1, 1);
            btnDeleteEMployeeManagement.Name = "btnDeleteEMployeeManagement";
            btnDeleteEMployeeManagement.Size = new Size(205, 123);
            btnDeleteEMployeeManagement.TabIndex = 12;
            btnDeleteEMployeeManagement.Text = "Delete";
            btnDeleteEMployeeManagement.UseVisualStyleBackColor = true;
            btnDeleteEMployeeManagement.Visible = false;
            // 
            // PnlMainMenu
            // 
            PnlMainMenu.BackColor = SystemColors.ControlDark;
            PnlMainMenu.BackgroundImage = (Image)resources.GetObject("PnlMainMenu.BackgroundImage");
            PnlMainMenu.Location = new Point(211, 41);
            PnlMainMenu.Margin = new Padding(1, 1, 1, 1);
            PnlMainMenu.Name = "PnlMainMenu";
            PnlMainMenu.Size = new Size(898, 476);
            PnlMainMenu.TabIndex = 2;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 520);
            Controls.Add(panel1);
            Controls.Add(PnlMainMenu);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(1, 1, 1, 1);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MediaBazzar";
            Load += MainMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button btnStockManagement;
        private Button btnSchedule;
        private Button btnEmployeeManagement;
        private Panel PnlMainMenu;
        private Button button1;
        private Label label2;
        private Button btnProductManagement;
        private Button EmployeeManagementClicked;
        private Button ScheduleManagementClicked;
        private Button btnDepartmentManagement;
        private Button btnCreateScheduleManagement;
        private Button btnCreateProductManagement;
        private Button btnWeeklyScheduleManagement;
        private Button btnDeleteProductManagement;
        private Button btnDeleteEMployeeManagement;
        private Button btnupdateEmployeeManagement;
        private Button btnUpdateProductManagement;
        private Button btnUpdateScheduleManagement;
        private Button btnCreateEmployee;
        private Button btnScheduleManagementClicked;
        private Button btnBack;
        private Button btnStockmanagementCLicked;
        private Label lblMainmenuName;
        private Label lbRoleInput;
        private Button button2;
    }
}