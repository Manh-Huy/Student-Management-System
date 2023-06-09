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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace _20142178_TranManhHuy_QLSV
{
    public partial class RegisterHRForm : Form
    {
        public RegisterHRForm()
        {
            InitializeComponent();
        }

        private void RegisterHRForm_Load(object sender, EventArgs e)
        {
            pictureBoxLogin.Image = Image.FromFile("../../images/register.jpg");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (verif() == false)
            {
                MessageBox.Show("Empty Fields", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                USER user = new USER();
                string id = textBoxID.Text;
                string fname = textBoxFirstName.Text;
                string lname = textBoxLastName.Text;
                string uname = textBoxUserName.Text;
                string pass = textBoxPassWord.Text;
                string email = textBoxEmail.Text;
                MemoryStream pic = new MemoryStream();
                pictureBoxImage.Image.Save(pic, pictureBoxImage.Image.RawFormat);

                if (user.CheckUserHumanResourceName(uname) && user.CheckUserHumanResourceID(id))
                {
                    if (textBoxPassWord.Text != textBoxConfirmPW.Text)
                    {
                        MessageBox.Show("Password does not match!!", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (IsValidEmail(email))
                    {
                        string pin = RANDOM_PIN_GENERATOR.GenerateRandomPIN(6); // Tạo ra mã PIN ngẫu nhiên gồm 6 chữ số
                        string subject = "Mã xác nhận đăng ký";
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
                            MessageBox.Show("Code Successfully Send", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MessageBox.Show("Enter PIN from email", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            EnterPINCodeForm.role = "human resource";
                            EnterPINCodeForm enterPin = new EnterPINCodeForm(pin, id, fname, lname, uname, pass, email, pic);
                            enterPin.ShowDialog(this);
                        }
                        catch
                        {
                            MessageBox.Show("Code Unsuccessfully Send", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email Not Correct!", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("UserName or ID Existed!", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // chuc nang kiem tra du lieu input
        bool verif()
        {
            if ((textBoxUserName.Text.Trim() == "")
                || (textBoxPassWord.Text.Trim() == "")
                || (textBoxConfirmPW.Text.Trim() == "")
                || (textBoxID.Text.Trim() == "")
                || (textBoxFirstName.Text.Trim() == "")
                || (textBoxLastName.Text.Trim() == "")
                || (pictureBoxImage.Image == null)
                || (textBoxEmail.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
