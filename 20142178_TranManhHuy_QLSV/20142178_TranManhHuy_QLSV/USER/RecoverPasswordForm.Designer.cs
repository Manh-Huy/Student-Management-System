namespace _20142178_TranManhHuy_QLSV
{
    partial class RecoverPasswordForm
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
            this.btnSendPINAgain = new System.Windows.Forms.Button();
            this.lblRecoverPassword = new System.Windows.Forms.Label();
            this.btnRecoverPassword = new System.Windows.Forms.Button();
            this.textBoxPINCode = new System.Windows.Forms.TextBox();
            this.lblEnterPINcode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendPINAgain
            // 
            this.btnSendPINAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSendPINAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendPINAgain.ForeColor = System.Drawing.Color.White;
            this.btnSendPINAgain.Location = new System.Drawing.Point(449, 155);
            this.btnSendPINAgain.Name = "btnSendPINAgain";
            this.btnSendPINAgain.Size = new System.Drawing.Size(233, 35);
            this.btnSendPINAgain.TabIndex = 36;
            this.btnSendPINAgain.Text = "Send PIN Code Again";
            this.btnSendPINAgain.UseVisualStyleBackColor = false;
            this.btnSendPINAgain.Click += new System.EventHandler(this.btnSendPINAgain_Click);
            // 
            // lblRecoverPassword
            // 
            this.lblRecoverPassword.AutoSize = true;
            this.lblRecoverPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecoverPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRecoverPassword.Location = new System.Drawing.Point(58, 60);
            this.lblRecoverPassword.Name = "lblRecoverPassword";
            this.lblRecoverPassword.Size = new System.Drawing.Size(282, 36);
            this.lblRecoverPassword.TabIndex = 35;
            this.lblRecoverPassword.Text = "Recover Password";
            // 
            // btnRecoverPassword
            // 
            this.btnRecoverPassword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRecoverPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverPassword.ForeColor = System.Drawing.Color.White;
            this.btnRecoverPassword.Location = new System.Drawing.Point(449, 104);
            this.btnRecoverPassword.Name = "btnRecoverPassword";
            this.btnRecoverPassword.Size = new System.Drawing.Size(233, 35);
            this.btnRecoverPassword.TabIndex = 34;
            this.btnRecoverPassword.Text = "Recover Password";
            this.btnRecoverPassword.UseVisualStyleBackColor = false;
            this.btnRecoverPassword.Click += new System.EventHandler(this.btnRecoverPassword_Click);
            // 
            // textBoxPINCode
            // 
            this.textBoxPINCode.Location = new System.Drawing.Point(257, 136);
            this.textBoxPINCode.Name = "textBoxPINCode";
            this.textBoxPINCode.Size = new System.Drawing.Size(168, 22);
            this.textBoxPINCode.TabIndex = 33;
            // 
            // lblEnterPINcode
            // 
            this.lblEnterPINcode.AutoSize = true;
            this.lblEnterPINcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPINcode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnterPINcode.Location = new System.Drawing.Point(59, 129);
            this.lblEnterPINcode.Name = "lblEnterPINcode";
            this.lblEnterPINcode.Size = new System.Drawing.Size(182, 29);
            this.lblEnterPINcode.TabIndex = 32;
            this.lblEnterPINcode.Text = "Enter PIN code:";
            // 
            // RecoverPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(762, 262);
            this.Controls.Add(this.btnSendPINAgain);
            this.Controls.Add(this.lblRecoverPassword);
            this.Controls.Add(this.btnRecoverPassword);
            this.Controls.Add(this.textBoxPINCode);
            this.Controls.Add(this.lblEnterPINcode);
            this.Name = "RecoverPasswordForm";
            this.Text = "RecoverPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendPINAgain;
        private System.Windows.Forms.Label lblRecoverPassword;
        private System.Windows.Forms.Button btnRecoverPassword;
        private System.Windows.Forms.TextBox textBoxPINCode;
        private System.Windows.Forms.Label lblEnterPINcode;
    }
}