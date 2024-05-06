namespace MediaBazaarSemester2Retake.UserControls
{
    partial class ucDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblNumofShiftsMorning = new Label();
            lblNumOfShiftsEvening = new Label();
            lblNumOfShiftsNight = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 0);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 0;
            label1.Text = "00";
            // 
            // lblNumofShiftsMorning
            // 
            lblNumofShiftsMorning.AutoSize = true;
            lblNumofShiftsMorning.Location = new Point(22, 25);
            lblNumofShiftsMorning.Name = "lblNumofShiftsMorning";
            lblNumofShiftsMorning.Size = new Size(13, 15);
            lblNumofShiftsMorning.TabIndex = 1;
            lblNumofShiftsMorning.Text = "1";
            // 
            // lblNumOfShiftsEvening
            // 
            lblNumOfShiftsEvening.AutoSize = true;
            lblNumOfShiftsEvening.Location = new Point(22, 40);
            lblNumOfShiftsEvening.Name = "lblNumOfShiftsEvening";
            lblNumOfShiftsEvening.Size = new Size(13, 15);
            lblNumOfShiftsEvening.TabIndex = 2;
            lblNumOfShiftsEvening.Text = "2";
            // 
            // lblNumOfShiftsNight
            // 
            lblNumOfShiftsNight.AutoSize = true;
            lblNumOfShiftsNight.Location = new Point(22, 55);
            lblNumOfShiftsNight.Name = "lblNumOfShiftsNight";
            lblNumOfShiftsNight.Size = new Size(13, 15);
            lblNumOfShiftsNight.TabIndex = 3;
            lblNumOfShiftsNight.Text = "3";
            // 
            // ucDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(lblNumOfShiftsNight);
            Controls.Add(lblNumOfShiftsEvening);
            Controls.Add(lblNumofShiftsMorning);
            Controls.Add(label1);
            Name = "ucDays";
            Size = new Size(116, 84);
            Load += ucDays_Load;
            Click += ucDays_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        private Label lblNumofShiftsMorning;
        private Label lblNumOfShiftsEvening;
        private Label lblNumOfShiftsNight;
    }
}
