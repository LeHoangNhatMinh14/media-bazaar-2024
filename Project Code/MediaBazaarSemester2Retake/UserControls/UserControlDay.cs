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
        private int _numberOfShifts = 0;
        public DateTime _day;
        public int NumberOfShifts
        {
            get { return _numberOfShifts; }
            set
            {
                _numberOfShifts = value;
                lblNumofShifts.Text = _numberOfShifts.ToString();
                lblNumofShifts.Visible = (_numberOfShifts > 0); // Show label only if there are shifts
                UpdateAppearance();
            }
        }

        public List<Shift> _shifts;

        public ucDays(DateTime day, List<Shift> shifts)
        {
            InitializeComponent();
            _shifts = shifts;
            _day = day;
            label1.Text = _day.Day.ToString();
        }

        private void UpdateAppearance()
        {
            this.BackColor = (_numberOfShifts > 0) ? Color.Green : Color.DarkGray;
        }
        private void ucDays_Load(object sender, EventArgs e)
        {

        }
        private void ucDays_Click(object sender, EventArgs e)
        {
            try
            {
                int day = int.Parse(label1.Text);
                int year = WeeklyShiftsForm._year;
                int month = WeeklyShiftsForm._month;
                DateTime selectedDate = new DateTime(year, month, day);

                ShiftsOnDayForm shiftsOnDayForm = new ShiftsOnDayForm(_shifts, selectedDate);
                shiftsOnDayForm.Show();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error parsing day number: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
