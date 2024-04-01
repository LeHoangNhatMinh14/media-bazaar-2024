using BusinessLogicLayer.ManageClass;
using MediaBazaarSemester2Retake._1.presentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarSemester2Retake
{
    public partial class MainMenu : Form
    {
        EmployeeForm employeeForm = new EmployeeForm();
        ScheduleForm scheduleForm = new ScheduleForm();
        WeeklyShiftsForm WeeklyShiftsForm = new WeeklyShiftsForm();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetCrudeOn();
            btnBack.Visible = true;
            btnStockmanagementCLicked.Visible=true;
          
            btnCreateProductManagement.Visible = true;
            btnDeleteProductManagement.Visible = true;
            btnUpdateProductManagement.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scheduleForm.Hide();


            employeeForm.TopLevel = false;
            employeeForm.FormBorderStyle = FormBorderStyle.None;
            employeeForm.Dock = DockStyle.Fill;


            PnlMainMenu.Controls.Add(employeeForm);
            employeeForm.Show();
            btnBack.Visible = true;
            btnupdateEmployeeManagement.Visible = true;
            btnDeleteEMployeeManagement.Visible = true;
            btnCreateEmployee.Visible = true;
            //pnlEmployeeManagement.Visible = true;


            btnSchedule.Visible = false;
            btnProductManagement.Visible = false;
            btnStockManagement.Visible = false;



        }
        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            btnBack.Visible = true;
            ProductManagementClicked.Visible = true;
            btnProductManagement.Visible = false;
            btnSchedule.Visible = false;
            btnEmployeeManagement.Visible = false;
            btnStockManagement.Visible = false;
            btnCreateProductManagement.Visible = true;
            btnDeleteProductManagement.Visible = true;
            btnUpdateProductManagement.Visible = true;
        }

        public void SetCrudeOn()
        {
            btnBack.Visible = true;
            btnSchedule.Visible = false;
            btnProductManagement.Visible = false;
            btnStockManagement.Visible = false;
            btnEmployeeManagement.Visible = false;
        }
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            PnlMainMenu.Controls.Clear(); // Clear the panel before adding new content.

            // Instantiate the WeeklyShiftsForm
            WeeklyShiftsForm = new WeeklyShiftsForm();
            WeeklyShiftsForm.TopLevel = false;
            WeeklyShiftsForm.FormBorderStyle = FormBorderStyle.None;
            WeeklyShiftsForm.Dock = DockStyle.Fill;

            // Add the form to the panel
            PnlMainMenu.Controls.Add(WeeklyShiftsForm);

            // Show the form
            WeeklyShiftsForm.Show();
            #region
            SetCrudeOn();
            btnBack.Visible = true;
            btnScheduleManagementClicked.Visible = true;
            btnCreateScheduleManagement.Visible = true;
            btnUpdateScheduleManagement.Visible = true;
            btnDeleteScheduleManagement.Visible = true;
            btnProductManagement.Visible = false;
            #endregion
        }
        public void CLear()
        {
            ProductManagementClicked.Visible = false;
            btnCreateProductManagement.Visible = false;
            btnDeleteProductManagement.Visible = false;
            btnUpdateProductManagement.Visible = false;

            btnupdateEmployeeManagement.Visible = false;
            btnDeleteEMployeeManagement.Visible = false;
            btnCreateEmployee.Visible = false;

            btnUpdateScheduleManagement.Visible = false;
            btnCreateScheduleManagement.Visible = false;
            btnDeleteScheduleManagement.Visible = false;


            btnUpdateScheduleManagement.Visible = false;

            btnProductManagement.Visible = true;
            btnSchedule.Visible = true;
            btnEmployeeManagement.Visible = true;
            btnStockManagement.Visible = true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {btnStockmanagementCLicked.Visible = false;
            btnBack.Visible = false;
           // pnlEmployeeManagement.Visible = false;
            ProductManagementClicked.Visible = false;
            btnCreateProductManagement.Visible = false;
            btnDeleteProductManagement.Visible = false;
            btnUpdateProductManagement.Visible = false;
            btnScheduleManagementClicked.Visible = false;
            
            btnupdateEmployeeManagement.Visible = false;
            btnDeleteEMployeeManagement.Visible = false;
            btnCreateEmployee.Visible = false;  

            btnUpdateScheduleManagement.Visible = false;
            btnCreateScheduleManagement.Visible = false;
            btnDeleteScheduleManagement.Visible = false;

           
            btnUpdateScheduleManagement.Visible = false;

            btnProductManagement.Visible = true;
            btnSchedule.Visible = true;
            btnEmployeeManagement.Visible = true;
            btnStockManagement.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PnlMainMenu.Controls.Clear(); // Clear the panel before adding new content.

            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.TopLevel = false;
            employeeForm.FormBorderStyle = FormBorderStyle.None;
            employeeForm.Dock = DockStyle.Fill;
            PnlMainMenu.Controls.Add(employeeForm); // Add the form to the panel.
            employeeForm.Show(); // Displa
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCreateScheduleManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateProductManagement_Click(object sender, EventArgs e)
        {

        }
    }
}
