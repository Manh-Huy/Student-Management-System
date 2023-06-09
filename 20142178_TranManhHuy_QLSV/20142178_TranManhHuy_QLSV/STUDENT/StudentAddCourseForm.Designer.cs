namespace _20142178_TranManhHuy_QLSV
{
    partial class StudentAddCourseForm
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
            this.btnAddScourse = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblSelectSemester = new System.Windows.Forms.Label();
            this.comboBoxSelectSemester = new System.Windows.Forms.ComboBox();
            this.ListBoxAvailableCourses = new System.Windows.Forms.ListBox();
            this.ListBoxSelectedCourses = new System.Windows.Forms.ListBox();
            this.lblAvailableCourse = new System.Windows.Forms.Label();
            this.lblSelectedCourse = new System.Windows.Forms.Label();
            this.btnViewAddedCourse = new System.Windows.Forms.Button();
            this.btnShowTimetable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddScourse
            // 
            this.btnAddScourse.BackColor = System.Drawing.Color.Green;
            this.btnAddScourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddScourse.ForeColor = System.Drawing.Color.White;
            this.btnAddScourse.Location = new System.Drawing.Point(354, 355);
            this.btnAddScourse.Name = "btnAddScourse";
            this.btnAddScourse.Size = new System.Drawing.Size(99, 48);
            this.btnAddScourse.TabIndex = 85;
            this.btnAddScourse.TabStop = false;
            this.btnAddScourse.Text = "Add";
            this.btnAddScourse.UseVisualStyleBackColor = false;
            this.btnAddScourse.Click += new System.EventHandler(this.btnAddScourse_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(190, 133);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(236, 22);
            this.textBoxLastName.TabIndex = 84;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(190, 94);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(236, 22);
            this.textBoxFirstName.TabIndex = 83;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(190, 43);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.ReadOnly = true;
            this.textBoxStudentID.Size = new System.Drawing.Size(132, 22);
            this.textBoxStudentID.TabIndex = 82;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(54, 126);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(134, 29);
            this.lblLastName.TabIndex = 81;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(54, 87);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(137, 29);
            this.lblFirstName.TabIndex = 80;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.Color.White;
            this.lblStudentID.Location = new System.Drawing.Point(54, 36);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(130, 29);
            this.lblStudentID.TabIndex = 79;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblSelectSemester
            // 
            this.lblSelectSemester.AutoSize = true;
            this.lblSelectSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSemester.ForeColor = System.Drawing.Color.White;
            this.lblSelectSemester.Location = new System.Drawing.Point(472, 166);
            this.lblSelectSemester.Name = "lblSelectSemester";
            this.lblSelectSemester.Size = new System.Drawing.Size(197, 29);
            this.lblSelectSemester.TabIndex = 78;
            this.lblSelectSemester.Text = "Select Semester:";
            // 
            // comboBoxSelectSemester
            // 
            this.comboBoxSelectSemester.FormattingEnabled = true;
            this.comboBoxSelectSemester.Location = new System.Drawing.Point(675, 171);
            this.comboBoxSelectSemester.Name = "comboBoxSelectSemester";
            this.comboBoxSelectSemester.Size = new System.Drawing.Size(82, 24);
            this.comboBoxSelectSemester.TabIndex = 86;
            this.comboBoxSelectSemester.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectSemester_SelectedIndexChanged);
            // 
            // ListBoxAvailableCourses
            // 
            this.ListBoxAvailableCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxAvailableCourses.FormattingEnabled = true;
            this.ListBoxAvailableCourses.ItemHeight = 25;
            this.ListBoxAvailableCourses.Location = new System.Drawing.Point(56, 257);
            this.ListBoxAvailableCourses.Name = "ListBoxAvailableCourses";
            this.ListBoxAvailableCourses.Size = new System.Drawing.Size(254, 254);
            this.ListBoxAvailableCourses.TabIndex = 87;
            this.ListBoxAvailableCourses.DoubleClick += new System.EventHandler(this.ListBoxAvailableCourses_DoubleClick);
            // 
            // ListBoxSelectedCourses
            // 
            this.ListBoxSelectedCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxSelectedCourses.FormattingEnabled = true;
            this.ListBoxSelectedCourses.ItemHeight = 25;
            this.ListBoxSelectedCourses.Location = new System.Drawing.Point(503, 257);
            this.ListBoxSelectedCourses.Name = "ListBoxSelectedCourses";
            this.ListBoxSelectedCourses.Size = new System.Drawing.Size(254, 254);
            this.ListBoxSelectedCourses.TabIndex = 88;
            this.ListBoxSelectedCourses.DoubleClick += new System.EventHandler(this.ListBoxSelectedCourses_DoubleClick);
            // 
            // lblAvailableCourse
            // 
            this.lblAvailableCourse.AutoSize = true;
            this.lblAvailableCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCourse.ForeColor = System.Drawing.Color.White;
            this.lblAvailableCourse.Location = new System.Drawing.Point(51, 211);
            this.lblAvailableCourse.Name = "lblAvailableCourse";
            this.lblAvailableCourse.Size = new System.Drawing.Size(195, 29);
            this.lblAvailableCourse.TabIndex = 90;
            this.lblAvailableCourse.Text = "Available Course";
            // 
            // lblSelectedCourse
            // 
            this.lblSelectedCourse.AutoSize = true;
            this.lblSelectedCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCourse.ForeColor = System.Drawing.Color.White;
            this.lblSelectedCourse.Location = new System.Drawing.Point(498, 211);
            this.lblSelectedCourse.Name = "lblSelectedCourse";
            this.lblSelectedCourse.Size = new System.Drawing.Size(193, 29);
            this.lblSelectedCourse.TabIndex = 91;
            this.lblSelectedCourse.Text = "Selected Course";
            // 
            // btnViewAddedCourse
            // 
            this.btnViewAddedCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnViewAddedCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAddedCourse.ForeColor = System.Drawing.Color.White;
            this.btnViewAddedCourse.Location = new System.Drawing.Point(500, 36);
            this.btnViewAddedCourse.Name = "btnViewAddedCourse";
            this.btnViewAddedCourse.Size = new System.Drawing.Size(251, 39);
            this.btnViewAddedCourse.TabIndex = 92;
            this.btnViewAddedCourse.TabStop = false;
            this.btnViewAddedCourse.Text = "View Added Courses";
            this.btnViewAddedCourse.UseVisualStyleBackColor = false;
            this.btnViewAddedCourse.Click += new System.EventHandler(this.btnViewAddedCourse_Click);
            // 
            // btnShowTimetable
            // 
            this.btnShowTimetable.BackColor = System.Drawing.Color.Teal;
            this.btnShowTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTimetable.ForeColor = System.Drawing.Color.White;
            this.btnShowTimetable.Location = new System.Drawing.Point(500, 104);
            this.btnShowTimetable.Name = "btnShowTimetable";
            this.btnShowTimetable.Size = new System.Drawing.Size(251, 39);
            this.btnShowTimetable.TabIndex = 93;
            this.btnShowTimetable.TabStop = false;
            this.btnShowTimetable.Text = "Show Timetable";
            this.btnShowTimetable.UseVisualStyleBackColor = false;
            this.btnShowTimetable.Click += new System.EventHandler(this.btnShowTimetable_Click);
            // 
            // StudentAddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(827, 543);
            this.Controls.Add(this.btnShowTimetable);
            this.Controls.Add(this.btnViewAddedCourse);
            this.Controls.Add(this.lblSelectedCourse);
            this.Controls.Add(this.lblAvailableCourse);
            this.Controls.Add(this.ListBoxSelectedCourses);
            this.Controls.Add(this.ListBoxAvailableCourses);
            this.Controls.Add(this.comboBoxSelectSemester);
            this.Controls.Add(this.btnAddScourse);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblSelectSemester);
            this.Name = "StudentAddCourseForm";
            this.Text = "StudentAddCourseForm";
            this.Load += new System.EventHandler(this.StudentAddCourseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddScourse;
        public System.Windows.Forms.TextBox textBoxLastName;
        public System.Windows.Forms.TextBox textBoxFirstName;
        public System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblSelectSemester;
        private System.Windows.Forms.ComboBox comboBoxSelectSemester;
        private System.Windows.Forms.ListBox ListBoxAvailableCourses;
        private System.Windows.Forms.ListBox ListBoxSelectedCourses;
        private System.Windows.Forms.Label lblAvailableCourse;
        private System.Windows.Forms.Label lblSelectedCourse;
        private System.Windows.Forms.Button btnViewAddedCourse;
        private System.Windows.Forms.Button btnShowTimetable;
    }
}