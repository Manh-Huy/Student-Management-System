using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;

namespace _20142178_TranManhHuy_QLSV
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            USER user = new USER();

            string email = textBoxEmail.Text;
            string username;
            string password;
            
            if (IsValidEmail(email))
            {
                MY_DB db = new MY_DB();

                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable table = new DataTable();


                SqlCommand command = new SqlCommand("SELECT username, password FROM Log_in WHERE email = '" + email + "'", db.getConnection);

                adapter.SelectCommand = command;
                
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    username = table.Rows[0].Field<string>("username");
                    password = table.Rows[0].Field<string>("password");

                    string pin = RANDOM_PIN_GENERATOR.GenerateRandomPIN(6); // Tạo ra mã PIN ngẫu nhiên gồm 6 chữ số
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

                        RecoverPasswordForm enterPin = new RecoverPasswordForm(pin, email, username, password);
                        enterPin.ShowDialog(this);
                    }
                    catch
                    {
                        MessageBox.Show("Code Unsuccessfully Send", "Enter Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email Not Exits In All Users!", "Enter Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Email Not Correct!", "Enter Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // chuc nang kiem tra format email
        private bool IsValidEmail(string email)
        {
            // Kiểm tra định dạng email bằng biểu thức chính quy
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}
