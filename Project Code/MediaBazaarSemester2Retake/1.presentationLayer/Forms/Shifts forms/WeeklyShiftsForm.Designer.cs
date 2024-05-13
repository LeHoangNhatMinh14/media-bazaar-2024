namespace MediaBazaarSemester2Retake._1.presentationLayer.Forms
{
    partial class WeeklyShiftsForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lbUsers = new ListBox();
            cbDepartments = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            lblMonth = new Label();
            btnAutoShiftAssign = new Button();
            lblWeekNumber = new Label();
            datePickerEnd = new DateTimePicker();
            datePickerStart = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            btnCreateShiftPeriod = new Button();
            numericPeopleNeeded = new NumericUpDown();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericPeopleNeeded).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 95);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(858, 87);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 45);
            label1.TabIndex = 1;
            label1.Text = "Weekly Shifts";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(12, 29);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 23);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(779, 29);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 77);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Monday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 77);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "Tuesday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 77);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 6;
            label4.Text = "Wednesday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 77);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 7;
            label5.Text = "Thursday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(539, 77);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 8;
            label6.Text = "Friday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(653, 77);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 9;
            label7.Text = "Saturday";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(779, 77);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 10;
            label8.Text = "Sunday";
            // 
            // lbUsers
            // 
            lbUsers.FormattingEnabled = true;
            lbUsers.ItemHeight = 15;
            lbUsers.Location = new Point(15, 215);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(286, 199);
            lbUsers.TabIndex = 11;
            lbUsers.SelectedIndexChanged += lbUsers_SelectedIndexChanged;
            // 
            // cbDepartments
            // 
            cbDepartments.FormattingEnabled = true;
            cbDepartments.Location = new Point(380, 260);
            cbDepartments.Name = "cbDepartments";
            cbDepartments.Size = new Size(121, 23);
            cbDepartments.TabIndex = 12;
            cbDepartments.SelectedIndexChanged += cbDepartments_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 197);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 13;
            label9.Text = "Sort by users";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(380, 242);
            label10.Name = "label10";
            label10.Size = new Size(121, 15);
            label10.TabIndex = 14;
            label10.Text = "Choose a department";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Location = new Point(364, 54);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(44, 15);
            lblMonth.TabIndex = 16;
            lblMonth.Text = "label11";
            // 
            // btnAutoShiftAssign
            // 
            btnAutoShiftAssign.Location = new Point(594, 402);
            btnAutoShiftAssign.Name = "btnAutoShiftAssign";
            btnAutoShiftAssign.Size = new Size(157, 23);
            btnAutoShiftAssign.TabIndex = 17;
            btnAutoShiftAssign.Text = "Automatic Shift Assign";
            btnAutoShiftAssign.UseVisualStyleBackColor = true;
            btnAutoShiftAssign.Click += btnAutoShiftAssign_Click;
            // 
            // lblWeekNumber
            // 
            lblWeekNumber.AutoSize = true;
            lblWeekNumber.Location = new Point(457, 54);
            lblWeekNumber.Name = "lblWeekNumber";
            lblWeekNumber.Size = new Size(44, 15);
            lblWeekNumber.TabIndex = 18;
            lblWeekNumber.Text = "label11";
            // 
            // datePickerEnd
            // 
            datePickerEnd.Location = new Point(571, 286);
            datePickerEnd.Name = "datePickerEnd";
            datePickerEnd.Size = new Size(200, 23);
            datePickerEnd.TabIndex = 19;
            // 
            // datePickerStart
            // 
            datePickerStart.Location = new Point(571, 234);
            datePickerStart.Name = "datePickerStart";
            datePickerStart.Size = new Size(200, 23);
            datePickerStart.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(653, 215);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 21;
            label11.Text = "Start:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(653, 268);
            label12.Name = "label12";
            label12.Size = new Size(30, 15);
            label12.TabIndex = 22;
            label12.Text = "End:";
            // 
            // btnCreateShiftPeriod
            // 
            btnCreateShiftPeriod.Location = new Point(594, 373);
            btnCreateShiftPeriod.Name = "btnCreateShiftPeriod";
            btnCreateShiftPeriod.Size = new Size(157, 23);
            btnCreateShiftPeriod.TabIndex = 23;
            btnCreateShiftPeriod.Text = "Create shift in Period";
            btnCreateShiftPeriod.UseVisualStyleBackColor = true;
            btnCreateShiftPeriod.Click += btnCreateShiftPeriod_Click;
            // 
            // numericPeopleNeeded
            // 
            numericPeopleNeeded.Location = new Point(571, 332);
            numericPeopleNeeded.Name = "numericPeopleNeeded";
            numericPeopleNeeded.Size = new Size(200, 23);
            numericPeopleNeeded.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(619, 314);
            label13.Name = "label13";
            label13.Size = new Size(87, 15);
            label13.TabIndex = 25;
            label13.Text = "People Needed";
            // 
            // WeeklyShiftsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 437);
            Controls.Add(label13);
            Controls.Add(numericPeopleNeeded);
            Controls.Add(btnCreateShiftPeriod);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(datePickerStart);
            Controls.Add(datePickerEnd);
            Controls.Add(lblWeekNumber);
            Controls.Add(btnAutoShiftAssign);
            Controls.Add(lblMonth);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(cbDepartments);
            Controls.Add(lbUsers);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WeeklyShiftsForm";
            Text = "WeeklyShiftsForm";
            Load += WeeklyShiftsForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericPeopleNeeded).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button btnPrevious;
        private Button btnNext;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListBox lbUsers;
        private ComboBox cbDepartments;
        private Label label9;
        private Label label10;
        private Label lblMonth;
        private Button btnAutoShiftAssign;
        private Label lblWeekNumber;
        private DateTimePicker datePickerEnd;
        private DateTimePicker datePickerStart;
        private Label label11;
        private Label label12;
        private Button btnCreateShiftPeriod;
        private NumericUpDown numericPeopleNeeded;
        private Label label13;
    }
}