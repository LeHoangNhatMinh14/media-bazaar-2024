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
        public LoginForm()
        {
            InitializeComponent();
            // InitializeImageList();
            LoaddEmbeddedImages();
            ConfigureTimer();
            ListEmbeddedResources();
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
        private Image LoadImageFromResources(Assembly assembly, string resourceName)
        {
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                return Image.FromStream(stream);
            }
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

            images.Add(LoadImageFromResources(assembly, "MediaBazaarSemester2Retake.image1.png"));
            images.Add(LoadImageFromResources(assembly, "MediaBazaarSemester2Retake.image2.png"));
            images.Add(LoadImageFromResources(assembly, "MediaBazaarSemester2Retake.image3.png"));
            images.Add(LoadImageFromResources(assembly, "MediaBazaarSemester2Retake.image4.png"));
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (images.Count == 0) return;
            pictureBox4.Image = images[currentIndex];

            currentIndex = (currentIndex+ 1)% images.Count;
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new MainMenu();
            myForm.Show();
            
        }
    }
}
