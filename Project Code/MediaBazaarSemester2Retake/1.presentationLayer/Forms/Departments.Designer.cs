namespace MediaBazaarSemester2Retake._1.presentationLayer.Forms
{
    partial class Departments
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
            textBoxDepartmentName = new TextBox();
            label1 = new Label();
            buttonAddDepartment = new Button();
            dataGridViewDepartments = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartments).BeginInit();
            SuspendLayout();
            // 
            // textBoxDepartmentName
            // 
            textBoxDepartmentName.Location = new Point(24, 112);
            textBoxDepartmentName.Name = "textBoxDepartmentName";
            textBoxDepartmentName.Size = new Size(173, 23);
            textBoxDepartmentName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 94);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "Department Name";
            // 
            // buttonAddDepartment
            // 
            buttonAddDepartment.Location = new Point(24, 153);
            buttonAddDepartment.Name = "buttonAddDepartment";
            buttonAddDepartment.Size = new Size(173, 23);
            buttonAddDepartment.TabIndex = 2;
            buttonAddDepartment.Text = "Add Department";
            buttonAddDepartment.UseVisualStyleBackColor = true;
            buttonAddDepartment.Click += buttonAddDepartment_Click;
            // 
            // dataGridViewDepartments
            // 
            dataGridViewDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDepartments.Location = new Point(331, 94);
            dataGridViewDepartments.Name = "dataGridViewDepartments";
            dataGridViewDepartments.Size = new Size(457, 344);
            dataGridViewDepartments.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 66);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 4;
            label2.Text = "Departments List";
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(dataGridViewDepartments);
            Controls.Add(buttonAddDepartment);
            Controls.Add(label1);
            Controls.Add(textBoxDepartmentName);
            Name = "Departments";
            Text = "Departments";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDepartmentName;
        private Label label1;
        private Button buttonAddDepartment;
        private DataGridView dataGridViewDepartments;
        private Label label2;
    }
}