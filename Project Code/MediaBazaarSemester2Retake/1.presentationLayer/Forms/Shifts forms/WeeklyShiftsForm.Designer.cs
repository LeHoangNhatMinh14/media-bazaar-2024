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
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(14, 127);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(981, 116);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(376, 12);
            label1.Name = "label1";
            label1.Size = new Size(258, 54);
            label1.TabIndex = 1;
            label1.Text = "Weekly Shifts";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(14, 39);
            btnPrevious.Margin = new Padding(3, 4, 3, 4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(86, 31);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(890, 39);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(86, 31);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 103);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 4;
            label2.Text = "Monday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 103);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 5;
            label3.Text = "Tuesday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 103);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 6;
            label4.Text = "Wednesday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(464, 103);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 7;
            label5.Text = "Thursday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(616, 103);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 8;
            label6.Text = "Friday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(746, 103);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 9;
            label7.Text = "Saturday";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(890, 103);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 10;
            label8.Text = "Sunday";
            // 
            // lbUsers
            // 
            lbUsers.FormattingEnabled = true;
            lbUsers.Location = new Point(17, 287);
            lbUsers.Margin = new Padding(3, 4, 3, 4);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(326, 264);
            lbUsers.TabIndex = 11;
            lbUsers.SelectedIndexChanged += lbUsers_SelectedIndexChanged;
            // 
            // cbDepartments
            // 
            cbDepartments.FormattingEnabled = true;
            cbDepartments.Location = new Point(434, 347);
            cbDepartments.Margin = new Padding(3, 4, 3, 4);
            cbDepartments.Name = "cbDepartments";
            cbDepartments.Size = new Size(138, 28);
            cbDepartments.TabIndex = 12;
            cbDepartments.SelectedIndexChanged += cbDepartments_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 263);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 13;
            label9.Text = "Sort by users";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(434, 323);
            label10.Name = "label10";
            label10.Size = new Size(152, 20);
            label10.TabIndex = 14;
            label10.Text = "Choose a department";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Location = new Point(416, 72);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(58, 20);
            lblMonth.TabIndex = 16;
            lblMonth.Text = "label11";
            // 
            // btnAutoShiftAssign
            // 
            btnAutoShiftAssign.Location = new Point(425, 420);
            btnAutoShiftAssign.Margin = new Padding(3, 4, 3, 4);
            btnAutoShiftAssign.Name = "btnAutoShiftAssign";
            btnAutoShiftAssign.Size = new Size(179, 31);
            btnAutoShiftAssign.TabIndex = 17;
            btnAutoShiftAssign.Text = "Automatic Shift Assign";
            btnAutoShiftAssign.UseVisualStyleBackColor = true;
            btnAutoShiftAssign.Click += btnAutoShiftAssign_Click;
            // 
            // lblWeekNumber
            // 
            lblWeekNumber.AutoSize = true;
            lblWeekNumber.Location = new Point(522, 72);
            lblWeekNumber.Name = "lblWeekNumber";
            lblWeekNumber.Size = new Size(58, 20);
            lblWeekNumber.TabIndex = 18;
            lblWeekNumber.Text = "label11";
            // 
            // WeeklyShiftsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 583);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "WeeklyShiftsForm";
            Text = "WeeklyShiftsForm";
            Load += WeeklyShiftsForm_Load;
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
        private Label lblStart;
        private Label lblEnd;
    }
}