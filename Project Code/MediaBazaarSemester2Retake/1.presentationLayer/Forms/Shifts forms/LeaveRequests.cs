using BusinessLogicLayer.Class;
using BusinessLogicLayer.ManageClass;
using Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarSemester2Retake._1.presentationLayer.Forms.Shifts_forms
{
    public partial class LeaveRequests : Form
    {
        ManageDaysOff mD;
        List<RequestDaysOff> approvedRequests;
        List<RequestDaysOff> disapprovedRequests;
        public LeaveRequests()
        {
            InitializeComponent();
            mD = ManageDaysOffFactory.Create();
        }

        private void LeaveRequests_Load(object sender, EventArgs e)
        {
            disapprovedRequests= mD.GetDaysOff(false);
            lbDisapprovedRequests.DataSource = disapprovedRequests;
            lbDisapprovedRequests.DisplayMember = "RequestInfo";
            approvedRequests = mD.GetDaysOff(true);
            lbApprovedLeaveRequests.DataSource = approvedRequests;
            lbApprovedLeaveRequests.DisplayMember = "RequesteInfo";
            RefreshListBoxes();
            label1.Hide();
            tbDisapprovalReason.Hide();
            btnDone.Hide();
            label2.Hide();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            RequestDaysOff selectedRequest = lbDisapprovedRequests.SelectedItem as RequestDaysOff;
            if (selectedRequest != null)
            {
                mD.AcceptOrDecline(selectedRequest.emloyeeID,true);
                disapprovedRequests.Remove(selectedRequest);
                approvedRequests.Add(selectedRequest);
                RefreshListBoxes();
            }
        }

        private void btnDisapprove_Click(object sender, EventArgs e)
        {
            tbDisapprovalReason.Show();
            label1.Show();
            btnDone.Show();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            RequestDaysOff selectedRequest = lbDisapprovedRequests.SelectedItem as RequestDaysOff;
            if (selectedRequest != null)
            {
                // Retrieve the disapproval reason
                string disapprovalReason = tbDisapprovalReason.Text.Trim();
                if (string.IsNullOrEmpty(disapprovalReason))
                {
                    MessageBox.Show("Please provide a reason for disapproval.", "Disapproval Reason Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Call method to update request status and disapproval reason
                mD.AcceptOrDecline(selectedRequest.emloyeeID, false, disapprovalReason);

                // Hide
                label1.Hide();
                tbDisapprovalReason.Hide();
                btnDone.Hide();
                label2.Hide();
            }
        }

        private void RefreshListBoxes()
        {
            lbApprovedLeaveRequests.DataSource = null;
            lbApprovedLeaveRequests.DataSource = approvedRequests;
            lbApprovedLeaveRequests.DisplayMember = "RequestInfo";

            lbDisapprovedRequests.DataSource = null;
            lbDisapprovedRequests.DataSource = disapprovedRequests;
            lbDisapprovedRequests.DisplayMember = "RequestInfo";
        }
    }
}
