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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pnlEmployeeManagement = new Panel();
            panel6 = new Panel();
            btnDeleteEmployee = new Button();
            btnReadEmployee = new Button();
            btnUpdateEmployee = new Button();
            btnCreateEmployee = new Button();
            panel1 = new Panel();
            txtBoxEmergencyContact = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBoxEmergencyRelation = new TextBox();
            txtBoxPostalCode = new TextBox();
            txtBoxemergencyPhoneNumber = new TextBox();
            label3 = new Label();
            label12 = new Label();
            panel5 = new Panel();
            dtpDateOfBirth = new DateTimePicker();
            txtBoxPhoneNumber = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtBoxEmail = new TextBox();
            txtBoxGender = new TextBox();
            label10 = new Label();
            label11 = new Label();
            panel2 = new Panel();
            txtCountry = new TextBox();
            label13 = new Label();
            label14 = new Label();
            txtBoxHouseNumber = new TextBox();
            txtBoxCity = new TextBox();
            txtBoxStreet = new TextBox();
            label15 = new Label();
            label16 = new Label();
            panel4 = new Panel();
            txtBoxLastName = new TextBox();
            label5 = new Label();
            txtBoxFirstName = new TextBox();
            txtBoxbsn = new TextBox();
            label4 = new Label();
            label6 = new Label();
            tabPage2 = new TabPage();
            lbEmployee = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            pnlEmployeeManagement.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 9);
            tabControl1.Margin = new Padding(2, 3, 2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1014, 509);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(pnlEmployeeManagement);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2, 3, 2, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 3, 2, 3);
            tabPage1.Size = new Size(1006, 476);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlEmployeeManagement
            // 
            pnlEmployeeManagement.BackColor = Color.Transparent;
            pnlEmployeeManagement.Controls.Add(panel6);
            pnlEmployeeManagement.Location = new Point(-3, -39);
            pnlEmployeeManagement.Margin = new Padding(1);
            pnlEmployeeManagement.Name = "pnlEmployeeManagement";
            pnlEmployeeManagement.Size = new Size(1014, 557);
            pnlEmployeeManagement.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BackgroundImageLayout = ImageLayout.None;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(btnDeleteEmployee);
            panel6.Controls.Add(btnReadEmployee);
            panel6.Controls.Add(btnUpdateEmployee);
            panel6.Controls.Add(btnCreateEmployee);
            panel6.Controls.Add(panel1);
            panel6.Controls.Add(panel5);
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(panel4);
            panel6.Location = new Point(22, 43);
            panel6.Margin = new Padding(1);
            panel6.Name = "panel6";
            panel6.Size = new Size(986, 464);
            panel6.TabIndex = 16;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(591, 372);
            btnDeleteEmployee.Margin = new Padding(2, 3, 2, 3);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(89, 36);
            btnDeleteEmployee.TabIndex = 22;
            btnDeleteEmployee.Text = "Delete";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnReadEmployee
            // 
            btnReadEmployee.Location = new Point(470, 372);
            btnReadEmployee.Margin = new Padding(2, 3, 2, 3);
            btnReadEmployee.Name = "btnReadEmployee";
            btnReadEmployee.Size = new Size(89, 36);
            btnReadEmployee.TabIndex = 21;
            btnReadEmployee.Text = "Read";
            btnReadEmployee.UseVisualStyleBackColor = true;
            btnReadEmployee.Click += btnReadEmployee_Click;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.Location = new Point(337, 372);
            btnUpdateEmployee.Margin = new Padding(2, 3, 2, 3);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(89, 36);
            btnUpdateEmployee.TabIndex = 20;
            btnUpdateEmployee.Text = "Update";
            btnUpdateEmployee.UseVisualStyleBackColor = true;
            btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.Location = new Point(223, 372);
            btnCreateEmployee.Margin = new Padding(2, 3, 2, 3);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(89, 36);
            btnCreateEmployee.TabIndex = 19;
            btnCreateEmployee.Text = "Create";
            btnCreateEmployee.UseVisualStyleBackColor = true;
            btnCreateEmployee.Click += btnCreateEmployee_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBoxEmergencyContact);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBoxEmergencyRelation);
            panel1.Controls.Add(txtBoxPostalCode);
            panel1.Controls.Add(txtBoxemergencyPhoneNumber);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label12);
            panel1.Location = new Point(527, 197);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 119);
            panel1.TabIndex = 18;
            // 
            // txtBoxEmergencyContact
            // 
            txtBoxEmergencyContact.BackColor = Color.AliceBlue;
            txtBoxEmergencyContact.ForeColor = Color.Black;
            txtBoxEmergencyContact.Location = new Point(183, 28);
            txtBoxEmergencyContact.Margin = new Padding(1);
            txtBoxEmergencyContact.Name = "txtBoxEmergencyContact";
            txtBoxEmergencyContact.Size = new Size(117, 27);
            txtBoxEmergencyContact.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Location = new Point(-1, 95);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 6;
            label1.Text = "Emergency Relation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Location = new Point(-1, 31);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 1;
            label2.Text = "Emergency Contact name";
            // 
            // txtBoxEmergencyRelation
            // 
            txtBoxEmergencyRelation.BackColor = Color.AliceBlue;
            txtBoxEmergencyRelation.ForeColor = Color.Black;
            txtBoxEmergencyRelation.Location = new Point(183, 93);
            txtBoxEmergencyRelation.Margin = new Padding(1);
            txtBoxEmergencyRelation.Name = "txtBoxEmergencyRelation";
            txtBoxEmergencyRelation.Size = new Size(117, 27);
            txtBoxEmergencyRelation.TabIndex = 4;
            // 
            // txtBoxPostalCode
            // 
            txtBoxPostalCode.BackColor = Color.AliceBlue;
            txtBoxPostalCode.ForeColor = Color.Black;
            txtBoxPostalCode.Location = new Point(183, 1);
            txtBoxPostalCode.Margin = new Padding(1);
            txtBoxPostalCode.Name = "txtBoxPostalCode";
            txtBoxPostalCode.Size = new Size(117, 27);
            txtBoxPostalCode.TabIndex = 3;
            // 
            // txtBoxemergencyPhoneNumber
            // 
            txtBoxemergencyPhoneNumber.BackColor = Color.AliceBlue;
            txtBoxemergencyPhoneNumber.ForeColor = Color.Black;
            txtBoxemergencyPhoneNumber.Location = new Point(183, 63);
            txtBoxemergencyPhoneNumber.Margin = new Padding(1);
            txtBoxemergencyPhoneNumber.Name = "txtBoxemergencyPhoneNumber";
            txtBoxemergencyPhoneNumber.Size = new Size(117, 27);
            txtBoxemergencyPhoneNumber.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Location = new Point(-1, 3);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 0;
            label3.Text = "Postal Code";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.AliceBlue;
            label12.Location = new Point(-1, 61);
            label12.Margin = new Padding(1, 0, 1, 0);
            label12.Name = "label12";
            label12.Size = new Size(177, 20);
            label12.TabIndex = 2;
            label12.Text = "EmergencyPhoneNumber";
            // 
            // panel5
            // 
            panel5.Controls.Add(dtpDateOfBirth);
            panel5.Controls.Add(txtBoxPhoneNumber);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtBoxEmail);
            panel5.Controls.Add(txtBoxGender);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label11);
            panel5.Location = new Point(26, 172);
            panel5.Margin = new Padding(1);
            panel5.Name = "panel5";
            panel5.Size = new Size(265, 127);
            panel5.TabIndex = 16;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CustomFormat = "";
            dtpDateOfBirth.Location = new Point(145, 0);
            dtpDateOfBirth.Margin = new Padding(3, 4, 3, 4);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(116, 27);
            dtpDateOfBirth.TabIndex = 7;
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.BackColor = Color.AliceBlue;
            txtBoxPhoneNumber.ForeColor = Color.Black;
            txtBoxPhoneNumber.Location = new Point(145, 27);
            txtBoxPhoneNumber.Margin = new Padding(1);
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.Size = new Size(117, 27);
            txtBoxPhoneNumber.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.AliceBlue;
            label8.Location = new Point(-1, 95);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 6;
            label8.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.AliceBlue;
            label9.Location = new Point(-1, 31);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 1;
            label9.Text = "Phone number";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.BackColor = Color.AliceBlue;
            txtBoxEmail.ForeColor = Color.Black;
            txtBoxEmail.Location = new Point(145, 92);
            txtBoxEmail.Margin = new Padding(1);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(117, 27);
            txtBoxEmail.TabIndex = 4;
            // 
            // txtBoxGender
            // 
            txtBoxGender.BackColor = Color.AliceBlue;
            txtBoxGender.ForeColor = Color.Black;
            txtBoxGender.Location = new Point(145, 61);
            txtBoxGender.Margin = new Padding(1);
            txtBoxGender.Name = "txtBoxGender";
            txtBoxGender.Size = new Size(117, 27);
            txtBoxGender.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.AliceBlue;
            label10.Location = new Point(-1, 3);
            label10.Margin = new Padding(1, 0, 1, 0);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 0;
            label10.Text = "Date of birth";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.AliceBlue;
            label11.Location = new Point(-1, 61);
            label11.Margin = new Padding(1, 0, 1, 0);
            label11.Name = "label11";
            label11.Size = new Size(57, 20);
            label11.TabIndex = 2;
            label11.Text = "Gender";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtCountry);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(txtBoxHouseNumber);
            panel2.Controls.Add(txtBoxCity);
            panel2.Controls.Add(txtBoxStreet);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label16);
            panel2.Location = new Point(527, 75);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 119);
            panel2.TabIndex = 17;
            // 
            // txtCountry
            // 
            txtCountry.BackColor = Color.AliceBlue;
            txtCountry.ForeColor = Color.Black;
            txtCountry.Location = new Point(183, 29);
            txtCountry.Margin = new Padding(1);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(117, 27);
            txtCountry.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.AliceBlue;
            label13.Location = new Point(-1, 95);
            label13.Margin = new Padding(1, 0, 1, 0);
            label13.Name = "label13";
            label13.Size = new Size(106, 20);
            label13.TabIndex = 6;
            label13.Text = "House number";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.AliceBlue;
            label14.Location = new Point(-1, 31);
            label14.Margin = new Padding(1, 0, 1, 0);
            label14.Name = "label14";
            label14.Size = new Size(60, 20);
            label14.TabIndex = 1;
            label14.Text = "Country";
            // 
            // txtBoxHouseNumber
            // 
            txtBoxHouseNumber.BackColor = Color.AliceBlue;
            txtBoxHouseNumber.ForeColor = Color.Black;
            txtBoxHouseNumber.Location = new Point(183, 95);
            txtBoxHouseNumber.Margin = new Padding(1);
            txtBoxHouseNumber.Name = "txtBoxHouseNumber";
            txtBoxHouseNumber.Size = new Size(117, 27);
            txtBoxHouseNumber.TabIndex = 4;
            // 
            // txtBoxCity
            // 
            txtBoxCity.BackColor = Color.AliceBlue;
            txtBoxCity.ForeColor = Color.Black;
            txtBoxCity.Location = new Point(183, 3);
            txtBoxCity.Margin = new Padding(1);
            txtBoxCity.Name = "txtBoxCity";
            txtBoxCity.Size = new Size(117, 27);
            txtBoxCity.TabIndex = 3;
            // 
            // txtBoxStreet
            // 
            txtBoxStreet.BackColor = Color.AliceBlue;
            txtBoxStreet.ForeColor = Color.Black;
            txtBoxStreet.Location = new Point(183, 64);
            txtBoxStreet.Margin = new Padding(1);
            txtBoxStreet.Name = "txtBoxStreet";
            txtBoxStreet.Size = new Size(117, 27);
            txtBoxStreet.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.AliceBlue;
            label15.Location = new Point(-1, 3);
            label15.Margin = new Padding(1, 0, 1, 0);
            label15.Name = "label15";
            label15.Size = new Size(34, 20);
            label15.TabIndex = 0;
            label15.Text = "City";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.AliceBlue;
            label16.Location = new Point(-1, 61);
            label16.Margin = new Padding(1, 0, 1, 0);
            label16.Name = "label16";
            label16.Size = new Size(48, 20);
            label16.TabIndex = 2;
            label16.Text = "Street";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtBoxLastName);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtBoxFirstName);
            panel4.Controls.Add(txtBoxbsn);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(26, 73);
            panel4.Margin = new Padding(1);
            panel4.Name = "panel4";
            panel4.Size = new Size(265, 96);
            panel4.TabIndex = 15;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.BackColor = Color.AliceBlue;
            txtBoxLastName.ForeColor = Color.Black;
            txtBoxLastName.Location = new Point(145, 27);
            txtBoxLastName.Margin = new Padding(1);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(117, 27);
            txtBoxLastName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AliceBlue;
            label5.Location = new Point(-1, 31);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 1;
            label5.Text = "Last name";
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.BackColor = Color.AliceBlue;
            txtBoxFirstName.ForeColor = Color.Black;
            txtBoxFirstName.Location = new Point(145, -1);
            txtBoxFirstName.Margin = new Padding(1);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(117, 27);
            txtBoxFirstName.TabIndex = 3;
            // 
            // txtBoxbsn
            // 
            txtBoxbsn.BackColor = Color.AliceBlue;
            txtBoxbsn.ForeColor = Color.Black;
            txtBoxbsn.Location = new Point(145, 61);
            txtBoxbsn.Margin = new Padding(1);
            txtBoxbsn.Name = "txtBoxbsn";
            txtBoxbsn.Size = new Size(117, 27);
            txtBoxbsn.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AliceBlue;
            label4.Location = new Point(-1, 3);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 0;
            label4.Text = "First name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AliceBlue;
            label6.Location = new Point(-1, 61);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 2;
            label6.Text = "bsn";
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.Controls.Add(lbEmployee);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2, 3, 2, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 3, 2, 3);
            tabPage2.Size = new Size(1006, 476);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbEmployee
            // 
            lbEmployee.FormattingEnabled = true;
            lbEmployee.Location = new Point(19, 51);
            lbEmployee.Name = "lbEmployee";
            lbEmployee.Size = new Size(960, 364);
            lbEmployee.TabIndex = 0;
            lbEmployee.SelectedIndexChanged += lbEmployee_SelectedIndexChanged;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 513);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            pnlEmployeeManagement.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel pnlEmployeeManagement;
        private Panel panel6;
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
        private Button btnDeleteEmployee;
        private Button btnReadEmployee;
        private Button btnUpdateEmployee;
        private Button btnCreateEmployee;
        private DateTimePicker dtpDateOfBirth;
        private ListBox lbEmployee;
    }
}