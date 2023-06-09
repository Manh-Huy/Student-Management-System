namespace _20142178_TranManhHuy_QLSV
{
    partial class EditCourseForm
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
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.numericUpDownPeriod = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblSelectCourseID = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.btnSearchContact = new System.Windows.Forms.Button();
            this.textBoxContactID = new System.Windows.Forms.TextBox();
            this.lblContactID = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.textBoxClassPeriodEnd = new System.Windows.Forms.TextBox();
            this.lblClassEnd = new System.Windows.Forms.Label();
            this.textBoxClassPeriodStart = new System.Windows.Forms.TextBox();
            this.lblClassStart = new System.Windows.Forms.Label();
            this.textBoxTimeStart = new System.Windows.Forms.TextBox();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.textBoxTimeEnd = new System.Windows.Forms.TextBox();
            this.labelTimeEnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.Location = new System.Drawing.Point(277, 339);
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.Size = new System.Drawing.Size(233, 22);
            this.textBoxSemester.TabIndex = 64;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.ForeColor = System.Drawing.Color.White;
            this.lblSemester.Location = new System.Drawing.Point(58, 332);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(123, 29);
            this.lblSemester.TabIndex = 63;
            this.lblSemester.Text = "Semester:";
            // 
            // numericUpDownPeriod
            // 
            this.numericUpDownPeriod.Location = new System.Drawing.Point(277, 285);
            this.numericUpDownPeriod.Name = "numericUpDownPeriod";
            this.numericUpDownPeriod.Size = new System.Drawing.Size(124, 22);
            this.numericUpDownPeriod.TabIndex = 62;
            this.numericUpDownPeriod.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(277, 44);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(124, 24);
            this.comboBoxCourse.TabIndex = 61;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(279, 671);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(233, 82);
            this.textBoxDescription.TabIndex = 60;
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.BackColor = System.Drawing.Color.Green;
            this.btnEditCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCourse.ForeColor = System.Drawing.Color.White;
            this.btnEditCourse.Location = new System.Drawing.Point(170, 799);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(233, 41);
            this.btnEditCourse.TabIndex = 59;
            this.btnEditCourse.Text = "Edit";
            this.btnEditCourse.UseVisualStyleBackColor = false;
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(277, 108);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(233, 22);
            this.textBoxCourseName.TabIndex = 58;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(60, 664);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(141, 29);
            this.lblDescription.TabIndex = 57;
            this.lblDescription.Text = "Description:";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.ForeColor = System.Drawing.Color.White;
            this.lblPeriod.Location = new System.Drawing.Point(58, 277);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(91, 29);
            this.lblPeriod.TabIndex = 56;
            this.lblPeriod.Text = "Period:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.ForeColor = System.Drawing.Color.White;
            this.lblCourseName.Location = new System.Drawing.Point(58, 101);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(168, 29);
            this.lblCourseName.TabIndex = 55;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblSelectCourseID
            // 
            this.lblSelectCourseID.AutoSize = true;
            this.lblSelectCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourseID.ForeColor = System.Drawing.Color.White;
            this.lblSelectCourseID.Location = new System.Drawing.Point(58, 39);
            this.lblSelectCourseID.Name = "lblSelectCourseID";
            this.lblSelectCourseID.Size = new System.Drawing.Size(171, 29);
            this.lblSelectCourseID.TabIndex = 54;
            this.lblSelectCourseID.Text = "Select Course:";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(277, 161);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(166, 24);
            this.comboBoxGroup.TabIndex = 69;
            // 
            // btnSearchContact
            // 
            this.btnSearchContact.BackColor = System.Drawing.Color.Olive;
            this.btnSearchContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchContact.ForeColor = System.Drawing.Color.White;
            this.btnSearchContact.Location = new System.Drawing.Point(406, 218);
            this.btnSearchContact.Name = "btnSearchContact";
            this.btnSearchContact.Size = new System.Drawing.Size(117, 35);
            this.btnSearchContact.TabIndex = 68;
            this.btnSearchContact.Text = "Search";
            this.btnSearchContact.UseVisualStyleBackColor = false;
            this.btnSearchContact.Click += new System.EventHandler(this.btnSearchContact_Click);
            // 
            // textBoxContactID
            // 
            this.textBoxContactID.Location = new System.Drawing.Point(277, 226);
            this.textBoxContactID.Name = "textBoxContactID";
            this.textBoxContactID.ReadOnly = true;
            this.textBoxContactID.Size = new System.Drawing.Size(101, 22);
            this.textBoxContactID.TabIndex = 67;
            // 
            // lblContactID
            // 
            this.lblContactID.AutoSize = true;
            this.lblContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactID.ForeColor = System.Drawing.Color.White;
            this.lblContactID.Location = new System.Drawing.Point(58, 219);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(129, 29);
            this.lblContactID.TabIndex = 66;
            this.lblContactID.Text = "Contact ID:";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.ForeColor = System.Drawing.Color.White;
            this.lblGroup.Location = new System.Drawing.Point(58, 156);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(86, 29);
            this.lblGroup.TabIndex = 65;
            this.lblGroup.Text = "Group:";
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBoxDay.Location = new System.Drawing.Point(327, 392);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(185, 24);
            this.comboBoxDay.TabIndex = 75;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(60, 392);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(60, 29);
            this.lblDay.TabIndex = 74;
            this.lblDay.Text = "Day:";
            // 
            // textBoxClassPeriodEnd
            // 
            this.textBoxClassPeriodEnd.Location = new System.Drawing.Point(366, 539);
            this.textBoxClassPeriodEnd.Name = "textBoxClassPeriodEnd";
            this.textBoxClassPeriodEnd.Size = new System.Drawing.Size(146, 22);
            this.textBoxClassPeriodEnd.TabIndex = 73;
            // 
            // lblClassEnd
            // 
            this.lblClassEnd.AutoSize = true;
            this.lblClassEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassEnd.ForeColor = System.Drawing.Color.White;
            this.lblClassEnd.Location = new System.Drawing.Point(60, 532);
            this.lblClassEnd.Name = "lblClassEnd";
            this.lblClassEnd.Size = new System.Drawing.Size(206, 29);
            this.lblClassEnd.TabIndex = 72;
            this.lblClassEnd.Text = "Class Period End:";
            // 
            // textBoxClassPeriodStart
            // 
            this.textBoxClassPeriodStart.Location = new System.Drawing.Point(364, 466);
            this.textBoxClassPeriodStart.Name = "textBoxClassPeriodStart";
            this.textBoxClassPeriodStart.Size = new System.Drawing.Size(146, 22);
            this.textBoxClassPeriodStart.TabIndex = 71;
            // 
            // lblClassStart
            // 
            this.lblClassStart.AutoSize = true;
            this.lblClassStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassStart.ForeColor = System.Drawing.Color.White;
            this.lblClassStart.Location = new System.Drawing.Point(60, 459);
            this.lblClassStart.Name = "lblClassStart";
            this.lblClassStart.Size = new System.Drawing.Size(212, 29);
            this.lblClassStart.TabIndex = 70;
            this.lblClassStart.Text = "Class Period Start:";
            // 
            // textBoxTimeStart
            // 
            this.textBoxTimeStart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxTimeStart.Location = new System.Drawing.Point(196, 610);
            this.textBoxTimeStart.Name = "textBoxTimeStart";
            this.textBoxTimeStart.ReadOnly = true;
            this.textBoxTimeStart.Size = new System.Drawing.Size(76, 22);
            this.textBoxTimeStart.TabIndex = 77;
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeStart.ForeColor = System.Drawing.Color.White;
            this.lblTimeStart.Location = new System.Drawing.Point(60, 603);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(130, 29);
            this.lblTimeStart.TabIndex = 76;
            this.lblTimeStart.Text = "Time Start:";
            // 
            // textBoxTimeEnd
            // 
            this.textBoxTimeEnd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxTimeEnd.Location = new System.Drawing.Point(434, 610);
            this.textBoxTimeEnd.Name = "textBoxTimeEnd";
            this.textBoxTimeEnd.ReadOnly = true;
            this.textBoxTimeEnd.Size = new System.Drawing.Size(76, 22);
            this.textBoxTimeEnd.TabIndex = 79;
            // 
            // labelTimeEnd
            // 
            this.labelTimeEnd.AutoSize = true;
            this.labelTimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeEnd.ForeColor = System.Drawing.Color.White;
            this.labelTimeEnd.Location = new System.Drawing.Point(298, 603);
            this.labelTimeEnd.Name = "labelTimeEnd";
            this.labelTimeEnd.Size = new System.Drawing.Size(124, 29);
            this.labelTimeEnd.TabIndex = 78;
            this.labelTimeEnd.Text = "Time End:";
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(568, 887);
            this.Controls.Add(this.textBoxTimeEnd);
            this.Controls.Add(this.labelTimeEnd);
            this.Controls.Add(this.textBoxTimeStart);
            this.Controls.Add(this.lblTimeStart);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.textBoxClassPeriodEnd);
            this.Controls.Add(this.lblClassEnd);
            this.Controls.Add(this.textBoxClassPeriodStart);
            this.Controls.Add(this.lblClassStart);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.btnSearchContact);
            this.Controls.Add(this.textBoxContactID);
            this.Controls.Add(this.lblContactID);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.textBoxSemester);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.numericUpDownPeriod);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.btnEditCourse);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblSelectCourseID);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSemester;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.NumericUpDown numericUpDownPeriod;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblSelectCourseID;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Button btnSearchContact;
        private System.Windows.Forms.TextBox textBoxContactID;
        private System.Windows.Forms.Label lblContactID;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TextBox textBoxClassPeriodEnd;
        private System.Windows.Forms.Label lblClassEnd;
        private System.Windows.Forms.TextBox textBoxClassPeriodStart;
        private System.Windows.Forms.Label lblClassStart;
        private System.Windows.Forms.TextBox textBoxTimeStart;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.TextBox textBoxTimeEnd;
        private System.Windows.Forms.Label labelTimeEnd;
    }
}