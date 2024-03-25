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
        public ScheduleForm()
        {
            InitializeComponent();
            _manageShifts = ManageShiftFactory.Create();
            _manageEmployee = ManageEmployeeFactory.Create();

        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            cbShiftType.SelectedIndex = 0;
            lbEmployees.DataSource = _manageEmployee.GetAllEmployees();
            lbEmployees.DisplayMember = "EmployeeInfo";
        }

        private void btnAssignShift_Click(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedItem != null && lbShiftsofEmployee.SelectedItem != null)
            {
                Employee selectedEmployee = lbEmployees.SelectedItem as Employee;
                Shift selectedShift = lbShiftsofEmployee.SelectedItem as Shift;

                if (_manageShifts.CanAssignShift(selectedEmployee.employeeID, selectedShift.shiftid))
                {
                    _manageShifts.AssignShift(selectedShift.shiftid, selectedEmployee.employeeID);
                    UpdateShiftsList(selectedEmployee.employeeID);
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
            int departmentIndex = cbDepartments.SelectedIndex;
            string shiftType = cbShiftType.Text;
            DateTime shiftDate = datePickerassignShift.Value;
            int peopleNeeded = (int)numericPplNeeded.Value;

            if (departmentIndex < 0)
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

            Shift shift = new Shift(0, shiftType, peopleNeeded, dateOnlyShiftDate, departmentIndex);
            _manageShifts.AddShift(shift);
        }


        private void UpdateShiftsList(int employeeID)
        {
            lbShiftsofEmployee.DataSource = _manageShifts.GetShiftsOfEmployee(employeeID);
            lbShiftsofEmployee.DisplayMember = "ShiftInfo";
        }
    }
}
