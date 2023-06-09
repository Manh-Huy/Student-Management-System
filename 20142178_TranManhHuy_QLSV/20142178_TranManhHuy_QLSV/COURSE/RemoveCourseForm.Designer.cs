namespace _20142178_TranManhHuy_QLSV
{
    partial class RemoveCourseForm
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
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.lblEnterCourseID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCourse.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCourse.Location = new System.Drawing.Point(471, 55);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(126, 43);
            this.btnRemoveCourse.TabIndex = 51;
            this.btnRemoveCourse.Text = "Remove";
            this.btnRemoveCourse.UseVisualStyleBackColor = false;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Location = new System.Drawing.Point(282, 68);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(155, 22);
            this.textBoxCourseID.TabIndex = 50;
            // 
            // lblEnterCourseID
            // 
            this.lblEnterCourseID.AutoSize = true;
            this.lblEnterCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCourseID.ForeColor = System.Drawing.Color.White;
            this.lblEnterCourseID.Location = new System.Drawing.Point(38, 61);
            this.lblEnterCourseID.Name = "lblEnterCourseID";
            this.lblEnterCourseID.Size = new System.Drawing.Size(238, 29);
            this.lblEnterCourseID.TabIndex = 49;
            this.lblEnterCourseID.Text = "Enter The Course ID:";
            // 
            // RemoveCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(634, 157);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.textBoxCourseID);
            this.Controls.Add(this.lblEnterCourseID);
            this.Name = "RemoveCourseForm";
            this.Text = "RemoveCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.Label lblEnterCourseID;
    }
}