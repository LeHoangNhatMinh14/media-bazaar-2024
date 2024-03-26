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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MediaBazaarSemester2Retake
{
    public partial class EmployeeForm : Form
    {
        ManageEmployee manageEmployee;
        Employee employee;

        public EmployeeForm()
        {
            InitializeComponent();
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = "dd'/'MM'/'yyyy";
            manageEmployee = ManageEmployeeFactory.Create();
            lbEmployee.DataSource = manageEmployee.GetAllEmployees();
        }


        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
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

            if (AllFieldsFilled())
            {
                int id = manageEmployee.GetAllEmployees().Count + 1;
                firstName = txtBoxFirstName.Text;
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

                employee = new Employee(id, firstName, lastName, bsn, DateOfBirth, phoneNumber, gender, email, city, country, street, houseNumber, postalCode, emergencyName, emergencyPhone, emergencyRelation);
                manageEmployee.AddEmployee(employee);
                MessageBox.Show("Successfully add employee");
                ResetField();
                lbEmployee.DataSource = manageEmployee.GetAllEmployees();
                lbEmployee.DisplayMember = "EmployeeInfo";
                lbEmployee.ValueMember = "employeeID";
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnReadEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {

        }

        private bool AllFieldsFilled()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show("Please fill in all the textbox!");
                        return false; // Field is not filled
                    }
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    if (dateTimePicker.Value == DateTime.Today) //if the day is today
                    {
                        MessageBox.Show("Date of birth can't be today!");
                        return false; // Field is not changed
                    }
                }

                // If the control is a container (e.g., GroupBox, Panel), recursively check its controls.
            }
            // try to convert the text and if it unable to convert the '!' will turn the result to true and run the if statement scope

            if (!int.TryParse(txtBoxHouseNumber.Text, out int result3))
            {
                MessageBox.Show("House number can only contain numeric value!");
                return false; // number only field
            }

            try
            {
                new System.Net.Mail.MailAddress(txtBoxEmail.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invaild Email!");
                return false;
            }

            return true;
        }

        private void ResetField()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Today;

                }
            }
        }

        private void lbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEmployee.SelectedIndex != -1)
            {
                Employee employee = (Employee)lbEmployee.SelectedItem;
                txtBoxFirstName.Text = employee.firstName;
                txtBoxLastName.Text = employee.lastName;
                txtBoxbsn.Text = employee.bsn;
                dtpDateOfBirth.Value = employee.dateOfBirth;
                txtBoxPhoneNumber.Text = employee.phoneNumber;
                txtBoxGender.Text = employee.gender;
                txtBoxEmail.Text = employee.email;
                txtBoxCity.Text = employee.city;
                txtCountry.Text = employee.country;
                txtBoxStreet.Text = employee.street;
                txtBoxHouseNumber.Text = employee.houseNumber.ToString();
                txtBoxPostalCode.Text = employee.postalCode;
                txtBoxEmergencyContact.Text = employee.emergencyContactName;
                txtBoxemergencyPhoneNumber.Text = employee.phoneNumber;
                txtBoxEmergencyRelation.Text = employee.emergencyRelation;
            }
            else
            {
                ResetField();
            }


        }
    }
}
