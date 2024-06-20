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
            lbUnassignedShifts = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btncreateShiftforNextWeek = new Button();
            ((System.ComponentModel.ISupportInitialize)numericPplNeeded).BeginInit();
            SuspendLayout();
            // 
            // lbEmployees
            // 
            lbEmployees.FormattingEnabled = true;
            lbEmployees.Location = new Point(14, 36);
            lbEmployees.Margin = new Padding(3, 4, 3, 4);
            lbEmployees.Name = "lbEmployees";
            lbEmployees.Size = new Size(980, 164);
            lbEmployees.TabIndex = 0;
            lbEmployees.MouseClick += lbEmployees_MouseClick;
            // 
            // datePickerassignShift
            // 
            datePickerassignShift.Location = new Point(14, 249);
            datePickerassignShift.Margin = new Padding(3, 4, 3, 4);
            datePickerassignShift.Name = "datePickerassignShift";
            datePickerassignShift.Size = new Size(310, 27);
            datePickerassignShift.TabIndex = 1;
            datePickerassignShift.ValueChanged += datePickerassignShift_ValueChanged_1;
            // 
            // lbShiftsofEmployee
            // 
            lbShiftsofEmployee.FormattingEnabled = true;
            lbShiftsofEmployee.Location = new Point(14, 308);
            lbShiftsofEmployee.Margin = new Padding(3, 4, 3, 4);
            lbShiftsofEmployee.Name = "lbShiftsofEmployee";
            lbShiftsofEmployee.Size = new Size(477, 224);
            lbShiftsofEmployee.TabIndex = 4;
            // 
            // btnAssignShift
            // 
            btnAssignShift.Location = new Point(14, 536);
            btnAssignShift.Margin = new Padding(3, 4, 3, 4);
            btnAssignShift.Name = "btnAssignShift";
            btnAssignShift.Size = new Size(478, 31);
            btnAssignShift.TabIndex = 5;
            btnAssignShift.Text = "Assign Shift";
            btnAssignShift.UseVisualStyleBackColor = true;
            btnAssignShift.Click += btnAssignShift_Click;
            // 
            // cbShiftType
            // 
            cbShiftType.FormattingEnabled = true;
            cbShiftType.Items.AddRange(new object[] { "Morning", "Evening", "Night" });
            cbShiftType.Location = new Point(331, 249);
            cbShiftType.Margin = new Padding(3, 4, 3, 4);
            cbShiftType.Name = "cbShiftType";
            cbShiftType.Size = new Size(308, 28);
            cbShiftType.TabIndex = 7;
            // 
            // btnAddShift
            // 
            btnAddShift.Location = new Point(514, 536);
            btnAddShift.Margin = new Padding(3, 4, 3, 4);
            btnAddShift.Name = "btnAddShift";
            btnAddShift.Size = new Size(251, 31);
            btnAddShift.TabIndex = 8;
            btnAddShift.Text = "Add Shift";
            btnAddShift.UseVisualStyleBackColor = true;
            btnAddShift.Click += btnAddShift_Click;
            // 
            // numericPplNeeded
            // 
            numericPplNeeded.Location = new Point(647, 249);
            numericPplNeeded.Margin = new Padding(3, 4, 3, 4);
            numericPplNeeded.Name = "numericPplNeeded";
            numericPplNeeded.Size = new Size(347, 27);
            numericPplNeeded.TabIndex = 9;
            // 
            // cbDepartments
            // 
            cbDepartments.FormattingEnabled = true;
            cbDepartments.Location = new Point(14, 211);
            cbDepartments.Margin = new Padding(3, 4, 3, 4);
            cbDepartments.Name = "cbDepartments";
            cbDepartments.Size = new Size(980, 28);
            cbDepartments.TabIndex = 10;
            cbDepartments.SelectedIndexChanged += cbDepartments_SelectedIndexChanged;
            // 
            // lbUnassignedShifts
            // 
            lbUnassignedShifts.FormattingEnabled = true;
            lbUnassignedShifts.Location = new Point(514, 308);
            lbUnassignedShifts.Margin = new Padding(3, 4, 3, 4);
            lbUnassignedShifts.Name = "lbUnassignedShifts";
            lbUnassignedShifts.Size = new Size(479, 224);
            lbUnassignedShifts.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 284);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 12;
            label1.Text = "Shifts of Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(686, 284);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 13;
            label2.Text = "Unassigned Shifts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 12);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 14;
            label3.Text = "Employees";
            // 
            // btncreateShiftforNextWeek
            // 
            btncreateShiftforNextWeek.Location = new Point(771, 536);
            btncreateShiftforNextWeek.Name = "btncreateShiftforNextWeek";
            btncreateShiftforNextWeek.Size = new Size(223, 29);
            btncreateShiftforNextWeek.TabIndex = 15;
            btncreateShiftforNextWeek.Text = "Create Shift for next Week";
            btncreateShiftforNextWeek.UseVisualStyleBackColor = true;
            btncreateShiftforNextWeek.Click += btncreateShiftforNextWeek_Click;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 583);
            Controls.Add(btncreateShiftforNextWeek);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbUnassignedShifts);
            Controls.Add(cbDepartments);
            Controls.Add(numericPplNeeded);
            Controls.Add(btnAddShift);
            Controls.Add(cbShiftType);
            Controls.Add(btnAssignShift);
            Controls.Add(lbShiftsofEmployee);
            Controls.Add(datePickerassignShift);
            Controls.Add(lbEmployees);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "ScheduleForm";
            Text = "ScheduleForm";
            Load += ScheduleForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericPplNeeded).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ListBox lbUnassignedShifts;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btncreateShiftforNextWeek;
    }
}