namespace MediaBazaarSemester2Retake
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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(1086, 7);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(21, 22);
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
            BtnGo.Location = new Point(31, 326);
            BtnGo.Margin = new Padding(2, 2, 2, 2);
            BtnGo.Name = "BtnGo";
            BtnGo.Size = new Size(209, 74);
            BtnGo.TabIndex = 49;
            BtnGo.UseVisualStyleBackColor = false;
            BtnGo.Click += BtnGo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 11.14286F);
            label7.Location = new Point(60, 235);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 46;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 11.14286F);
            label6.Location = new Point(57, 176);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 45;
            label6.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(46, 81);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(163, 32);
            label5.TabIndex = 43;
            label5.Text = "MediaBazaar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label1.Location = new Point(85, 134);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 39;
            label1.Text = "Sign In";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BackColor = Color.WhiteSmoke;
            txtBoxPassword.Location = new Point(57, 254);
            txtBoxPassword.Margin = new Padding(2, 2, 2, 2);
            txtBoxPassword.Multiline = true;
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(159, 32);
            txtBoxPassword.TabIndex = 37;
            txtBoxPassword.KeyPress += txtBoxPassword_KeyPress;
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.BackColor = Color.WhiteSmoke;
            txtBoxUsername.Location = new Point(57, 196);
            txtBoxUsername.Margin = new Padding(2, 2, 2, 2);
            txtBoxUsername.Multiline = true;
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(159, 32);
            txtBoxUsername.TabIndex = 36;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.LightSteelBlue;
            pictureBox4.Location = new Point(316, -1);
            pictureBox4.Margin = new Padding(2, 2, 2, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(809, 552);
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
            btnLoginAsAdmin.Location = new Point(208, 499);
            btnLoginAsAdmin.Name = "btnLoginAsAdmin";
            btnLoginAsAdmin.Size = new Size(99, 23);
            btnLoginAsAdmin.TabIndex = 51;
            btnLoginAsAdmin.Text = "Login as Admin";
            btnLoginAsAdmin.UseVisualStyleBackColor = true;
            btnLoginAsAdmin.Click += btnLoginAsAdmin_Click;
            // 
            // btnLoginAsHR
            // 
            btnLoginAsHR.Location = new Point(121, 499);
            btnLoginAsHR.Name = "btnLoginAsHR";
            btnLoginAsHR.Size = new Size(92, 23);
            btnLoginAsHR.TabIndex = 52;
            btnLoginAsHR.Text = "Login as HR";
            btnLoginAsHR.UseVisualStyleBackColor = true;
            btnLoginAsHR.Click += btnLoginAsHR_Click;
            // 
            // btnLoginAsSchedule
            // 
            btnLoginAsSchedule.Location = new Point(1, 499);
            btnLoginAsSchedule.Name = "btnLoginAsSchedule";
            btnLoginAsSchedule.Size = new Size(120, 23);
            btnLoginAsSchedule.TabIndex = 53;
            btnLoginAsSchedule.Text = "Login as Schedule";
            btnLoginAsSchedule.UseVisualStyleBackColor = true;
            btnLoginAsSchedule.Click += btnLoginAsSchedule_Click;
            // 
            // btnLoginAsDepartment
            // 
            btnLoginAsDepartment.Location = new Point(160, 528);
            btnLoginAsDepartment.Name = "btnLoginAsDepartment";
            btnLoginAsDepartment.Size = new Size(158, 23);
            btnLoginAsDepartment.TabIndex = 54;
            btnLoginAsDepartment.Text = "Login as Product";
            btnLoginAsDepartment.UseVisualStyleBackColor = true;
            btnLoginAsDepartment.Click += btnLoginAsDepartment_Click;
            // 
            // btnLoginAsStock
            // 
            btnLoginAsStock.Location = new Point(1, 528);
            btnLoginAsStock.Name = "btnLoginAsStock";
            btnLoginAsStock.Size = new Size(162, 23);
            btnLoginAsStock.TabIndex = 55;
            btnLoginAsStock.Text = "Login as Stock";
            btnLoginAsStock.UseVisualStyleBackColor = true;
            btnLoginAsStock.Click += btnLoginAsStock_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1, 470);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 56;
            button1.Text = "Login sale department manager";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1124, 550);
            Controls.Add(button1);
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
            Margin = new Padding(2, 2, 2, 2);
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
        private Button button1;
    }
}