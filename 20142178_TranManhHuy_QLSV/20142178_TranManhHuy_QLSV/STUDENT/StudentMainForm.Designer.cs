namespace _20142178_TranManhHuy_QLSV
{
    partial class StudentMainForm
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
            this.lblNotification = new System.Windows.Forms.Label();
            this.comboBoxSemesterInNotification = new System.Windows.Forms.ComboBox();
            this.lblSemesterInNotification = new System.Windows.Forms.Label();
            this.comboBoxCourseinNotification = new System.Windows.Forms.ComboBox();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.tabPageScore = new System.Windows.Forms.TabPage();
            this.btnPrintScore = new System.Windows.Forms.Button();
            this.lblAvgScore = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnSearchStd = new System.Windows.Forms.Button();
            this.lblSemesterinAddScore = new System.Windows.Forms.Label();
            this.dataGridViewScoreList = new System.Windows.Forms.DataGridView();
            this.comboBoxSemesterInScore = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.linkLabelRefresh = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditInfo = new System.Windows.Forms.LinkLabel();
            this.lblWelcomeHr = new System.Windows.Forms.Label();
            this.pictureBoxHr = new System.Windows.Forms.PictureBox();
            this.tabPageCourse = new System.Windows.Forms.TabPage();
            this.lblCourse = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.comboBoxSelectSemester = new System.Windows.Forms.ComboBox();
            this.lblSelectSemester = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dataGridViewCourseContactList = new System.Windows.Forms.DataGridView();
            this.tabControlContact = new System.Windows.Forms.TabControl();
            this.tabPageTimeTable = new System.Windows.Forms.TabPage();
            this.lblTimetable = new System.Windows.Forms.Label();
            this.btnCancelInTimeTable = new System.Windows.Forms.Button();
            this.btnPrintTimetable = new System.Windows.Forms.Button();
            this.comboBoxSemesterForTimetable = new System.Windows.Forms.ComboBox();
            this.lblSelectSemesterforTimetable = new System.Windows.Forms.Label();
            this.dataGridViewTimetable = new System.Windows.Forms.DataGridView();
            this.tabPageNotification = new System.Windows.Forms.TabPage();
            this.panelNotification = new System.Windows.Forms.Panel();
            this.dataGridViewNotificationList = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.btnShowAllCourse = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabPageScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHr)).BeginInit();
            this.tabPageCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseContactList)).BeginInit();
            this.tabControlContact.SuspendLayout();
            this.tabPageTimeTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetable)).BeginInit();
            this.tabPageNotification.SuspendLayout();
            this.panelNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotificationList)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.Color.White;
            this.lblNotification.Location = new System.Drawing.Point(284, 23);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(259, 38);
            this.lblNotification.TabIndex = 149;
            this.lblNotification.Text = "NOTIFICATION";
            // 
            // comboBoxSemesterInNotification
            // 
            this.comboBoxSemesterInNotification.FormattingEnabled = true;
            this.comboBoxSemesterInNotification.Location = new System.Drawing.Point(341, 90);
            this.comboBoxSemesterInNotification.Name = "comboBoxSemesterInNotification";
            this.comboBoxSemesterInNotification.Size = new System.Drawing.Size(87, 24);
            this.comboBoxSemesterInNotification.TabIndex = 124;
            this.comboBoxSemesterInNotification.SelectedIndexChanged += new System.EventHandler(this.comboBoxSemesterInNotification_SelectedIndexChanged);
            // 
            // lblSemesterInNotification
            // 
            this.lblSemesterInNotification.AutoSize = true;
            this.lblSemesterInNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterInNotification.ForeColor = System.Drawing.Color.White;
            this.lblSemesterInNotification.Location = new System.Drawing.Point(138, 90);
            this.lblSemesterInNotification.Name = "lblSemesterInNotification";
            this.lblSemesterInNotification.Size = new System.Drawing.Size(197, 29);
            this.lblSemesterInNotification.TabIndex = 123;
            this.lblSemesterInNotification.Text = "Select Semester:";
            // 
            // comboBoxCourseinNotification
            // 
            this.comboBoxCourseinNotification.FormattingEnabled = true;
            this.comboBoxCourseinNotification.Location = new System.Drawing.Point(341, 144);
            this.comboBoxCourseinNotification.Name = "comboBoxCourseinNotification";
            this.comboBoxCourseinNotification.Size = new System.Drawing.Size(232, 24);
            this.comboBoxCourseinNotification.TabIndex = 121;
            this.comboBoxCourseinNotification.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourseinNotification_SelectedIndexChanged);
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.ForeColor = System.Drawing.Color.White;
            this.lblSelectCourse.Location = new System.Drawing.Point(138, 139);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(171, 29);
            this.lblSelectCourse.TabIndex = 120;
            this.lblSelectCourse.Text = "Select Course:";
            // 
            // tabPageScore
            // 
            this.tabPageScore.BackColor = System.Drawing.Color.Green;
            this.tabPageScore.Controls.Add(this.btnPrintScore);
            this.tabPageScore.Controls.Add(this.lblAvgScore);
            this.tabPageScore.Controls.Add(this.btnDelete);
            this.tabPageScore.Controls.Add(this.lblScore);
            this.tabPageScore.Controls.Add(this.btnSearchStd);
            this.tabPageScore.Controls.Add(this.lblSemesterinAddScore);
            this.tabPageScore.Controls.Add(this.dataGridViewScoreList);
            this.tabPageScore.Controls.Add(this.comboBoxSemesterInScore);
            this.tabPageScore.Location = new System.Drawing.Point(4, 25);
            this.tabPageScore.Name = "tabPageScore";
            this.tabPageScore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScore.Size = new System.Drawing.Size(892, 645);
            this.tabPageScore.TabIndex = 3;
            this.tabPageScore.Text = "Score";
            // 
            // btnPrintScore
            // 
            this.btnPrintScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrintScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintScore.ForeColor = System.Drawing.Color.White;
            this.btnPrintScore.Location = new System.Drawing.Point(126, 483);
            this.btnPrintScore.Name = "btnPrintScore";
            this.btnPrintScore.Size = new System.Drawing.Size(99, 48);
            this.btnPrintScore.TabIndex = 181;
            this.btnPrintScore.TabStop = false;
            this.btnPrintScore.Text = "Print";
            this.btnPrintScore.UseVisualStyleBackColor = false;
            this.btnPrintScore.Click += new System.EventHandler(this.btnPrintScore_Click);
            // 
            // lblAvgScore
            // 
            this.lblAvgScore.BackColor = System.Drawing.Color.Purple;
            this.lblAvgScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgScore.ForeColor = System.Drawing.Color.White;
            this.lblAvgScore.Location = new System.Drawing.Point(267, 483);
            this.lblAvgScore.Name = "lblAvgScore";
            this.lblAvgScore.Size = new System.Drawing.Size(485, 46);
            this.lblAvgScore.TabIndex = 180;
            this.lblAvgScore.Text = "Average Score:";
            this.lblAvgScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(362, 623);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 45);
            this.btnDelete.TabIndex = 179;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(345, 21);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(140, 38);
            this.lblScore.TabIndex = 176;
            this.lblScore.Text = "SCORE";
            // 
            // btnSearchStd
            // 
            this.btnSearchStd.BackColor = System.Drawing.Color.Navy;
            this.btnSearchStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStd.ForeColor = System.Drawing.Color.White;
            this.btnSearchStd.Location = new System.Drawing.Point(480, 74);
            this.btnSearchStd.Name = "btnSearchStd";
            this.btnSearchStd.Size = new System.Drawing.Size(143, 45);
            this.btnSearchStd.TabIndex = 178;
            this.btnSearchStd.Text = "Search";
            this.btnSearchStd.UseVisualStyleBackColor = false;
            this.btnSearchStd.Click += new System.EventHandler(this.btnSearchStd_Click);
            // 
            // lblSemesterinAddScore
            // 
            this.lblSemesterinAddScore.AutoSize = true;
            this.lblSemesterinAddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterinAddScore.ForeColor = System.Drawing.Color.White;
            this.lblSemesterinAddScore.Location = new System.Drawing.Point(233, 81);
            this.lblSemesterinAddScore.Name = "lblSemesterinAddScore";
            this.lblSemesterinAddScore.Size = new System.Drawing.Size(123, 29);
            this.lblSemesterinAddScore.TabIndex = 174;
            this.lblSemesterinAddScore.Text = "Semester:";
            // 
            // dataGridViewScoreList
            // 
            this.dataGridViewScoreList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScoreList.Location = new System.Drawing.Point(122, 153);
            this.dataGridViewScoreList.Name = "dataGridViewScoreList";
            this.dataGridViewScoreList.RowHeadersWidth = 51;
            this.dataGridViewScoreList.RowTemplate.Height = 24;
            this.dataGridViewScoreList.Size = new System.Drawing.Size(630, 312);
            this.dataGridViewScoreList.TabIndex = 177;
            // 
            // comboBoxSemesterInScore
            // 
            this.comboBoxSemesterInScore.FormattingEnabled = true;
            this.comboBoxSemesterInScore.Location = new System.Drawing.Point(362, 86);
            this.comboBoxSemesterInScore.Name = "comboBoxSemesterInScore";
            this.comboBoxSemesterInScore.Size = new System.Drawing.Size(87, 24);
            this.comboBoxSemesterInScore.TabIndex = 175;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(639, 516);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 48);
            this.btnCancel.TabIndex = 117;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
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
            // tabPageCourse
            // 
            this.tabPageCourse.BackColor = System.Drawing.Color.Green;
            this.tabPageCourse.Controls.Add(this.lblCourse);
            this.tabPageCourse.Controls.Add(this.btnAddCourse);
            this.tabPageCourse.Controls.Add(this.comboBoxSelectSemester);
            this.tabPageCourse.Controls.Add(this.lblSelectSemester);
            this.tabPageCourse.Controls.Add(this.btnCancel);
            this.tabPageCourse.Controls.Add(this.btnPrint);
            this.tabPageCourse.Controls.Add(this.dataGridViewCourseContactList);
            this.tabPageCourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageCourse.Location = new System.Drawing.Point(4, 25);
            this.tabPageCourse.Name = "tabPageCourse";
            this.tabPageCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCourse.Size = new System.Drawing.Size(892, 645);
            this.tabPageCourse.TabIndex = 0;
            this.tabPageCourse.Text = "Course";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.Color.White;
            this.lblCourse.Location = new System.Drawing.Point(305, 18);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(247, 38);
            this.lblCourse.TabIndex = 150;
            this.lblCourse.Text = "LIST COURSE";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.Olive;
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Location = new System.Drawing.Point(364, 516);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(156, 48);
            this.btnAddCourse.TabIndex = 120;
            this.btnAddCourse.TabStop = false;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // comboBoxSelectSemester
            // 
            this.comboBoxSelectSemester.FormattingEnabled = true;
            this.comboBoxSelectSemester.Location = new System.Drawing.Point(467, 84);
            this.comboBoxSelectSemester.Name = "comboBoxSelectSemester";
            this.comboBoxSelectSemester.Size = new System.Drawing.Size(105, 24);
            this.comboBoxSelectSemester.TabIndex = 119;
            this.comboBoxSelectSemester.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectSemester_SelectedIndexChanged);
            // 
            // lblSelectSemester
            // 
            this.lblSelectSemester.AutoSize = true;
            this.lblSelectSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSemester.ForeColor = System.Drawing.Color.White;
            this.lblSelectSemester.Location = new System.Drawing.Point(240, 79);
            this.lblSelectSemester.Name = "lblSelectSemester";
            this.lblSelectSemester.Size = new System.Drawing.Size(197, 29);
            this.lblSelectSemester.TabIndex = 118;
            this.lblSelectSemester.Text = "Select Semester:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(140, 516);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(99, 48);
            this.btnPrint.TabIndex = 110;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dataGridViewCourseContactList
            // 
            this.dataGridViewCourseContactList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCourseContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourseContactList.Location = new System.Drawing.Point(100, 141);
            this.dataGridViewCourseContactList.Name = "dataGridViewCourseContactList";
            this.dataGridViewCourseContactList.RowHeadersWidth = 51;
            this.dataGridViewCourseContactList.RowTemplate.Height = 24;
            this.dataGridViewCourseContactList.Size = new System.Drawing.Size(693, 353);
            this.dataGridViewCourseContactList.TabIndex = 109;
            // 
            // tabControlContact
            // 
            this.tabControlContact.Controls.Add(this.tabPageCourse);
            this.tabControlContact.Controls.Add(this.tabPageTimeTable);
            this.tabControlContact.Controls.Add(this.tabPageNotification);
            this.tabControlContact.Controls.Add(this.tabPageScore);
            this.tabControlContact.Location = new System.Drawing.Point(0, 106);
            this.tabControlContact.Name = "tabControlContact";
            this.tabControlContact.SelectedIndex = 0;
            this.tabControlContact.Size = new System.Drawing.Size(900, 674);
            this.tabControlContact.TabIndex = 20;
            // 
            // tabPageTimeTable
            // 
            this.tabPageTimeTable.BackColor = System.Drawing.Color.Green;
            this.tabPageTimeTable.Controls.Add(this.lblTimetable);
            this.tabPageTimeTable.Controls.Add(this.btnCancelInTimeTable);
            this.tabPageTimeTable.Controls.Add(this.btnPrintTimetable);
            this.tabPageTimeTable.Controls.Add(this.comboBoxSemesterForTimetable);
            this.tabPageTimeTable.Controls.Add(this.lblSelectSemesterforTimetable);
            this.tabPageTimeTable.Controls.Add(this.dataGridViewTimetable);
            this.tabPageTimeTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageTimeTable.Location = new System.Drawing.Point(4, 25);
            this.tabPageTimeTable.Name = "tabPageTimeTable";
            this.tabPageTimeTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTimeTable.Size = new System.Drawing.Size(892, 645);
            this.tabPageTimeTable.TabIndex = 1;
            this.tabPageTimeTable.Text = "Timetable";
            // 
            // lblTimetable
            // 
            this.lblTimetable.AutoSize = true;
            this.lblTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimetable.ForeColor = System.Drawing.Color.White;
            this.lblTimetable.Location = new System.Drawing.Point(308, 17);
            this.lblTimetable.Name = "lblTimetable";
            this.lblTimetable.Size = new System.Drawing.Size(207, 38);
            this.lblTimetable.TabIndex = 150;
            this.lblTimetable.Text = "TIMETABLE";
            // 
            // btnCancelInTimeTable
            // 
            this.btnCancelInTimeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelInTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelInTimeTable.ForeColor = System.Drawing.Color.White;
            this.btnCancelInTimeTable.Location = new System.Drawing.Point(495, 520);
            this.btnCancelInTimeTable.Name = "btnCancelInTimeTable";
            this.btnCancelInTimeTable.Size = new System.Drawing.Size(99, 48);
            this.btnCancelInTimeTable.TabIndex = 124;
            this.btnCancelInTimeTable.TabStop = false;
            this.btnCancelInTimeTable.Text = "Cancel";
            this.btnCancelInTimeTable.UseVisualStyleBackColor = false;
            // 
            // btnPrintTimetable
            // 
            this.btnPrintTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrintTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintTimetable.ForeColor = System.Drawing.Color.White;
            this.btnPrintTimetable.Location = new System.Drawing.Point(275, 520);
            this.btnPrintTimetable.Name = "btnPrintTimetable";
            this.btnPrintTimetable.Size = new System.Drawing.Size(99, 48);
            this.btnPrintTimetable.TabIndex = 123;
            this.btnPrintTimetable.TabStop = false;
            this.btnPrintTimetable.Text = "Print";
            this.btnPrintTimetable.UseVisualStyleBackColor = false;
            this.btnPrintTimetable.Click += new System.EventHandler(this.btnPrintTimetable_Click);
            // 
            // comboBoxSemesterForTimetable
            // 
            this.comboBoxSemesterForTimetable.FormattingEnabled = true;
            this.comboBoxSemesterForTimetable.Location = new System.Drawing.Point(472, 84);
            this.comboBoxSemesterForTimetable.Name = "comboBoxSemesterForTimetable";
            this.comboBoxSemesterForTimetable.Size = new System.Drawing.Size(105, 24);
            this.comboBoxSemesterForTimetable.TabIndex = 122;
            this.comboBoxSemesterForTimetable.SelectedIndexChanged += new System.EventHandler(this.comboBoxSemesterForTimetable_SelectedIndexChanged);
            // 
            // lblSelectSemesterforTimetable
            // 
            this.lblSelectSemesterforTimetable.AutoSize = true;
            this.lblSelectSemesterforTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSemesterforTimetable.ForeColor = System.Drawing.Color.White;
            this.lblSelectSemesterforTimetable.Location = new System.Drawing.Point(245, 79);
            this.lblSelectSemesterforTimetable.Name = "lblSelectSemesterforTimetable";
            this.lblSelectSemesterforTimetable.Size = new System.Drawing.Size(197, 29);
            this.lblSelectSemesterforTimetable.TabIndex = 121;
            this.lblSelectSemesterforTimetable.Text = "Select Semester:";
            // 
            // dataGridViewTimetable
            // 
            this.dataGridViewTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTimetable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimetable.Location = new System.Drawing.Point(33, 143);
            this.dataGridViewTimetable.Name = "dataGridViewTimetable";
            this.dataGridViewTimetable.RowHeadersWidth = 51;
            this.dataGridViewTimetable.RowTemplate.Height = 24;
            this.dataGridViewTimetable.Size = new System.Drawing.Size(820, 353);
            this.dataGridViewTimetable.TabIndex = 120;
            // 
            // tabPageNotification
            // 
            this.tabPageNotification.BackColor = System.Drawing.Color.Green;
            this.tabPageNotification.Controls.Add(this.panelNotification);
            this.tabPageNotification.Controls.Add(this.btnShowAllCourse);
            this.tabPageNotification.Controls.Add(this.lblNotification);
            this.tabPageNotification.Controls.Add(this.comboBoxSemesterInNotification);
            this.tabPageNotification.Controls.Add(this.lblSemesterInNotification);
            this.tabPageNotification.Controls.Add(this.comboBoxCourseinNotification);
            this.tabPageNotification.Controls.Add(this.lblSelectCourse);
            this.tabPageNotification.Location = new System.Drawing.Point(4, 25);
            this.tabPageNotification.Name = "tabPageNotification";
            this.tabPageNotification.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNotification.Size = new System.Drawing.Size(892, 645);
            this.tabPageNotification.TabIndex = 2;
            this.tabPageNotification.Text = "Notification";
            // 
            // panelNotification
            // 
            this.panelNotification.BackColor = System.Drawing.Color.Indigo;
            this.panelNotification.Controls.Add(this.dataGridViewNotificationList);
            this.panelNotification.Controls.Add(this.btnShow);
            this.panelNotification.Controls.Add(this.textBoxContent);
            this.panelNotification.Location = new System.Drawing.Point(80, 195);
            this.panelNotification.Name = "panelNotification";
            this.panelNotification.Size = new System.Drawing.Size(729, 385);
            this.panelNotification.TabIndex = 167;
            // 
            // dataGridViewNotificationList
            // 
            this.dataGridViewNotificationList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNotificationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotificationList.Location = new System.Drawing.Point(40, 40);
            this.dataGridViewNotificationList.Name = "dataGridViewNotificationList";
            this.dataGridViewNotificationList.RowHeadersWidth = 51;
            this.dataGridViewNotificationList.RowTemplate.Height = 24;
            this.dataGridViewNotificationList.Size = new System.Drawing.Size(649, 172);
            this.dataGridViewNotificationList.TabIndex = 152;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Green;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(287, 218);
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
            this.textBoxContent.Location = new System.Drawing.Point(63, 294);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(605, 70);
            this.textBoxContent.TabIndex = 124;
            // 
            // btnShowAllCourse
            // 
            this.btnShowAllCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnShowAllCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllCourse.ForeColor = System.Drawing.Color.White;
            this.btnShowAllCourse.Location = new System.Drawing.Point(448, 76);
            this.btnShowAllCourse.Name = "btnShowAllCourse";
            this.btnShowAllCourse.Size = new System.Drawing.Size(333, 58);
            this.btnShowAllCourse.TabIndex = 166;
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
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 100);
            this.panel4.TabIndex = 19;
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(894, 723);
            this.Controls.Add(this.tabControlContact);
            this.Controls.Add(this.panel4);
            this.Name = "StudentMainForm";
            this.Text = "StudentMainForm";
            this.Load += new System.EventHandler(this.StudentMainForm_Load);
            this.tabPageScore.ResumeLayout(false);
            this.tabPageScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHr)).EndInit();
            this.tabPageCourse.ResumeLayout(false);
            this.tabPageCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseContactList)).EndInit();
            this.tabControlContact.ResumeLayout(false);
            this.tabPageTimeTable.ResumeLayout(false);
            this.tabPageTimeTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetable)).EndInit();
            this.tabPageNotification.ResumeLayout(false);
            this.tabPageNotification.PerformLayout();
            this.panelNotification.ResumeLayout(false);
            this.panelNotification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotificationList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.ComboBox comboBoxSemesterInNotification;
        private System.Windows.Forms.Label lblSemesterInNotification;
        private System.Windows.Forms.ComboBox comboBoxCourseinNotification;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.TabPage tabPageScore;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel linkLabelRefresh;
        private System.Windows.Forms.LinkLabel linkLabelEditInfo;
        private System.Windows.Forms.Label lblWelcomeHr;
        private System.Windows.Forms.PictureBox pictureBoxHr;
        private System.Windows.Forms.TabPage tabPageCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ComboBox comboBoxSelectSemester;
        private System.Windows.Forms.Label lblSelectSemester;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dataGridViewCourseContactList;
        private System.Windows.Forms.TabControl tabControlContact;
        private System.Windows.Forms.TabPage tabPageTimeTable;
        private System.Windows.Forms.Label lblTimetable;
        private System.Windows.Forms.Button btnCancelInTimeTable;
        private System.Windows.Forms.Button btnPrintTimetable;
        private System.Windows.Forms.ComboBox comboBoxSemesterForTimetable;
        private System.Windows.Forms.Label lblSelectSemesterforTimetable;
        private System.Windows.Forms.DataGridView dataGridViewTimetable;
        private System.Windows.Forms.TabPage tabPageNotification;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnShowAllCourse;
        private System.Windows.Forms.Panel panelNotification;
        private System.Windows.Forms.DataGridView dataGridViewNotificationList;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnSearchStd;
        private System.Windows.Forms.Label lblSemesterinAddScore;
        private System.Windows.Forms.DataGridView dataGridViewScoreList;
        private System.Windows.Forms.ComboBox comboBoxSemesterInScore;
        private System.Windows.Forms.Label lblAvgScore;
        private System.Windows.Forms.Button btnPrintScore;
    }
}