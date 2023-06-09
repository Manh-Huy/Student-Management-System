namespace _20142178_TranManhHuy_QLSV
{
    partial class ContactHistoryNotificationSent
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
            this.panelNotification = new System.Windows.Forms.Panel();
            this.dataGridViewNotificationList = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.lblNotification = new System.Windows.Forms.Label();
            this.comboBoxSemesterInNotification = new System.Windows.Forms.ComboBox();
            this.lblSemesterInNotification = new System.Windows.Forms.Label();
            this.comboBoxCourseinNotification = new System.Windows.Forms.ComboBox();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.btnShowAllCourse = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabelRefresh = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditInfo = new System.Windows.Forms.LinkLabel();
            this.lblWelcomeHr = new System.Windows.Forms.Label();
            this.pictureBoxHr = new System.Windows.Forms.PictureBox();
            this.panelNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotificationList)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHr)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNotification
            // 
            this.panelNotification.BackColor = System.Drawing.Color.Indigo;
            this.panelNotification.Controls.Add(this.dataGridViewNotificationList);
            this.panelNotification.Controls.Add(this.btnShow);
            this.panelNotification.Controls.Add(this.textBoxContent);
            this.panelNotification.Location = new System.Drawing.Point(76, 292);
            this.panelNotification.Name = "panelNotification";
            this.panelNotification.Size = new System.Drawing.Size(729, 567);
            this.panelNotification.TabIndex = 164;
            // 
            // dataGridViewNotificationList
            // 
            this.dataGridViewNotificationList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNotificationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotificationList.Location = new System.Drawing.Point(40, 40);
            this.dataGridViewNotificationList.Name = "dataGridViewNotificationList";
            this.dataGridViewNotificationList.RowHeadersWidth = 51;
            this.dataGridViewNotificationList.RowTemplate.Height = 24;
            this.dataGridViewNotificationList.Size = new System.Drawing.Size(649, 231);
            this.dataGridViewNotificationList.TabIndex = 152;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Green;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(276, 290);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(176, 58);
            this.btnShow.TabIndex = 151;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Show Content";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(141, 367);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(463, 178);
            this.textBoxContent.TabIndex = 124;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.Color.White;
            this.lblNotification.Location = new System.Drawing.Point(292, 126);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(259, 38);
            this.lblNotification.TabIndex = 163;
            this.lblNotification.Text = "NOTIFICATION";
            // 
            // comboBoxSemesterInNotification
            // 
            this.comboBoxSemesterInNotification.FormattingEnabled = true;
            this.comboBoxSemesterInNotification.Location = new System.Drawing.Point(346, 191);
            this.comboBoxSemesterInNotification.Name = "comboBoxSemesterInNotification";
            this.comboBoxSemesterInNotification.Size = new System.Drawing.Size(87, 24);
            this.comboBoxSemesterInNotification.TabIndex = 162;
            this.comboBoxSemesterInNotification.SelectedIndexChanged += new System.EventHandler(this.comboBoxSemesterInNotification_SelectedIndexChanged);
            // 
            // lblSemesterInNotification
            // 
            this.lblSemesterInNotification.AutoSize = true;
            this.lblSemesterInNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterInNotification.ForeColor = System.Drawing.Color.White;
            this.lblSemesterInNotification.Location = new System.Drawing.Point(143, 191);
            this.lblSemesterInNotification.Name = "lblSemesterInNotification";
            this.lblSemesterInNotification.Size = new System.Drawing.Size(197, 29);
            this.lblSemesterInNotification.TabIndex = 161;
            this.lblSemesterInNotification.Text = "Select Semester:";
            // 
            // comboBoxCourseinNotification
            // 
            this.comboBoxCourseinNotification.FormattingEnabled = true;
            this.comboBoxCourseinNotification.Location = new System.Drawing.Point(346, 245);
            this.comboBoxCourseinNotification.Name = "comboBoxCourseinNotification";
            this.comboBoxCourseinNotification.Size = new System.Drawing.Size(232, 24);
            this.comboBoxCourseinNotification.TabIndex = 160;
            this.comboBoxCourseinNotification.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourseinNotification_SelectedIndexChanged);
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.ForeColor = System.Drawing.Color.White;
            this.lblSelectCourse.Location = new System.Drawing.Point(143, 240);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(171, 29);
            this.lblSelectCourse.TabIndex = 159;
            this.lblSelectCourse.Text = "Select Course:";
            // 
            // btnShowAllCourse
            // 
            this.btnShowAllCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnShowAllCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllCourse.ForeColor = System.Drawing.Color.White;
            this.btnShowAllCourse.Location = new System.Drawing.Point(452, 183);
            this.btnShowAllCourse.Name = "btnShowAllCourse";
            this.btnShowAllCourse.Size = new System.Drawing.Size(317, 47);
            this.btnShowAllCourse.TabIndex = 165;
            this.btnShowAllCourse.TabStop = false;
            this.btnShowAllCourse.Text = "Show All Course Notification";
            this.btnShowAllCourse.UseVisualStyleBackColor = false;
            this.btnShowAllCourse.Click += new System.EventHandler(this.btnShowAllCourse_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.linkLabelRefresh);
            this.panel4.Controls.Add(this.linkLabelEditInfo);
            this.panel4.Controls.Add(this.lblWelcomeHr);
            this.panel4.Controls.Add(this.pictureBoxHr);
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(873, 100);
            this.panel4.TabIndex = 180;
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
            // ContactHistoryNotificationSent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(874, 907);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnShowAllCourse);
            this.Controls.Add(this.panelNotification);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.comboBoxSemesterInNotification);
            this.Controls.Add(this.lblSemesterInNotification);
            this.Controls.Add(this.comboBoxCourseinNotification);
            this.Controls.Add(this.lblSelectCourse);
            this.Name = "ContactHistoryNotificationSent";
            this.Text = "ContactHistoryNotificationSent";
            this.Load += new System.EventHandler(this.ContactHistoryNotificationSent_Load);
            this.panelNotification.ResumeLayout(false);
            this.panelNotification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotificationList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNotification;
        private System.Windows.Forms.DataGridView dataGridViewNotificationList;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.ComboBox comboBoxSemesterInNotification;
        private System.Windows.Forms.Label lblSemesterInNotification;
        private System.Windows.Forms.ComboBox comboBoxCourseinNotification;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Button btnShowAllCourse;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabelRefresh;
        private System.Windows.Forms.LinkLabel linkLabelEditInfo;
        private System.Windows.Forms.Label lblWelcomeHr;
        private System.Windows.Forms.PictureBox pictureBoxHr;
    }
}