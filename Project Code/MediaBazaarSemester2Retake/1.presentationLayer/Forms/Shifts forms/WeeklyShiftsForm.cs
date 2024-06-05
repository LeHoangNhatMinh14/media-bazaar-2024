using BusinessLogicLayer.Class;
using BusinessLogicLayer.ManageClass;
using Factory;
using MediaBazaarSemester2Retake.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        List<Shift> _shifts;
        public WeeklyShiftsForm(string role, string department)
        {
            InitializeComponent();
            _manageEmployee = ManageEmployeeFactory.Create();
            _manageShifts = ManageShiftFactory.Create();
            _manageDepartment = ManageDepartmentFactory.Create();
            _manageAvailability = ManageAvailabilityFactory.Create();
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
            lbUsers.DataSource = _manageEmployee.GetAllEmployees();
            lbUsers.DisplayMember = "EmployeeInfo";

            cbDepartments.DataSource = _manageDepartment.GetDepartmentList();
            cbDepartments.DisplayMember = "_departmentName";
            cbDepartments.ValueMember = "_departmentID";

            DateTime currentDate = DateTime.Today;
            int initialWeekOffset = (currentDate.DayOfWeek == DayOfWeek.Sunday) ? 0 : 1;

            if (role == "HR")
            {
                lblStart.Hide();
                lblEnd.Hide();
                datePickerEnd.Hide();
                datePickerStart.Hide();
                numericPeopleNeeded.Hide();
                btnAutoShiftAssign.Hide();
                btnCreateShiftPeriod.Hide();
                lblPplNeeded.Hide();
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
            AutomaticScheduling();
        }
        private void AutomaticScheduling()
        {
            DateTime start =DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            DateTime end = start.AddDays(6);
            string department = cbDepartments.Text;

            var shiftsList = _manageShifts.GetShiftsbyperiod(start, end, department);
            foreach (Shift shift in shiftsList)
            {
                if (shift.peopleNeeded == 0)
                {
                    continue;
                }

                var employeesofDepartment = _manageEmployee.GetEmployeeofDepartment(department);

                for (int i = 0; i < shiftsList.Count; i++)
                {
                    foreach (Employee employee in employeesofDepartment)
                    {
                        if (_manageShifts.isEmployeeOnShift(shift.shiftid, employee.employeeID))
                        {
                            continue;
                        }

                        if (_manageAvailability.IsEmployeeAvailableforShift(employee.employeeID, shift.shiftDate))
                        {
                            _manageShifts.AssignShift(shift.shiftid, employee.employeeID);
                        }

                    }
                }
            }
        }


        private int GetIso8601WeekOfYear(DateTime date)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(new DateTime(date.Year, 1, 4));

            int daysToAdd = day >= DayOfWeek.Monday && day <= DayOfWeek.Thursday ? -((int)day) + 1 : 8 - (int)day;

            DateTime firstMondayOfYear = new DateTime(date.Year, 1, 4).AddDays(daysToAdd);

            int weekNumber = (date.DayOfYear - firstMondayOfYear.DayOfYear) / 7 + 1;

            if (weekNumber == 0)
            {
                weekNumber = GetIso8601WeekOfYear(new DateTime(date.Year - 1, 12, 31));
            }
            else if (weekNumber == 53 && firstMondayOfYear.DayOfWeek != DayOfWeek.Thursday && firstMondayOfYear.DayOfWeek != DayOfWeek.Wednesday)
            {
                weekNumber = 1;
            }

            return weekNumber;
        }

        private void btnCreateShiftPeriod_Click(object sender, EventArgs e)
        {
        //    DateTime start = datePickerStart.Value.Date;
        //    DateTime end = datePickerEnd.Value.Date;

        //    int departmentID = (int)cbDepartments.SelectedValue;
        //    int peopleNeeded = Convert.ToInt32(numericPeopleNeeded.Value);

        //    if (cbDepartments.SelectedItem == null)
        //    {
        //        MessageBox.Show("Please select a department");
        //    }

        //    if (start < DateTime.Today)
        //    {
        //        MessageBox.Show("Please select a time after today");
        //    }

        //    if (end < DateTime.Today || end > DateTime.Today.AddDays(35))
        //    {
        //        MessageBox.Show("Please select a time after today or a day 5 weeks from now");
        //    }

        //    if (peopleNeeded < 0)
        //    {
        //        MessageBox.Show("Please specify the number of people needed for the shifts");
        //    }

        //    _manageShifts.CreateShiftinPeriod(start, end, departmentID, peopleNeeded);

        //    MessageBox.Show($"Created shifts from {start.ToString("dd/MM/yyyy")} to {end.ToString("dd/MM/yyyy")}");
        }
    }
}
