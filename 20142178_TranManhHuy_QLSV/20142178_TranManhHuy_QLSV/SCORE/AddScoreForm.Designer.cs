namespace _20142178_TranManhHuy_QLSV
{
    partial class AddScoreForm
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
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.comboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.dataGridViewScoreList = new System.Windows.Forms.DataGridView();
            this.btnAddScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreList)).BeginInit();
            this.SuspendLayout();
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(225, 237);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(236, 82);
            this.textDescription.TabIndex = 97;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(225, 184);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(236, 22);
            this.textBoxScore.TabIndex = 96;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(225, 73);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.ReadOnly = true;
            this.textBoxStudentID.Size = new System.Drawing.Size(124, 22);
            this.textBoxStudentID.TabIndex = 94;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(48, 230);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(141, 29);
            this.lblDescription.TabIndex = 93;
            this.lblDescription.Text = "Description:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(51, 177);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(83, 29);
            this.lblScore.TabIndex = 92;
            this.lblScore.Text = "Score:";
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.ForeColor = System.Drawing.Color.White;
            this.lblSelectCourse.Location = new System.Drawing.Point(48, 120);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(171, 29);
            this.lblSelectCourse.TabIndex = 91;
            this.lblSelectCourse.Text = "Select Course:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.Color.White;
            this.lblStudentID.Location = new System.Drawing.Point(48, 66);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(130, 29);
            this.lblStudentID.TabIndex = 90;
            this.lblStudentID.Text = "Student ID:";
            // 
            // comboBoxSelectCourse
            // 
            this.comboBoxSelectCourse.FormattingEnabled = true;
            this.comboBoxSelectCourse.Location = new System.Drawing.Point(225, 125);
            this.comboBoxSelectCourse.Name = "comboBoxSelectCourse";
            this.comboBoxSelectCourse.Size = new System.Drawing.Size(236, 24);
            this.comboBoxSelectCourse.TabIndex = 98;
            // 
            // dataGridViewScoreList
            // 
            this.dataGridViewScoreList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScoreList.Location = new System.Drawing.Point(514, 42);
            this.dataGridViewScoreList.Name = "dataGridViewScoreList";
            this.dataGridViewScoreList.RowHeadersWidth = 51;
            this.dataGridViewScoreList.RowTemplate.Height = 24;
            this.dataGridViewScoreList.Size = new System.Drawing.Size(440, 396);
            this.dataGridViewScoreList.TabIndex = 99;
            this.dataGridViewScoreList.Click += new System.EventHandler(this.dataGridViewScoreList_Click);
            // 
            // btnAddScore
            // 
            this.btnAddScore.BackColor = System.Drawing.Color.Green;
            this.btnAddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddScore.ForeColor = System.Drawing.Color.White;
            this.btnAddScore.Location = new System.Drawing.Point(225, 349);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(143, 45);
            this.btnAddScore.TabIndex = 100;
            this.btnAddScore.Text = "Add Score";
            this.btnAddScore.UseVisualStyleBackColor = false;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(1016, 481);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.dataGridViewScoreList);
            this.Controls.Add(this.comboBoxSelectCourse);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.lblStudentID);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textDescription;
        public System.Windows.Forms.TextBox textBoxScore;
        public System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.ComboBox comboBoxSelectCourse;
        private System.Windows.Forms.DataGridView dataGridViewScoreList;
        private System.Windows.Forms.Button btnAddScore;
    }
}