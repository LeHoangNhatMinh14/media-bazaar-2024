using BusinessLogicLayer.Class;
using MediaBazaarSemester2Retake.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MediaBazaarSemester2Retake._1.presentationLayer.Forms.Shifts_forms
{
    public partial class AutoSchedulingPreview : Form
    {
        private Shift[] _shifts;
        public string MonthYear
        {
            get { return lblMonthYear.Text; }
            set { lblMonthYear.Text = value; }
        }
        private int weekNumber;
        public int WeekNumber
        {
            get { return weekNumber; }
            set
            {
                weekNumber = value;
                label1.Text = $"Shifts preview form - Week {weekNumber}";
            }
        }

        public AutoSchedulingPreview(Shift[] shifts)
        {
            _shifts = shifts;
            InitializeComponent();
            LoadShifts();
        }

        private void LoadShifts()
        {
            DateTime today = DateTime.Today;
            int daysUntilNextWeek = ((int)DayOfWeek.Sunday - (int)today.DayOfWeek + 7) % 7;
            DateTime firstDayOfNextWeek = today.AddDays(daysUntilNextWeek);

            for (int i = 0; i < 7; i++)
            {
                DateTime day = firstDayOfNextWeek.AddDays(i);
                List<Shift> dayShifts = _shifts.Where(s => s.shiftDate.Date == day.Date).ToList();
                ucDays uc = new ucDays(day, dayShifts);
                uc.NumberOfShifts = dayShifts.Count;
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
