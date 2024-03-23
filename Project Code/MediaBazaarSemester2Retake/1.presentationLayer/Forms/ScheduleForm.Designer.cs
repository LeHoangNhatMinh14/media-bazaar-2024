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
            SuspendLayout();
            // 
            // lbEmployees
            // 
            lbEmployees.FormattingEnabled = true;
            lbEmployees.ItemHeight = 25;
            lbEmployees.Location = new Point(17, 20);
            lbEmployees.Margin = new Padding(4, 5, 4, 5);
            lbEmployees.Name = "lbEmployees";
            lbEmployees.Size = new Size(1224, 279);
            lbEmployees.TabIndex = 0;
            lbEmployees.MouseClick += lbEmployees_MouseClick;
            lbEmployees.SelectedIndexChanged += lbEmployees_SelectedIndexChanged;
            // 
            // datePickerassignShift
            // 
            datePickerassignShift.Location = new Point(17, 312);
            datePickerassignShift.Margin = new Padding(4, 5, 4, 5);
            datePickerassignShift.Name = "datePickerassignShift";
            datePickerassignShift.Size = new Size(595, 31);
            datePickerassignShift.TabIndex = 1;
            // 
            // lbShiftsofEmployee
            // 
            lbShiftsofEmployee.FormattingEnabled = true;
            lbShiftsofEmployee.ItemHeight = 25;
            lbShiftsofEmployee.Location = new Point(17, 360);
            lbShiftsofEmployee.Margin = new Padding(4, 5, 4, 5);
            lbShiftsofEmployee.Name = "lbShiftsofEmployee";
            lbShiftsofEmployee.Size = new Size(1224, 304);
            lbShiftsofEmployee.TabIndex = 4;
            // 
            // btnAssignShift
            // 
            btnAssignShift.Location = new Point(17, 670);
            btnAssignShift.Margin = new Padding(4, 5, 4, 5);
            btnAssignShift.Name = "btnAssignShift";
            btnAssignShift.Size = new Size(1226, 38);
            btnAssignShift.TabIndex = 5;
            btnAssignShift.Text = "Assign Shift";
            btnAssignShift.UseVisualStyleBackColor = true;
            btnAssignShift.Click += btnAssignShift_Click;
            // 
            // cbShiftType
            // 
            cbShiftType.FormattingEnabled = true;
            cbShiftType.Items.AddRange(new object[] { "Morning", "Evening", "Night" });
            cbShiftType.Location = new Point(643, 312);
            cbShiftType.Margin = new Padding(4, 5, 4, 5);
            cbShiftType.Name = "cbShiftType";
            cbShiftType.Size = new Size(598, 33);
            cbShiftType.TabIndex = 7;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 728);
            Controls.Add(cbShiftType);
            Controls.Add(btnAssignShift);
            Controls.Add(lbShiftsofEmployee);
            Controls.Add(datePickerassignShift);
            Controls.Add(lbEmployees);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScheduleForm";
            Text = "ScheduleForm";
            Load += ScheduleForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbEmployees;
        private DateTimePicker datePickerassignShift;
        private ListBox lbShiftsofEmployee;
        private Button btnAssignShift;
        private ComboBox cbShiftType;
    }
}