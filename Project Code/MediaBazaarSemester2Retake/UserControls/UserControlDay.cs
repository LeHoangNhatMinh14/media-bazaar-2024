using BusinessLogicLayer.Class;
using MediaBazaarSemester2Retake._1.presentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarSemester2Retake.UserControls
{
    public partial class ucDays : UserControl
    {
        private int _morningShiftsCount = 0;
        private int _eveningShiftsCount = 0;
        private int _nightShiftsCount = 0;

        string _day;
        public int MorningShiftsCount
        {
            get { return _morningShiftsCount; }
            set
            {
                _morningShiftsCount = value;
                lblNumofShiftsMorning.Text = $"Morning shifts: {_morningShiftsCount}";
                lblNumofShiftsMorning.Visible = _morningShiftsCount > 0;
                UpdateAppearance();
            }
        }

        public int EveningShiftsCount
        {
            get { return _eveningShiftsCount; }
            set
            {
                _eveningShiftsCount = value;
                lblNumOfShiftsEvening.Text = $"Evening shifts: {_eveningShiftsCount}";
                lblNumOfShiftsEvening.Visible = _eveningShiftsCount > 0;
                UpdateAppearance();
            }
        }

        public int NightShiftsCount
        {
            get { return _nightShiftsCount; }
            set
            {
                _nightShiftsCount = value;
                lblNumOfShiftsNight.Text = $"Night shifts: {_nightShiftsCount}";
                lblNumOfShiftsNight.Visible = _nightShiftsCount > 0;
                UpdateAppearance();
            }
        }
        List<Shift> _shifts;
        public ucDays(string day, List<Shift> shifts)
        {
            InitializeComponent();
            _shifts = shifts;
            _day = day;
            label1.Text = _day;
        }
        private void UpdateAppearance()
        {
            lblNumofShiftsMorning.ForeColor = _morningShiftsCount > 0 ? Color.Yellow : Color.Black;

            lblNumOfShiftsEvening.ForeColor = _eveningShiftsCount > 0 ? Color.Blue : Color.Black;

            lblNumOfShiftsNight.ForeColor = _nightShiftsCount > 0 ? Color.Red : Color.Black;

            if (_morningShiftsCount > 0 || _eveningShiftsCount > 0 || _nightShiftsCount > 0)
                this.BackColor = Color.Green;
            else
                this.BackColor = Color.DarkGray;
        }

        private void ucDays_Load(object sender, EventArgs e)
        {

        }

        private void ucDays_Click(object sender, EventArgs e)
        {
            int day = int.Parse(label1.Text);

            int year = WeeklyShiftsForm._year;
            int month = WeeklyShiftsForm._month;

            DateTime selectedDate = new DateTime(year, month, day);

            ShiftsOnDayForm shiftsOnDayForm = new ShiftsOnDayForm(_shifts, selectedDate);
            shiftsOnDayForm.Show();
        }
    }
}
