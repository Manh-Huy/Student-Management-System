namespace _20142178_TranManhHuy_QLSV
{
    partial class ContactListStudentScoreList
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
            this.lblScore = new System.Windows.Forms.Label();
            this.btnSearchStd = new System.Windows.Forms.Button();
            this.lblSemesterinAddScore = new System.Windows.Forms.Label();
            this.lblCourseInAddScore = new System.Windows.Forms.Label();
            this.dataGridViewScoreList = new System.Windows.Forms.DataGridView();
            this.comboBoxCourseInAddCourse = new System.Windows.Forms.ComboBox();
            this.comboBoxSemesterInAddScore = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabelRefresh = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditInfo = new System.Windows.Forms.LinkLabel();
            this.lblWelcomeHr = new System.Windows.Forms.Label();
            this.pictureBoxHr = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreList)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHr)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(274, 121);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(140, 38);
            this.lblScore.TabIndex = 167;
            this.lblScore.Text = "SCORE";
            // 
            // btnSearchStd
            // 
            this.btnSearchStd.BackColor = System.Drawing.Color.Navy;
            this.btnSearchStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStd.ForeColor = System.Drawing.Color.White;
            this.btnSearchStd.Location = new System.Drawing.Point(291, 305);
            this.btnSearchStd.Name = "btnSearchStd";
            this.btnSearchStd.Size = new System.Drawing.Size(143, 45);
            this.btnSearchStd.TabIndex = 169;
            this.btnSearchStd.Text = "Search";
            this.btnSearchStd.UseVisualStyleBackColor = false;
            this.btnSearchStd.Click += new System.EventHandler(this.btnSearchStd_Click);
            // 
            // lblSemesterinAddScore
            // 
            this.lblSemesterinAddScore.AutoSize = true;
            this.lblSemesterinAddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterinAddScore.ForeColor = System.Drawing.Color.White;
            this.lblSemesterinAddScore.Location = new System.Drawing.Point(198, 194);
            this.lblSemesterinAddScore.Name = "lblSemesterinAddScore";
            this.lblSemesterinAddScore.Size = new System.Drawing.Size(123, 29);
            this.lblSemesterinAddScore.TabIndex = 165;
            this.lblSemesterinAddScore.Text = "Semester:";
            // 
            // lblCourseInAddScore
            // 
            this.lblCourseInAddScore.AutoSize = true;
            this.lblCourseInAddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseInAddScore.ForeColor = System.Drawing.Color.White;
            this.lblCourseInAddScore.Location = new System.Drawing.Point(198, 243);
            this.lblCourseInAddScore.Name = "lblCourseInAddScore";
            this.lblCourseInAddScore.Size = new System.Drawing.Size(97, 29);
            this.lblCourseInAddScore.TabIndex = 163;
            this.lblCourseInAddScore.Text = "Course:";
            // 
            // dataGridViewScoreList
            // 
            this.dataGridViewScoreList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScoreList.Location = new System.Drawing.Point(60, 378);
            this.dataGridViewScoreList.Name = "dataGridViewScoreList";
            this.dataGridViewScoreList.RowHeadersWidth = 51;
            this.dataGridViewScoreList.RowTemplate.Height = 24;
            this.dataGridViewScoreList.Size = new System.Drawing.Size(626, 312);
            this.dataGridViewScoreList.TabIndex = 168;
            // 
            // comboBoxCourseInAddCourse
            // 
            this.comboBoxCourseInAddCourse.FormattingEnabled = true;
            this.comboBoxCourseInAddCourse.Location = new System.Drawing.Point(327, 250);
            this.comboBoxCourseInAddCourse.Name = "comboBoxCourseInAddCourse";
            this.comboBoxCourseInAddCourse.Size = new System.Drawing.Size(232, 24);
            this.comboBoxCourseInAddCourse.TabIndex = 164;
            // 
            // comboBoxSemesterInAddScore
            // 
            this.comboBoxSemesterInAddScore.FormattingEnabled = true;
            this.comboBoxSemesterInAddScore.Location = new System.Drawing.Point(327, 199);
            this.comboBoxSemesterInAddScore.Name = "comboBoxSemesterInAddScore";
            this.comboBoxSemesterInAddScore.Size = new System.Drawing.Size(87, 24);
            this.comboBoxSemesterInAddScore.TabIndex = 166;
            this.comboBoxSemesterInAddScore.SelectedIndexChanged += new System.EventHandler(this.comboBoxSemesterInAddScore_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.linkLabelRefresh);
            this.panel4.Controls.Add(this.linkLabelEditInfo);
            this.panel4.Controls.Add(this.lblWelcomeHr);
            this.panel4.Controls.Add(this.pictureBoxHr);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(738, 100);
            this.panel4.TabIndex = 170;
            // 
            // linkLabelRefresh
            // 
            this.linkLabelRefresh.AutoSize = true;
            this.linkLabelRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRefresh.LinkColor = System.Drawing.Color.White;
            this.linkLabelRefresh.Location = new System.Drawing.Point(144, 70);
            this.linkLabelRefresh.Name = "linkLabelRefresh";
            this.linkLabelRefresh.Size = new System.Drawing.Size(60, 18);
            this.linkLabelRefresh.TabIndex = 17;
            this.linkLabelRefresh.TabStop = true;
            this.linkLabelRefresh.Text = "Refresh";
            // 
            // linkLabelEditInfo
            // 
            this.linkLabelEditInfo.AutoSize = true;
            this.linkLabelEditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelEditInfo.LinkColor = System.Drawing.Color.White;
            this.linkLabelEditInfo.Location = new System.Drawing.Point(144, 43);
            this.linkLabelEditInfo.Name = "linkLabelEditInfo";
            this.linkLabelEditInfo.Size = new System.Drawing.Size(85, 18);
            this.linkLabelEditInfo.TabIndex = 16;
            this.linkLabelEditInfo.TabStop = true;
            this.linkLabelEditInfo.Text = "Edit my info";
            // 
            // lblWelcomeHr
            // 
            this.lblWelcomeHr.AutoSize = true;
            this.lblWelcomeHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeHr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcomeHr.Location = new System.Drawing.Point(143, 13);
            this.lblWelcomeHr.Name = "lblWelcomeHr";
            this.lblWelcomeHr.Size = new System.Drawing.Size(194, 20);
            this.lblWelcomeHr.TabIndex = 15;
            this.lblWelcomeHr.Text = "Welcome (user name)";
            // 
            // pictureBoxHr
            // 
            this.pictureBoxHr.Location = new System.Drawing.Point(37, 13);
            this.pictureBoxHr.Name = "pictureBoxHr";
            this.pictureBoxHr.Size = new System.Drawing.Size(80, 75);
            this.pictureBoxHr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHr.TabIndex = 14;
            this.pictureBoxHr.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(443, 723);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 45);
            this.btnDelete.TabIndex = 171;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Olive;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(147, 723);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(143, 45);
            this.btnPrint.TabIndex = 172;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ContactListStudentScoreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(737, 795);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSearchStd);
            this.Controls.Add(this.lblSemesterinAddScore);
            this.Controls.Add(this.lblCourseInAddScore);
            this.Controls.Add(this.dataGridViewScoreList);
            this.Controls.Add(this.comboBoxCourseInAddCourse);
            this.Controls.Add(this.comboBoxSemesterInAddScore);
            this.Name = "ContactListStudentScoreList";
            this.Text = "ContactListStudentScoreList";
            this.Load += new System.EventHandler(this.ContactListStudentScoreList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnSearchStd;
        private System.Windows.Forms.Label lblSemesterinAddScore;
        private System.Windows.Forms.Label lblCourseInAddScore;
        private System.Windows.Forms.DataGridView dataGridViewScoreList;
        private System.Windows.Forms.ComboBox comboBoxCourseInAddCourse;
        private System.Windows.Forms.ComboBox comboBoxSemesterInAddScore;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabelRefresh;
        private System.Windows.Forms.LinkLabel linkLabelEditInfo;
        private System.Windows.Forms.Label lblWelcomeHr;
        private System.Windows.Forms.PictureBox pictureBoxHr;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
    }
}