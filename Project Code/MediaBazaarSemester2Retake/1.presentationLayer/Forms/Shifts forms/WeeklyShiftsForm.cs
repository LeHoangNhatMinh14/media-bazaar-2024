using BusinessLogicLayer.Class;
using BusinessLogicLayer.ManageClass;
using Factory;
using MediaBazaarSemester2Retake._1.presentationLayer.Forms.Shifts_forms;
using MediaBazaarSemester2Retake.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarSemester2Retake._1.presentationLayer.Forms
{
    public partial class WeeklyShiftsForm : Form
    {
        public static int _year, _month;
        private int currentWeekOffset = 0;
        private string role;
        private string department;
        ManageEmployee _manageEmployee;
        ManageShifts _manageShifts;
        ManageDepartment _manageDepartment;
        ManageAvailability _manageAvailability;
        ManageDaysOff _manageDaysOff;
        List<Shift> _shifts;
        public WeeklyShiftsForm(string role, string department)
        {
            InitializeComponent();
            _manageEmployee = ManageEmployeeFactory.Create();
            _manageShifts = ManageShiftFactory.Create();
            _manageDepartment = ManageDepartmentFactory.Create();
            _manageAvailability = ManageAvailabilityFactory.Create();
            _manageDaysOff = ManageDaysOffFactory.Create();
            this.role = role;
            this.department = department;
        }

        private void showDays(int weekOffset, List<Shift> shifts)
        {
            flowLayoutPanel1.Controls.Clear();

            DateTime currentDate = DateTime.Today;

            DateTime firstDayOfWeek = currentDate.AddDays(-((int)currentDate.DayOfWeek - 1) + 7 * weekOffset);

            for (int i = 0; i < 7; i++)
            {
                DateTime day = firstDayOfWeek.AddDays(i);
                ucDays uc = new ucDays(day, _shifts);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void WeeklyShiftsForm_Load(object sender, EventArgs e)
        {
            if (role == "Manager")
            {
                lbUsers.DataSource = _manageEmployee.GetEmployeeofDepartment(department);
                lbUsers.DisplayMember = "EmployeeInfo";

                cbDepartments.DataSource = _manageDepartment.GetDepartmentbyName(department);
                cbDepartments.DisplayMember = "_departmentName";
                cbDepartments.ValueMember = "_departmentID";
                cbDepartments.Enabled = false;
            }
            else
            {
                lbUsers.DataSource = _manageEmployee.GetAllEmployees();
                lbUsers.DisplayMember = "EmployeeInfo";

                cbDepartments.DataSource = _manageDepartment.GetDepartmentList();
                cbDepartments.DisplayMember = "_departmentName";
                cbDepartments.ValueMember = "_departmentID";

                cbDepartments.Enabled = true;
            }


            DateTime currentDate = DateTime.Today;
            int initialWeekOffset = (currentDate.DayOfWeek == DayOfWeek.Sunday) ? 0 : 1;

            if (role == "HR")
            {
                lblStart.Hide();
                lblEnd.Hide();
                datePickerEnd.Hide();
                datePickerStart.Hide();
                btnAutoShiftAssign.Hide();
            }

            _year = currentDate.Year;
            _month = currentDate.Month;

            _shifts = new List<Shift>();

            showDays(initialWeekOffset, _shifts);

            string currentMonth = currentDate.ToString("MMMM");
            string nextWeekMonth = currentDate.AddDays(6).ToString("MMMM");
            lblMonth.Text = (currentMonth != nextWeekMonth) ? $"{currentMonth}/{nextWeekMonth} {currentDate.Year}" : $"{currentMonth} {currentDate.Year}";

            UpdateWeekDisplay();
            UpdateShiftsForSelectedEmployee();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today.AddDays(7 * currentWeekOffset);
            _year = currentDate.Year;
            _month = currentDate.Month;

            currentWeekOffset++;
            UpdateShiftsForSelectedEmployee();
            UpdateWeekDisplay();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today.AddDays(7 * currentWeekOffset);
            _year = currentDate.Year;
            _month = currentDate.Month;

            currentWeekOffset--;
            UpdateShiftsForSelectedEmployee();
            UpdateWeekDisplay();
        }

        private void UpdateWeekDisplay()
        {
            showDays(currentWeekOffset, _shifts);


            DateTime currentDate = DateTime.Today.AddDays(7 * currentWeekOffset);
            string currentMonth = currentDate.ToString("MMMM");
            string nextWeekMonth = currentDate.AddDays(6).ToString("MMMM");

            int weekNumber = GetIso8601WeekOfYear(currentDate);


            if (currentMonth != nextWeekMonth)
            {
                lblMonth.Text = $"{currentMonth}/{nextWeekMonth} {currentDate.Year}";
            }
            else
            {
                lblMonth.Text = $"{currentMonth} {currentDate.Year}";
            }
            lblWeekNumber.Text = $"Week {weekNumber}";
            UpdateShiftsForSelectedEmployee();
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateShiftsForSelectedEmployee();
        }

        private void UpdateShiftsForSelectedEmployee()
        {
            if (lbUsers.SelectedItem != null)
            {
                Employee selectedEmployee = (Employee)lbUsers.SelectedItem;
                _shifts = _manageShifts.GetShiftsOfEmployee(selectedEmployee.employeeID);

                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is ucDays uc)
                    {
                        DateTime controlDate = uc._day; // Add a Date property to ucDays to get the DateTime object
                        int shiftsCount = _shifts.Count(shift => shift.shiftDate.Date == controlDate.Date);
                        uc.NumberOfShifts = shiftsCount;
                        uc._shifts = _shifts;
                    }
                }
            }
        }
        private void cbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepartment = cbDepartments.SelectedItem.ToString();

            lbUsers.DataSource = _manageEmployee.GetEmployeeofDepartment(selectedDepartment);
            lbUsers.DisplayMember = "EmployeeInfo";
        }

        private void btnAutoShiftAssign_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + 7);
            DateTime end = start.AddDays(6);
            string department = cbDepartments.Text;

            var shiftsList = _manageShifts.GetShiftsbyperiod(start, end, department);
            List<Shift> shiftsToPreview = new List<Shift>();

            if (!shiftsList.Any())
            {
                MessageBox.Show("No shifts available for the selected department.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (Shift shift in shiftsList)
            {
                if (shift.peopleNeeded > 0)
                {
                    var employeesofDepartment = _manageEmployee.GetEmployeeofDepartment(department);

                    bool shiftAdded = false;
                    foreach (Employee employee in employeesofDepartment)
                    {
                        var DaysOffs = _manageDaysOff.GetDaysOff(employee.employeeID);
                        bool isOnDaysOff = false;
                        if (DaysOffs != null)
                        {
                            isOnDaysOff = DaysOffs.startDate <= shift.shiftDate && shift.shiftDate <= DaysOffs.endDate;
                        }
                        if (!_manageShifts.isEmployeeOnShift(shift.shiftid, employee.employeeID) &&
                            _manageAvailability.IsEmployeeAvailableforShift(employee.employeeID, shift.shiftDate)&&
                            _manageShifts.CanAssignShift(employee.employeeID, shift) &&
                            !isOnDaysOff)
                        {
                            
                            shiftsToPreview.Add(shift);
                            shift.EmployeeEmail = $"{employee.firstName} {employee.lastName}";
                            shiftAdded = true;
                            break;
                        }
                    }
                }
            }

            if (!shiftsToPreview.Any())
            {
                MessageBox.Show("No available employees found for any shift.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

                DateTime currentDate = DateTime.Today.AddDays(7 * (currentWeekOffset + 1));
                AutoSchedulingPreview previewForm = new AutoSchedulingPreview(shiftsToPreview.ToArray())
                {
                    MonthYear = lblMonth.Text,
                    WeekNumber = GetIso8601WeekOfYear(currentDate)
                };
                if (previewForm.ShowDialog() == DialogResult.OK)
                {
                    bool shiftsAssigned = false;

                    foreach (var shift in shiftsToPreview)
                    {
                        var employeesofDepartment = _manageEmployee.GetEmployeeofDepartment(department);

                        foreach (Employee employee in employeesofDepartment)
                        {
                        var DaysOffs = _manageDaysOff.GetDaysOff(employee.employeeID);
                        bool isOnDaysOff = DaysOffs.startDate <= shift.shiftDate && shift.shiftDate <= DaysOffs.endDate;
                        if (!_manageShifts.isEmployeeOnShift(shift.shiftid, employee.employeeID) &&
                                _manageAvailability.IsEmployeeAvailableforShift(employee.employeeID, shift.shiftDate) &&
                                _manageShifts.CanAssignShift(employee.employeeID, shift) &&
                                !isOnDaysOff)
                            {
                                _manageShifts.AssignShift(shift.shiftid, employee.employeeID);
                                shiftsAssigned = true;
                            }
                        }
                    }

                    if (shiftsAssigned)
                    {
                        MessageBox.Show("Shifts successfully assigned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Shift assignment was canceled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }




        private int GetIso8601WeekOfYear(DateTime date)
        {
            var day = (int)CultureInfo.CurrentCulture.Calendar.GetDayOfWeek(date);
            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}
