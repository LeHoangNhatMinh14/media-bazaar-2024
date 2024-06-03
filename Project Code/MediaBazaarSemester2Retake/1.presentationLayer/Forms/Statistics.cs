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

            var employeeCountByDepartment = departments.Select(d => new
            {
                DepartmentName = d._departmentName,
                EmployeeCount = employees.Count(e => e.Contract != null && e.Contract.departmentID == d._departmentID)
            }).ToList();

            chart1.Series.Clear();
            chart1.Titles.Add("Employee Count by Department");

            var series = new Series
            {
                Name = "Employees",
                Color = System.Drawing.Color.Green,
                ChartType = SeriesChartType.Column
            };

            chart1.Series.Add(series);

            foreach (var item in employeeCountByDepartment)
            {
                series.Points.AddXY(item.DepartmentName, item.EmployeeCount);
            }

            chart1.Invalidate();
        }
    }
}
