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
            lblMainmenuName = new Label();
            button2 = new Button();
            lbRoleInput = new Label();
            label2 = new Label();
            btnBack = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btnWeeklyScheduleManagement = new Button();
            btnProductManagement = new Button();
            btnScheduleManagementClicked = new Button();
            btnSchedule = new Button();
            btnCreateScheduleManagement = new Button();
            btnStockManagement = new Button();
            btnDepartmentManagement = new Button();
            EmployeeManagementClicked = new Button();
            btnEmployeeManagement = new Button();
            btnStockmanagementCLicked = new Button();
            PnlMainMenu = new Panel();
            btnStatisticsForm = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblMainmenuName);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(lbRoleInput);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(2, -3);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 52);
            panel1.TabIndex = 0;
            // 
            // lblMainmenuName
            // 
            lblMainmenuName.AutoSize = true;
            lblMainmenuName.Location = new Point(200, 17);
            lblMainmenuName.Name = "lblMainmenuName";
            lblMainmenuName.Size = new Size(50, 20);
            lblMainmenuName.TabIndex = 6;
            lblMainmenuName.Text = "label4";
            lblMainmenuName.Click += lblMainmenuName_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(1147, 13);
            button2.Margin = new Padding(3, 5, 3, 5);
            button2.Name = "button2";
            button2.Size = new Size(86, 27);
            button2.TabIndex = 3;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // lbRoleInput
            // 
            lbRoleInput.AutoSize = true;
            lbRoleInput.ForeColor = SystemColors.ActiveCaptionText;
            lbRoleInput.Location = new Point(1087, 19);
            lbRoleInput.Margin = new Padding(2, 0, 2, 0);
            lbRoleInput.Name = "lbRoleInput";
            lbRoleInput.Size = new Size(50, 20);
            lbRoleInput.TabIndex = 5;
            lbRoleInput.Text = "label4";
            lbRoleInput.Click += lbRoleInput_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(1046, 19);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 3;
            label2.Text = "Role:";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(17, 17);
            btnBack.Margin = new Padding(2, 3, 2, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 27);
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
            label1.Location = new Point(119, 17);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "DashBoard";
            // 
            // panel2
            // 
            panel2.Location = new Point(2, 259);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 564);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(btnStatisticsForm);
            panel3.Controls.Add(btnWeeklyScheduleManagement);
            panel3.Controls.Add(btnProductManagement);
            panel3.Controls.Add(btnScheduleManagementClicked);
            panel3.Controls.Add(btnSchedule);
            panel3.Controls.Add(btnCreateScheduleManagement);
            panel3.Controls.Add(btnStockManagement);
            panel3.Controls.Add(btnDepartmentManagement);
            panel3.Controls.Add(EmployeeManagementClicked);
            panel3.Controls.Add(btnEmployeeManagement);
            panel3.Controls.Add(btnStockmanagementCLicked);
            panel3.Location = new Point(5, 55);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 635);
            panel3.TabIndex = 1;
            // 
            // btnWeeklyScheduleManagement
            // 
            btnWeeklyScheduleManagement.Location = new Point(-1, 159);
            btnWeeklyScheduleManagement.Margin = new Padding(2, 3, 2, 3);
            btnWeeklyScheduleManagement.Name = "btnWeeklyScheduleManagement";
            btnWeeklyScheduleManagement.Size = new Size(233, 159);
            btnWeeklyScheduleManagement.TabIndex = 14;
            btnWeeklyScheduleManagement.Text = "Weekly Schedule";
            btnWeeklyScheduleManagement.UseVisualStyleBackColor = true;
            btnWeeklyScheduleManagement.Visible = false;
            btnWeeklyScheduleManagement.Click += btnWeeklyScheduleManagement_Click;
            // 
            // btnProductManagement
            // 
            btnProductManagement.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnProductManagement.FlatAppearance.BorderSize = 500;
            btnProductManagement.Location = new Point(0, 159);
            btnProductManagement.Margin = new Padding(2, 3, 2, 3);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(233, 159);
            btnProductManagement.TabIndex = 1;
            btnProductManagement.Text = "Product Management";
            btnProductManagement.UseVisualStyleBackColor = true;
            btnProductManagement.Click += btnProductManagement_Click;
            // 
            // btnScheduleManagementClicked
            // 
            btnScheduleManagementClicked.BackColor = Color.DarkTurquoise;
            btnScheduleManagementClicked.FlatStyle = FlatStyle.System;
            btnScheduleManagementClicked.ForeColor = Color.CornflowerBlue;
            btnScheduleManagementClicked.Location = new Point(0, 0);
            btnScheduleManagementClicked.Margin = new Padding(1, 1, 1, 1);
            btnScheduleManagementClicked.Name = "btnScheduleManagementClicked";
            btnScheduleManagementClicked.Size = new Size(233, 159);
            btnScheduleManagementClicked.TabIndex = 6;
            btnScheduleManagementClicked.Text = "Schedule Management*";
            btnScheduleManagementClicked.UseVisualStyleBackColor = false;
            btnScheduleManagementClicked.Visible = false;
            btnScheduleManagementClicked.Click += btnScheduleManagementClicked_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(0, 313);
            btnSchedule.Margin = new Padding(2, 3, 2, 3);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(233, 159);
            btnSchedule.TabIndex = 2;
            btnSchedule.Text = "Schedule";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnCreateScheduleManagement
            // 
            btnCreateScheduleManagement.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnCreateScheduleManagement.FlatAppearance.BorderSize = 500;
            btnCreateScheduleManagement.Location = new Point(0, 317);
            btnCreateScheduleManagement.Margin = new Padding(1, 1, 1, 1);
            btnCreateScheduleManagement.Name = "btnCreateScheduleManagement";
            btnCreateScheduleManagement.Size = new Size(233, 159);
            btnCreateScheduleManagement.TabIndex = 8;
            btnCreateScheduleManagement.Text = "Leave Requests";
            btnCreateScheduleManagement.UseVisualStyleBackColor = true;
            btnCreateScheduleManagement.Visible = false;
            btnCreateScheduleManagement.Click += btnCreateScheduleManagement_Click;
            // 
            // btnStockManagement
            // 
            btnStockManagement.Location = new Point(0, 471);
            btnStockManagement.Margin = new Padding(2, 3, 2, 3);
            btnStockManagement.Name = "btnStockManagement";
            btnStockManagement.Size = new Size(233, 159);
            btnStockManagement.TabIndex = 3;
            btnStockManagement.Text = "Stock Management";
            btnStockManagement.UseVisualStyleBackColor = true;
            btnStockManagement.Click += button4_Click;
            // 
            // btnDepartmentManagement
            // 
            btnDepartmentManagement.BackColor = Color.DarkTurquoise;
            btnDepartmentManagement.FlatStyle = FlatStyle.System;
            btnDepartmentManagement.ForeColor = Color.CornflowerBlue;
            btnDepartmentManagement.Location = new Point(0, 0);
            btnDepartmentManagement.Margin = new Padding(2, 3, 2, 3);
            btnDepartmentManagement.Name = "btnDepartmentManagement";
            btnDepartmentManagement.Size = new Size(233, 159);
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
            EmployeeManagementClicked.Margin = new Padding(2, 3, 2, 3);
            EmployeeManagementClicked.Name = "EmployeeManagementClicked";
            EmployeeManagementClicked.Size = new Size(233, 159);
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
            btnEmployeeManagement.Margin = new Padding(2, 3, 2, 3);
            btnEmployeeManagement.Name = "btnEmployeeManagement";
            btnEmployeeManagement.Size = new Size(233, 159);
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
            btnStockmanagementCLicked.Margin = new Padding(2, 3, 2, 3);
            btnStockmanagementCLicked.Name = "btnStockmanagementCLicked";
            btnStockmanagementCLicked.Size = new Size(233, 159);
            btnStockmanagementCLicked.TabIndex = 16;
            btnStockmanagementCLicked.Text = "Stock Management*";
            btnStockmanagementCLicked.UseVisualStyleBackColor = false;
            // 
            // PnlMainMenu
            // 
            PnlMainMenu.BackColor = SystemColors.ControlDark;
            PnlMainMenu.BackgroundImage = (Image)resources.GetObject("PnlMainMenu.BackgroundImage");
            PnlMainMenu.Location = new Point(241, 55);
            PnlMainMenu.Margin = new Padding(2, 3, 2, 3);
            PnlMainMenu.Name = "PnlMainMenu";
            PnlMainMenu.Size = new Size(1026, 635);
            PnlMainMenu.TabIndex = 2;
            // 
            // btnStatisticsForm
            // 
            btnStatisticsForm.Location = new Point(2, 471);
            btnStatisticsForm.Name = "btnStatisticsForm";
            btnStatisticsForm.Size = new Size(230, 156);
            btnStatisticsForm.TabIndex = 17;
            btnStatisticsForm.Text = "Statistics";
            btnStatisticsForm.UseVisualStyleBackColor = true;
            btnStatisticsForm.Click += btnStatisticsForm_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 693);
            Controls.Add(panel1);
            Controls.Add(PnlMainMenu);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2, 3, 2, 3);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MediaBazzar";
            Load += MainMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button btnStockManagement;
        private Button btnEmployeeManagement;
        private Panel PnlMainMenu;
        private Label label2;
        private Button btnProductManagement;
        private Button EmployeeManagementClicked;
        private Button btnDepartmentManagement;
        private Button btnCreateScheduleManagement;
        private Button btnWeeklyScheduleManagement;
        private Button btnScheduleManagementClicked;
        private Button btnBack;
        private Button btnStockmanagementCLicked;
        private Label lbRoleInput;
        private Button button2;
        private Button btnSchedule;
        private Label lblMainmenuName;
        private Button btnStatisticsForm;
    }
    #endregion
}