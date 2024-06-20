namespace MediaBazaarSemester2Retake._1.presentationLayer.Forms.Shifts_forms
{
    partial class AutoSchedulingPreview
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
            btnOK = new Button();
            btnCancel = new Button();
            lblMonthYear = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(-2, 29);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(859, 89);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(656, 154);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(88, 28);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(767, 154);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 28);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblMonthYear
            // 
            lblMonthYear.AutoSize = true;
            lblMonthYear.Location = new Point(6, 167);
            lblMonthYear.Name = "lblMonthYear";
            lblMonthYear.Size = new Size(38, 15);
            lblMonthYear.TabIndex = 3;
            lblMonthYear.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 161);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 4;
            label1.Text = "Shifts preview of week ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 9);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Monday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 9);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 6;
            label3.Text = "Tuesday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 9);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 7;
            label4.Text = "Wednesday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(409, 9);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "Thursday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(528, 9);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 9;
            label6.Text = "Friday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(634, 11);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 10;
            label7.Text = "Saturday";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(767, 11);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 11;
            label8.Text = "Sunday";
            // 
            // AutoSchedulingPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 192);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblMonthYear);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(flowLayoutPanel1);
            Name = "AutoSchedulingPreview";
            Text = "Auto Scheduling Preview";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private Label lblMonthYear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }

    #endregion
}