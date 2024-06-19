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
        List<RequestDaysOff> Requests;
        RequestDaysOff selectedRequest;
        ucLeaveRequests selectedUc;
        private string departmentName = null;

        public LeaveRequests()
        {
            InitializeComponent();
            mD = ManageDaysOffFactory.Create();
            panelLeaveRequests.AutoScroll = true; // Enable scrolling
        }

        public LeaveRequests(string department)
        {
            InitializeComponent();
            mD = ManageDaysOffFactory.Create();
            panelLeaveRequests.AutoScroll = true; // Enable scrolling
            departmentName = department;
        }

        private void LeaveRequests_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(departmentName))
            {
                Requests = mD.GetDaysOff();
            }
            else
            {
                Requests = mD.GetRequestsByDepartment(departmentName);
            }

            panelLeaveRequests.Controls.Clear(); // Clear any existing controls

            foreach (RequestDaysOff requestDaysOff in Requests)
            {
                ucLeaveRequests uc = new ucLeaveRequests();
                uc.SetData(requestDaysOff); // Set the data for the user control
                uc.Selected += Uc_Selected; // Subscribe to the Selected event
                panelLeaveRequests.Controls.Add(uc);
            }

            tbDisapprovalReason.Enabled = false;
            btnDone.Enabled = false;
            label2.Enabled = false;
        }

        private void Uc_Selected(object sender, EventArgs e)
        {
            if (selectedUc != null)
            {
                selectedUc.Deselect(); // Deselect previously selected control
            }

            selectedUc = sender as ucLeaveRequests;
            selectedRequest = selectedUc.Request;
            tbDisapprovalReason.Enabled = false;
            label1.Enabled = false;
            btnDone.Enabled = false;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (selectedRequest != null)
            {
                mD.AcceptOrDecline(selectedRequest.emloyeeID, true);
                selectedRequest.approved = true;
                selectedRequest.disaprovalReason = null;

                // Update UI
                var uc = panelLeaveRequests.Controls.OfType<ucLeaveRequests>()
                    .FirstOrDefault(x => x.Request.emloyeeID == selectedRequest.emloyeeID);
                if (uc != null)
                {
                    uc.SetData(selectedRequest);
                }
            }
        }

        private void btnDisapprove_Click(object sender, EventArgs e)
        {
            if (selectedRequest != null)
            {
                if (selectedRequest.approved == true)
                {
                    MessageBox.Show("This request has been accepted. \r\nPlease select a different request.");
                    return;
                }
                else if (selectedRequest.approved == false && !string.IsNullOrEmpty(selectedRequest.disaprovalReason))
                {
                    MessageBox.Show("This request has been processed. \r\nPlease select a different request.");
                    return;
                }

                // Enable disapproval controls
                tbDisapprovalReason.Enabled = true;
                label1.Enabled = true;
                btnDone.Enabled = true;
            }
        }


        private void btnDone_Click(object sender, EventArgs e)
        {
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
                selectedRequest.approved = false;
                selectedRequest.disaprovalReason = disapprovalReason;

                // Update UI
                var uc = panelLeaveRequests.Controls.OfType<ucLeaveRequests>()
                    .FirstOrDefault(x => x.Request.emloyeeID == selectedRequest.emloyeeID);
                if (uc != null)
                {
                    uc.SetData(selectedRequest);
                }

                // Hide
                label1.Hide();
                tbDisapprovalReason.Hide();
                btnDone.Hide();
                label2.Hide();
            }
        }
    }
}
