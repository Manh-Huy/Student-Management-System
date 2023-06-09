namespace _20142178_TranManhHuy_QLSV
{
    partial class AuthenticationHumanResourceForm
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
            this.ButtonRejectAll = new System.Windows.Forms.Button();
            this.ButtonApproveAll = new System.Windows.Forms.Button();
            this.ButtonReject = new System.Windows.Forms.Button();
            this.ButtonApprove = new System.Windows.Forms.Button();
            this.dataGridViewTemp_HumanResourceList = new System.Windows.Forms.DataGridView();
            this.lblHr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemp_HumanResourceList)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRejectAll
            // 
            this.ButtonRejectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ButtonRejectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRejectAll.Location = new System.Drawing.Point(619, 441);
            this.ButtonRejectAll.Name = "ButtonRejectAll";
            this.ButtonRejectAll.Size = new System.Drawing.Size(146, 40);
            this.ButtonRejectAll.TabIndex = 11;
            this.ButtonRejectAll.Text = "Reject All";
            this.ButtonRejectAll.UseVisualStyleBackColor = false;
            this.ButtonRejectAll.Click += new System.EventHandler(this.ButtonRejectAll_Click);
            // 
            // ButtonApproveAll
            // 
            this.ButtonApproveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonApproveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonApproveAll.Location = new System.Drawing.Point(192, 441);
            this.ButtonApproveAll.Name = "ButtonApproveAll";
            this.ButtonApproveAll.Size = new System.Drawing.Size(146, 40);
            this.ButtonApproveAll.TabIndex = 10;
            this.ButtonApproveAll.Text = "Approve All";
            this.ButtonApproveAll.UseVisualStyleBackColor = false;
            this.ButtonApproveAll.Click += new System.EventHandler(this.ButtonApproveAll_Click);
            // 
            // ButtonReject
            // 
            this.ButtonReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ButtonReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReject.Location = new System.Drawing.Point(429, 441);
            this.ButtonReject.Name = "ButtonReject";
            this.ButtonReject.Size = new System.Drawing.Size(112, 40);
            this.ButtonReject.TabIndex = 9;
            this.ButtonReject.Text = "Reject";
            this.ButtonReject.UseVisualStyleBackColor = false;
            this.ButtonReject.Click += new System.EventHandler(this.ButtonReject_Click);
            // 
            // ButtonApprove
            // 
            this.ButtonApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonApprove.Location = new System.Drawing.Point(39, 441);
            this.ButtonApprove.Name = "ButtonApprove";
            this.ButtonApprove.Size = new System.Drawing.Size(112, 40);
            this.ButtonApprove.TabIndex = 8;
            this.ButtonApprove.Text = "Approve";
            this.ButtonApprove.UseVisualStyleBackColor = false;
            this.ButtonApprove.Click += new System.EventHandler(this.ButtonApprove_Click);
            // 
            // dataGridViewTemp_HumanResourceList
            // 
            this.dataGridViewTemp_HumanResourceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTemp_HumanResourceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTemp_HumanResourceList.Location = new System.Drawing.Point(39, 77);
            this.dataGridViewTemp_HumanResourceList.Name = "dataGridViewTemp_HumanResourceList";
            this.dataGridViewTemp_HumanResourceList.RowHeadersWidth = 51;
            this.dataGridViewTemp_HumanResourceList.RowTemplate.Height = 24;
            this.dataGridViewTemp_HumanResourceList.Size = new System.Drawing.Size(726, 340);
            this.dataGridViewTemp_HumanResourceList.TabIndex = 7;
            // 
            // lblHr
            // 
            this.lblHr.AutoSize = true;
            this.lblHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr.ForeColor = System.Drawing.Color.White;
            this.lblHr.Location = new System.Drawing.Point(33, 20);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(268, 36);
            this.lblHr.TabIndex = 69;
            this.lblHr.Text = "Human Resource:";
            // 
            // AuthenticationHumanResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.lblHr);
            this.Controls.Add(this.ButtonRejectAll);
            this.Controls.Add(this.ButtonApproveAll);
            this.Controls.Add(this.ButtonReject);
            this.Controls.Add(this.ButtonApprove);
            this.Controls.Add(this.dataGridViewTemp_HumanResourceList);
            this.Name = "AuthenticationHumanResourceForm";
            this.Text = "AuthenticationHumanResourceForm";
            this.Load += new System.EventHandler(this.AuthenticationHumanResourceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemp_HumanResourceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonRejectAll;
        private System.Windows.Forms.Button ButtonApproveAll;
        private System.Windows.Forms.Button ButtonReject;
        private System.Windows.Forms.Button ButtonApprove;
        private System.Windows.Forms.DataGridView dataGridViewTemp_HumanResourceList;
        private System.Windows.Forms.Label lblHr;
    }
}