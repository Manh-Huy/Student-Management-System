namespace _20142178_TranManhHuy_QLSV
{
    partial class StudentListForm
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
            this.components = new System.ComponentModel.Container();
            this.DataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.sttDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hometownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acayearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentListViewDataSet = new _20142178_TranManhHuy_QLSV.StudentListViewDataSet();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.stdTableAdapter = new _20142178_TranManhHuy_QLSV.StudentListViewDataSetTableAdapters.StdTableAdapter();
            this.panelFind = new System.Windows.Forms.Panel();
            this.comboBoxAcaYear = new System.Windows.Forms.ComboBox();
            this.lblAcaYear = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBoxHometown = new System.Windows.Forms.TextBox();
            this.lblHometown = new System.Windows.Forms.Label();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.comboBoxMajor = new System.Windows.Forms.ComboBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.radioButtonFindFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonFindMale = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListViewDataSet)).BeginInit();
            this.panelFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewStudentList
            // 
            this.DataGridViewStudentList.AutoGenerateColumns = false;
            this.DataGridViewStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.bdateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.facultyDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn,
            this.hometownDataGridViewTextBoxColumn,
            this.acayearDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.DataGridViewStudentList.DataSource = this.stdBindingSource;
            this.DataGridViewStudentList.Location = new System.Drawing.Point(22, 184);
            this.DataGridViewStudentList.Name = "DataGridViewStudentList";
            this.DataGridViewStudentList.RowHeadersWidth = 51;
            this.DataGridViewStudentList.RowTemplate.Height = 24;
            this.DataGridViewStudentList.Size = new System.Drawing.Size(1386, 405);
            this.DataGridViewStudentList.TabIndex = 0;
            this.DataGridViewStudentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewStudentList_CellDoubleClick);
            // 
            // sttDataGridViewTextBoxColumn
            // 
            this.sttDataGridViewTextBoxColumn.DataPropertyName = "stt";
            this.sttDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sttDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttDataGridViewTextBoxColumn.Name = "sttDataGridViewTextBoxColumn";
            this.sttDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.bdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bdateDataGridViewTextBoxColumn.Name = "bdateDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // facultyDataGridViewTextBoxColumn
            // 
            this.facultyDataGridViewTextBoxColumn.DataPropertyName = "faculty";
            this.facultyDataGridViewTextBoxColumn.HeaderText = "Faculty";
            this.facultyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facultyDataGridViewTextBoxColumn.Name = "facultyDataGridViewTextBoxColumn";
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            // 
            // hometownDataGridViewTextBoxColumn
            // 
            this.hometownDataGridViewTextBoxColumn.DataPropertyName = "hometown";
            this.hometownDataGridViewTextBoxColumn.HeaderText = "Hometown";
            this.hometownDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hometownDataGridViewTextBoxColumn.Name = "hometownDataGridViewTextBoxColumn";
            // 
            // acayearDataGridViewTextBoxColumn
            // 
            this.acayearDataGridViewTextBoxColumn.DataPropertyName = "acayear";
            this.acayearDataGridViewTextBoxColumn.HeaderText = "Academic Year";
            this.acayearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acayearDataGridViewTextBoxColumn.Name = "acayearDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "Std";
            this.stdBindingSource.DataSource = this.studentListViewDataSet;
            // 
            // studentListViewDataSet
            // 
            this.studentListViewDataSet.DataSetName = "StudentListViewDataSet";
            this.studentListViewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRefresh.Location = new System.Drawing.Point(701, 610);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(112, 40);
            this.ButtonRefresh.TabIndex = 2;
            this.ButtonRefresh.Text = "Refresh";
            this.ButtonRefresh.UseVisualStyleBackColor = false;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // panelFind
            // 
            this.panelFind.BackColor = System.Drawing.Color.Green;
            this.panelFind.Controls.Add(this.comboBoxAcaYear);
            this.panelFind.Controls.Add(this.lblAcaYear);
            this.panelFind.Controls.Add(this.textBoxAddress);
            this.panelFind.Controls.Add(this.lblAddress);
            this.panelFind.Controls.Add(this.textBoxHometown);
            this.panelFind.Controls.Add(this.lblHometown);
            this.panelFind.Controls.Add(this.comboBoxFaculty);
            this.panelFind.Controls.Add(this.lblFaculty);
            this.panelFind.Controls.Add(this.lblMajor);
            this.panelFind.Controls.Add(this.comboBoxMajor);
            this.panelFind.Controls.Add(this.textBoxLastName);
            this.panelFind.Controls.Add(this.lblLName);
            this.panelFind.Controls.Add(this.lblFName);
            this.panelFind.Controls.Add(this.textBoxFirstName);
            this.panelFind.Controls.Add(this.lblStudentID);
            this.panelFind.Controls.Add(this.textBoxID);
            this.panelFind.Controls.Add(this.lblFind);
            this.panelFind.Controls.Add(this.radioButtonFindFemale);
            this.panelFind.Controls.Add(this.radioButtonFindMale);
            this.panelFind.Controls.Add(this.btnFind);
            this.panelFind.Location = new System.Drawing.Point(54, 24);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(1325, 140);
            this.panelFind.TabIndex = 74;
            // 
            // comboBoxAcaYear
            // 
            this.comboBoxAcaYear.FormattingEnabled = true;
            this.comboBoxAcaYear.Location = new System.Drawing.Point(1013, 54);
            this.comboBoxAcaYear.Name = "comboBoxAcaYear";
            this.comboBoxAcaYear.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAcaYear.TabIndex = 82;
            // 
            // lblAcaYear
            // 
            this.lblAcaYear.AutoSize = true;
            this.lblAcaYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcaYear.ForeColor = System.Drawing.Color.White;
            this.lblAcaYear.Location = new System.Drawing.Point(844, 56);
            this.lblAcaYear.Name = "lblAcaYear";
            this.lblAcaYear.Size = new System.Drawing.Size(150, 22);
            this.lblAcaYear.TabIndex = 81;
            this.lblAcaYear.Text = "Academic Year:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(1169, 12);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(122, 22);
            this.textBoxAddress.TabIndex = 80;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(1074, 14);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(89, 22);
            this.lblAddress.TabIndex = 79;
            this.lblAddress.Text = "Address:";
            // 
            // textBoxHometown
            // 
            this.textBoxHometown.Location = new System.Drawing.Point(696, 54);
            this.textBoxHometown.Name = "textBoxHometown";
            this.textBoxHometown.Size = new System.Drawing.Size(122, 22);
            this.textBoxHometown.TabIndex = 78;
            // 
            // lblHometown
            // 
            this.lblHometown.AutoSize = true;
            this.lblHometown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHometown.ForeColor = System.Drawing.Color.White;
            this.lblHometown.Location = new System.Drawing.Point(571, 56);
            this.lblHometown.Name = "lblHometown";
            this.lblHometown.Size = new System.Drawing.Size(109, 22);
            this.lblHometown.TabIndex = 77;
            this.lblHometown.Text = "Hometown:";
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.BackColor = System.Drawing.Color.White;
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(207, 54);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFaculty.TabIndex = 76;
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.ForeColor = System.Drawing.Color.White;
            this.lblFaculty.Location = new System.Drawing.Point(120, 56);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(81, 22);
            this.lblFaculty.TabIndex = 75;
            this.lblFaculty.Text = "Faculty:";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajor.ForeColor = System.Drawing.Color.White;
            this.lblMajor.Location = new System.Drawing.Point(355, 56);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(65, 22);
            this.lblMajor.TabIndex = 74;
            this.lblMajor.Text = "Major:";
            // 
            // comboBoxMajor
            // 
            this.comboBoxMajor.FormattingEnabled = true;
            this.comboBoxMajor.Location = new System.Drawing.Point(426, 54);
            this.comboBoxMajor.Name = "comboBoxMajor";
            this.comboBoxMajor.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMajor.TabIndex = 73;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(675, 12);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(122, 22);
            this.textBoxLastName.TabIndex = 72;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.Color.White;
            this.lblLName.Location = new System.Drawing.Point(549, 14);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(111, 22);
            this.lblLName.TabIndex = 71;
            this.lblLName.Text = "Last Name:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.White;
            this.lblFName.Location = new System.Drawing.Point(278, 12);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(113, 22);
            this.lblFName.TabIndex = 70;
            this.lblFName.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(410, 12);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(122, 22);
            this.textBoxFirstName.TabIndex = 69;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.Color.White;
            this.lblStudentID.Location = new System.Drawing.Point(120, 12);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(35, 22);
            this.lblStudentID.TabIndex = 68;
            this.lblStudentID.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(161, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 67;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.ForeColor = System.Drawing.Color.White;
            this.lblFind.Location = new System.Drawing.Point(6, 9);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(108, 29);
            this.lblFind.TabIndex = 65;
            this.lblFind.Text = "Find By:";
            // 
            // radioButtonFindFemale
            // 
            this.radioButtonFindFemale.AutoSize = true;
            this.radioButtonFindFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFindFemale.ForeColor = System.Drawing.Color.White;
            this.radioButtonFindFemale.Location = new System.Drawing.Point(953, 12);
            this.radioButtonFindFemale.Name = "radioButtonFindFemale";
            this.radioButtonFindFemale.Size = new System.Drawing.Size(96, 26);
            this.radioButtonFindFemale.TabIndex = 59;
            this.radioButtonFindFemale.TabStop = true;
            this.radioButtonFindFemale.Text = "Female";
            this.radioButtonFindFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFindMale
            // 
            this.radioButtonFindMale.AutoSize = true;
            this.radioButtonFindMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFindMale.ForeColor = System.Drawing.Color.White;
            this.radioButtonFindMale.Location = new System.Drawing.Point(848, 12);
            this.radioButtonFindMale.Name = "radioButtonFindMale";
            this.radioButtonFindMale.Size = new System.Drawing.Size(73, 26);
            this.radioButtonFindMale.TabIndex = 58;
            this.radioButtonFindMale.TabStop = true;
            this.radioButtonFindMale.Text = "Male";
            this.radioButtonFindMale.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.Transparent;
            this.btnFind.Location = new System.Drawing.Point(1200, 56);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(91, 38);
            this.btnFind.TabIndex = 62;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1431, 671);
            this.Controls.Add(this.panelFind);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.DataGridViewStudentList);
            this.Name = "StudentListForm";
            this.Text = "StudentListForm";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListViewDataSet)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewStudentList;
        private System.Windows.Forms.Button ButtonRefresh;
        private StudentListViewDataSet studentListViewDataSet;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private StudentListViewDataSetTableAdapters.StdTableAdapter stdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hometownDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acayearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.Label lblFind;
        public System.Windows.Forms.RadioButton radioButtonFindFemale;
        public System.Windows.Forms.RadioButton radioButtonFindMale;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox comboBoxMajor;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.ComboBox comboBoxAcaYear;
        private System.Windows.Forms.Label lblAcaYear;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textBoxHometown;
        private System.Windows.Forms.Label lblHometown;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.Label lblFaculty;
    }
}