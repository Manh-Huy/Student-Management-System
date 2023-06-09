namespace _20142178_TranManhHuy_QLSV
{
    partial class RemoveScoreForm
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
            this.dataGridViewRemoveScoreList = new System.Windows.Forms.DataGridView();
            this.btnRemoveScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemoveScoreList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRemoveScoreList
            // 
            this.dataGridViewRemoveScoreList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRemoveScoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRemoveScoreList.Location = new System.Drawing.Point(58, 30);
            this.dataGridViewRemoveScoreList.Name = "dataGridViewRemoveScoreList";
            this.dataGridViewRemoveScoreList.RowHeadersWidth = 51;
            this.dataGridViewRemoveScoreList.RowTemplate.Height = 24;
            this.dataGridViewRemoveScoreList.Size = new System.Drawing.Size(782, 324);
            this.dataGridViewRemoveScoreList.TabIndex = 0;
            // 
            // btnRemoveScore
            // 
            this.btnRemoveScore.BackColor = System.Drawing.Color.Brown;
            this.btnRemoveScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveScore.ForeColor = System.Drawing.Color.White;
            this.btnRemoveScore.Location = new System.Drawing.Point(359, 387);
            this.btnRemoveScore.Name = "btnRemoveScore";
            this.btnRemoveScore.Size = new System.Drawing.Size(170, 40);
            this.btnRemoveScore.TabIndex = 101;
            this.btnRemoveScore.Text = "Remove Score";
            this.btnRemoveScore.UseVisualStyleBackColor = false;
            this.btnRemoveScore.Click += new System.EventHandler(this.btnRemoveScore_Click);
            // 
            // RemoveScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.btnRemoveScore);
            this.Controls.Add(this.dataGridViewRemoveScoreList);
            this.Name = "RemoveScoreForm";
            this.Text = "RemoveScoreForm";
            this.Load += new System.EventHandler(this.RemoveScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemoveScoreList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRemoveScoreList;
        private System.Windows.Forms.Button btnRemoveScore;
    }
}