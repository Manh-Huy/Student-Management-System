namespace _20142178_TranManhHuy_QLSV
{
    partial class TimetableContactForm
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
            this.comboBoxSelectSemester = new System.Windows.Forms.ComboBox();
            this.lblSelectSemester = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.textBoxContactID = new System.Windows.Forms.TextBox();
            this.lblContactID = new System.Windows.Forms.Label();
            this.lblTimeTble = new System.Windows.Forms.Label();
            this.dataGridViewTimetable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSelectSemester
            // 
            this.comboBoxSelectSemester.FormattingEnabled = true;
            this.comboBoxSelectSemester.Location = new System.Drawing.Point(737, 228);
            this.comboBoxSelectSemester.Name = "comboBoxSelectSemester";
            this.comboBoxSelectSemester.Size = new System.Drawing.Size(105, 24);
            this.comboBoxSelectSemester.TabIndex = 125;
            this.comboBoxSelectSemester.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectSemester_SelectedIndexChanged);
            // 
            // lblSelectSemester
            // 
            this.lblSelectSemester.AutoSize = true;
            this.lblSelectSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSemester.ForeColor = System.Drawing.Color.White;
            this.lblSelectSemester.Location = new System.Drawing.Point(608, 223);
            this.lblSelectSemester.Name = "lblSelectSemester";
            this.lblSelectSemester.Size = new System.Drawing.Size(123, 29);
            this.lblSelectSemester.TabIndex = 124;
            this.lblSelectSemester.Text = "Semester:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(551, 660);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 48);
            this.btnCancel.TabIndex = 123;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(210, 660);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(99, 48);
            this.btnPrint.TabIndex = 122;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(589, 87);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.ReadOnly = true;
            this.textBoxGroup.Size = new System.Drawing.Size(132, 22);
            this.textBoxGroup.TabIndex = 134;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.ForeColor = System.Drawing.Color.White;
            this.lblGroup.Location = new System.Drawing.Point(480, 80);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(86, 29);
            this.lblGroup.TabIndex = 133;
            this.lblGroup.Text = "Group:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(210, 119);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(209, 22);
            this.textBoxName.TabIndex = 130;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(63, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(130, 29);
            this.lblName.TabIndex = 129;
            this.lblName.Text = "Full Name:";
            // 
            // textBoxContactID
            // 
            this.textBoxContactID.Location = new System.Drawing.Point(210, 55);
            this.textBoxContactID.Name = "textBoxContactID";
            this.textBoxContactID.ReadOnly = true;
            this.textBoxContactID.Size = new System.Drawing.Size(178, 22);
            this.textBoxContactID.TabIndex = 128;
            // 
            // lblContactID
            // 
            this.lblContactID.AutoSize = true;
            this.lblContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactID.ForeColor = System.Drawing.Color.White;
            this.lblContactID.Location = new System.Drawing.Point(63, 48);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(129, 29);
            this.lblContactID.TabIndex = 127;
            this.lblContactID.Text = "Contact ID:";
            // 
            // lblTimeTble
            // 
            this.lblTimeTble.AutoSize = true;
            this.lblTimeTble.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTble.ForeColor = System.Drawing.Color.White;
            this.lblTimeTble.Location = new System.Drawing.Point(317, 184);
            this.lblTimeTble.Name = "lblTimeTble";
            this.lblTimeTble.Size = new System.Drawing.Size(207, 38);
            this.lblTimeTble.TabIndex = 135;
            this.lblTimeTble.Text = "TIMETABLE";
            // 
            // dataGridViewTimetable
            // 
            this.dataGridViewTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTimetable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimetable.Location = new System.Drawing.Point(30, 277);
            this.dataGridViewTimetable.Name = "dataGridViewTimetable";
            this.dataGridViewTimetable.RowHeadersWidth = 51;
            this.dataGridViewTimetable.RowTemplate.Height = 24;
            this.dataGridViewTimetable.Size = new System.Drawing.Size(820, 353);
            this.dataGridViewTimetable.TabIndex = 136;
            // 
            // TimetableContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(884, 736);
            this.Controls.Add(this.dataGridViewTimetable);
            this.Controls.Add(this.lblTimeTble);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBoxContactID);
            this.Controls.Add(this.lblContactID);
            this.Controls.Add(this.comboBoxSelectSemester);
            this.Controls.Add(this.lblSelectSemester);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Name = "TimetableContactForm";
            this.Text = "TimetableContactForm";
            this.Load += new System.EventHandler(this.TimetableContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxSelectSemester;
        private System.Windows.Forms.Label lblSelectSemester;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label lblGroup;
        public System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox textBoxContactID;
        private System.Windows.Forms.Label lblContactID;
        private System.Windows.Forms.Label lblTimeTble;
        private System.Windows.Forms.DataGridView dataGridViewTimetable;
    }
}