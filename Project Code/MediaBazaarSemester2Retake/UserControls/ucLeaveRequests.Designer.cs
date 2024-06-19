namespace MediaBazaarSemester2Retake
{
    partial class ucLeaveRequests
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
            lblDate = new Label();
            lblStatus = new Label();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(3, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(78, 32);
            lblDate.TabIndex = 0;
            lblDate.Text = "label1";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblStatus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(339, 70);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(112, 30);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "label2";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(0, 32);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 21);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "label1";
            // 
            // ucLeaveRequests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(lblEmail);
            Controls.Add(lblStatus);
            Controls.Add(lblDate);
            Name = "ucLeaveRequests";
            Size = new Size(454, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDate;
        private Label lblStatus;
        private Label lblEmail;
    }
}
