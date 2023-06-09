namespace _20142178_TranManhHuy_QLSV
{
    partial class AvgScoreByCourseForm
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
            this.dataGridViewAvgScoreByCourse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvgScoreByCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAvgScoreByCourse
            // 
            this.dataGridViewAvgScoreByCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAvgScoreByCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvgScoreByCourse.Location = new System.Drawing.Point(28, 39);
            this.dataGridViewAvgScoreByCourse.Name = "dataGridViewAvgScoreByCourse";
            this.dataGridViewAvgScoreByCourse.RowHeadersWidth = 51;
            this.dataGridViewAvgScoreByCourse.RowTemplate.Height = 24;
            this.dataGridViewAvgScoreByCourse.Size = new System.Drawing.Size(432, 323);
            this.dataGridViewAvgScoreByCourse.TabIndex = 0;
            // 
            // AvgScoreByCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.dataGridViewAvgScoreByCourse);
            this.Name = "AvgScoreByCourseForm";
            this.Text = "AvgScoreByCourseForm";
            this.Load += new System.EventHandler(this.AvgScoreByCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvgScoreByCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAvgScoreByCourse;
    }
}