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
            label17 = new Label();
            txtBoxPassword = new TextBox();
            txtBoxPhoneNumber = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtBoxEmail = new TextBox();
            txtBoxDateOfBirth = new TextBox();
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
            label7 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            txtBoxFirstName = new TextBox();
            txtBoxbsn = new TextBox();
            label4 = new Label();
            label6 = new Label();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            btnCreateEmployee = new Button();
            btnUpdateEmployee = new Button();
            btnReadEmployee = new Button();
            btnDeleteEmployee = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            pnlEmployeeManagement.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1267, 637);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(pnlEmployeeManagement);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1259, 599);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlEmployeeManagement
            // 
            pnlEmployeeManagement.BackColor = Color.Transparent;
            pnlEmployeeManagement.Controls.Add(panel6);
            pnlEmployeeManagement.Location = new Point(-4, -49);
            pnlEmployeeManagement.Margin = new Padding(2);
            pnlEmployeeManagement.Name = "pnlEmployeeManagement";
            pnlEmployeeManagement.Size = new Size(1267, 697);
            pnlEmployeeManagement.TabIndex = 8;
            pnlEmployeeManagement.Visible = false;
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
            panel6.Location = new Point(27, 54);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(1231, 579);
            panel6.TabIndex = 16;
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
            panel1.Location = new Point(659, 247);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 149);
            panel1.TabIndex = 18;
            // 
            // txtBoxEmergencyContact
            // 
            txtBoxEmergencyContact.BackColor = Color.AliceBlue;
            txtBoxEmergencyContact.ForeColor = Color.Black;
            txtBoxEmergencyContact.Location = new Point(229, 35);
            txtBoxEmergencyContact.Margin = new Padding(2);
            txtBoxEmergencyContact.Name = "txtBoxEmergencyContact";
            txtBoxEmergencyContact.Size = new Size(146, 31);
            txtBoxEmergencyContact.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Location = new Point(-2, 119);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 6;
            label1.Text = "Emergency Relation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Location = new Point(-2, 38);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(214, 25);
            label2.TabIndex = 1;
            label2.Text = "Emergency Contact name";
            // 
            // txtBoxEmergencyRelation
            // 
            txtBoxEmergencyRelation.BackColor = Color.AliceBlue;
            txtBoxEmergencyRelation.ForeColor = Color.Black;
            txtBoxEmergencyRelation.Location = new Point(229, 117);
            txtBoxEmergencyRelation.Margin = new Padding(2);
            txtBoxEmergencyRelation.Name = "txtBoxEmergencyRelation";
            txtBoxEmergencyRelation.Size = new Size(146, 31);
            txtBoxEmergencyRelation.TabIndex = 4;
            // 
            // txtBoxPostalCode
            // 
            txtBoxPostalCode.BackColor = Color.AliceBlue;
            txtBoxPostalCode.ForeColor = Color.Black;
            txtBoxPostalCode.Location = new Point(229, 1);
            txtBoxPostalCode.Margin = new Padding(2);
            txtBoxPostalCode.Name = "txtBoxPostalCode";
            txtBoxPostalCode.Size = new Size(146, 31);
            txtBoxPostalCode.TabIndex = 3;
            // 
            // txtBoxemergencyPhoneNumber
            // 
            txtBoxemergencyPhoneNumber.BackColor = Color.AliceBlue;
            txtBoxemergencyPhoneNumber.ForeColor = Color.Black;
            txtBoxemergencyPhoneNumber.Location = new Point(229, 78);
            txtBoxemergencyPhoneNumber.Margin = new Padding(2);
            txtBoxemergencyPhoneNumber.Name = "txtBoxemergencyPhoneNumber";
            txtBoxemergencyPhoneNumber.Size = new Size(146, 31);
            txtBoxemergencyPhoneNumber.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Location = new Point(-2, 3);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 0;
            label3.Text = "Postal Code";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.AliceBlue;
            label12.Location = new Point(-2, 76);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(214, 25);
            label12.TabIndex = 2;
            label12.Text = "EmergencyPhoneNumber";
            // 
            // panel5
            // 
            panel5.Controls.Add(label17);
            panel5.Controls.Add(txtBoxPassword);
            panel5.Controls.Add(txtBoxPhoneNumber);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtBoxEmail);
            panel5.Controls.Add(txtBoxDateOfBirth);
            panel5.Controls.Add(txtBoxGender);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label11);
            panel5.Location = new Point(33, 244);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(331, 192);
            panel5.TabIndex = 16;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.AliceBlue;
            label17.Location = new Point(-2, 154);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(87, 25);
            label17.TabIndex = 8;
            label17.Text = "Password";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BackColor = Color.AliceBlue;
            txtBoxPassword.ForeColor = Color.Black;
            txtBoxPassword.Location = new Point(182, 150);
            txtBoxPassword.Margin = new Padding(2);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(146, 31);
            txtBoxPassword.TabIndex = 7;
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.BackColor = Color.AliceBlue;
            txtBoxPhoneNumber.ForeColor = Color.Black;
            txtBoxPhoneNumber.Location = new Point(182, 33);
            txtBoxPhoneNumber.Margin = new Padding(2);
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.Size = new Size(146, 31);
            txtBoxPhoneNumber.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.AliceBlue;
            label8.Location = new Point(-2, 119);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 25);
            label8.TabIndex = 6;
            label8.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.AliceBlue;
            label9.Location = new Point(-2, 38);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(129, 25);
            label9.TabIndex = 1;
            label9.Text = "Phone number";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.BackColor = Color.AliceBlue;
            txtBoxEmail.ForeColor = Color.Black;
            txtBoxEmail.Location = new Point(182, 115);
            txtBoxEmail.Margin = new Padding(2);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(146, 31);
            txtBoxEmail.TabIndex = 4;
            // 
            // txtBoxDateOfBirth
            // 
            txtBoxDateOfBirth.BackColor = Color.AliceBlue;
            txtBoxDateOfBirth.ForeColor = Color.Black;
            txtBoxDateOfBirth.Location = new Point(182, -1);
            txtBoxDateOfBirth.Margin = new Padding(2);
            txtBoxDateOfBirth.Name = "txtBoxDateOfBirth";
            txtBoxDateOfBirth.Size = new Size(146, 31);
            txtBoxDateOfBirth.TabIndex = 3;
            // 
            // txtBoxGender
            // 
            txtBoxGender.BackColor = Color.AliceBlue;
            txtBoxGender.ForeColor = Color.Black;
            txtBoxGender.Location = new Point(182, 76);
            txtBoxGender.Margin = new Padding(2);
            txtBoxGender.Name = "txtBoxGender";
            txtBoxGender.Size = new Size(146, 31);
            txtBoxGender.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.AliceBlue;
            label10.Location = new Point(-2, 3);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(113, 25);
            label10.TabIndex = 0;
            label10.Text = "Date of birth";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.AliceBlue;
            label11.Location = new Point(-2, 76);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(69, 25);
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
            panel2.Location = new Point(659, 94);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 149);
            panel2.TabIndex = 17;
            // 
            // txtCountry
            // 
            txtCountry.BackColor = Color.AliceBlue;
            txtCountry.ForeColor = Color.Black;
            txtCountry.Location = new Point(229, 37);
            txtCountry.Margin = new Padding(2);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(146, 31);
            txtCountry.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.AliceBlue;
            label13.Location = new Point(-2, 119);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(130, 25);
            label13.TabIndex = 6;
            label13.Text = "House number";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.AliceBlue;
            label14.Location = new Point(-2, 38);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(75, 25);
            label14.TabIndex = 1;
            label14.Text = "Country";
            // 
            // txtBoxHouseNumber
            // 
            txtBoxHouseNumber.BackColor = Color.AliceBlue;
            txtBoxHouseNumber.ForeColor = Color.Black;
            txtBoxHouseNumber.Location = new Point(229, 119);
            txtBoxHouseNumber.Margin = new Padding(2);
            txtBoxHouseNumber.Name = "txtBoxHouseNumber";
            txtBoxHouseNumber.Size = new Size(146, 31);
            txtBoxHouseNumber.TabIndex = 4;
            // 
            // txtBoxCity
            // 
            txtBoxCity.BackColor = Color.AliceBlue;
            txtBoxCity.ForeColor = Color.Black;
            txtBoxCity.Location = new Point(229, 3);
            txtBoxCity.Margin = new Padding(2);
            txtBoxCity.Name = "txtBoxCity";
            txtBoxCity.Size = new Size(146, 31);
            txtBoxCity.TabIndex = 3;
            // 
            // txtBoxStreet
            // 
            txtBoxStreet.BackColor = Color.AliceBlue;
            txtBoxStreet.ForeColor = Color.Black;
            txtBoxStreet.Location = new Point(229, 80);
            txtBoxStreet.Margin = new Padding(2);
            txtBoxStreet.Name = "txtBoxStreet";
            txtBoxStreet.Size = new Size(146, 31);
            txtBoxStreet.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.AliceBlue;
            label15.Location = new Point(-2, 3);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(42, 25);
            label15.TabIndex = 0;
            label15.Text = "City";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.AliceBlue;
            label16.Location = new Point(-2, 76);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(57, 25);
            label16.TabIndex = 2;
            label16.Text = "Street";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtBoxLastName);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(txtBoxFirstName);
            panel4.Controls.Add(txtBoxbsn);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(33, 91);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(331, 149);
            panel4.TabIndex = 15;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.BackColor = Color.AliceBlue;
            txtBoxLastName.ForeColor = Color.Black;
            txtBoxLastName.Location = new Point(182, 33);
            txtBoxLastName.Margin = new Padding(2);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(146, 31);
            txtBoxLastName.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.AliceBlue;
            label7.Location = new Point(-2, 119);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(117, 25);
            label7.TabIndex = 6;
            label7.Text = "BSN nummer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AliceBlue;
            label5.Location = new Point(-2, 38);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 1;
            label5.Text = "Last name";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.AliceBlue;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(182, 115);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 31);
            textBox2.TabIndex = 4;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.BackColor = Color.AliceBlue;
            txtBoxFirstName.ForeColor = Color.Black;
            txtBoxFirstName.Location = new Point(182, -1);
            txtBoxFirstName.Margin = new Padding(2);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(146, 31);
            txtBoxFirstName.TabIndex = 3;
            // 
            // txtBoxbsn
            // 
            txtBoxbsn.BackColor = Color.AliceBlue;
            txtBoxbsn.ForeColor = Color.Black;
            txtBoxbsn.Location = new Point(182, 76);
            txtBoxbsn.Margin = new Padding(2);
            txtBoxbsn.Name = "txtBoxbsn";
            txtBoxbsn.Size = new Size(146, 31);
            txtBoxbsn.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AliceBlue;
            label4.Location = new Point(-2, 3);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 0;
            label4.Text = "First name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AliceBlue;
            label6.Location = new Point(-2, 76);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 25);
            label6.TabIndex = 2;
            label6.Text = "bsn";
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1259, 599);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1167, 416);
            dataGridView1.TabIndex = 0;
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.Location = new Point(279, 465);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(112, 34);
            btnCreateEmployee.TabIndex = 19;
            btnCreateEmployee.Text = "Create";
            btnCreateEmployee.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.Location = new Point(422, 465);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(112, 34);
            btnUpdateEmployee.TabIndex = 20;
            btnUpdateEmployee.Text = "Read";
            btnUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // btnReadEmployee
            // 
            btnReadEmployee.Location = new Point(587, 465);
            btnReadEmployee.Name = "btnReadEmployee";
            btnReadEmployee.Size = new Size(112, 34);
            btnReadEmployee.TabIndex = 21;
            btnReadEmployee.Text = "Read";
            btnReadEmployee.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(739, 465);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(112, 34);
            btnDeleteEmployee.TabIndex = 22;
            btnDeleteEmployee.Text = "Delete";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 641);
            Controls.Add(tabControl1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox txtBoxDateOfBirth;
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
        private Label label7;
        private Label label5;
        private TextBox textBox2;
        private TextBox txtBoxFirstName;
        private TextBox txtBoxbsn;
        private Label label4;
        private Label label6;
        private Label label17;
        private TextBox txtBoxPassword;
        private DataGridView dataGridView1;
        private Button btnDeleteEmployee;
        private Button btnReadEmployee;
        private Button btnUpdateEmployee;
        private Button btnCreateEmployee;
    }
}