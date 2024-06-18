using BusinessLogicLayer.Class;
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

namespace MediaBazaarSemester2Retake._1.presentationLayer.Forms
{
    public partial class ViewEmployee : Form
    {
        ManageEmployee manageEmployee;
        ManageDepartment manageDepartment;
        private string employeeDepartment;
        public ViewEmployee(string _department)
        {
            InitializeComponent();
            manageEmployee = ManageEmployeeFactory.Create();
            manageDepartment = ManageDepartmentFactory.Create();
            employeeDepartment = _department;
            FillDatagrid();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = NameBox.Text.ToLower();

            if (string.IsNullOrEmpty(searchKeyword))
            {
                // If the NameBox is empty, display all employees
                FillDatagrid();
            }
            else
            {
                // Filter the list of employees based on the search keyword
                IEnumerable<Employee> filteredEmployees = manageEmployee.GetEmployeeofDepartment(employeeDepartment)
                    .Where(emp => emp.firstName.ToLower().Contains(searchKeyword) ||
                                   emp.lastName.ToLower().Contains(searchKeyword) ||
                                   emp.email.ToLower().Contains(searchKeyword) ||
                                   emp.phoneNumber.ToLower().Contains(searchKeyword));

                // Update the DataGridView with the filtered list
                FillDatagrid(filteredEmployees);
            }
        }

        private void FillDatagrid()
        {
            FillDatagrid(manageEmployee.GetEmployeeofDepartment(employeeDepartment));
        }

        private void FillDatagrid(IEnumerable<Employee> list)
        {
            dgv_Employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv_Employee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Employee.MultiSelect = false;

            var displayList = list.Select(emp => new
            {
                employeeId = emp.employeeID,
                Name = $"{emp.firstName} {emp.lastName}",
                Department = emp.Contract != null ? manageDepartment.GetDepartmentName(emp.Contract.departmentID) : "Not assigned",
                Email = emp.email,
                ContractType = emp.Contract != null ? emp.Contract.contractType : "Not assigned"
            });

            var source = new BindingSource();
            source.DataSource = displayList;
            dgv_Employee.DataSource = source;
            dgv_Employee.ScrollBars = ScrollBars.Both;
        }


    }
}
