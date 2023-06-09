namespace _20142178_TranManhHuy_QLSV
{
    partial class HumanResourceMainForm
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
            this.panelContact = new System.Windows.Forms.Panel();
            this.btnShowFullList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSelectContact = new System.Windows.Forms.Button();
            this.textBoxContactID = new System.Windows.Forms.TextBox();
            this.lblEnterContactId = new System.Windows.Forms.Label();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.lblContact = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxRemoveSelectGroup = new System.Windows.Forms.ComboBox();
            this.btnRemoveGroup = new System.Windows.Forms.Button();
            this.lblRemoveSelectGroup = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.lblEnterNewName = new System.Windows.Forms.Label();
            this.comboBoxEditSelectGroup = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblEditSelectGroup = new System.Windows.Forms.Label();
            this.panelEnterGroup = new System.Windows.Forms.Panel();
            this.btnAddGroupName = new System.Windows.Forms.Button();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.lblEnterGroupName = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabelRefresh = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditInfo = new System.Windows.Forms.LinkLabel();
            this.lblWelcomeHr = new System.Windows.Forms.Label();
            this.pictureBoxHr = new System.Windows.Forms.PictureBox();
            this.panelContact.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelEnterGroup.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHr)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContact
            // 
            this.panelContact.Controls.Add(this.btnShowFullList);
            this.panelContact.Controls.Add(this.panel2);
            this.panelContact.Controls.Add(this.btnEditContact);
            this.panelContact.Controls.Add(this.btnAddContact);
            this.panelContact.Controls.Add(this.lblContact);
            this.panelContact.Location = new System.Drawing.Point(37, 116);
            this.panelContact.Name = "panelContact";
            this.panelContact.Size = new System.Drawing.Size(589, 495);
            this.panelContact.TabIndex = 0;
            // 
            // btnShowFullList
            // 
            this.btnShowFullList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnShowFullList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFullList.ForeColor = System.Drawing.Color.White;
            this.btnShowFullList.Location = new System.Drawing.Point(54, 389);
            this.btnShowFullList.Name = "btnShowFullList";
            this.btnShowFullList.Size = new System.Drawing.Size(459, 49);
            this.btnShowFullList.TabIndex = 105;
            this.btnShowFullList.Text = "Show Full List";
            this.btnShowFullList.UseVisualStyleBackColor = false;
            this.btnShowFullList.Click += new System.EventHandler(this.btnShowFullList_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnSelectContact);
            this.panel2.Controls.Add(this.textBoxContactID);
            this.panel2.Controls.Add(this.lblEnterContactId);
            this.panel2.Location = new System.Drawing.Point(29, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 122);
            this.panel2.TabIndex = 103;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(25, 61);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(459, 49);
            this.btnRemove.TabIndex = 104;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSelectContact
            // 
            this.btnSelectContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSelectContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectContact.ForeColor = System.Drawing.Color.White;
            this.btnSelectContact.Location = new System.Drawing.Point(322, 5);
            this.btnSelectContact.Name = "btnSelectContact";
            this.btnSelectContact.Size = new System.Drawing.Size(162, 41);
            this.btnSelectContact.TabIndex = 103;
            this.btnSelectContact.Text = "Select Contact";
            this.btnSelectContact.UseVisualStyleBackColor = false;
            this.btnSelectContact.Click += new System.EventHandler(this.btnSelectContact_Click);
            // 
            // textBoxContactID
            // 
            this.textBoxContactID.Location = new System.Drawing.Point(187, 10);
            this.textBoxContactID.Name = "textBoxContactID";
            this.textBoxContactID.ReadOnly = true;
            this.textBoxContactID.Size = new System.Drawing.Size(119, 22);
            this.textBoxContactID.TabIndex = 2;
            // 
            // lblEnterContactId
            // 
            this.lblEnterContactId.AutoSize = true;
            this.lblEnterContactId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterContactId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnterContactId.Location = new System.Drawing.Point(12, 12);
            this.lblEnterContactId.Name = "lblEnterContactId";
            this.lblEnterContactId.Size = new System.Drawing.Size(156, 20);
            this.lblEnterContactId.TabIndex = 1;
            this.lblEnterContactId.Text = "Enter Contact ID:";
            // 
            // btnEditContact
            // 
            this.btnEditContact.BackColor = System.Drawing.Color.Green;
            this.btnEditContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditContact.ForeColor = System.Drawing.Color.White;
            this.btnEditContact.Location = new System.Drawing.Point(29, 158);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(118, 45);
            this.btnEditContact.TabIndex = 102;
            this.btnEditContact.Text = "Edit";
            this.btnEditContact.UseVisualStyleBackColor = false;
            this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.Color.Green;
            this.btnAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContact.ForeColor = System.Drawing.Color.White;
            this.btnAddContact.Location = new System.Drawing.Point(29, 77);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(118, 45);
            this.btnAddContact.TabIndex = 101;
            this.btnAddContact.Text = "Add";
            this.btnAddContact.UseVisualStyleBackColor = false;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContact.Location = new System.Drawing.Point(23, 19);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(124, 36);
            this.lblContact.TabIndex = 0;
            this.lblContact.Text = "Contact";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel.Location = new System.Drawing.Point(651, 116);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(11, 495);
            this.panel.TabIndex = 2;
            // 
            // panelGroup
            // 
            this.panelGroup.Controls.Add(this.panel1);
            this.panelGroup.Controls.Add(this.panel3);
            this.panelGroup.Controls.Add(this.panelEnterGroup);
            this.panelGroup.Controls.Add(this.lblGroup);
            this.panelGroup.Location = new System.Drawing.Point(689, 116);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(589, 495);
            this.panelGroup.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.comboBoxRemoveSelectGroup);
            this.panel1.Controls.Add(this.btnRemoveGroup);
            this.panel1.Controls.Add(this.lblRemoveSelectGroup);
            this.panel1.Location = new System.Drawing.Point(29, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 113);
            this.panel1.TabIndex = 105;
            // 
            // comboBoxRemoveSelectGroup
            // 
            this.comboBoxRemoveSelectGroup.FormattingEnabled = true;
            this.comboBoxRemoveSelectGroup.Location = new System.Drawing.Point(212, 8);
            this.comboBoxRemoveSelectGroup.Name = "comboBoxRemoveSelectGroup";
            this.comboBoxRemoveSelectGroup.Size = new System.Drawing.Size(272, 24);
            this.comboBoxRemoveSelectGroup.TabIndex = 105;
            // 
            // btnRemoveGroup
            // 
            this.btnRemoveGroup.BackColor = System.Drawing.Color.Green;
            this.btnRemoveGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveGroup.ForeColor = System.Drawing.Color.White;
            this.btnRemoveGroup.Location = new System.Drawing.Point(25, 52);
            this.btnRemoveGroup.Name = "btnRemoveGroup";
            this.btnRemoveGroup.Size = new System.Drawing.Size(459, 40);
            this.btnRemoveGroup.TabIndex = 104;
            this.btnRemoveGroup.Text = "Remove";
            this.btnRemoveGroup.UseVisualStyleBackColor = false;
            this.btnRemoveGroup.Click += new System.EventHandler(this.btnRemoveGroup_Click);
            // 
            // lblRemoveSelectGroup
            // 
            this.lblRemoveSelectGroup.AutoSize = true;
            this.lblRemoveSelectGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveSelectGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemoveSelectGroup.Location = new System.Drawing.Point(12, 12);
            this.lblRemoveSelectGroup.Name = "lblRemoveSelectGroup";
            this.lblRemoveSelectGroup.Size = new System.Drawing.Size(125, 20);
            this.lblRemoveSelectGroup.TabIndex = 1;
            this.lblRemoveSelectGroup.Text = "Select Group:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.textBoxNewName);
            this.panel3.Controls.Add(this.lblEnterNewName);
            this.panel3.Controls.Add(this.comboBoxEditSelectGroup);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.lblEditSelectGroup);
            this.panel3.Location = new System.Drawing.Point(29, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 148);
            this.panel3.TabIndex = 104;
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(212, 56);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(272, 22);
            this.textBoxNewName.TabIndex = 107;
            // 
            // lblEnterNewName
            // 
            this.lblEnterNewName.AutoSize = true;
            this.lblEnterNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNewName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnterNewName.Location = new System.Drawing.Point(12, 56);
            this.lblEnterNewName.Name = "lblEnterNewName";
            this.lblEnterNewName.Size = new System.Drawing.Size(156, 20);
            this.lblEnterNewName.TabIndex = 106;
            this.lblEnterNewName.Text = "Enter New Name:";
            // 
            // comboBoxEditSelectGroup
            // 
            this.comboBoxEditSelectGroup.FormattingEnabled = true;
            this.comboBoxEditSelectGroup.Location = new System.Drawing.Point(212, 8);
            this.comboBoxEditSelectGroup.Name = "comboBoxEditSelectGroup";
            this.comboBoxEditSelectGroup.Size = new System.Drawing.Size(272, 24);
            this.comboBoxEditSelectGroup.TabIndex = 105;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Green;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(25, 91);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(459, 40);
            this.btnEdit.TabIndex = 104;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblEditSelectGroup
            // 
            this.lblEditSelectGroup.AutoSize = true;
            this.lblEditSelectGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditSelectGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditSelectGroup.Location = new System.Drawing.Point(12, 12);
            this.lblEditSelectGroup.Name = "lblEditSelectGroup";
            this.lblEditSelectGroup.Size = new System.Drawing.Size(125, 20);
            this.lblEditSelectGroup.TabIndex = 1;
            this.lblEditSelectGroup.Text = "Select Group:";
            // 
            // panelEnterGroup
            // 
            this.panelEnterGroup.BackColor = System.Drawing.Color.Purple;
            this.panelEnterGroup.Controls.Add(this.btnAddGroupName);
            this.panelEnterGroup.Controls.Add(this.textBoxGroupName);
            this.panelEnterGroup.Controls.Add(this.lblEnterGroupName);
            this.panelEnterGroup.ForeColor = System.Drawing.Color.Black;
            this.panelEnterGroup.Location = new System.Drawing.Point(29, 68);
            this.panelEnterGroup.Name = "panelEnterGroup";
            this.panelEnterGroup.Size = new System.Drawing.Size(506, 112);
            this.panelEnterGroup.TabIndex = 103;
            // 
            // btnAddGroupName
            // 
            this.btnAddGroupName.BackColor = System.Drawing.Color.Green;
            this.btnAddGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroupName.ForeColor = System.Drawing.Color.White;
            this.btnAddGroupName.Location = new System.Drawing.Point(25, 51);
            this.btnAddGroupName.Name = "btnAddGroupName";
            this.btnAddGroupName.Size = new System.Drawing.Size(459, 40);
            this.btnAddGroupName.TabIndex = 104;
            this.btnAddGroupName.Text = "Add";
            this.btnAddGroupName.UseVisualStyleBackColor = false;
            this.btnAddGroupName.Click += new System.EventHandler(this.btnAddGroupName_Click);
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Location = new System.Drawing.Point(212, 10);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(272, 22);
            this.textBoxGroupName.TabIndex = 2;
            // 
            // lblEnterGroupName
            // 
            this.lblEnterGroupName.AutoSize = true;
            this.lblEnterGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterGroupName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnterGroupName.Location = new System.Drawing.Point(12, 12);
            this.lblEnterGroupName.Name = "lblEnterGroupName";
            this.lblEnterGroupName.Size = new System.Drawing.Size(171, 20);
            this.lblEnterGroupName.TabIndex = 1;
            this.lblEnterGroupName.Text = "Enter Group Name:";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGroup.Location = new System.Drawing.Point(23, 19);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(104, 36);
            this.lblGroup.TabIndex = 0;
            this.lblGroup.Text = "Group";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.linkLabelRefresh);
            this.panel4.Controls.Add(this.linkLabelEditInfo);
            this.panel4.Controls.Add(this.lblWelcomeHr);
            this.panel4.Controls.Add(this.pictureBoxHr);
            this.panel4.Location = new System.Drawing.Point(-8, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1296, 100);
            this.panel4.TabIndex = 14;
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
            this.linkLabelRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRefresh_LinkClicked);
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
            // HumanResourceMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1285, 650);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelGroup);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelContact);
            this.Name = "HumanResourceMainForm";
            this.Text = "HumanResourceMainForm";
            this.Load += new System.EventHandler(this.HumanResourceMainForm_Load);
            this.panelContact.ResumeLayout(false);
            this.panelContact.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelEnterGroup.ResumeLayout(false);
            this.panelEnterGroup.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContact;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEnterContactId;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnShowFullList;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSelectContact;
        private System.Windows.Forms.TextBox textBoxContactID;
        private System.Windows.Forms.Panel panelGroup;
        private System.Windows.Forms.Panel panelEnterGroup;
        private System.Windows.Forms.Button btnAddGroupName;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Label lblEnterGroupName;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label lblEnterNewName;
        private System.Windows.Forms.ComboBox comboBoxEditSelectGroup;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblEditSelectGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxRemoveSelectGroup;
        private System.Windows.Forms.Button btnRemoveGroup;
        private System.Windows.Forms.Label lblRemoveSelectGroup;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabelRefresh;
        private System.Windows.Forms.LinkLabel linkLabelEditInfo;
        private System.Windows.Forms.Label lblWelcomeHr;
        private System.Windows.Forms.PictureBox pictureBoxHr;
    }
}