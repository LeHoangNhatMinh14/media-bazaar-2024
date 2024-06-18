using BusinessLogicLayer.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarSemester2Retake
{
    public partial class ucLeaveRequests : UserControl
    {
        public RequestDaysOff Request { get; private set; }

        public ucLeaveRequests()
        {
            InitializeComponent();
            this.Click += UcLeaveRequests_Click;
        }

        public void SetData(RequestDaysOff request)
        {
            Request = request;
            lblDate.Text = $"{request.startDate.ToString("dd/MM/yyyy")} - {request.endDate.ToString("dd/MM/yyyy")}";
            lblEmail.Text = request.employeeEmail;

            if (request.approved)
            {
                lblStatus.Text = "Approved";
                lblStatus.BackColor = Color.Green; // Approved color
            }
            else if (!string.IsNullOrEmpty(request.disaprovalReason))
            {
                lblStatus.Text = "Declined";
                lblStatus.BackColor = Color.Red; // Declined color
            }
            else
            {
                lblStatus.Text = string.Empty; // Not touched
                lblStatus.BackColor = Color.Transparent;
            }
        }

        private void UcLeaveRequests_Click(object sender, EventArgs e)
        {
            OnSelected(EventArgs.Empty);
        }

        public event EventHandler Selected;

        protected virtual void OnSelected(EventArgs e)
        {
            this.BackColor = Color.LightBlue; // Change background color when selected
            Selected?.Invoke(this, e);
        }

        public void Deselect()
        {
            this.BackColor = Color.Gray; // Reset background color when deselected
        }
    }
}
