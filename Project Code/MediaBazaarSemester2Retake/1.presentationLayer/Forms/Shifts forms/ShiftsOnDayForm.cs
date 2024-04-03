using BusinessLogicLayer.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarSemester2Retake._1.presentationLayer.Forms
{
    public partial class ShiftsOnDayForm : Form
    {
        List<Shift> _shifts;
        DateTime _selectedDate;
        public ShiftsOnDayForm(List<Shift> shifts, DateTime selectedDate)
        {
            InitializeComponent();
            _shifts = shifts;
            _selectedDate = selectedDate;
        }

        private void ShiftsOnDayForm_Load(object sender, EventArgs e)
        {
            foreach (var shift in _shifts)
            {
                if (shift.shiftDate.Date == _selectedDate)
                {
                    if (shift.shiftType == "Morning")
                    {
                        lbMorningShifts.Items.Add(shift.ShiftInfo);
                    }
                    if (shift.shiftType == "Evening")
                    {
                        lbEveningShifts.Items.Add(shift.ShiftInfo);
                    }
                    if (shift.shiftType == "Night")
                    {
                        lbNightShifts.Items.Add(shift.ShiftInfo);
                    }
                }
            }
        }
    }
}
