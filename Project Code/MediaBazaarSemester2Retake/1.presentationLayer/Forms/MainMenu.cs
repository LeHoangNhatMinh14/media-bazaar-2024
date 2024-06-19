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
        Statistics statisticsForm = new Statistics();

        public MainMenu(string role, string department)
        {
            InitializeComponent();
            userRole = role;
            this.department = department;
            ConfigureAccessBasedOnRole();
            UpdateUIWithUserRole();
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
                    btnWeeklyScheduleManagement.Visible = true;
                    btnStatisticsForm.Visible = true;
                    break;
                case "Schedule":
                    // Enable access to schedule management for Schedule Managers
                    btnSchedule.Visible = true;
                    btnWeeklyScheduleManagement.Visible = true;
                    btnStockManagement.Visible = false;
                    btnStockmanagementCLicked.Visible = false;
                    break;
                case "Product":
                    // Enable access to product management
                    btnProductManagement.Visible = true;
                    btnStockmanagementCLicked.Visible = false;
                    break;
                case "Stock":
                    // Enable access to stock management only
                    btnStockManagement.Visible = true;
                    btnStockmanagementCLicked.Visible = false;
                    break;
                case "Manager":
                    // Enable access to department manager
                    btnEmployeeManagement.Visible= true;
                    btnSchedule.Visible= true;
                    btnWeeklyScheduleManagement.Visible= true;

                    break;
            }
        }

        private void SetAllTabsVisibility(bool visible)
        {
            btnSchedule.Visible = visible;
            btnProductManagement.Visible = visible;
            btnStockManagement.Visible = visible;
            btnEmployeeManagement.Visible = visible;
            // btnWeeklyScheduleManagement.Visible = visible;
            btnStatisticsForm.Visible = visible;
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
            PnlMainMenu.Controls.Clear();

            if (userRole == "Manager")
            {
                ViewEmployee viewEmployee = new ViewEmployee(department);
                viewEmployee.TopLevel = false;
                viewEmployee.FormBorderStyle = FormBorderStyle.None;
                viewEmployee.Dock = DockStyle.Fill;

                PnlMainMenu.Controls.Add(viewEmployee);
                viewEmployee.Show();
                btnBack.Visible = true;

                btnSchedule.Visible = true;
                btnProductManagement.Visible = false;
                btnStockManagement.Visible = false;
            }
            else
            {
                employeeForm.TopLevel = false;
                employeeForm.FormBorderStyle = FormBorderStyle.None;
                employeeForm.Dock = DockStyle.Fill;

                PnlMainMenu.Controls.Add(employeeForm);
                employeeForm.Show();
                btnBack.Visible = true;

                btnSchedule.Visible = false;
                btnProductManagement.Visible = false;
                btnStockManagement.Visible = false;
            }

        }

        public void SetCrudeOn()
        {
            btnBack.Visible = true;
            btnSchedule.Visible = false;
            btnProductManagement.Visible = false;
            btnStockManagement.Visible = false;
            btnEmployeeManagement.Visible = false;
            btnScheduleManagementClicked.Visible = false;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            PnlMainMenu.Controls.Clear();

            // Instantiate the WeeklyShiftsForm
            if (userRole != "Manager")
            {
                scheduleForm = new ScheduleForm();
                scheduleForm.TopLevel = false;
                scheduleForm.FormBorderStyle = FormBorderStyle.None;
                scheduleForm.Dock = DockStyle.Fill;
            }
            else
            {
                scheduleForm = new ScheduleForm(department);
                scheduleForm.TopLevel = false;
                scheduleForm.FormBorderStyle = FormBorderStyle.None;
                scheduleForm.Dock = DockStyle.Fill;
            }
            


            // Add the form to the panel
            PnlMainMenu.Controls.Add(scheduleForm);

            // Show the form
            scheduleForm.Show();

            SetCrudeOn();
            btnBack.Visible = true;
            btnScheduleManagementClicked.Visible = true;
            btnCreateScheduleManagement.Visible = true;
            btnWeeklyScheduleManagement.Visible = true;
            btnProductManagement.Visible = false;
        }

        public void Clear()
        {
            btnDepartmentManagement.Visible = false;
            btnCreateScheduleManagement.Visible = false;
            btnWeeklyScheduleManagement.Visible = false;

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
            Clear();
            ConfigureAccessBasedOnRole();
            UpdateUIWithUserRole();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PnlMainMenu.Controls.Clear();

            if (this.userRole == "Manager")
            {
                ViewEmployee viewEmployee = new ViewEmployee(department);
                viewEmployee.TopLevel = false;
                viewEmployee.FormBorderStyle = FormBorderStyle.None;
                viewEmployee.Dock = DockStyle.Fill;
                PnlMainMenu.Controls.Add(viewEmployee);
            }
            else
            {
                EmployeeForm employeeForm = new EmployeeForm();
                employeeForm.TopLevel = false;
                employeeForm.FormBorderStyle = FormBorderStyle.None;
                employeeForm.Dock = DockStyle.Fill;
                PnlMainMenu.Controls.Add(employeeForm);
            }

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
            if (userRole == "Manager")
            {
                LeaveRequests leaveRequests = new LeaveRequests(department);
                leaveRequests.TopLevel = false;
                leaveRequests.FormBorderStyle = FormBorderStyle.None;
                leaveRequests.Dock = DockStyle.Fill;

                PnlMainMenu.Controls.Add(leaveRequests);
                leaveRequests.Show();
            }
            else
            {
                LeaveRequests leaveRequests = new LeaveRequests();
                leaveRequests.TopLevel = false;
                leaveRequests.FormBorderStyle = FormBorderStyle.None;
                leaveRequests.Dock = DockStyle.Fill;

                PnlMainMenu.Controls.Add(leaveRequests);
                leaveRequests.Show();
            }

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

            SetCrudeOn();
            btnBack.Visible = true;
            btnWeeklyScheduleManagement.Visible = false;
            btnProductManagement.Visible = false;
            btnStockmanagementCLicked.Visible = false;
            btnStockManagement.Visible = false;
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
            PnlMainMenu.Controls.Clear();
            productForm.TopLevel = false;
            productForm.FormBorderStyle = FormBorderStyle.None;
            productForm.Dock = DockStyle.Fill;
            PnlMainMenu.Controls.Add(productForm);
            productForm.Show();
            btnBack.Visible = true;
            SetCrudeOn();
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
            SetCrudeOn();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Clear the main panel and reset UI based on user role
            PnlMainMenu.Controls.Clear();
            Clear();
            ConfigureAccessBasedOnRole();
            UpdateUIWithUserRole();
            btnBack.Visible = false;
        }

        private void Logout()
        {
            // Reset userRole
            userRole = string.Empty;

            // Reset UI elements
            UpdateUIWithUserRole();
            SetAllTabsVisibility(false);
            Clear();

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

        private void btnStockmanagementCLicked_Click(object sender, EventArgs e)
        {
        }

        private void btnStatisticsForm_Click(object sender, EventArgs e)
        {
            PnlMainMenu.Controls.Clear();
            statisticsForm.TopLevel = false;
            statisticsForm.FormBorderStyle = FormBorderStyle.None;
            statisticsForm.Dock = DockStyle.Fill;
            PnlMainMenu.Controls.Add(statisticsForm);
            statisticsForm.Show();
            btnBack.Visible = true;
            SetCrudeOn();
        }
    }
}