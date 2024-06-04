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
using System.Windows.Forms.DataVisualization.Charting;

namespace MediaBazaarSemester2Retake._1.presentationLayer.Forms
{
    public partial class Statistics : Form
    {
        private ManageEmployee manageEmployee;
        private ManageDepartment manageDepartment;

        public Statistics()
        {
            InitializeComponent();
            manageEmployee = ManageEmployeeFactory.Create();
            manageDepartment = ManageDepartmentFactory.Create();
            LoadChart();
        }

        private void LoadChart()
        {
            var employees = manageEmployee.GetAllEmployees();
            var departments = manageDepartment.GetDepartmentList();

            chart1.Series.Clear();
            chart1.Titles.Add("Employee Count by Department");

            // Define an array of colors
            Color[] colors = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Purple };

            int colorIndex = 0;

            foreach (var department in departments)
            {
                var employeeCount = employees.Count(e => e.Contract != null && e.Contract.departmentID == department._departmentID);

                var series = new Series
                {
                    Name = department._departmentName,
                    ChartType = SeriesChartType.Column,
                    Color = colors[colorIndex % colors.Length], // Assign a color from the array
                    LegendText = department._departmentName // Set the legend text to the department name
                };

                chart1.Series.Add(series);

                series.Points.AddXY("Departments", employeeCount);

                colorIndex++;
            }
        }



    }
}
