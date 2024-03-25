﻿using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;
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
            }
            else
            {
                MessageBox.Show("Please fill in all the textbox!");
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
                        return false; // Field is not filled
                    }
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    if (dateTimePicker.Value == DateTime.Today) //if the day is today
                    {
                        return false; // Field is not changed
                    }
                }

                // If the control is a container (e.g., GroupBox, Panel), recursively check its controls.
            }
            // try to convert the text and if it unable tp convert the '!' will turn the result to true and run the if statement scope

            if (!int.TryParse(txtBoxHouseNumber.Text, out int result3))
            {
                return false; // number only field
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
    } 
}
