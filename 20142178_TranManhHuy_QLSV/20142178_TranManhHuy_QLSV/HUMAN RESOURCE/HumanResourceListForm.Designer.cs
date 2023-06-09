namespace _20142178_TranManhHuy_QLSV
{
    partial class HumanResourceListForm
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
            this.panelFindUser = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblFind = new System.Windows.Forms.Label();
            this.dataGridViewHrList = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblHr = new System.Windows.Forms.Label();
            this.panelFindUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHrList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFindUser
            // 
            this.panelFindUser.BackColor = System.Drawing.Color.Green;
            this.panelFindUser.Controls.Add(this.btnFind);
            this.panelFindUser.Controls.Add(this.textBoxEmail);
            this.panelFindUser.Controls.Add(this.textBoxUserName);
            this.panelFindUser.Controls.Add(this.lblEmail);
            this.panelFindUser.Controls.Add(this.lblUserName);
            this.panelFindUser.Controls.Add(this.lblFind);
            this.panelFindUser.Location = new System.Drawing.Point(283, 90);
            this.panelFindUser.Name = "panelFindUser";
            this.panelFindUser.Size = new System.Drawing.Size(573, 100);
            this.panelFindUser.TabIndex = 66;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.Transparent;
            this.btnFind.Location = new System.Drawing.Point(463, 34);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(91, 38);
            this.btnFind.TabIndex = 63;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(270, 52);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(175, 22);
            this.textBoxEmail.TabIndex = 72;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(270, 18);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(108, 22);
            this.textBoxUserName.TabIndex = 71;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(139, 50);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 22);
            this.lblEmail.TabIndex = 70;
            this.lblEmail.Text = "Email:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(139, 18);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(115, 22);
            this.lblUserName.TabIndex = 69;
            this.lblUserName.Text = "User Name:";
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.ForeColor = System.Drawing.Color.White;
            this.lblFind.Location = new System.Drawing.Point(16, 13);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(108, 29);
            this.lblFind.TabIndex = 66;
            this.lblFind.Text = "Find By:";
            // 
            // dataGridViewHrList
            // 
            this.dataGridViewHrList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHrList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHrList.Location = new System.Drawing.Point(37, 212);
            this.dataGridViewHrList.Name = "dataGridViewHrList";
            this.dataGridViewHrList.RowHeadersWidth = 51;
            this.dataGridViewHrList.RowTemplate.Height = 24;
            this.dataGridViewHrList.Size = new System.Drawing.Size(1017, 274);
            this.dataGridViewHrList.TabIndex = 65;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Green;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(518, 506);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 38);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblHr
            // 
            this.lblHr.AutoSize = true;
            this.lblHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr.ForeColor = System.Drawing.Color.White;
            this.lblHr.Location = new System.Drawing.Point(31, 27);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(268, 36);
            this.lblHr.TabIndex = 68;
            this.lblHr.Text = "Human Resource:";
            // 
            // HumanResourceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1090, 564);
            this.Controls.Add(this.lblHr);
            this.Controls.Add(this.panelFindUser);
            this.Controls.Add(this.dataGridViewHrList);
            this.Controls.Add(this.btnDelete);
            this.Name = "HumanResourceListForm";
            this.Text = "HumanResourceListForm";
            this.Load += new System.EventHandler(this.HumanResourceListForm_Load);
            this.panelFindUser.ResumeLayout(false);
            this.panelFindUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHrList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFindUser;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.DataGridView dataGridViewHrList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblHr;
    }
}