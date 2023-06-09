using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;

namespace _20142178_TranManhHuy_QLSV
{
    public partial class EnterPINCodeForm : Form
    {
        public EnterPINCodeForm()
        {
            InitializeComponent();
        }
        USER user = new USER();
        string pincode;
        string idStd;
        string username;
        string password;
        string emailuser;
        public static string role;

        public EnterPINCodeForm(string id, string pin, string uname, string pass, string email)
        {
            pincode = pin;
            username = uname;
            password = pass;
            emailuser = email;
            idStd = id;
            InitializeComponent();
        }

        string firstname;
        string lastname;
        string idHr;
        MemoryStream picture = new MemoryStream();
        public EnterPINCodeForm(string pin, string id, string fname, string lname, string uname, string pass, string email, MemoryStream pic)
        {
            pincode = pin;
            firstname = fname;
            lastname = lname;
            username = uname;
            password = pass;
            emailuser = email;
            idHr = id;
            picture = pic;
            InitializeComponent();
        }
        private void btnEnterPINCode_Click(object sender, EventArgs e)
        {
            if (role == "student")
            {
                if (textBoxPINCode.Text == pincode)
                {
                    user.insertTempUser(idStd, username, password, emailuser);
                    MessageBox.Show("sign Up Successfully! , Please Wait For Admin To Accept", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                    Login_Form login = new Login_Form();
                    login.Show(this);
                }
                else
                {
                    MessageBox.Show("PIN Code Not Correct!", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPINCode.Text = "";
                }
            }

            else if (role == "human resource")
            {
                if (textBoxPINCode.Text == pincode)
                {
                    user.insertTempHumanResource(idHr, firstname, lastname, username, password, emailuser, picture);
                    MessageBox.Show("sign Up Successfully! , Please Wait For Admin To Accept", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                    Login_Form login = new Login_Form();
                    login.Show(this);
                }
                else
                {
                    MessageBox.Show("PIN Code Not Correct!", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPINCode.Text = "";
                }
            }
            else if (role == "contact")
            {
                if (textBoxPINCode.Text == pincode)
                {
                    user.insertTempContact(idStd, username, password, emailuser);
                    MessageBox.Show("sign Up Successfully! , Please Wait For Admin To Accept", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                    Login_Form login = new Login_Form();
                    login.Show(this);
                }
                else
                {
                    MessageBox.Show("PIN Code Not Correct!", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPINCode.Text = "";
                }
            }
        }

        private void btnSendPINAgain_Click(object sender, EventArgs e)
        {
            string pin = RANDOM_PIN_GENERATOR.GenerateRandomPIN(6); // Tạo ra mã PIN ngẫu nhiên gồm 6 chữ số
            pincode = pin;
            string subject = "Mã xác nhận đăng ký";
            string body = $"Mã xác nhận của bạn là {pin}";

            // Thông tin tài khoản email gửi
            string fromEmail = "test24072002@gmail.com";
            string fromPassword = "kcsxsxfgaojfhuzp";

            MailMessage message = new MailMessage(fromEmail, emailuser, subject, body);
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(fromEmail, fromPassword);

            // Gửi email
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Successfully Send", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPINCode.Text = "";

            }
            catch
            {
                MessageBox.Show("Code Unsuccessfully Send", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }              
    }
}
