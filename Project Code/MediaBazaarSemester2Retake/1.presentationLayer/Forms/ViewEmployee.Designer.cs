namespace MediaBazaarSemester2Retake._1.presentationLayer.Forms
{
    partial class ViewEmployee
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
            label42 = new Label();
            NameBox = new TextBox();
            dgv_Employee = new DataGridView();
            department = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_Employee).BeginInit();
            SuspendLayout();
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(12, 18);
            label42.Name = "label42";
            label42.Size = new Size(113, 15);
            label42.TabIndex = 17;
            label42.Text = "Search By Employee";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(10, 37);
            NameBox.Margin = new Padding(3, 2, 3, 2);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(183, 23);
            NameBox.TabIndex = 16;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // dgv_Employee
            // 
            dgv_Employee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Employee.Columns.AddRange(new DataGridViewColumn[] { department });
            dgv_Employee.Location = new Point(12, 80);
            dgv_Employee.Margin = new Padding(3, 2, 3, 2);
            dgv_Employee.Name = "dgv_Employee";
            dgv_Employee.RowHeadersWidth = 51;
            dgv_Employee.RowTemplate.Height = 29;
            dgv_Employee.Size = new Size(571, 395);
            dgv_Employee.TabIndex = 15;
            // 
            // department
            // 
            department.DataPropertyName = "department";
            department.HeaderText = "Department";
            department.MinimumWidth = 8;
            department.Name = "department";
            department.ReadOnly = true;
            department.Width = 150;
            // 
            // ViewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 513);
            Controls.Add(label42);
            Controls.Add(NameBox);
            Controls.Add(dgv_Employee);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewEmployee";
            Text = "ViewEmployee";
            ((System.ComponentModel.ISupportInitialize)dgv_Employee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label42;
        private TextBox NameBox;
        private DataGridView dgv_Employee;
        private DataGridViewTextBoxColumn department;
    }
}