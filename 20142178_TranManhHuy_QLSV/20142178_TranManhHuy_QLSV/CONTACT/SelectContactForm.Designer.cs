namespace _20142178_TranManhHuy_QLSV
{
    partial class SelectContactForm
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
            this.dataGridViewSelectContactForm = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabelRefresh = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditInfo = new System.Windows.Forms.LinkLabel();
            this.lblWelcomeHr = new System.Windows.Forms.Label();
            this.pictureBoxHr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectContactForm)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHr)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSelectContactForm
            // 
            this.dataGridViewSelectContactForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelectContactForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectContactForm.Location = new System.Drawing.Point(77, 137);
            this.dataGridViewSelectContactForm.Name = "dataGridViewSelectContactForm";
            this.dataGridViewSelectContactForm.RowHeadersWidth = 51;
            this.dataGridViewSelectContactForm.RowTemplate.Height = 24;
            this.dataGridViewSelectContactForm.Size = new System.Drawing.Size(656, 319);
            this.dataGridViewSelectContactForm.TabIndex = 0;
            this.dataGridViewSelectContactForm.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSelectContactForm_CellDoubleClick);
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
            this.panel4.Size = new System.Drawing.Size(800, 100);
            this.panel4.TabIndex = 72;
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
            // SelectContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridViewSelectContactForm);
            this.Name = "SelectContactForm";
            this.Text = "SelectContactForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectContactForm_FormClosed);
            this.Load += new System.EventHandler(this.SelectContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectContactForm)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSelectContactForm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabelRefresh;
        private System.Windows.Forms.LinkLabel linkLabelEditInfo;
        private System.Windows.Forms.Label lblWelcomeHr;
        private System.Windows.Forms.PictureBox pictureBoxHr;
    }
}