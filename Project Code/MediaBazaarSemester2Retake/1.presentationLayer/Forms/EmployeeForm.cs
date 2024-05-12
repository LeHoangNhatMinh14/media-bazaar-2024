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
using System.Reflection.Metadata.Ecma335;
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
        ManageContract manageContract;
        public EmployeeForm()
        {
            InitializeComponent();
            manageEmployee = ManageEmployeeFactory.Create();
            manageDepartment = ManageDepartmentFactory.Create();
            manageContract = ManageContractFactory.Create();
            FillDatagrid();
            FillComboBoxes();

        }

        private void FillComboBoxes()
        {
            //TODO
            List<Department> departments = manageDepartment.GetDepartmentList();
            CbXDepartment.DataSource = departments;
            CbXEditDepartment.DataSource = departments;
        }

        private void FillEditEmployee(Employee employee)
        {
            lblEmpId.Text = employee.employeeID.ToString();
            TxtBxEditFirstName.Text = employee.firstName;
            TxtBxEditLastName.Text = employee.lastName;
            TxtBxEditPassword.Text = employee.password;
            TxtBxEditEmail.Text = employee.email;
            TxtBxEditPhoneNumber.Text = employee.phoneNumber;
            CbXEditGender.SelectedItem = employee.gender;
            TxtBxEditCity.Text = employee.city;
            TxtBxEditStreet.Text = employee.street;
            TxtBxEditPostalCode.Text = employee.postalCode;
            TxtBxEditHouseNumber.Text = employee.houseNumber.ToString();
            TxtBxEditCountry.Text = employee.country;


            TxtBxEditBsn.Text = employee.bsn.ToString();
            DtpEditDateOfBirth.Value = Convert.ToDateTime(employee.dateOfBirth);

            if (employee.Contract != null)
            {
                TxtBxEditPosition.Text = employee.Contract.position;
                CbXEditDepartment.SelectedItem = manageDepartment.GetDepartmentName(employee.Contract.departmentID);
                TxtBxEditWorkHour.Text = employee.Contract.workHours;
                CbXEditContract.SelectedItem = employee.Contract.contractType;

                DtPEditStartDate.Value = Convert.ToDateTime(employee.Contract.startDate);
                if (employee.Contract.endDate != default(DateTime))
                {
                    DtPEditEndDate.Value = Convert.ToDateTime(employee.Contract.endDate);
                }
                CbXEditContract.SelectedItem = CbXEditContract.Items.IndexOf(employee.Contract.contractType);
            }


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
            int employeeId;
            string firstName;
            string lastName;
            string password;
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
            // change to department object maybe
            Department department;
            string workHour;
            DateTime startTime;
            DateTime endTime;
            string contractType;
            //Check ALl Boxes if name is same;
            if (AllFieldsFilled(tabPage2) && CheckBsn(TxtBxBsn.Text))
            {
                firstName = TxtBxFirstName.Text;
                lastName = TxtBxLastName.Text;
                password = TxtBxPassword.Text;
                bsn = TxtBxBsn.Text;
                DateOfBirth = DtPDateOfBirth.Value;
                phoneNumber = TxtBxPhoneNumber.Text;
                gender = CbXGender.Text;
                email = TxtBxEmail.Text;
                city = TxtBxCity.Text;
                country = TxtBxCountry.Text;
                street = TxtBxStreet.Text;
                houseNumber = Convert.ToInt32(TxtBxHouseNumber.Text);
                postalCode = TxtBxPostalCode.Text;
                emergencyName = TxtBxEmergencyName.Text;
                emergencyPhone = TxtBxEmergencyContact.Text;
                emergencyRelation = CbXEmergencyRelationship.Text;
                //Contract
                positon = TxtBxPosition.Text;
                department = (Department)CbXDepartment.SelectedItem;
                workHour = TxtBxWorkHour.Text;
                startTime = DtPStartDate.Value;
                endTime = DtPEndDate.Value;
                contractType = CbXContract.Text;

                Contract contract;
                //IF Contract type different thingy

                    EmailService.SendEmail(password, email);
                    employee = new Employee(firstName, lastName, password, bsn, DateOfBirth, phoneNumber, gender, email, city, country, street, houseNumber, postalCode, emergencyName, emergencyPhone, emergencyRelation);
                    manageEmployee.AddEmployee(employee);
                    employeeId = manageEmployee.GetRecentEmployee().employeeID;
                    if (contractType == "Temporary")
                    {
                        contract = new Contract(contractType, employeeId, workHour, positon, department._departmentID, startTime, endTime);
                    }
                    else // Permanent
                    {
                        contract = new Contract(contractType, employeeId, workHour, positon, department._departmentID, startTime);
                    }
                    manageContract.AddContract(contract);
                    employee.Contract = contract;
                    MessageBox.Show("Successfully add employee");

                ResetField(tabPage2);
                FillDatagrid();
                
            }

        }

        private void BtnFireEmployee_Click(object sender, EventArgs e)
        {
            Employee employee;
            DataGridViewRow selectedRow = dgv_Employee.SelectedRows[0];
            int id = (int)selectedRow.Cells["employeeId"].Value;
            employee = manageEmployee.GetEmployeeByID(id);
            manageEmployee.DeleteEmployee(employee);
        }

        private void BtnSendToEditEmployee_Click(object sender, EventArgs e)
        {
            Employee employee;
            DataGridViewRow selectedRow = dgv_Employee.SelectedRows[0];
            int id = (int)selectedRow.Cells["employeeId"].Value;
            employee = manageEmployee.GetEmployeeByID(id);
            employee.Contract = manageContract.GetContract(id);
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
            CbXGender.SelectedIndex = 0;
            TxtBxCity.Text = "Eindhoven";
            TxtBxStreet.Text = "Staat";
            TxtBxHouseNumber.Text = "1";
            TxtBxCountry.Text = "Netherland";
            

            TxtBxBsn.Text = "21234475";
            DtPDateOfBirth.Value = Convert.ToDateTime("05/08/1998");

            TxtBxPosition.Text = "Cashier";
            CbXDepartment.SelectedIndex = 1;
            CbXContract.SelectedIndex = 1;
            TxtBxWorkHour.Text = "40";


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
            int employeeId;
            string firstName;
            string lastName;
            string password;
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
            //check if all field in tab 3 is filled
            if (AllFieldsFilled(tabPage3))
            {
                employeeId = Convert.ToInt32(lblEmpId.Text);
                firstName = TxtBxEditFirstName.Text;
                lastName = TxtBxEditLastName.Text;
                password = TxtBxEditPassword.Text;
                bsn = TxtBxEditBsn.Text;
                DateOfBirth = DtpEditDateOfBirth.Value;
                phoneNumber = TxtBxEditPhoneNumber.Text;
                gender = CbXEditGender.Text;
                email = TxtBxEditEmail.Text;
                city = TxtBxEditCity.Text;
                country = TxtBxEditCountry.Text;
                street = TxtBxEditStreet.Text;
                houseNumber = Convert.ToInt32(TxtBxEditHouseNumber.Text);
                postalCode = TxtBxEditPostalCode.Text;
                emergencyName = TxtBxEditEmergencyName.Text;
                emergencyPhone = TxtBxEditEmergencyContact.Text;
                emergencyRelation = CbXEditEmergencyRelationship.Text;

                employee = new Employee(firstName, lastName, password, bsn, DateOfBirth, phoneNumber, gender, email, city, country, street, houseNumber, postalCode, emergencyName, emergencyPhone, emergencyRelation);
                employee.employeeID = employeeId;

                manageEmployee.EditEmployee(employee);
                ResetField(tabPage3);
                MessageBox.Show("Successfully edit employee");
                FillDatagrid();
            }
        }

        private bool CheckBsn(string bsn)
        {
            // get all employee 
            foreach (Employee employee in manageEmployee.GetAllEmployees())
            {
                // check if employee bsn is the same
                if (employee.bsn == bsn)
                {
                    // return false if bsn is the same
                    return false;
                }
            }
            // return true if the bsn is not in the employee database
            return true;
        }

        private bool AllFieldsFilled(TabPage tabPageName)
        {
            foreach (GroupBox groupBox in tabPageName.Controls.OfType<GroupBox>())
            {
                foreach (Control control in groupBox.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        if (string.IsNullOrEmpty(textBox.Text))
                        {
                            MessageBox.Show("Please fill in all the textbox!");
                            return false; // Field is not filled
                        }
                    }
                    else if (control is ComboBox comboBox)
                    {
                        if (string.IsNullOrWhiteSpace(comboBox.Text)) //if the day is today
                        {
                            MessageBox.Show("Please make sure all comboBox is selected");
                            return false; // Field is not changed
                        }
                    }

                    // If the control is a container (e.g., GroupBox, Panel), recursively check its controls.
                }
                // email validation

                try
                {
                    if (tabPage2 == tabPageName)
                    {
                        new System.Net.Mail.MailAddress(TxtBxEmail.Text);
                    }
                    else if (tabPage3 == tabPageName)
                    {
                        new System.Net.Mail.MailAddress(TxtBxEditEmail.Text);
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Invaild Email!");
                    return false;
                }

            }
            return true;
        }

        private void ResetField(TabPage tabPageName)
        {
            // reset all field to empty or today date
            foreach (GroupBox groupBox in tabPageName.Controls.OfType<GroupBox>())
            {
                foreach (Control control in groupBox.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Text = "";
                    }
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.SelectedIndex = -1;
                    }
                    else if (control is DateTimePicker dateTimePicker)
                    {
                        dateTimePicker.Value = DateTime.Now;
                    }

                    // If the control is a container (e.g., GroupBox, Panel), recursively check its controls.
                }

            }

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
