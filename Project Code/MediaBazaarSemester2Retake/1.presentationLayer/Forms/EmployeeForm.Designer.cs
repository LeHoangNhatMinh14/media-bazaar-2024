namespace MediaBazaarSemester2Retake
{
    partial class EmployeeForm
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
            tabControl1 = new TabControl();
            tabPageEmployees = new TabPage();
            unfilter = new Button();
            rbnLogistic = new RadioButton();
            rbnSecurity = new RadioButton();
            rbnCustomerService = new RadioButton();
            rbnHR = new RadioButton();
            button2 = new Button();
            NameBox = new TextBox();
            BtnFireEmployee = new Button();
            BtnSendToEditEmployee = new Button();
            dgv_Employee = new DataGridView();
            department = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            button1 = new Button();
            BtnAddEmployee = new Button();
            groupBox4 = new GroupBox();
            CbXContract = new ComboBox();
            DtPEndDate = new DateTimePicker();
            DtPStartDate = new DateTimePicker();
            label19 = new Label();
            CbXDepartment = new ComboBox();
            TxtBxPosition = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            groupBox3 = new GroupBox();
            CbXEmergencyRelationship = new ComboBox();
            TxtBxEmergencyContact = new TextBox();
            TxtBxEmergencyName = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            TxtBxBsn = new TextBox();
            label14 = new Label();
            TxtBxPhoneNumber = new TextBox();
            label13 = new Label();
            DtPDateOfBirth = new DateTimePicker();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtBxStreet = new TextBox();
            TxtBxPostalCode = new TextBox();
            TxtBxPassword = new TextBox();
            TxtBxEmail = new TextBox();
            TxtBxLastName = new TextBox();
            TxtBxFirstName = new TextBox();
            tabPage3 = new TabPage();
            BtnEditEmployee = new Button();
            groupBox6 = new GroupBox();
            CbXEditContract = new ComboBox();
            DtPEditEndDate = new DateTimePicker();
            DtPEditStartDate = new DateTimePicker();
            label32 = new Label();
            CbXEditDepartment = new ComboBox();
            TxtBxEditPosition = new TextBox();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            groupBox7 = new GroupBox();
            CbXEditEmergencyRelationship = new ComboBox();
            TxtBxEditEmergencyContact = new TextBox();
            TxtBxEditEmergencyName = new TextBox();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            groupBox5 = new GroupBox();
            label41 = new Label();
            TxtBxEditBsn = new TextBox();
            label21 = new Label();
            TxtBxEditPhoneNumber = new TextBox();
            label22 = new Label();
            DtpEditDateOfBirth = new DateTimePicker();
            label23 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            TxtBxEditStreet = new TextBox();
            TxtBxEditPostalCode = new TextBox();
            TxtBxEditPassword = new TextBox();
            TxtBxEditEmail = new TextBox();
            TxtBxEditLastName = new TextBox();
            TxtBxEditFirstName = new TextBox();
            tabControl1.SuspendLayout();
            tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Employee).BeginInit();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageEmployees);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1125, 457);
            tabControl1.TabIndex = 8;
            // 
            // tabPageEmployees
            // 
            tabPageEmployees.Controls.Add(unfilter);
            tabPageEmployees.Controls.Add(rbnLogistic);
            tabPageEmployees.Controls.Add(rbnSecurity);
            tabPageEmployees.Controls.Add(rbnCustomerService);
            tabPageEmployees.Controls.Add(rbnHR);
            tabPageEmployees.Controls.Add(button2);
            tabPageEmployees.Controls.Add(NameBox);
            tabPageEmployees.Controls.Add(BtnFireEmployee);
            tabPageEmployees.Controls.Add(BtnSendToEditEmployee);
            tabPageEmployees.Controls.Add(dgv_Employee);
            tabPageEmployees.Location = new Point(4, 24);
            tabPageEmployees.Margin = new Padding(3, 2, 3, 2);
            tabPageEmployees.Name = "tabPageEmployees";
            tabPageEmployees.Padding = new Padding(3, 2, 3, 2);
            tabPageEmployees.Size = new Size(1117, 429);
            tabPageEmployees.TabIndex = 3;
            tabPageEmployees.Text = "Employees";
            tabPageEmployees.UseVisualStyleBackColor = true;
            // 
            // unfilter
            // 
            unfilter.Location = new Point(856, 131);
            unfilter.Margin = new Padding(2);
            unfilter.Name = "unfilter";
            unfilter.Size = new Size(92, 20);
            unfilter.TabIndex = 13;
            unfilter.Text = "Remove Filter";
            unfilter.UseVisualStyleBackColor = true;
            unfilter.Click += unfilter_Click_1;
            // 
            // rbnLogistic
            // 
            rbnLogistic.AutoSize = true;
            rbnLogistic.Location = new Point(780, 112);
            rbnLogistic.Margin = new Padding(2);
            rbnLogistic.Name = "rbnLogistic";
            rbnLogistic.Size = new Size(66, 19);
            rbnLogistic.TabIndex = 12;
            rbnLogistic.TabStop = true;
            rbnLogistic.Text = "Logistic";
            rbnLogistic.UseVisualStyleBackColor = true;
            // 
            // rbnSecurity
            // 
            rbnSecurity.AutoSize = true;
            rbnSecurity.Location = new Point(780, 89);
            rbnSecurity.Margin = new Padding(2);
            rbnSecurity.Name = "rbnSecurity";
            rbnSecurity.Size = new Size(67, 19);
            rbnSecurity.TabIndex = 11;
            rbnSecurity.TabStop = true;
            rbnSecurity.Text = "Security";
            rbnSecurity.UseVisualStyleBackColor = true;
            // 
            // rbnCustomerService
            // 
            rbnCustomerService.AutoSize = true;
            rbnCustomerService.Location = new Point(780, 66);
            rbnCustomerService.Margin = new Padding(2);
            rbnCustomerService.Name = "rbnCustomerService";
            rbnCustomerService.Size = new Size(117, 19);
            rbnCustomerService.TabIndex = 10;
            rbnCustomerService.TabStop = true;
            rbnCustomerService.Text = "Customer Service";
            rbnCustomerService.UseVisualStyleBackColor = true;
            // 
            // rbnHR
            // 
            rbnHR.AutoSize = true;
            rbnHR.Location = new Point(780, 45);
            rbnHR.Margin = new Padding(2);
            rbnHR.Name = "rbnHR";
            rbnHR.Size = new Size(41, 19);
            rbnHR.TabIndex = 9;
            rbnHR.TabStop = true;
            rbnHR.Text = "HR";
            rbnHR.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(766, 131);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(85, 20);
            button2.TabIndex = 8;
            button2.Text = "Filter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(766, 12);
            NameBox.Margin = new Padding(3, 2, 3, 2);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(183, 23);
            NameBox.TabIndex = 7;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // BtnFireEmployee
            // 
            BtnFireEmployee.BackColor = Color.Red;
            BtnFireEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnFireEmployee.ForeColor = SystemColors.ButtonHighlight;
            BtnFireEmployee.Location = new Point(766, 317);
            BtnFireEmployee.Margin = new Padding(3, 2, 3, 2);
            BtnFireEmployee.Name = "BtnFireEmployee";
            BtnFireEmployee.Size = new Size(183, 36);
            BtnFireEmployee.TabIndex = 2;
            BtnFireEmployee.Text = "Fire Employee";
            BtnFireEmployee.UseVisualStyleBackColor = false;
            BtnFireEmployee.Click += BtnFireEmployee_Click;
            // 
            // BtnSendToEditEmployee
            // 
            BtnSendToEditEmployee.Location = new Point(766, 259);
            BtnSendToEditEmployee.Margin = new Padding(3, 2, 3, 2);
            BtnSendToEditEmployee.Name = "BtnSendToEditEmployee";
            BtnSendToEditEmployee.Size = new Size(183, 36);
            BtnSendToEditEmployee.TabIndex = 1;
            BtnSendToEditEmployee.Text = "Edit";
            BtnSendToEditEmployee.UseVisualStyleBackColor = true;
            BtnSendToEditEmployee.Click += BtnSendToEditEmployee_Click;
            // 
            // dgv_Employee
            // 
            dgv_Employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Employee.Columns.AddRange(new DataGridViewColumn[] { department });
            dgv_Employee.Location = new Point(6, 5);
            dgv_Employee.Margin = new Padding(3, 2, 3, 2);
            dgv_Employee.Name = "dgv_Employee";
            dgv_Employee.RowHeadersWidth = 51;
            dgv_Employee.RowTemplate.Height = 29;
            dgv_Employee.Size = new Size(755, 347);
            dgv_Employee.TabIndex = 0;
            // 
            // department
            // 
            department.DataPropertyName = "department";
            department.HeaderText = "Department";
            department.MinimumWidth = 8;
            department.Name = "department";
            department.ReadOnly = true;
            department.Width = 150;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(BtnAddEmployee);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1117, 429);
            tabPage2.TabIndex = 4;
            tabPage2.Text = "Add Employee";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(11, 309);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 4;
            button1.Text = "Demo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnAddEmployee
            // 
            BtnAddEmployee.Location = new Point(319, 309);
            BtnAddEmployee.Margin = new Padding(3, 2, 3, 2);
            BtnAddEmployee.Name = "BtnAddEmployee";
            BtnAddEmployee.Size = new Size(200, 43);
            BtnAddEmployee.TabIndex = 3;
            BtnAddEmployee.Text = "Add Employee";
            BtnAddEmployee.UseVisualStyleBackColor = true;
            BtnAddEmployee.Click += BtnAddEmployee_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(CbXContract);
            groupBox4.Controls.Add(DtPEndDate);
            groupBox4.Controls.Add(DtPStartDate);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(CbXDepartment);
            groupBox4.Controls.Add(TxtBxPosition);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label15);
            groupBox4.Location = new Point(421, 5);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(414, 185);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Department";
            // 
            // CbXContract
            // 
            CbXContract.FormattingEnabled = true;
            CbXContract.Location = new Point(85, 124);
            CbXContract.Margin = new Padding(3, 2, 3, 2);
            CbXContract.Name = "CbXContract";
            CbXContract.Size = new Size(243, 23);
            CbXContract.TabIndex = 10;
            // 
            // DtPEndDate
            // 
            DtPEndDate.Location = new Point(85, 99);
            DtPEndDate.Margin = new Padding(3, 2, 3, 2);
            DtPEndDate.Name = "DtPEndDate";
            DtPEndDate.Size = new Size(243, 23);
            DtPEndDate.TabIndex = 9;
            // 
            // DtPStartDate
            // 
            DtPStartDate.Location = new Point(85, 74);
            DtPStartDate.Margin = new Padding(3, 2, 3, 2);
            DtPStartDate.Name = "DtPStartDate";
            DtPStartDate.Size = new Size(243, 23);
            DtPStartDate.TabIndex = 8;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 122);
            label19.Name = "label19";
            label19.Size = new Size(53, 15);
            label19.TabIndex = 6;
            label19.Text = "Contract";
            // 
            // CbXDepartment
            // 
            CbXDepartment.FormattingEnabled = true;
            CbXDepartment.Location = new Point(85, 47);
            CbXDepartment.Margin = new Padding(3, 2, 3, 2);
            CbXDepartment.Name = "CbXDepartment";
            CbXDepartment.Size = new Size(243, 23);
            CbXDepartment.TabIndex = 5;
            // 
            // TxtBxPosition
            // 
            TxtBxPosition.Location = new Point(85, 19);
            TxtBxPosition.Margin = new Padding(3, 2, 3, 2);
            TxtBxPosition.Name = "TxtBxPosition";
            TxtBxPosition.Size = new Size(243, 23);
            TxtBxPosition.TabIndex = 4;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 98);
            label18.Name = "label18";
            label18.Size = new Size(54, 15);
            label18.TabIndex = 3;
            label18.Text = "End Date";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 73);
            label17.Name = "label17";
            label17.Size = new Size(58, 15);
            label17.TabIndex = 2;
            label17.Text = "Start Date";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 48);
            label16.Name = "label16";
            label16.Size = new Size(70, 15);
            label16.TabIndex = 1;
            label16.Text = "Department";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 24);
            label15.Name = "label15";
            label15.Size = new Size(50, 15);
            label15.TabIndex = 0;
            label15.Text = "Position";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(CbXEmergencyRelationship);
            groupBox3.Controls.Add(TxtBxEmergencyContact);
            groupBox3.Controls.Add(TxtBxEmergencyName);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(421, 194);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(414, 103);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Emergency";
            // 
            // CbXEmergencyRelationship
            // 
            CbXEmergencyRelationship.FormattingEnabled = true;
            CbXEmergencyRelationship.Items.AddRange(new object[] { "Spouse", "Parent", "Sibling", "Guardian" });
            CbXEmergencyRelationship.Location = new Point(90, 72);
            CbXEmergencyRelationship.Margin = new Padding(2);
            CbXEmergencyRelationship.Name = "CbXEmergencyRelationship";
            CbXEmergencyRelationship.Size = new Size(249, 23);
            CbXEmergencyRelationship.TabIndex = 5;
            // 
            // TxtBxEmergencyContact
            // 
            TxtBxEmergencyContact.Location = new Point(90, 50);
            TxtBxEmergencyContact.Margin = new Padding(3, 2, 3, 2);
            TxtBxEmergencyContact.Name = "TxtBxEmergencyContact";
            TxtBxEmergencyContact.Size = new Size(249, 23);
            TxtBxEmergencyContact.TabIndex = 5;
            // 
            // TxtBxEmergencyName
            // 
            TxtBxEmergencyName.Location = new Point(90, 29);
            TxtBxEmergencyName.Margin = new Padding(3, 2, 3, 2);
            TxtBxEmergencyName.Name = "TxtBxEmergencyName";
            TxtBxEmergencyName.Size = new Size(249, 23);
            TxtBxEmergencyName.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 106);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 75);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 2;
            label11.Text = "Relationship";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 52);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 1;
            label10.Text = "Contact";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 30);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 0;
            label9.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtBxBsn);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(TxtBxPhoneNumber);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(DtPDateOfBirth);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(TxtBxStreet);
            groupBox2.Controls.Add(TxtBxPostalCode);
            groupBox2.Controls.Add(TxtBxPassword);
            groupBox2.Controls.Add(TxtBxEmail);
            groupBox2.Controls.Add(TxtBxLastName);
            groupBox2.Controls.Add(TxtBxFirstName);
            groupBox2.Location = new Point(6, 5);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(410, 293);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Details";
            // 
            // TxtBxBsn
            // 
            TxtBxBsn.Location = new Point(113, 261);
            TxtBxBsn.Margin = new Padding(3, 2, 3, 2);
            TxtBxBsn.Name = "TxtBxBsn";
            TxtBxBsn.Size = new Size(260, 23);
            TxtBxBsn.TabIndex = 19;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 262);
            label14.Name = "label14";
            label14.Size = new Size(29, 15);
            label14.TabIndex = 18;
            label14.Text = "BSN";
            // 
            // TxtBxPhoneNumber
            // 
            TxtBxPhoneNumber.Location = new Point(113, 123);
            TxtBxPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            TxtBxPhoneNumber.Name = "TxtBxPhoneNumber";
            TxtBxPhoneNumber.Size = new Size(260, 23);
            TxtBxPhoneNumber.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 124);
            label13.Name = "label13";
            label13.Size = new Size(88, 15);
            label13.TabIndex = 16;
            label13.Text = "Phone Number";
            // 
            // DtPDateOfBirth
            // 
            DtPDateOfBirth.Location = new Point(113, 236);
            DtPDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            DtPDateOfBirth.Name = "DtPDateOfBirth";
            DtPDateOfBirth.Size = new Size(260, 23);
            DtPDateOfBirth.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 239);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 14;
            label8.Text = "Date Of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 189);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 12;
            label6.Text = "Street";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 166);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 11;
            label5.Text = "Postal Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 98);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 73);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 8;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 7;
            label1.Text = "First Name";
            // 
            // TxtBxStreet
            // 
            TxtBxStreet.Location = new Point(113, 187);
            TxtBxStreet.Margin = new Padding(3, 2, 3, 2);
            TxtBxStreet.Name = "TxtBxStreet";
            TxtBxStreet.Size = new Size(260, 23);
            TxtBxStreet.TabIndex = 4;
            // 
            // TxtBxPostalCode
            // 
            TxtBxPostalCode.Location = new Point(113, 162);
            TxtBxPostalCode.Margin = new Padding(3, 2, 3, 2);
            TxtBxPostalCode.Name = "TxtBxPostalCode";
            TxtBxPostalCode.Size = new Size(260, 23);
            TxtBxPostalCode.TabIndex = 3;
            // 
            // TxtBxPassword
            // 
            TxtBxPassword.Location = new Point(113, 95);
            TxtBxPassword.Margin = new Padding(3, 2, 3, 2);
            TxtBxPassword.Name = "TxtBxPassword";
            TxtBxPassword.PasswordChar = '⬤';
            TxtBxPassword.Size = new Size(260, 23);
            TxtBxPassword.TabIndex = 3;
            // 
            // TxtBxEmail
            // 
            TxtBxEmail.Location = new Point(113, 71);
            TxtBxEmail.Margin = new Padding(3, 2, 3, 2);
            TxtBxEmail.Name = "TxtBxEmail";
            TxtBxEmail.Size = new Size(260, 23);
            TxtBxEmail.TabIndex = 2;
            // 
            // TxtBxLastName
            // 
            TxtBxLastName.Location = new Point(113, 47);
            TxtBxLastName.Margin = new Padding(3, 2, 3, 2);
            TxtBxLastName.Name = "TxtBxLastName";
            TxtBxLastName.Size = new Size(260, 23);
            TxtBxLastName.TabIndex = 1;
            // 
            // TxtBxFirstName
            // 
            TxtBxFirstName.Location = new Point(113, 23);
            TxtBxFirstName.Margin = new Padding(3, 2, 3, 2);
            TxtBxFirstName.Name = "TxtBxFirstName";
            TxtBxFirstName.Size = new Size(260, 23);
            TxtBxFirstName.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(BtnEditEmployee);
            tabPage3.Controls.Add(groupBox6);
            tabPage3.Controls.Add(groupBox7);
            tabPage3.Controls.Add(groupBox5);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(1117, 429);
            tabPage3.TabIndex = 5;
            tabPage3.Text = "Edit Employee";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnEditEmployee
            // 
            BtnEditEmployee.Location = new Point(307, 308);
            BtnEditEmployee.Margin = new Padding(3, 2, 3, 2);
            BtnEditEmployee.Name = "BtnEditEmployee";
            BtnEditEmployee.Size = new Size(200, 43);
            BtnEditEmployee.TabIndex = 5;
            BtnEditEmployee.Text = "Edit Employee";
            BtnEditEmployee.UseVisualStyleBackColor = true;
            BtnEditEmployee.Click += BtnEditEmployee_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(CbXEditContract);
            groupBox6.Controls.Add(DtPEditEndDate);
            groupBox6.Controls.Add(DtPEditStartDate);
            groupBox6.Controls.Add(label32);
            groupBox6.Controls.Add(CbXEditDepartment);
            groupBox6.Controls.Add(TxtBxEditPosition);
            groupBox6.Controls.Add(label33);
            groupBox6.Controls.Add(label34);
            groupBox6.Controls.Add(label35);
            groupBox6.Controls.Add(label36);
            groupBox6.Location = new Point(421, 12);
            groupBox6.Margin = new Padding(3, 2, 3, 2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 2, 3, 2);
            groupBox6.Size = new Size(414, 185);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Department";
            // 
            // CbXEditContract
            // 
            CbXEditContract.FormattingEnabled = true;
            CbXEditContract.Location = new Point(85, 124);
            CbXEditContract.Margin = new Padding(3, 2, 3, 2);
            CbXEditContract.Name = "CbXEditContract";
            CbXEditContract.Size = new Size(243, 23);
            CbXEditContract.TabIndex = 10;
            // 
            // DtPEditEndDate
            // 
            DtPEditEndDate.Location = new Point(85, 99);
            DtPEditEndDate.Margin = new Padding(3, 2, 3, 2);
            DtPEditEndDate.Name = "DtPEditEndDate";
            DtPEditEndDate.Size = new Size(243, 23);
            DtPEditEndDate.TabIndex = 9;
            // 
            // DtPEditStartDate
            // 
            DtPEditStartDate.Location = new Point(85, 74);
            DtPEditStartDate.Margin = new Padding(3, 2, 3, 2);
            DtPEditStartDate.Name = "DtPEditStartDate";
            DtPEditStartDate.Size = new Size(243, 23);
            DtPEditStartDate.TabIndex = 8;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(6, 122);
            label32.Name = "label32";
            label32.Size = new Size(53, 15);
            label32.TabIndex = 6;
            label32.Text = "Contract";
            // 
            // CbXEditDepartment
            // 
            CbXEditDepartment.FormattingEnabled = true;
            CbXEditDepartment.Location = new Point(85, 47);
            CbXEditDepartment.Margin = new Padding(3, 2, 3, 2);
            CbXEditDepartment.Name = "CbXEditDepartment";
            CbXEditDepartment.Size = new Size(243, 23);
            CbXEditDepartment.TabIndex = 5;
            // 
            // TxtBxEditPosition
            // 
            TxtBxEditPosition.Location = new Point(85, 19);
            TxtBxEditPosition.Margin = new Padding(3, 2, 3, 2);
            TxtBxEditPosition.Name = "TxtBxEditPosition";
            TxtBxEditPosition.Size = new Size(243, 23);
            TxtBxEditPosition.TabIndex = 4;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(6, 98);
            label33.Name = "label33";
            label33.Size = new Size(54, 15);
            label33.TabIndex = 3;
            label33.Text = "End Date";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(6, 73);
            label34.Name = "label34";
            label34.Size = new Size(58, 15);
            label34.TabIndex = 2;
            label34.Text = "Start Date";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(6, 48);
            label35.Name = "label35";
            label35.Size = new Size(70, 15);
            label35.TabIndex = 1;
            label35.Text = "Department";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(6, 24);
            label36.Name = "label36";
            label36.Size = new Size(50, 15);
            label36.TabIndex = 0;
            label36.Text = "Position";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(CbXEditEmergencyRelationship);
            groupBox7.Controls.Add(TxtBxEditEmergencyContact);
            groupBox7.Controls.Add(TxtBxEditEmergencyName);
            groupBox7.Controls.Add(label37);
            groupBox7.Controls.Add(label38);
            groupBox7.Controls.Add(label39);
            groupBox7.Controls.Add(label40);
            groupBox7.Location = new Point(421, 202);
            groupBox7.Margin = new Padding(3, 2, 3, 2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 2, 3, 2);
            groupBox7.Size = new Size(414, 103);
            groupBox7.TabIndex = 3;
            groupBox7.TabStop = false;
            groupBox7.Text = "Emergency";
            // 
            // CbXEditEmergencyRelationship
            // 
            CbXEditEmergencyRelationship.FormattingEnabled = true;
            CbXEditEmergencyRelationship.Items.AddRange(new object[] { "Spouse", "Parent", "Sibling", "Guardian" });
            CbXEditEmergencyRelationship.Location = new Point(90, 73);
            CbXEditEmergencyRelationship.Margin = new Padding(2);
            CbXEditEmergencyRelationship.Name = "CbXEditEmergencyRelationship";
            CbXEditEmergencyRelationship.Size = new Size(249, 23);
            CbXEditEmergencyRelationship.TabIndex = 6;
            // 
            // TxtBxEditEmergencyContact
            // 
            TxtBxEditEmergencyContact.Location = new Point(90, 50);
            TxtBxEditEmergencyContact.Margin = new Padding(3, 2, 3, 2);
            TxtBxEditEmergencyContact.Name = "TxtBxEditEmergencyContact";
            TxtBxEditEmergencyContact.Size = new Size(249, 23);
            TxtBxEditEmergencyContact.TabIndex = 5;
            // 
            // TxtBxEditEmergencyName
            // 
            TxtBxEditEmergencyName.Location = new Point(90, 29);
            TxtBxEditEmergencyName.Margin = new Padding(3, 2, 3, 2);
            TxtBxEditEmergencyName.Name = "TxtBxEditEmergencyName";
            TxtBxEditEmergencyName.Size = new Size(249, 23);
            TxtBxEditEmergencyName.TabIndex = 4;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(6, 106);
            label37.Name = "label37";
            label37.Size = new Size(0, 15);
            label37.TabIndex = 3;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(6, 75);
            label38.Name = "label38";
            label38.Size = new Size(72, 15);
            label38.TabIndex = 2;
            label38.Text = "Relationship";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(6, 52);
            label39.Name = "label39";
            label39.Size = new Size(49, 15);
            label39.TabIndex = 1;
            label39.Text = "Contact";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(6, 30);
            label40.Name = "label40";
            label40.Size = new Size(39, 15);
            label40.TabIndex = 0;
            label40.Text = "Name";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label41);
            groupBox5.Controls.Add(TxtBxEditBsn);
            groupBox5.Controls.Add(label21);
            groupBox5.Controls.Add(TxtBxEditPhoneNumber);
            groupBox5.Controls.Add(label22);
            groupBox5.Controls.Add(DtpEditDateOfBirth);
            groupBox5.Controls.Add(label23);
            groupBox5.Controls.Add(label25);
            groupBox5.Controls.Add(label26);
            groupBox5.Controls.Add(label27);
            groupBox5.Controls.Add(label28);
            groupBox5.Controls.Add(label29);
            groupBox5.Controls.Add(label30);
            groupBox5.Controls.Add(TxtBxEditStreet);
            groupBox5.Controls.Add(TxtBxEditPostalCode);
            groupBox5.Controls.Add(TxtBxEditPassword);
            groupBox5.Controls.Add(TxtBxEditEmail);
            groupBox5.Controls.Add(TxtBxEditLastName);
            groupBox5.Controls.Add(TxtBxEditFirstName);
            groupBox5.Location = new Point(6, 5);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(377, 299);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Basic Details";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(113, 149);
            label41.Margin = new Padding(2, 0, 2, 0);
            label41.Name = "label41";
            label41.Size = new Size(44, 15);
            label41.TabIndex = 20;
            label41.Text = "label41";
            label41.Visible = false;
            // 
            // TxtBxEditBsn
            // 
            TxtBxEditBsn.Location = new Point(113, 271);
            TxtBxEditBsn.Margin = new Padding(3, 2, 3, 2);
            TxtBxEditBsn.Name = "TxtBxEditBsn";
            TxtBxEditBsn.Size = new Size(260, 23);
            TxtBxEditBsn.TabIndex = 19;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 273);
            label21.Name = "label21";
            label21.Size = new Size(29, 15);
            label21.TabIndex = 18;
            label21.Text = "BSN";
            // 
            // TxtBxEditPhoneNumber
            // 
            TxtBxEditPhoneNumber.Location = new Point(113, 123);
            TxtBxEditPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            TxtBxEditPhoneNumber.Name = "TxtBxEditPhoneNumber";
            TxtBxEditPhoneNumber.Size = new Size(260, 23);
            TxtBxEditPhoneNumber.TabIndex = 17;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 124);
            label22.Name = "label22";
            label22.Size = new Size(88, 15);
            label22.TabIndex = 16;
            label22.Text = "Phone Number";
            // 
            // DtpEditDateOfBirth
            // 
            DtpEditDateOfBirth.Location = new Point(113, 247);
            DtpEditDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            DtpEditDateOfBirth.Name = "DtpEditDateOfBirth";
            DtpEditDateOfBirth.Size = new Size(260, 23);
            DtpEditDateOfBirth.TabIndex = 15;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(6, 250);
            label23.Name = "label23";
            label23.Size = new Size(75, 15);
            label23.TabIndex = 14;
            label23.Text = "Date Of Birth";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(4, 202);
            label25.Name = "label25";
            label25.Size = new Size(37, 15);
            label25.TabIndex = 12;
            label25.Text = "Street";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(6, 177);
            label26.Name = "label26";
            label26.Size = new Size(70, 15);
            label26.TabIndex = 11;
            label26.Text = "Postal Code";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(6, 98);
            label27.Name = "label27";
            label27.Size = new Size(84, 15);
            label27.TabIndex = 10;
            label27.Text = "New Password";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(6, 73);
            label28.Name = "label28";
            label28.Size = new Size(36, 15);
            label28.TabIndex = 9;
            label28.Text = "Email";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(6, 48);
            label29.Name = "label29";
            label29.Size = new Size(63, 15);
            label29.TabIndex = 8;
            label29.Text = "Last Name";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(6, 24);
            label30.Name = "label30";
            label30.Size = new Size(64, 15);
            label30.TabIndex = 7;
            label30.Text = "First Name";
            // 
            // TxtBxEditStreet
            // 
            TxtBxEditStreet.Location = new Point(113, 197);
            TxtBxEditStreet.Margin = new Padding(3, 2, 3, 2);
            TxtBxEditStreet.Name = "TxtBxEditStreet";
            TxtBxEditStreet.Size = new Size(260, 23);
            TxtBxEditStreet.TabIndex = 4;
            // 
            // TxtBxEditPostalCode
            // 
            TxtBxEditPostalCode.Location = new Point(113, 173);
            TxtBxEditPostalCode.Margin = new Padding(3, 2, 3, 2);
            TxtBxEditPostalCode.Name = "TxtBxEditPostalCode";
            TxtBxEditPostalCode.Size = new Size(260, 23);
            TxtBxEditPostalCode.TabIndex = 3;
            // 
            // TxtBxEditPassword
            // 
            TxtBxEditPassword.Location = new Point(113, 97);
            TxtBxEditPassword.Margin = new Padding(3, 2, 3, 2);
            TxtBxEditPassword.Name = "TxtBxEditPassword";
            TxtBxEditPassword.PasswordChar = '⬤';
            TxtBxEditPassword.Size = new Size(260, 23);
            TxtBxEditPassword.TabIndex = 3;
            // 
            // TxtBxEditEmail
            // 
            TxtBxEditEmail.Location = new Point(113, 69);
            TxtBxEditEmail.Margin = new Padding(3, 2, 3, 2);
            TxtBxEditEmail.Name = "TxtBxEditEmail";
            TxtBxEditEmail.Size = new Size(260, 23);
            TxtBxEditEmail.TabIndex = 2;
            // 
            // TxtBxEditLastName
            // 
            TxtBxEditLastName.Location = new Point(113, 44);
            TxtBxEditLastName.Margin = new Padding(3, 2, 3, 2);
            TxtBxEditLastName.Name = "TxtBxEditLastName";
            TxtBxEditLastName.Size = new Size(260, 23);
            TxtBxEditLastName.TabIndex = 1;
            // 
            // TxtBxEditFirstName
            // 
            TxtBxEditFirstName.Location = new Point(113, 19);
            TxtBxEditFirstName.Margin = new Padding(3, 2, 3, 2);
            TxtBxEditFirstName.Name = "TxtBxEditFirstName";
            TxtBxEditFirstName.Size = new Size(260, 23);
            TxtBxEditFirstName.TabIndex = 0;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 474);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            tabControl1.ResumeLayout(false);
            tabPageEmployees.ResumeLayout(false);
            tabPageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Employee).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox txtBoxEmergencyContact;
        private Label label1;
        private Label label2;
        private TextBox txtBoxEmergencyRelation;
        private TextBox txtBoxPostalCode;
        private TextBox txtBoxemergencyPhoneNumber;
        private Label label3;
        private Label label12;
        private Panel panel5;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtBoxPhoneNumber;
        private Label label8;
        private Label label9;
        private TextBox txtBoxEmail;
        private TextBox txtBoxGender;
        private Label label10;
        private Label label11;
        private Panel panel2;
        private TextBox txtCountry;
        private Label label13;
        private Label label14;
        private TextBox txtBoxHouseNumber;
        private TextBox txtBoxCity;
        private TextBox txtBoxStreet;
        private Label label15;
        private Label label16;
        private Panel panel4;
        private TextBox txtBoxLastName;
        private Label label5;
        private TextBox txtBoxFirstName;
        private TextBox txtBoxbsn;
        private Label label4;
        private Label label6;
        private TabControl tabControl1;
        private TabPage tabPageEmployees;
        private Button unfilter;
        private RadioButton rbnLogistic;
        private RadioButton rbnSecurity;
        private RadioButton rbnCustomerService;
        private RadioButton rbnHR;
        private Button button2;
        private TextBox NameBox;
        private Button BtnFireEmployee;
        private Button BtnSendToEditEmployee;
        private DataGridView dgv_Employee;
        private DataGridViewTextBoxColumn department;
        private TabPage tabPage2;
        private Button button1;
        private Button BtnAddEmployee;
        private GroupBox groupBox4;
        private ComboBox CbXContract;
        private DateTimePicker DtPEndDate;
        private DateTimePicker DtPStartDate;
        private Label label19;
        private ComboBox CbXDepartment;
        private TextBox TxtBxPosition;
        private Label label18;
        private Label label17;
        private GroupBox groupBox3;
        private ComboBox CbXEmergencyRelationship;
        private TextBox TxtBxEmergencyContact;
        private TextBox TxtBxEmergencyName;
        private GroupBox groupBox2;
        private TextBox TxtBxBsn;
        private TextBox TxtBxPhoneNumber;
        private DateTimePicker DtPDateOfBirth;
        private TextBox TxtBxStreet;
        private TextBox TxtBxPostalCode;
        private TextBox TxtBxPassword;
        private TextBox TxtBxEmail;
        private TextBox TxtBxLastName;
        private TextBox TxtBxFirstName;
        private TabPage tabPage3;
        private Button BtnEditEmployee;
        private GroupBox groupBox6;
        private ComboBox CbXEditContract;
        private DateTimePicker DtPEditEndDate;
        private DateTimePicker DtPEditStartDate;
        private Label label32;
        private ComboBox CbXEditDepartment;
        private TextBox TxtBxEditPosition;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private GroupBox groupBox7;
        private ComboBox CbXEditEmergencyRelationship;
        private TextBox TxtBxEditEmergencyContact;
        private TextBox TxtBxEditEmergencyName;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private GroupBox groupBox5;
        private Label label41;
        private TextBox TxtBxEditBsn;
        private Label label21;
        private TextBox TxtBxEditPhoneNumber;
        private Label label22;
        private DateTimePicker DtpEditDateOfBirth;
        private Label label23;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private TextBox TxtBxEditStreet;
        private TextBox TxtBxEditPostalCode;
        private TextBox TxtBxEditPassword;
        private TextBox TxtBxEditEmail;
        private TextBox TxtBxEditLastName;
        private TextBox TxtBxEditFirstName;
        private TabPage tabPage1;
    }
}