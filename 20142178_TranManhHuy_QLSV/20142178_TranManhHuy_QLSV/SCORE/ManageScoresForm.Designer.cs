namespace _20142178_TranManhHuy_QLSV
{
    partial class ManageScoresForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewManageScore = new System.Windows.Forms.DataGridView();
            this.comboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAverageScoreByCourse = new System.Windows.Forms.Button();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.btnShowScores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageScore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(128, 349);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 45);
            this.btnAdd.TabIndex = 110;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewManageScore
            // 
            this.dataGridViewManageScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewManageScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageScore.Location = new System.Drawing.Point(514, 126);
            this.dataGridViewManageScore.Name = "dataGridViewManageScore";
            this.dataGridViewManageScore.RowHeadersWidth = 51;
            this.dataGridViewManageScore.RowTemplate.Height = 24;
            this.dataGridViewManageScore.Size = new System.Drawing.Size(541, 396);
            this.dataGridViewManageScore.TabIndex = 109;
            this.dataGridViewManageScore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageScore_CellClick);
            // 
            // comboBoxSelectCourse
            // 
            this.comboBoxSelectCourse.FormattingEnabled = true;
            this.comboBoxSelectCourse.Location = new System.Drawing.Point(211, 126);
            this.comboBoxSelectCourse.Name = "comboBoxSelectCourse";
            this.comboBoxSelectCourse.Size = new System.Drawing.Size(236, 24);
            this.comboBoxSelectCourse.TabIndex = 108;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(211, 238);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(236, 82);
            this.textDescription.TabIndex = 107;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(211, 185);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(236, 22);
            this.textBoxScore.TabIndex = 106;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(211, 74);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.ReadOnly = true;
            this.textBoxStudentID.Size = new System.Drawing.Size(124, 22);
            this.textBoxStudentID.TabIndex = 105;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(34, 231);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(141, 29);
            this.lblDescription.TabIndex = 104;
            this.lblDescription.Text = "Description:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(37, 178);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(83, 29);
            this.lblScore.TabIndex = 103;
            this.lblScore.Text = "Score:";
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.ForeColor = System.Drawing.Color.White;
            this.lblSelectCourse.Location = new System.Drawing.Point(34, 121);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(171, 29);
            this.lblSelectCourse.TabIndex = 102;
            this.lblSelectCourse.Text = "Select Course:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.Color.White;
            this.lblStudentID.Location = new System.Drawing.Point(34, 67);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(130, 29);
            this.lblStudentID.TabIndex = 101;
            this.lblStudentID.Text = "Student ID:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Olive;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(326, 349);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(121, 45);
            this.btnRemove.TabIndex = 111;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAverageScoreByCourse
            // 
            this.btnAverageScoreByCourse.BackColor = System.Drawing.Color.DarkViolet;
            this.btnAverageScoreByCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverageScoreByCourse.ForeColor = System.Drawing.Color.White;
            this.btnAverageScoreByCourse.Location = new System.Drawing.Point(128, 422);
            this.btnAverageScoreByCourse.Name = "btnAverageScoreByCourse";
            this.btnAverageScoreByCourse.Size = new System.Drawing.Size(319, 45);
            this.btnAverageScoreByCourse.TabIndex = 112;
            this.btnAverageScoreByCourse.Text = "Average Score By Course";
            this.btnAverageScoreByCourse.UseVisualStyleBackColor = false;
            this.btnAverageScoreByCourse.Click += new System.EventHandler(this.btnAverageScoreByCourse_Click);
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.BackColor = System.Drawing.Color.Teal;
            this.btnShowStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStudents.ForeColor = System.Drawing.Color.White;
            this.btnShowStudents.Location = new System.Drawing.Point(514, 60);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(220, 45);
            this.btnShowStudents.TabIndex = 113;
            this.btnShowStudents.Text = "Show Students";
            this.btnShowStudents.UseVisualStyleBackColor = false;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // btnShowScores
            // 
            this.btnShowScores.BackColor = System.Drawing.Color.Teal;
            this.btnShowScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowScores.ForeColor = System.Drawing.Color.White;
            this.btnShowScores.Location = new System.Drawing.Point(835, 60);
            this.btnShowScores.Name = "btnShowScores";
            this.btnShowScores.Size = new System.Drawing.Size(220, 45);
            this.btnShowScores.TabIndex = 114;
            this.btnShowScores.Text = "Show Scores";
            this.btnShowScores.UseVisualStyleBackColor = false;
            this.btnShowScores.Click += new System.EventHandler(this.btnShowScores_Click);
            // 
            // ManageScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1093, 568);
            this.Controls.Add(this.btnShowScores);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.btnAverageScoreByCourse);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewManageScore);
            this.Controls.Add(this.comboBoxSelectCourse);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.lblStudentID);
            this.Name = "ManageScoresForm";
            this.Text = "ManageScoresForm";
            this.Load += new System.EventHandler(this.ManageScoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewManageScore;
        private System.Windows.Forms.ComboBox comboBoxSelectCourse;
        public System.Windows.Forms.TextBox textDescription;
        public System.Windows.Forms.TextBox textBoxScore;
        public System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAverageScoreByCourse;
        private System.Windows.Forms.Button btnShowStudents;
        private System.Windows.Forms.Button btnShowScores;
    }
}