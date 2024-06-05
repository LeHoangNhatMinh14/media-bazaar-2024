using BusinessLogicLayer.ManageClass;
using MediaBazaarSemester2Retake._1.presentationLayer.Forms;
using MediaBazaarSemester2Retake._1.presentationLayer.Forms.Shifts_forms;
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
        private string userRole;
        private string department;
        EmployeeForm employeeForm = new EmployeeForm();
        ScheduleForm scheduleForm = new ScheduleForm();
        WeeklyShiftsForm WeeklyShiftsForm = null;
        Departments Departments = new Departments();
        ProductForm productForm = new ProductForm();
        StockForm stockForm = new StockForm();
        public MainMenu(string role, string department)
        {
            InitializeComponent();
            userRole = role;
            ConfigureAccessBasedOnRole();
            UpdateUIWithUserRole();
            this.department = department;
        }
        private void UpdateUIWithUserRole()
        {
            lbRoleInput.Text = userRole; // Update the label with the user's role
        }
        private void ConfigureAccessBasedOnRole()
        {
            // Default to all disabled
            SetAllTabsVisibility(false);

            switch (userRole)
            {
                case "Admin":
                    // Enable all functionality for Admin
                    SetAllTabsVisibility(true);
                    break;
                case "HR":
                case "HR2":
                    // Enable only employee management for HR
                    btnEmployeeManagement.Visible = true;
                    btnSchedule.Visible = true;
                    //    btnDeleteEmployeeManagement.Visible = true;
                    //  btnUpdateEmployeeManagement.Visible = true;
                    break;
                case "Schedule":
                    // Enable access to schedule management for Schedule Managers
                    btnSchedule.Visible = true;
                    break;
                case "Department":
                    // Enable access to department-specific functionalities
                    btnDepartmentManagement.Visible = true; // Assuming you have a button for department management
                    break;
            }
        }


        private void SetAllTabsVisibility(bool visible)
        {
            btnSchedule.Visible = visible;
            btnProductManagement.Visible = visible;
            btnStockManagement.Visible = visible;
            btnEmployeeManagement.Visible = visible;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            PnlMainMenu.Controls.Clear();
            stockForm.TopLevel = false;
            stockForm.FormBorderStyle = FormBorderStyle.None;
            stockForm.Dock = DockStyle.Fill;
            PnlMainMenu.Controls.Add(stockForm);
            stockForm.Show();
            btnBack.Visible = true;
            SetCrudeOn();
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
            PnlMainMenu.Controls.Clear();

            // Instantiate the WeeklyShiftsForm
            scheduleForm = new ScheduleForm();
            scheduleForm.TopLevel = false;
            scheduleForm.FormBorderStyle = FormBorderStyle.None;
            scheduleForm.Dock = DockStyle.Fill;

            // Add the form to the panel
            PnlMainMenu.Controls.Add(scheduleForm);

            // Show the form
            scheduleForm.Show();
            #region
            SetCrudeOn();
            btnBack.Visible = true;
            btnScheduleManagementClicked.Visible = true;
            btnCreateScheduleManagement.Visible = true;
            btnUpdateScheduleManagement.Visible = true;
            btnWeeklyScheduleManagement.Visible = true;
            btnProductManagement.Visible = false;
            #endregion
        }
        public void CLear()
        {
            btnDepartmentManagement.Visible = false;
            btnCreateProductManagement.Visible = false;
            btnDeleteProductManagement.Visible = false;
            btnUpdateProductManagement.Visible = false;

            btnupdateEmployeeManagement.Visible = false;
            btnDeleteEMployeeManagement.Visible = false;
            btnCreateEmployee.Visible = false;

            btnUpdateScheduleManagement.Visible = false;
            btnCreateScheduleManagement.Visible = false;
            btnWeeklyScheduleManagement.Visible = false;


            btnUpdateScheduleManagement.Visible = false;

            btnProductManagement.Visible = true;
            btnSchedule.Visible = true;
            btnEmployeeManagement.Visible = true;
            btnStockManagement.Visible = true;
        }
        private void btnStockManagement_Click(object sender, EventArgs e)
        {
            PnlMainMenu.Controls.Clear();
            stockForm.TopLevel = false;
            stockForm.FormBorderStyle = FormBorderStyle.None;
            stockForm.Dock = DockStyle.Fill;
            PnlMainMenu.Controls.Add(stockForm);
            stockForm.Show();
            btnBack.Visible = true;
            SetCrudeOn();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            CLear();
            ConfigureAccessBasedOnRole();
            UpdateUIWithUserRole();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            PnlMainMenu.Controls.Clear();

            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.TopLevel = false;
            employeeForm.FormBorderStyle = FormBorderStyle.None;
            employeeForm.Dock = DockStyle.Fill;
            PnlMainMenu.Controls.Add(employeeForm);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateScheduleManagement_Click(object sender, EventArgs e)
        {
            PnlMainMenu.Controls.Clear();


            LeaveRequests leaveRequests = new LeaveRequests();
            leaveRequests.TopLevel = false;
            leaveRequests.FormBorderStyle = FormBorderStyle.None;
            leaveRequests.Dock = DockStyle.Fill;


            PnlMainMenu.Controls.Add(leaveRequests);
            leaveRequests.Show();
        }

        private void btnCreateProductManagement_Click(object sender, EventArgs e)
        {
        }

        private void btnWeeklyScheduleManagement_Click(object sender, EventArgs e)
        {
            PnlMainMenu.Controls.Clear();


          
            WeeklyShiftsForm = new WeeklyShiftsForm(userRole, department);
            WeeklyShiftsForm.TopLevel = false;
            WeeklyShiftsForm.FormBorderStyle = FormBorderStyle.None;
            WeeklyShiftsForm.Dock = DockStyle.Fill;


            PnlMainMenu.Controls.Add(WeeklyShiftsForm);


            WeeklyShiftsForm.Show();
            #region
            SetCrudeOn();
            btnBack.Visible = true;
            btnScheduleManagementClicked.Visible = true;
            btnCreateScheduleManagement.Visible = true;
            btnUpdateScheduleManagement.Visible = true;
            btnWeeklyScheduleManagement.Visible = true;
            btnProductManagement.Visible = false;
            #endregion
        }

        private void btnScheduleManagementClicked_Click(object sender, EventArgs e)
        {
            PnlMainMenu.Controls.Clear(); // Clear the panel before adding new content.

            scheduleForm = new ScheduleForm();
            scheduleForm.TopLevel = false;
            scheduleForm.FormBorderStyle = FormBorderStyle.None;
            scheduleForm.Dock = DockStyle.Fill;


            PnlMainMenu.Controls.Add(scheduleForm);


            scheduleForm.Show();
        }

        private void lbRoleInput_Click(object sender, EventArgs e)
        {

        }

        private void lblMainmenuName_Click(object sender, EventArgs e)
        {

        }

        private void btnDepartmentManagement_Click(object sender, EventArgs e)
        {
            ConfigureAccessBasedOnRole();
            UpdateUIWithUserRole();
            Departments departments = new Departments();
            departments.TopLevel = false;
            departments.FormBorderStyle = FormBorderStyle.None;
            departments.Dock = DockStyle.Fill;

            PnlMainMenu.Controls.Clear();
            PnlMainMenu.Controls.Add(departments);
            departments.Show();



        }
        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            PnlMainMenu.Controls.Clear();
            productForm.TopLevel = false;
            productForm.FormBorderStyle = FormBorderStyle.None;
            productForm.Dock = DockStyle.Fill;
            PnlMainMenu.Controls.Add(productForm);
            productForm.Show();
            btnBack.Visible = true;
            btnCreateProductManagement.Visible = true;
            btnDeleteProductManagement.Visible = true;
            btnUpdateProductManagement.Visible = true;
            SetCrudeOn();
        }
      

        private void Logout()
        {
            // Reset userRole
            userRole = string.Empty;

            // Reset UI elements
            UpdateUIWithUserRole();
            SetAllTabsVisibility(false);
            CLear();

            // Clear the panel
            PnlMainMenu.Controls.Clear();

            // Navigate back to the login screen
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide(); // Assuming you want to hide the main menu form after logging out
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Logout();
        }
    }
}
