namespace _20142178_TranManhHuy_QLSV
{
    partial class EnterPINCodeForm
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
            this.lblEnterPINcode = new System.Windows.Forms.Label();
            this.textBoxPINCode = new System.Windows.Forms.TextBox();
            this.btnEnterPINCode = new System.Windows.Forms.Button();
            this.lblAccountVerification = new System.Windows.Forms.Label();
            this.btnSendPINAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterPINcode
            // 
            this.lblEnterPINcode.AutoSize = true;
            this.lblEnterPINcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPINcode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnterPINcode.Location = new System.Drawing.Point(43, 105);
            this.lblEnterPINcode.Name = "lblEnterPINcode";
            this.lblEnterPINcode.Size = new System.Drawing.Size(182, 29);
            this.lblEnterPINcode.TabIndex = 24;
            this.lblEnterPINcode.Text = "Enter PIN code:";
            // 
            // textBoxPINCode
            // 
            this.textBoxPINCode.Location = new System.Drawing.Point(241, 112);
            this.textBoxPINCode.Name = "textBoxPINCode";
            this.textBoxPINCode.Size = new System.Drawing.Size(168, 22);
            this.textBoxPINCode.TabIndex = 26;
            // 
            // btnEnterPINCode
            // 
            this.btnEnterPINCode.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEnterPINCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterPINCode.ForeColor = System.Drawing.Color.White;
            this.btnEnterPINCode.Location = new System.Drawing.Point(433, 80);
            this.btnEnterPINCode.Name = "btnEnterPINCode";
            this.btnEnterPINCode.Size = new System.Drawing.Size(233, 35);
            this.btnEnterPINCode.TabIndex = 29;
            this.btnEnterPINCode.Text = "Authenticate and Login";
            this.btnEnterPINCode.UseVisualStyleBackColor = false;
            this.btnEnterPINCode.Click += new System.EventHandler(this.btnEnterPINCode_Click);
            // 
            // lblAccountVerification
            // 
            this.lblAccountVerification.AutoSize = true;
            this.lblAccountVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountVerification.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAccountVerification.Location = new System.Drawing.Point(42, 36);
            this.lblAccountVerification.Name = "lblAccountVerification";
            this.lblAccountVerification.Size = new System.Drawing.Size(302, 36);
            this.lblAccountVerification.TabIndex = 30;
            this.lblAccountVerification.Text = "Account Verification";
            // 
            // btnSendPINAgain
            // 
            this.btnSendPINAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSendPINAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendPINAgain.ForeColor = System.Drawing.Color.White;
            this.btnSendPINAgain.Location = new System.Drawing.Point(433, 131);
            this.btnSendPINAgain.Name = "btnSendPINAgain";
            this.btnSendPINAgain.Size = new System.Drawing.Size(233, 35);
            this.btnSendPINAgain.TabIndex = 31;
            this.btnSendPINAgain.Text = "Send PIN Code Again";
            this.btnSendPINAgain.UseVisualStyleBackColor = false;
            this.btnSendPINAgain.Click += new System.EventHandler(this.btnSendPINAgain_Click);
            // 
            // EnterPINCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(721, 213);
            this.Controls.Add(this.btnSendPINAgain);
            this.Controls.Add(this.lblAccountVerification);
            this.Controls.Add(this.btnEnterPINCode);
            this.Controls.Add(this.textBoxPINCode);
            this.Controls.Add(this.lblEnterPINcode);
            this.Name = "EnterPINCodeForm";
            this.Text = "EnterPINCodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterPINcode;
        private System.Windows.Forms.TextBox textBoxPINCode;
        private System.Windows.Forms.Button btnEnterPINCode;
        private System.Windows.Forms.Label lblAccountVerification;
        private System.Windows.Forms.Button btnSendPINAgain;
    }
}