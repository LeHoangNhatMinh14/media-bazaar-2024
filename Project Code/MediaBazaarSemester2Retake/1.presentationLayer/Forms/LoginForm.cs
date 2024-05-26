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
        private List<Image> images = new List<Image>();
        private int currentIndex = 0;
        private readonly ManageDepartment mD;
        public LoginForm()
        {
            InitializeComponent();
            // InitializeImageList();
            LoaddEmbeddedImages();
            ConfigureTimer();
            ListEmbeddedResources();
            mD = ManageDepartmentFactory.Create();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void ConfigureTimer()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 10000;
            timer.Tick += Timer1_Tick;
            timer.Start();
        }

        private void ListEmbeddedResources()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string[] resourceNames = assembly.GetManifestResourceNames();
            foreach (string resourceName in resourceNames)
            {
                Console.WriteLine(resourceName);
            }
        }
        private void LoaddEmbeddedImages()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();


        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (images.Count == 0) return;
            pictureBox4.Image = images[currentIndex];

            currentIndex = (currentIndex + 1) % images.Count;
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

        private void txtBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnGo_Click(sender, e);
            }
        }
    }
}
