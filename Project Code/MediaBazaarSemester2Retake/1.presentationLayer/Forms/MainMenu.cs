using BusinessLogicLayer.ManageClass;
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
        private ManageShifts _manageShifts;
        private ManageEmployee _manageEmployee;
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

            ScheduleForm scheduleForm = new ScheduleForm(_manageShifts, _manageEmployee);
            scheduleForm.TopLevel = false;
            scheduleForm.FormBorderStyle = FormBorderStyle.None;
            scheduleForm.Dock = DockStyle.Fill;
            PnlMainMenu.Controls.Add(scheduleForm); // Add the form to the panel.
            scheduleForm.Show(); // Displa
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
