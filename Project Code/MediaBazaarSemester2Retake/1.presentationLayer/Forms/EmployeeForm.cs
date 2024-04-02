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
        }

        private void FillEditEmployee(Employee employee)
        {
            label42.Text = employee.employeeID.ToString();
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
            string departmentName;
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
                departmentName = CbXDepartment.Text;
                startTime = DtPStartDate.Value;
                endTime = DtPEndDate.Value;
                contractType = CbXContract.Text;

                //IF Contract type different thingy
                Contract contract = new Contract();
                employee = new Employee( firstName, lastName, password, bsn, DateOfBirth, phoneNumber, gender, email, city, country, street, houseNumber, postalCode, emergencyName, emergencyPhone, emergencyRelation, contract);
                manageEmployee.AddEmployee(employee);
                MessageBox.Show("Successfully add employee");
                ResetField(tabPage2);
                FillDatagrid();
                
            }

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
            //check if all field in tab 3 is filled
            if (AllFieldsFilled(tabPage3))
            {

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
    }
}
