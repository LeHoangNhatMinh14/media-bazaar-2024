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
            btnCantSignIn = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtBoxPassword = new TextBox();
            txtBoxUsername = new TextBox();
            pictureBox4 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(1552, 12);
            button4.Name = "button4";
            button4.Size = new Size(30, 37);
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
            BtnGo.Location = new Point(44, 543);
            BtnGo.Name = "BtnGo";
            BtnGo.Size = new Size(298, 123);
            BtnGo.TabIndex = 49;
            BtnGo.UseVisualStyleBackColor = false;
            BtnGo.Click += BtnGo_Click;
            // 
            // btnCantSignIn
            // 
            btnCantSignIn.FlatStyle = FlatStyle.Flat;
            btnCantSignIn.Location = new Point(81, 779);
            btnCantSignIn.Name = "btnCantSignIn";
            btnCantSignIn.Size = new Size(226, 55);
            btnCantSignIn.TabIndex = 47;
            btnCantSignIn.Text = "Cant sign in ?";
            btnCantSignIn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 11.14286F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(86, 391);
            label7.Name = "label7";
            label7.Size = new Size(110, 31);
            label7.TabIndex = 46;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 11.14286F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(81, 293);
            label6.Name = "label6";
            label6.Size = new Size(117, 31);
            label6.TabIndex = 45;
            label6.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(66, 135);
            label5.Name = "label5";
            label5.Size = new Size(240, 48);
            label5.TabIndex = 43;
            label5.Text = "MediaBazaar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 849);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 42;
            label4.Text = "V 0.1";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(84, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(151, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(121, 223);
            label1.Name = "label1";
            label1.Size = new Size(114, 38);
            label1.TabIndex = 39;
            label1.Text = "Sign In";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BackColor = Color.WhiteSmoke;
            txtBoxPassword.Location = new Point(81, 424);
            txtBoxPassword.Multiline = true;
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(225, 51);
            txtBoxPassword.TabIndex = 37;
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.BackColor = Color.WhiteSmoke;
            txtBoxUsername.Location = new Point(81, 326);
            txtBoxUsername.Multiline = true;
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(225, 51);
            txtBoxUsername.TabIndex = 36;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.LightSteelBlue;
            pictureBox4.Location = new Point(452, -1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1156, 920);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += Timer1_Tick;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1606, 919);
            Controls.Add(button4);
            Controls.Add(BtnGo);
            Controls.Add(btnCantSignIn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxUsername);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button BtnGo;
        private Button btnCantSignIn;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtBoxPassword;
        private TextBox txtBoxUsername;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
    }
}