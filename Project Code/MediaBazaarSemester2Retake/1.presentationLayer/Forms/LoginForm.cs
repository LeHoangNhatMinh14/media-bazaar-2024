using BusinessLogicLayer.Class;
using BusinessLogicLayer.ManageClass;
using DAL;
using Factory;
using MediaBazaarSemester2Retake._1.presentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MediaBazaarSemester2Retake
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

            EmployeeRepo employeeRepo = new EmployeeRepo();
            (string role, string department) = employeeRepo.VerifyLogin(username, password);


            if (!string.IsNullOrEmpty(role))
            {
                this.Hide();
                MainMenu mainMenuForm = new MainMenu(role, department);  // Pass role to MainMenu
                mainMenuForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxPassword.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnGo_Click(sender, e);
            }
        }

        private void btnLoginAsAdmin_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Text = "john.doe@example.com";
            txtBoxPassword.Text = "password";
            //  BtnGo_Click(sender, e);
        }

        private void btnLoginAsHR_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Text = "jane.smith@example.com";
            txtBoxPassword.Text = "password";
            //  BtnGo_Click(sender, e);
        }

        private void btnLoginAsSchedule_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Text = "emily.johnson@example.com";
            txtBoxPassword.Text = "password";
            //BtnGo_Click(sender, e);
        }

        private void btnLoginAsDepartment_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Text = "michael.williams@example.com";
            txtBoxPassword.Text = "password";
            // BtnGo_Click(sender, e);
        }

        private void btnLoginAsStock_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Text = "john.williams@mediabazaar.nl";
            txtBoxPassword.Text = "password123";
            //BtnGo_Click(sender, e);
        }



        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Timer logic here (if needed)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Text = "heworon836@elahan.com";
            txtBoxPassword.Text = "2zX9GG7X";
        }
    }
}