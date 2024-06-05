﻿namespace MediaBazaarSemester2Retake
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            button4 = new Button();
            BtnGo = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            txtBoxPassword = new TextBox();
            txtBoxUsername = new TextBox();
            pictureBox4 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btnLoginAsAdmin = new Button();
            btnLoginAsHR = new Button();
            btnLoginAsSchedule = new Button();
            btnLoginAsDepartment = new Button();
            btnLoginAsStock = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(1862, 14);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(36, 44);
            button4.TabIndex = 50;
            button4.Text = "x";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // BtnGo
            // 
            BtnGo.BackColor = Color.White;
            BtnGo.CausesValidation = false;
            BtnGo.Image = (Image)resources.GetObject("BtnGo.Image");
            BtnGo.Location = new Point(53, 652);
            BtnGo.Margin = new Padding(3, 4, 3, 4);
            BtnGo.Name = "BtnGo";
            BtnGo.Size = new Size(358, 148);
            BtnGo.TabIndex = 49;
            BtnGo.UseVisualStyleBackColor = false;
            BtnGo.Click += BtnGo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 11.14286F);
            label7.Location = new Point(103, 470);
            label7.Name = "label7";
            label7.Size = new Size(128, 37);
            label7.TabIndex = 46;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 11.14286F);
            label6.Location = new Point(98, 352);
            label6.Name = "label6";
            label6.Size = new Size(136, 37);
            label6.TabIndex = 45;
            label6.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(79, 162);
            label5.Name = "label5";
            label5.Size = new Size(286, 57);
            label5.TabIndex = 43;
            label5.Text = "MediaBazaar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label1.Location = new Point(146, 268);
            label1.Name = "label1";
            label1.Size = new Size(133, 45);
            label1.TabIndex = 39;
            label1.Text = "Sign In";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BackColor = Color.WhiteSmoke;
            txtBoxPassword.Location = new Point(98, 508);
            txtBoxPassword.Margin = new Padding(3, 4, 3, 4);
            txtBoxPassword.Multiline = true;
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(270, 60);
            txtBoxPassword.TabIndex = 37;
            txtBoxPassword.KeyPress += txtBoxPassword_KeyPress;
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.BackColor = Color.WhiteSmoke;
            txtBoxUsername.Location = new Point(98, 392);
            txtBoxUsername.Margin = new Padding(3, 4, 3, 4);
            txtBoxUsername.Multiline = true;
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(270, 60);
            txtBoxUsername.TabIndex = 36;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.LightSteelBlue;
            pictureBox4.Location = new Point(542, -2);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1387, 1104);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += Timer1_Tick;
            // 
            // btnLoginAsAdmin
            // 
            btnLoginAsAdmin.Location = new Point(356, 998);
            btnLoginAsAdmin.Margin = new Padding(5, 6, 5, 6);
            btnLoginAsAdmin.Name = "btnLoginAsAdmin";
            btnLoginAsAdmin.Size = new Size(169, 46);
            btnLoginAsAdmin.TabIndex = 51;
            btnLoginAsAdmin.Text = "Login as Admin";
            btnLoginAsAdmin.UseVisualStyleBackColor = true;
            btnLoginAsAdmin.Click += btnLoginAsAdmin_Click;
            // 
            // btnLoginAsHR
            // 
            btnLoginAsHR.Location = new Point(207, 998);
            btnLoginAsHR.Margin = new Padding(5, 6, 5, 6);
            btnLoginAsHR.Name = "btnLoginAsHR";
            btnLoginAsHR.Size = new Size(158, 46);
            btnLoginAsHR.TabIndex = 52;
            btnLoginAsHR.Text = "Login as HR";
            btnLoginAsHR.UseVisualStyleBackColor = true;
            btnLoginAsHR.Click += btnLoginAsHR_Click;
            // 
            // btnLoginAsSchedule
            // 
            btnLoginAsSchedule.Location = new Point(2, 998);
            btnLoginAsSchedule.Margin = new Padding(5, 6, 5, 6);
            btnLoginAsSchedule.Name = "btnLoginAsSchedule";
            btnLoginAsSchedule.Size = new Size(206, 46);
            btnLoginAsSchedule.TabIndex = 53;
            btnLoginAsSchedule.Text = "Login as Schedule";
            btnLoginAsSchedule.UseVisualStyleBackColor = true;
            btnLoginAsSchedule.Click += btnLoginAsSchedule_Click;
            // 
            // btnLoginAsDepartment
            // 
            btnLoginAsDepartment.Location = new Point(275, 1056);
            btnLoginAsDepartment.Margin = new Padding(5, 6, 5, 6);
            btnLoginAsDepartment.Name = "btnLoginAsDepartment";
            btnLoginAsDepartment.Size = new Size(270, 46);
            btnLoginAsDepartment.TabIndex = 54;
            btnLoginAsDepartment.Text = "Login as Product";
            btnLoginAsDepartment.UseVisualStyleBackColor = true;
            btnLoginAsDepartment.Click += btnLoginAsDepartment_Click;
            // 
            // btnLoginAsStock
            // 
            btnLoginAsStock.Location = new Point(2, 1056);
            btnLoginAsStock.Margin = new Padding(5, 6, 5, 6);
            btnLoginAsStock.Name = "btnLoginAsStock";
            btnLoginAsStock.Size = new Size(277, 46);
            btnLoginAsStock.TabIndex = 55;
            btnLoginAsStock.Text = "Login as Stock";
            btnLoginAsStock.UseVisualStyleBackColor = true;
            btnLoginAsStock.Click += btnLoginAsStock_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1927, 1102);
            Controls.Add(btnLoginAsStock);
            Controls.Add(btnLoginAsDepartment);
            Controls.Add(btnLoginAsSchedule);
            Controls.Add(btnLoginAsHR);
            Controls.Add(btnLoginAsAdmin);
            Controls.Add(button4);
            Controls.Add(BtnGo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxUsername);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button BtnGo;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox txtBoxPassword;
        private TextBox txtBoxUsername;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private Button btnLoginAsAdmin;
        private Button btnLoginAsHR;
        private Button btnLoginAsSchedule;
        private Button btnLoginAsDepartment;
        private Button btnLoginAsStock;
    }
}