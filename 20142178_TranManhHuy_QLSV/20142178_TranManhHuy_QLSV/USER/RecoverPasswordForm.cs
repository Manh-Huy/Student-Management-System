using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20142178_TranManhHuy_QLSV
{
    public partial class RecoverPasswordForm : Form
    {
        public RecoverPasswordForm()
        {
            InitializeComponent();
        }
        string username;
        string password;
        string pincode;
        string email;

        public RecoverPasswordForm( string pin, string mail, string uname, string pass)
        {
            pincode = pin;
            email = mail;
            username = uname;
            password = pass;
            InitializeComponent();
        }

        private void btnRecoverPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPINCode.Text == pincode)
            {
                MessageBox.Show("Username: " + username + "\nPassword: " + password, "Recover password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("PIN Code Not Correct!", " Recover password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPINCode.Text = "";
            }
        }

        private void btnSendPINAgain_Click(object sender, EventArgs e)
        {
            string pin = RANDOM_PIN_GENERATOR.GenerateRandomPIN(6); // Tạo ra mã PIN ngẫu nhiên gồm 6 chữ số
            pincode = pin;
            string subject = "Mã khôi phục tài khoản";
            string body = $"Mã xác nhận của bạn là {pin}";

            // Thông tin tài khoản email gửi
            string fromEmail = "test24072002@gmail.com";
            string fromPassword = "kcsxsxfgaojfhuzp";

            MailMessage message = new MailMessage(fromEmail, email, subject, body);
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(fromEmail, fromPassword);

            // Gửi email
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Successfully Send", "Enter Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("Enter PIN from email", "Enter Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxPINCode.Text = "";
            }
            catch
            {
                MessageBox.Show("Code Unsuccessfully Send", "Enter Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
