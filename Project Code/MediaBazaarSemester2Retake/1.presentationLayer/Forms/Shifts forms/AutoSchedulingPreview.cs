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

        public AutoSchedulingPreview(Shift[] shifts)
        {
            _shifts = shifts;
            InitializeComponent();
            LoadShifts();
        }

        private void LoadShifts()
        {
            DateTime firstDayOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);

            for (int i = 0; i < 7; i++)
            {
                DateTime day = firstDayOfWeek.AddDays(i);
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
