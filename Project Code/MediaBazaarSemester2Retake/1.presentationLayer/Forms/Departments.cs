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
    public partial class Departments : Form
    {
        private ManageDepartment manageDepartment;
        public Departments()
        {
            InitializeComponent();
            manageDepartment =  ManageDepartmentFactory.Create();
            GetDepartmets();
        }


        private void GetDepartmets()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Department ID");
            dataTable.Columns.Add("Department Name");
            List<Department> departments = new List<Department>();
            departments = manageDepartment.GetDepartmentList();
            foreach (Department department in departments)
            {
                dataTable.Rows.Add(department._departmentID, department._departmentName);
            }
            dataGridViewDepartments.DataSource = dataTable;
        }


        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {
            if(textBoxDepartmentName.Text == "")
            {
                MessageBox.Show("Please enter a department name.");
            }
            else
            {
                manageDepartment.AddDepartment(textBoxDepartmentName.Text);
                MessageBox.Show("Department added successfully.");
            }
        }
    }
}
