namespace _20142178_TranManhHuy_QLSV
{
    partial class PrintStudentForm
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
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.RadioButtonYes = new System.Windows.Forms.RadioButton();
            this.lblBirthDateBetween = new System.Windows.Forms.Label();
            this.lblUseDateRange = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.RadioButtonAll = new System.Windows.Forms.RadioButton();
            this.DateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.RadioButtonNo = new System.Windows.Forms.RadioButton();
            this.groupBoxBirthDateRange = new System.Windows.Forms.GroupBox();
            this.lblAnd = new System.Windows.Forms.Label();
            this.DateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.btnPrinter = new System.Windows.Forms.Button();
            this.btnSavetoTextFile = new System.Windows.Forms.Button();
            this.groupBoxCheck = new System.Windows.Forms.GroupBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.comboBoxSaveToFile = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.groupBoxBirthDateRange.SuspendLayout();
            this.groupBoxCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(28, 178);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.RowHeadersWidth = 51;
            this.dataGridViewStudentList.RowTemplate.Height = 24;
            this.dataGridViewStudentList.Size = new System.Drawing.Size(886, 306);
            this.dataGridViewStudentList.TabIndex = 12;
            // 
            // RadioButtonYes
            // 
            this.RadioButtonYes.AutoSize = true;
            this.RadioButtonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonYes.ForeColor = System.Drawing.Color.White;
            this.RadioButtonYes.Location = new System.Drawing.Point(197, 22);
            this.RadioButtonYes.Name = "RadioButtonYes";
            this.RadioButtonYes.Size = new System.Drawing.Size(65, 24);
            this.RadioButtonYes.TabIndex = 3;
            this.RadioButtonYes.TabStop = true;
            this.RadioButtonYes.Text = "YES";
            this.RadioButtonYes.UseVisualStyleBackColor = true;
            this.RadioButtonYes.CheckedChanged += new System.EventHandler(this.RadioButtonYes_CheckedChanged);
            // 
            // lblBirthDateBetween
            // 
            this.lblBirthDateBetween.AutoSize = true;
            this.lblBirthDateBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDateBetween.ForeColor = System.Drawing.Color.White;
            this.lblBirthDateBetween.Location = new System.Drawing.Point(6, 64);
            this.lblBirthDateBetween.Name = "lblBirthDateBetween";
            this.lblBirthDateBetween.Size = new System.Drawing.Size(174, 20);
            this.lblBirthDateBetween.TabIndex = 1;
            this.lblBirthDateBetween.Text = "BirthDate Between:";
            // 
            // lblUseDateRange
            // 
            this.lblUseDateRange.AutoSize = true;
            this.lblUseDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseDateRange.ForeColor = System.Drawing.Color.White;
            this.lblUseDateRange.Location = new System.Drawing.Point(6, 24);
            this.lblUseDateRange.Name = "lblUseDateRange";
            this.lblUseDateRange.Size = new System.Drawing.Size(153, 20);
            this.lblUseDateRange.TabIndex = 0;
            this.lblUseDateRange.Text = "Use Date Range:";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(757, 59);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(112, 46);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonFemale.ForeColor = System.Drawing.Color.White;
            this.RadioButtonFemale.Location = new System.Drawing.Point(140, 58);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(91, 24);
            this.RadioButtonFemale.TabIndex = 3;
            this.RadioButtonFemale.TabStop = true;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonMale.ForeColor = System.Drawing.Color.White;
            this.RadioButtonMale.Location = new System.Drawing.Point(64, 58);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(70, 24);
            this.RadioButtonMale.TabIndex = 2;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAll
            // 
            this.RadioButtonAll.AutoSize = true;
            this.RadioButtonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonAll.ForeColor = System.Drawing.Color.White;
            this.RadioButtonAll.Location = new System.Drawing.Point(6, 58);
            this.RadioButtonAll.Name = "RadioButtonAll";
            this.RadioButtonAll.Size = new System.Drawing.Size(52, 24);
            this.RadioButtonAll.TabIndex = 1;
            this.RadioButtonAll.TabStop = true;
            this.RadioButtonAll.Text = "All";
            this.RadioButtonAll.UseVisualStyleBackColor = true;
            // 
            // DateTimePickerStartTime
            // 
            this.DateTimePickerStartTime.Location = new System.Drawing.Point(197, 62);
            this.DateTimePickerStartTime.Name = "DateTimePickerStartTime";
            this.DateTimePickerStartTime.Size = new System.Drawing.Size(116, 22);
            this.DateTimePickerStartTime.TabIndex = 5;
            // 
            // RadioButtonNo
            // 
            this.RadioButtonNo.AutoSize = true;
            this.RadioButtonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonNo.ForeColor = System.Drawing.Color.White;
            this.RadioButtonNo.Location = new System.Drawing.Point(303, 22);
            this.RadioButtonNo.Name = "RadioButtonNo";
            this.RadioButtonNo.Size = new System.Drawing.Size(57, 24);
            this.RadioButtonNo.TabIndex = 4;
            this.RadioButtonNo.TabStop = true;
            this.RadioButtonNo.Text = "NO";
            this.RadioButtonNo.UseVisualStyleBackColor = true;
            this.RadioButtonNo.CheckedChanged += new System.EventHandler(this.RadioButtonNo_CheckedChanged);
            // 
            // groupBoxBirthDateRange
            // 
            this.groupBoxBirthDateRange.Controls.Add(this.lblAnd);
            this.groupBoxBirthDateRange.Controls.Add(this.DateTimePickerEndTime);
            this.groupBoxBirthDateRange.Controls.Add(this.DateTimePickerStartTime);
            this.groupBoxBirthDateRange.Controls.Add(this.RadioButtonNo);
            this.groupBoxBirthDateRange.Controls.Add(this.RadioButtonYes);
            this.groupBoxBirthDateRange.Controls.Add(this.lblBirthDateBetween);
            this.groupBoxBirthDateRange.Controls.Add(this.lblUseDateRange);
            this.groupBoxBirthDateRange.Location = new System.Drawing.Point(247, 21);
            this.groupBoxBirthDateRange.Name = "groupBoxBirthDateRange";
            this.groupBoxBirthDateRange.Size = new System.Drawing.Size(494, 104);
            this.groupBoxBirthDateRange.TabIndex = 0;
            this.groupBoxBirthDateRange.TabStop = false;
            // 
            // lblAnd
            // 
            this.lblAnd.AutoSize = true;
            this.lblAnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnd.ForeColor = System.Drawing.Color.White;
            this.lblAnd.Location = new System.Drawing.Point(319, 64);
            this.lblAnd.Name = "lblAnd";
            this.lblAnd.Size = new System.Drawing.Size(41, 20);
            this.lblAnd.TabIndex = 1;
            this.lblAnd.Text = "And";
            // 
            // DateTimePickerEndTime
            // 
            this.DateTimePickerEndTime.Location = new System.Drawing.Point(368, 62);
            this.DateTimePickerEndTime.Name = "DateTimePickerEndTime";
            this.DateTimePickerEndTime.Size = new System.Drawing.Size(116, 22);
            this.DateTimePickerEndTime.TabIndex = 6;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // btnPrinter
            // 
            this.btnPrinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinter.ForeColor = System.Drawing.Color.White;
            this.btnPrinter.Location = new System.Drawing.Point(552, 507);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(188, 46);
            this.btnPrinter.TabIndex = 14;
            this.btnPrinter.Text = "To Printer";
            this.btnPrinter.UseVisualStyleBackColor = false;
            this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
            // 
            // btnSavetoTextFile
            // 
            this.btnSavetoTextFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSavetoTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavetoTextFile.ForeColor = System.Drawing.Color.White;
            this.btnSavetoTextFile.Location = new System.Drawing.Point(191, 507);
            this.btnSavetoTextFile.Name = "btnSavetoTextFile";
            this.btnSavetoTextFile.Size = new System.Drawing.Size(153, 46);
            this.btnSavetoTextFile.TabIndex = 13;
            this.btnSavetoTextFile.Text = "Save to File";
            this.btnSavetoTextFile.UseVisualStyleBackColor = false;
            this.btnSavetoTextFile.Click += new System.EventHandler(this.btnSavetoTextFile_Click);
            // 
            // groupBoxCheck
            // 
            this.groupBoxCheck.Controls.Add(this.btnCheck);
            this.groupBoxCheck.Controls.Add(this.RadioButtonFemale);
            this.groupBoxCheck.Controls.Add(this.RadioButtonMale);
            this.groupBoxCheck.Controls.Add(this.RadioButtonAll);
            this.groupBoxCheck.Controls.Add(this.groupBoxBirthDateRange);
            this.groupBoxCheck.Location = new System.Drawing.Point(30, 17);
            this.groupBoxCheck.Name = "groupBoxCheck";
            this.groupBoxCheck.Size = new System.Drawing.Size(884, 146);
            this.groupBoxCheck.TabIndex = 11;
            this.groupBoxCheck.TabStop = false;
            // 
            // comboBoxSaveToFile
            // 
            this.comboBoxSaveToFile.FormattingEnabled = true;
            this.comboBoxSaveToFile.Items.AddRange(new object[] {
            "File Txt",
            "File Word",
            "File Excel"});
            this.comboBoxSaveToFile.Location = new System.Drawing.Point(64, 520);
            this.comboBoxSaveToFile.Name = "comboBoxSaveToFile";
            this.comboBoxSaveToFile.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSaveToFile.TabIndex = 17;
            // 
            // PrintStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(942, 580);
            this.Controls.Add(this.comboBoxSaveToFile);
            this.Controls.Add(this.dataGridViewStudentList);
            this.Controls.Add(this.btnPrinter);
            this.Controls.Add(this.btnSavetoTextFile);
            this.Controls.Add(this.groupBoxCheck);
            this.Name = "PrintStudentForm";
            this.Text = "PrintStudentForm";
            this.Load += new System.EventHandler(this.PrintStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.groupBoxBirthDateRange.ResumeLayout(false);
            this.groupBoxBirthDateRange.PerformLayout();
            this.groupBoxCheck.ResumeLayout(false);
            this.groupBoxCheck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        private System.Windows.Forms.RadioButton RadioButtonYes;
        private System.Windows.Forms.Label lblBirthDateBetween;
        private System.Windows.Forms.Label lblUseDateRange;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.RadioButton RadioButtonFemale;
        private System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.RadioButton RadioButtonAll;
        private System.Windows.Forms.DateTimePicker DateTimePickerStartTime;
        private System.Windows.Forms.RadioButton RadioButtonNo;
        private System.Windows.Forms.GroupBox groupBoxBirthDateRange;
        private System.Windows.Forms.Label lblAnd;
        private System.Windows.Forms.DateTimePicker DateTimePickerEndTime;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Button btnPrinter;
        private System.Windows.Forms.Button btnSavetoTextFile;
        private System.Windows.Forms.GroupBox groupBoxCheck;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.ComboBox comboBoxSaveToFile;
    }
}