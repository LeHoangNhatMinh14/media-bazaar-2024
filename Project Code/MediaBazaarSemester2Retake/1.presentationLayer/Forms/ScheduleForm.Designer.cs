namespace MediaBazaarSemester2Retake
{
    partial class ScheduleForm
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
            lbEmployees = new ListBox();
            datePickerassignShift = new DateTimePicker();
            lbShiftsofEmployee = new ListBox();
            btnAssignShift = new Button();
            cbShiftType = new ComboBox();
            btnAddShift = new Button();
            numericPplNeeded = new NumericUpDown();
            cbDepartments = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericPplNeeded).BeginInit();
            SuspendLayout();
            // 
            // lbEmployees
            // 
            lbEmployees.FormattingEnabled = true;
            lbEmployees.ItemHeight = 15;
            lbEmployees.Location = new Point(12, 12);
            lbEmployees.Name = "lbEmployees";
            lbEmployees.Size = new Size(858, 139);
            lbEmployees.TabIndex = 0;
            lbEmployees.MouseClick += lbEmployees_MouseClick;
            // 
            // datePickerassignShift
            // 
            datePickerassignShift.Location = new Point(12, 187);
            datePickerassignShift.Name = "datePickerassignShift";
            datePickerassignShift.Size = new Size(272, 23);
            datePickerassignShift.TabIndex = 1;
            // 
            // lbShiftsofEmployee
            // 
            lbShiftsofEmployee.FormattingEnabled = true;
            lbShiftsofEmployee.ItemHeight = 15;
            lbShiftsofEmployee.Location = new Point(12, 216);
            lbShiftsofEmployee.Name = "lbShiftsofEmployee";
            lbShiftsofEmployee.Size = new Size(858, 184);
            lbShiftsofEmployee.TabIndex = 4;
            // 
            // btnAssignShift
            // 
            btnAssignShift.Location = new Point(12, 402);
            btnAssignShift.Name = "btnAssignShift";
            btnAssignShift.Size = new Size(418, 23);
            btnAssignShift.TabIndex = 5;
            btnAssignShift.Text = "Assign Shift";
            btnAssignShift.UseVisualStyleBackColor = true;
            btnAssignShift.Click += btnAssignShift_Click;
            // 
            // cbShiftType
            // 
            cbShiftType.FormattingEnabled = true;
            cbShiftType.Items.AddRange(new object[] { "Morning", "Evening", "Night" });
            cbShiftType.Location = new Point(290, 187);
            cbShiftType.Name = "cbShiftType";
            cbShiftType.Size = new Size(270, 23);
            cbShiftType.TabIndex = 7;
            // 
            // btnAddShift
            // 
            btnAddShift.Location = new Point(450, 402);
            btnAddShift.Name = "btnAddShift";
            btnAddShift.Size = new Size(420, 23);
            btnAddShift.TabIndex = 8;
            btnAddShift.Text = "Add Shift";
            btnAddShift.UseVisualStyleBackColor = true;
            btnAddShift.Click += btnAddShift_Click;
            // 
            // numericPplNeeded
            // 
            numericPplNeeded.Location = new Point(566, 187);
            numericPplNeeded.Name = "numericPplNeeded";
            numericPplNeeded.Size = new Size(304, 23);
            numericPplNeeded.TabIndex = 9;
            // 
            // cbDepartments
            // 
            cbDepartments.FormattingEnabled = true;
            cbDepartments.Location = new Point(12, 158);
            cbDepartments.Name = "cbDepartments";
            cbDepartments.Size = new Size(858, 23);
            cbDepartments.TabIndex = 10;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 437);
            Controls.Add(cbDepartments);
            Controls.Add(numericPplNeeded);
            Controls.Add(btnAddShift);
            Controls.Add(cbShiftType);
            Controls.Add(btnAssignShift);
            Controls.Add(lbShiftsofEmployee);
            Controls.Add(datePickerassignShift);
            Controls.Add(lbEmployees);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ScheduleForm";
            Text = "ScheduleForm";
            Load += ScheduleForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericPplNeeded).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbEmployees;
        private DateTimePicker datePickerassignShift;
        private ListBox lbShiftsofEmployee;
        private Button btnAssignShift;
        private ComboBox cbShiftType;
        private Button btnAddShift;
        private NumericUpDown numericPplNeeded;
        private ComboBox cbDepartments;
    }
}