namespace _20142178_TranManhHuy_QLSV
{
    partial class CourseStudentListForm
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
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.dataGridViewCourseStdList = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseStdList)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.Location = new System.Drawing.Point(585, 44);
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.ReadOnly = true;
            this.textBoxSemester.Size = new System.Drawing.Size(120, 22);
            this.textBoxSemester.TabIndex = 88;
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(226, 44);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.ReadOnly = true;
            this.textBoxCourseName.Size = new System.Drawing.Size(178, 22);
            this.textBoxCourseName.TabIndex = 87;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.ForeColor = System.Drawing.Color.White;
            this.lblSemester.Location = new System.Drawing.Point(449, 37);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(123, 29);
            this.lblSemester.TabIndex = 86;
            this.lblSemester.Text = "Semester:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.ForeColor = System.Drawing.Color.White;
            this.lblCourseName.Location = new System.Drawing.Point(49, 37);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(168, 29);
            this.lblCourseName.TabIndex = 85;
            this.lblCourseName.Text = "Course Name:";
            // 
            // dataGridViewCourseStdList
            // 
            this.dataGridViewCourseStdList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCourseStdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourseStdList.Location = new System.Drawing.Point(54, 106);
            this.dataGridViewCourseStdList.Name = "dataGridViewCourseStdList";
            this.dataGridViewCourseStdList.RowHeadersWidth = 51;
            this.dataGridViewCourseStdList.RowTemplate.Height = 24;
            this.dataGridViewCourseStdList.Size = new System.Drawing.Size(651, 309);
            this.dataGridViewCourseStdList.TabIndex = 89;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(338, 443);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(99, 48);
            this.btnPrint.TabIndex = 90;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // CourseStudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(778, 515);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridViewCourseStdList);
            this.Controls.Add(this.textBoxSemester);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblCourseName);
            this.Name = "CourseStudentListForm";
            this.Text = "CourseStudentListForm";
            this.Load += new System.EventHandler(this.CourseStudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseStdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxSemester;
        public System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.DataGridView dataGridViewCourseStdList;
        private System.Windows.Forms.Button btnPrint;
    }
}