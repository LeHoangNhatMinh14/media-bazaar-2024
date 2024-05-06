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
            comboBox1 = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            btnSearch = new Button();
            lblMonth = new Label();
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(329, 215);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
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
            label10.Location = new Point(329, 197);
            label10.Name = "label10";
            label10.Size = new Size(121, 15);
            label10.TabIndex = 14;
            label10.Text = "Choose a department";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(329, 402);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 23);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Location = new Point(406, 54);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(44, 15);
            lblMonth.TabIndex = 16;
            lblMonth.Text = "label11";
            // 
            // WeeklyShiftsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 437);
            Controls.Add(lblMonth);
            Controls.Add(btnSearch);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(comboBox1);
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
        private ComboBox comboBox1;
        private Label label9;
        private Label label10;
        private Button btnSearch;
        private Label lblMonth;
    }
}