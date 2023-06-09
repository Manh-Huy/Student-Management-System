namespace _20142178_TranManhHuy_QLSV
{
    partial class FullListContactForm
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
            this.ListBoxGroup = new System.Windows.Forms.ListBox();
            this.lblShowAll = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.dataGridViewContactList = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabelRefresh = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditInfo = new System.Windows.Forms.LinkLabel();
            this.lblWelcomeHr = new System.Windows.Forms.Label();
            this.pictureBoxHr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactList)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHr)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxGroup
            // 
            this.ListBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxGroup.FormattingEnabled = true;
            this.ListBoxGroup.ItemHeight = 25;
            this.ListBoxGroup.Location = new System.Drawing.Point(38, 194);
            this.ListBoxGroup.Name = "ListBoxGroup";
            this.ListBoxGroup.Size = new System.Drawing.Size(205, 329);
            this.ListBoxGroup.TabIndex = 90;
            this.ListBoxGroup.DoubleClick += new System.EventHandler(this.ListBoxGroup_DoubleClick);
            // 
            // lblShowAll
            // 
            this.lblShowAll.AutoSize = true;
            this.lblShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowAll.ForeColor = System.Drawing.Color.White;
            this.lblShowAll.Location = new System.Drawing.Point(285, 129);
            this.lblShowAll.Name = "lblShowAll";
            this.lblShowAll.Size = new System.Drawing.Size(142, 32);
            this.lblShowAll.TabIndex = 89;
            this.lblShowAll.Text = "Show All:";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.ForeColor = System.Drawing.Color.White;
            this.lblGroup.Location = new System.Drawing.Point(32, 129);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(107, 32);
            this.lblGroup.TabIndex = 88;
            this.lblGroup.Text = "Group:";
            // 
            // dataGridViewContactList
            // 
            this.dataGridViewContactList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContactList.Location = new System.Drawing.Point(291, 194);
            this.dataGridViewContactList.Name = "dataGridViewContactList";
            this.dataGridViewContactList.RowHeadersWidth = 51;
            this.dataGridViewContactList.RowTemplate.Height = 24;
            this.dataGridViewContactList.Size = new System.Drawing.Size(809, 329);
            this.dataGridViewContactList.TabIndex = 91;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(918, 547);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 45);
            this.btnCancel.TabIndex = 104;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Green;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(325, 547);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(149, 45);
            this.btnRefresh.TabIndex = 103;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.Olive;
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Location = new System.Drawing.Point(618, 547);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(149, 45);
            this.btnChoose.TabIndex = 105;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
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
            this.panel4.Size = new System.Drawing.Size(1131, 100);
            this.panel4.TabIndex = 106;
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
            // FullListContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1131, 630);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewContactList);
            this.Controls.Add(this.ListBoxGroup);
            this.Controls.Add(this.lblShowAll);
            this.Controls.Add(this.lblGroup);
            this.Name = "FullListContactForm";
            this.Text = "FullListContactForm";
            this.Load += new System.EventHandler(this.FullListContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxGroup;
        private System.Windows.Forms.Label lblShowAll;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.DataGridView dataGridViewContactList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabelRefresh;
        private System.Windows.Forms.LinkLabel linkLabelEditInfo;
        private System.Windows.Forms.Label lblWelcomeHr;
        private System.Windows.Forms.PictureBox pictureBoxHr;
    }
}