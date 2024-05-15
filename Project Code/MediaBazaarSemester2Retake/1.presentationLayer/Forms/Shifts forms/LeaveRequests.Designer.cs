namespace MediaBazaarSemester2Retake._1.presentationLayer.Forms.Shifts_forms
{
    partial class LeaveRequests
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
            lbApprovedLeaveRequests = new ListBox();
            btnApprove = new Button();
            btnDisapprove = new Button();
            tbDisapprovalReason = new TextBox();
            label1 = new Label();
            btnDone = new Button();
            lbDisapprovedRequests = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbApprovedLeaveRequests
            // 
            lbApprovedLeaveRequests.FormattingEnabled = true;
            lbApprovedLeaveRequests.ItemHeight = 15;
            lbApprovedLeaveRequests.Location = new Point(417, 12);
            lbApprovedLeaveRequests.Name = "lbApprovedLeaveRequests";
            lbApprovedLeaveRequests.Size = new Size(336, 124);
            lbApprovedLeaveRequests.TabIndex = 0;
            // 
            // btnApprove
            // 
            btnApprove.Location = new Point(12, 352);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(136, 23);
            btnApprove.TabIndex = 1;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnDisapprove
            // 
            btnDisapprove.Location = new Point(154, 352);
            btnDisapprove.Name = "btnDisapprove";
            btnDisapprove.Size = new Size(137, 23);
            btnDisapprove.TabIndex = 2;
            btnDisapprove.Text = "Disapprove";
            btnDisapprove.UseVisualStyleBackColor = true;
            btnDisapprove.Click += btnDisapprove_Click;
            // 
            // tbDisapprovalReason
            // 
            tbDisapprovalReason.Location = new Point(417, 185);
            tbDisapprovalReason.Multiline = true;
            tbDisapprovalReason.Name = "tbDisapprovalReason";
            tbDisapprovalReason.Size = new Size(336, 122);
            tbDisapprovalReason.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(492, 157);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 4;
            label1.Text = "Dissapproval Reason";
            // 
            // btnDone
            // 
            btnDone.Location = new Point(417, 313);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(336, 23);
            btnDone.TabIndex = 5;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // lbDisapprovedRequests
            // 
            lbDisapprovedRequests.FormattingEnabled = true;
            lbDisapprovedRequests.ItemHeight = 15;
            lbDisapprovedRequests.Location = new Point(12, 12);
            lbDisapprovedRequests.Name = "lbDisapprovedRequests";
            lbDisapprovedRequests.Size = new Size(279, 334);
            lbDisapprovedRequests.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(473, 352);
            label2.Name = "label2";
            label2.Size = new Size(214, 15);
            label2.TabIndex = 7;
            label2.Text = "Please give a reason for the disapproval";
            // 
            // LeaveRequests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 398);
            Controls.Add(label2);
            Controls.Add(lbDisapprovedRequests);
            Controls.Add(btnDone);
            Controls.Add(label1);
            Controls.Add(tbDisapprovalReason);
            Controls.Add(btnDisapprove);
            Controls.Add(btnApprove);
            Controls.Add(lbApprovedLeaveRequests);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LeaveRequests";
            Text = "LeaveRequests";
            Load += LeaveRequests_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbApprovedLeaveRequests;
        private Button btnApprove;
        private Button btnDisapprove;
        private TextBox tbDisapprovalReason;
        private Label label1;
        private Button btnDone;
        private ListBox lbDisapprovedRequests;
        private Label label2;
    }
}