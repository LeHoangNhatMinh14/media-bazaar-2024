using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;
using BusinessLogicLayer.ManageClass;
using Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MediaBazaarSemester2Retake
{
    public partial class EmployeeForm : Form
    {
        ManageEmployee manageEmployee;
        Employee employee;
        public ManageDepartment manageDepartment;
        public EmployeeForm()
        {
            InitializeComponent();
            manageEmployee = ManageEmployeeFactory.Create();
            manageDepartment = ManageDepartmentFactory.Create();
            FillDatagrid();
            FillComboBoxes();

        }

        private void FillComboBoxes()
        {
            //TODO
        }

        private void FillEditEmployee(Employee employee)
        {
            label41.Text = employee.employeeID.ToString();
            TxtBxEditFirstName.Text = employee.firstName;
            TxtBxEditLastName.Text = employee.lastName;
            TxtBxEditEmail.Text = employee.email;
            TxtBxEditPhoneNumber.Text = employee.phoneNumber;
            TxtBxEditStreet.Text = employee.street;
            TxtBxEditPostalCode.Text = employee.postalCode;

            TxtBxEditBsn.Text = employee.bsn.ToString();
            DtpEditDateOfBirth.Value = Convert.ToDateTime(employee.dateOfBirth);

            TxtBxEditPosition.Text = employee.Contract.position;
            CbXEditDepartment.SelectedItem = manageDepartment.GetDepartmentName(employee.Contract.departmentID);
            CbXEditContract.SelectedItem = employee.Contract.contractType;

            DtPStartDate.Value = Convert.ToDateTime(employee.Contract.startDate);
            DtPEndDate.Value = Convert.ToDateTime(employee.Contract.endDate);
            CbXContract.SelectedItem = employee.Contract.contractType;

            TxtBxEditEmergencyName.Text = employee.emergencyContactName;
            TxtBxEditEmergencyContact.Text = employee.emergencyPhoneNumber;
            CbXEditEmergencyRelationship.Text = employee.emergencyRelation;
        }

        private void FillDatagrid()
        {
            FillDatagrid(manageEmployee.GetAllEmployees());
        }

        private void FillDatagrid(IEnumerable<Employee> list)
        {
            dgv_Employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv_Employee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Employee.MultiSelect = false;
            var source = new BindingSource();
            source.DataSource = list;
            dgv_Employee.DataSource = source;
            dgv_Employee.ScrollBars = ScrollBars.Both;
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {

            string firstName;
            string lastName;
            string bsn;
            DateTime DateOfBirth;
            string phoneNumber;
            string gender;
            string email;
            string city;
            string country;
            string street;
            int houseNumber;
            string postalCode;
            string emergencyName;
            string emergencyPhone;
            string emergencyRelation;
            string positon;
            string departmentName;
            DateTime startTime;
            DateTime endTime;
            string contractType;
            //Check ALl Boxes if name is same;
            int id = manageEmployee.GetAllEmployees().Count + 1;
            firstName = TxtBxFirstName.Text;
            lastName = txtBoxLastName.Text;
            bsn = txtBoxbsn.Text;
            DateTime dob = dtpDateOfBirth.Value;
            // convert DateTime to DateOnly 
            DateOfBirth = dtpDateOfBirth.Value;
            phoneNumber = txtBoxPhoneNumber.Text;
            gender = txtBoxGender.Text;
            email = txtBoxEmail.Text;
            city = txtBoxCity.Text;
            country = txtCountry.Text;
            street = txtBoxStreet.Text;
            houseNumber = Convert.ToInt32(txtBoxHouseNumber.Text);
            postalCode = txtBoxPostalCode.Text;
            emergencyName = txtBoxEmergencyContact.Text;
            emergencyPhone = txtBoxemergencyPhoneNumber.Text;
            emergencyRelation = txtBoxEmergencyRelation.Text;
            positon = TxtBxPosition.Text;
            departmentName = CbXDepartment.Text;
            //startTime =
            // endTime =



            //IF Contract type different thingy
            Contract contract = new Contract();
            employee = new Employee(id, firstName, lastName, bsn, DateOfBirth, phoneNumber, gender, email, city, country, street, houseNumber, postalCode, emergencyName, emergencyPhone, emergencyRelation, contract);
            manageEmployee.AddEmployee(employee);
            MessageBox.Show("Successfully add employee");
        }

        private void BtnFireEmployee_Click(object sender, EventArgs e)
        {
            //
        }

        private void BtnSendToEditEmployee_Click(object sender, EventArgs e)
        {
            Employee employee;
            DataGridViewRow selectedRow = dgv_Employee.SelectedRows[0];
            int id = (int)selectedRow.Cells["employeeId"].Value;
            employee = manageEmployee.GetEmployeeByID(id);
            FillEditEmployee(employee);
            tabControl1.SelectedTab = tabPage3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtBxFirstName.Text = "Jaan";
            TxtBxLastName.Text = "Jansen";
            TxtBxEmail.Text = "j.jansen@mediabazaar.nl";
            TxtBxPhoneNumber.Text = "0123456789";
            TxtBxPassword.Text = "password123";
            TxtBxStreet.Text = "Magellanstraat 11";
            TxtBxPostalCode.Text = "2371BB";

            TxtBxBsn.Text = "21234475";
            DtPDateOfBirth.Value = Convert.ToDateTime("05/08/1998");

            TxtBxPosition.Text = "Cashier";
            CbXDepartment.SelectedIndex = 1;
            CbXContract.SelectedIndex = 1;


            TxtBxEmergencyName.Text = "Mieteke Joris";
            TxtBxEmergencyContact.Text = "0612219179";
            CbXEmergencyRelationship.Text = "Spouse";
        }



        private void unfilter_Click(object sender, EventArgs e)
        {
            rbnHR.Checked = false;
            rbnCustomerService.Checked = false;
            rbnLogistic.Checked = false;
            rbnSecurity.Checked = false;
            FillDatagrid();
        }


        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {

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
                IEnumerable<Employee> filteredEmployees = manageEmployee.GetAllEmployees()
                    .Where(emp => emp.firstName.ToLower().Contains(searchKeyword) ||
                                   emp.lastName.ToLower().Contains(searchKeyword) ||
                                   emp.email.ToLower().Contains(searchKeyword) ||
                                   emp.phoneNumber.ToLower().Contains(searchKeyword));

                // Update the DataGridView with the filtered list
                FillDatagrid(filteredEmployees);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedDepartment = string.Empty;

            if (rbnSecurity.Checked)
            {
                selectedDepartment = "Security";
            }
            else if (rbnLogistic.Checked)
            {
                selectedDepartment = "Logistic";
            }
            else if (rbnCustomerService.Checked)
            {
                selectedDepartment = "CustomerService";
            }
            else if (rbnHR.Checked)
            {
                selectedDepartment = "HR";
            }

            if (!string.IsNullOrEmpty(selectedDepartment))
            {
                // Filter the list of employees based on the selected department
                IEnumerable<Employee> filteredEmployees = manageEmployee.GetAllEmployees()
                    .Where(emp => emp.Contract.departmentID == manageDepartment.GetDepartmentID(selectedDepartment));

                // Update the DataGridView with the filtered list
                FillDatagrid(filteredEmployees);
            }
            else
            {
                // If no department is selected, display all employees
                FillDatagrid();
            }
        }

        private void unfilter_Click_1(object sender, EventArgs e)
        {
            // Uncheck all radio buttons
            rbnHR.Checked = false;
            rbnCustomerService.Checked = false;
            rbnLogistic.Checked = false;
            rbnSecurity.Checked = false;

            // Reset the DataGridView to display all employees
            FillDatagrid();
        }
    }
}
