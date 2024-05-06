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
        ManageEmployee _manageEmployee;
        ManageShifts _manageShifts;
        List<Shift> _shifts;
        public WeeklyShiftsForm()
        {
            InitializeComponent();
            _manageEmployee = ManageEmployeeFactory.Create();
            _manageShifts = ManageShiftFactory.Create();
        }

        private void showDays(int weekOffset, List<Shift> shifts)
        {
            flowLayoutPanel1.Controls.Clear();

            DateTime currentDate = DateTime.Today;

            DateTime firstDayOfWeek = currentDate.AddDays(-((int)currentDate.DayOfWeek - 1) + 7 * weekOffset);

            for (int i = 0; i < 7; i++)
            {
                DateTime day = firstDayOfWeek.AddDays(i);
                ucDays uc = new ucDays(day.Day.ToString(),_shifts);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void WeeklyShiftsForm_Load(object sender, EventArgs e)
        {
            lbUsers.DataSource = _manageEmployee.GetAllEmployees();
            lbUsers.DisplayMember = "EmployeeInfo";

            DateTime currentDate = DateTime.Today;
            int initialWeekOffset = (currentDate.DayOfWeek == DayOfWeek.Sunday) ? 0 : 1;

            _year = currentDate.Year;
            _month = currentDate.Month;

            _shifts = new List<Shift>();

            showDays(initialWeekOffset, _shifts); 

            string currentMonth = currentDate.ToString("MMMM");
            string nextWeekMonth = currentDate.AddDays(6).ToString("MMMM");
            lblMonth.Text = (currentMonth != nextWeekMonth) ? $"{currentMonth}/{nextWeekMonth} {currentDate.Year}" : $"{currentMonth} {currentDate.Year}";

            UpdateShiftsForSelectedEmployee();
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            currentWeekOffset++;
            UpdateShiftsForSelectedEmployee();
            UpdateWeekDisplay();

            DateTime currentDate = DateTime.Today.AddDays(7 * currentWeekOffset);
            _year = currentDate.Year;
            _month = currentDate.Month;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentWeekOffset--;
            UpdateShiftsForSelectedEmployee();
            UpdateWeekDisplay();

            DateTime currentDate = DateTime.Today.AddDays(7 * currentWeekOffset);
            _year = currentDate.Year;
            _month = currentDate.Month;
        }

        private void UpdateWeekDisplay()
        {
            showDays(currentWeekOffset, _shifts);


            DateTime currentDate = DateTime.Today.AddDays(7 * currentWeekOffset);
            string currentMonth = currentDate.ToString("MMMM");
            string nextWeekMonth = currentDate.AddDays(6).ToString("MMMM");


            if (currentMonth != nextWeekMonth)
            {
                lblMonth.Text = $"{currentMonth}/{nextWeekMonth} {currentDate.Year}";
            }
            else
            {
                lblMonth.Text = $"{currentMonth} {currentDate.Year}";
            }
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
                        if (int.TryParse(uc.label1.Text, out int day))
                        {
                            var shiftsForDay = _shifts.Where(shift => shift.shiftDate.Day == day);

                            int morningShiftsCount = shiftsForDay.Count(shift => shift.shiftType == "Morning");
                            int eveningShiftsCount = shiftsForDay.Count(shift => shift.shiftType == "Evening");
                            int nightShiftsCount = shiftsForDay.Count(shift => shift.shiftType == "Night");

                            uc.MorningShiftsCount = morningShiftsCount;
                            uc.EveningShiftsCount = eveningShiftsCount;
                            uc.NightShiftsCount = nightShiftsCount;
                        }
                    }
                }
            }
        }

    }
}
