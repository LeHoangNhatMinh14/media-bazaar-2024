namespace MediaBazaarSemester2Retake._1.presentationLayer.Forms
{
    partial class ShiftsOnDayForm
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
            lbMorningShifts = new ListBox();
            lbEveningShifts = new ListBox();
            lbNightShifts = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lbMorningShifts
            // 
            lbMorningShifts.FormattingEnabled = true;
            lbMorningShifts.ItemHeight = 15;
            lbMorningShifts.Location = new Point(12, 27);
            lbMorningShifts.Name = "lbMorningShifts";
            lbMorningShifts.Size = new Size(639, 79);
            lbMorningShifts.TabIndex = 0;
            // 
            // lbEveningShifts
            // 
            lbEveningShifts.FormattingEnabled = true;
            lbEveningShifts.ItemHeight = 15;
            lbEveningShifts.Location = new Point(12, 131);
            lbEveningShifts.Name = "lbEveningShifts";
            lbEveningShifts.Size = new Size(639, 94);
            lbEveningShifts.TabIndex = 1;
            // 
            // lbNightShifts
            // 
            lbNightShifts.FormattingEnabled = true;
            lbNightShifts.ItemHeight = 15;
            lbNightShifts.Location = new Point(12, 246);
            lbNightShifts.Name = "lbNightShifts";
            lbNightShifts.Size = new Size(639, 94);
            lbNightShifts.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 3;
            label1.Text = "Morning Shifts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 4;
            label2.Text = "Evening Shifts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 228);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "Night Shifts";
            // 
            // ShiftsOnDayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 354);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbNightShifts);
            Controls.Add(lbEveningShifts);
            Controls.Add(lbMorningShifts);
            Name = "ShiftsOnDayForm";
            Text = "ShiftsOnDayForm";
            Load += ShiftsOnDayForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbMorningShifts;
        private ListBox lbEveningShifts;
        private ListBox lbNightShifts;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}