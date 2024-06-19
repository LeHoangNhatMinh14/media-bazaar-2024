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

namespace MediaBazaarSemester2Retake
{
    public partial class ScheduleForm : Form
    {
        ManageShifts _manageShifts;
        ManageEmployee _manageEmployee;
        ManageDepartment _manageDepartment;
        ManageDaysOff mD;
        private string department;
        public ScheduleForm()
        {
            InitializeComponent();
            _manageShifts = ManageShiftFactory.Create();
            _manageEmployee = ManageEmployeeFactory.Create();
            _manageDepartment = ManageDepartmentFactory.Create();
            mD = ManageDaysOffFactory.Create();
        }
        // for department manager
        public ScheduleForm(string department)
        {
            InitializeComponent();
            _manageShifts = ManageShiftFactory.Create();
            _manageEmployee = ManageEmployeeFactory.Create();
            _manageDepartment = ManageDepartmentFactory.Create();
            mD = ManageDaysOffFactory.Create();
            this.department = department;
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(department))
            {
                cbShiftType.SelectedIndex = 0;
                lbEmployees.DataSource = _manageEmployee.GetAllEmployees();
                lbEmployees.DisplayMember = "EmployeeInfo";
                lbEmployees.ValueMember = "employeeID";
                cbDepartments.DataSource = _manageDepartment.GetDepartmentList();
                cbDepartments.DisplayMember = "_departmentName";
                cbDepartments.ValueMember = "_departmentID";
                lbUnassignedShifts.DataSource = _manageShifts.GetUnassignedShifts();
                lbUnassignedShifts.DisplayMember = "ShiftInfo";
                lbUnassignedShifts.ValueMember = "shiftid";
            }
            else
            {
                cbShiftType.SelectedIndex = 0;
                lbEmployees.DataSource = _manageEmployee.GetEmployeeofDepartment(department);
                lbEmployees.DisplayMember = "EmployeeInfo";
                lbEmployees.ValueMember = "employeeID";
                cbDepartments.DataSource = _manageDepartment.GetDepartmentbyName(department);
                cbDepartments.DisplayMember = "_departmentName";
                cbDepartments.ValueMember = "_departmentID";
                cbDepartments.Enabled = false;
                lbUnassignedShifts.DataSource = _manageShifts.GetUnassignedShifts();
                lbUnassignedShifts.DisplayMember = "ShiftInfo";
                lbUnassignedShifts.ValueMember = "shiftid";
            }

        }

        private void btnAssignShift_Click(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedItem != null && lbUnassignedShifts.SelectedItem != null)
            {
                Employee selectedEmployee = lbEmployees.SelectedItem as Employee;
                Shift selectedShift = lbUnassignedShifts.SelectedItem as Shift;

                // Check if the selected employee has any days off that overlap with the shift date
                List<RequestDaysOff> daysOffRequests = mD.GetRequestDaysOffs(selectedEmployee.employeeID);
                foreach (var daysOff in daysOffRequests)
                {
                    if (selectedShift.shiftDate >= daysOff.startDate && selectedShift.shiftDate <= daysOff.endDate)
                    {
                        MessageBox.Show("The selected employee has a day off during the shift period. Please select a different employee or shift.");
                        return;
                    }
                }

                // Proceed with assigning the shift if there are no conflicting days off
                if (_manageShifts.CanAssignShift(selectedEmployee.employeeID, selectedShift))
                {
                    int remainingPeopleNeeded = _manageShifts.AssignShift(selectedShift.shiftid, selectedEmployee.employeeID);

                    UpdateShiftsList(selectedEmployee.employeeID);

                    if (remainingPeopleNeeded > 0)
                    {
                        MessageBox.Show($"Shift has been assigned to {selectedEmployee.firstName} {selectedEmployee.lastName}. Still need {remainingPeopleNeeded} more people.");
                    }
                    else
                    {
                        MessageBox.Show($"Shift has been fully assigned to {selectedEmployee.firstName} {selectedEmployee.lastName}.");
                    }
                }
                else
                {
                    MessageBox.Show("This shift cannot be assigned to the selected employee.");
                }
            }
            else
            {
                MessageBox.Show("Please select both an employee and a shift.");
            }
        }


        private void lbEmployees_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbEmployees.SelectedItem != null)
            {
                Employee selectedEmployee = lbEmployees.SelectedItem as Employee;

                UpdateShiftsList(selectedEmployee.employeeID);
            }
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            Department department = (Department)cbDepartments.SelectedItem;
            int departmentID = department._departmentID;
            string shiftType = cbShiftType.Text;
            DateTime shiftDate = datePickerassignShift.Value;
            int peopleNeeded = (int)numericPplNeeded.Value;

            if (departmentID < 0)
            {
                MessageBox.Show("Please select a department.");
                return;
            }

            if (shiftDate == null)
            {
                MessageBox.Show("Please select a shift date.");
                return;
            }

            if (peopleNeeded <= 0)
            {
                MessageBox.Show("Please determine the number of people needed for a shift");
                return;
            }

            if (string.IsNullOrEmpty(shiftType))
            {
                MessageBox.Show("Please enter a shift type.");
                return;
            }

            DateTime dateOnlyShiftDate = new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day);

            Shift shift = new Shift(0, shiftType, peopleNeeded, dateOnlyShiftDate, departmentID);
            _manageShifts.AddShift(shift);
            lbUnassignedShifts.DataSource = _manageShifts.GetUnassignedShifts();
            lbUnassignedShifts.DisplayMember = "ShiftInfo";
            lbUnassignedShifts.ValueMember = "shiftid";
        }


        private void UpdateShiftsList(int employeeID)
        {
            lbShiftsofEmployee.DataSource = _manageShifts.GetShiftsOfEmployee(employeeID);
            lbShiftsofEmployee.DisplayMember = "ShiftInfo";
            lbUnassignedShifts.DataSource = _manageShifts.GetUnassignedShifts();
            lbUnassignedShifts.DisplayMember = "ShiftInfo";
            lbUnassignedShifts.ValueMember = "shiftid";
        }

        private void datePickerassignShift_ValueChanged_1(object sender, EventArgs e)
        {
            if (datePickerassignShift.Value < DateTime.Today)
            {
                MessageBox.Show("Please select a date that has NOT already passed.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                datePickerassignShift.Value = DateTime.Today;
            }
        }

        private void cbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepartment = cbDepartments.SelectedItem.ToString();

            lbEmployees.DataSource = _manageEmployee.GetEmployeeofDepartment(selectedDepartment);
            lbEmployees.DisplayMember = "EmployeeInfo";
        }
    }
}
