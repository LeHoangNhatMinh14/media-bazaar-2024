using BusinessLogicLayer.ManageClass;
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
    public partial class ScheduleForm : Form
    {
        ManageShifts _manageShifts;
        ManageEmployee _manageEmployee;
        public ScheduleForm(ManageShifts manageShifts, ManageEmployee manageEmployee)
        {
            _manageShifts = manageShifts;
            InitializeComponent();

        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            lbEmployees.DataSource = _manageEmployee.GetAllEmployees();
            lbEmployees.DisplayMember = "EmployeeInfo";
        }

        private void btnAssignShift_Click(object sender, EventArgs e)
        {

        }

        private void lbEmployees_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
