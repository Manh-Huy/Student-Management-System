using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20142178_TranManhHuy_QLSV
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            db.closeConnection();

            if (radioButtonStudent.Checked == true)
            {
                string userAdmin = textBoxUserName.Text;
                string passAdmin = textBoxPassWord.Text;

                if (userAdmin == "admin" && passAdmin == "admin")
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    DataTable table = new DataTable();

                    SqlCommand command = new SqlCommand("SELECT * FROM Log_in WHERE username = @User AND password = @Pass", db.getConnection);

                    command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUserName.Text;
                    command.Parameters.Add("Pass", SqlDbType.VarChar).Value = textBoxPassWord.Text;

                    adapter.SelectCommand = command;

                    adapter.Fill(table);

                    // xác nhận user đang chờ admin xác nhận
                    SqlDataAdapter adapterTempUser = new SqlDataAdapter();

                    DataTable tableTempUser = new DataTable();

                    SqlCommand commandTempUser = new SqlCommand("SELECT * FROM Temp_Log_in WHERE username = @User AND password = @Pass", db.getConnection);

                    commandTempUser.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUserName.Text;
                    commandTempUser.Parameters.Add("Pass", SqlDbType.VarChar).Value = textBoxPassWord.Text;

                    adapterTempUser.SelectCommand = commandTempUser;

                    adapterTempUser.Fill(tableTempUser);

                    if ((table.Rows.Count > 0))
                    {
                        //MessageBox.Show("OK, next time will be go to Main Menu of App");
                        //this.DialogResult = DialogResult.OK;

                        //MainForm MainF = new MainForm(textBoxUserName.Text, textBoxPassWord.Text);
                        //MainF.Show(this);

                        string idStudent = table.Rows[0][0].ToString();
                        Global.SetGlobalUserId(idStudent);
                        StudentMainForm StdMainF = new StudentMainForm();
                        StdMainF.Show(this);
                    }
                    else if ((tableTempUser.Rows.Count > 0))
                    {
                        MessageBox.Show("Sorry, Please Wait For Admin To Accept", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (radioButtonHr.Checked == true)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand("SELECT * FROM HumanResource WHERE username = @User AND password = @Pass", db.getConnection);

                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUserName.Text;
                command.Parameters.Add("Pass", SqlDbType.VarChar).Value = textBoxPassWord.Text;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                // xác nhận user đang chờ admin xác nhận
                SqlDataAdapter adapterTempUser = new SqlDataAdapter();

                DataTable tableTempUser = new DataTable();

                SqlCommand commandTempUser = new SqlCommand("SELECT * FROM Temp_HumanResource WHERE username = @User AND password = @Pass", db.getConnection);

                commandTempUser.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUserName.Text;
                commandTempUser.Parameters.Add("Pass", SqlDbType.VarChar).Value = textBoxPassWord.Text;

                adapterTempUser.SelectCommand = commandTempUser;

                adapterTempUser.Fill(tableTempUser);

                if ((table.Rows.Count > 0))
                {
                    string idHr = table.Rows[0][0].ToString();
                    Global.SetGlobalUserId(idHr);
                    HumanResourceMainForm HrMainF = new HumanResourceMainForm();
                    HrMainF.Show(this);
                }
                else if ((tableTempUser.Rows.Count > 0))
                {
                    MessageBox.Show("Sorry, Please Wait For Admin To Accept", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButtonAdmin.Checked == true)
            {
                if (textBoxUserName.Text == "admin" && textBoxPassWord.Text == "admin")
                {
                    MainForm MainF = new MainForm(textBoxUserName.Text, textBoxPassWord.Text);
                    MainF.Show(this);
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //SqlDataAdapter adapter = new SqlDataAdapter();

                //DataTable table = new DataTable();

                //SqlCommand command = new SqlCommand("SELECT * FROM Log_in WHERE username = @User AND password = @Pass", db.getConnection);

                //command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUserName.Text;
                //command.Parameters.Add("Pass", SqlDbType.VarChar).Value = textBoxPassWord.Text;

                //adapter.SelectCommand = command;

                //adapter.Fill(table);

                //if ((table.Rows.Count > 0))
                //{
                //    //MessageBox.Show("OK, next time will be go to Main Menu of App");
                //    //this.DialogResult = DialogResult.OK;

                //    MainForm MainF = new MainForm(textBoxUserName.Text, textBoxPassWord.Text);
                //    MainF.Show(this);
                //}
                //else
                //{
                //    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            else if (radioButtonTeacher.Checked == true)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand("SELECT * FROM Log_in_Contact WHERE username = @User AND password = @Pass", db.getConnection);

                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUserName.Text;
                command.Parameters.Add("Pass", SqlDbType.VarChar).Value = textBoxPassWord.Text;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                // xác nhận user đang chờ admin xác nhận
                SqlDataAdapter adapterTempUser = new SqlDataAdapter();

                DataTable tableTempUser = new DataTable();

                SqlCommand commandTempUser = new SqlCommand("SELECT * FROM Temp_Log_in_Contact WHERE username = @User AND password = @Pass", db.getConnection);

                commandTempUser.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUserName.Text;
                commandTempUser.Parameters.Add("Pass", SqlDbType.VarChar).Value = textBoxPassWord.Text;

                adapterTempUser.SelectCommand = commandTempUser;

                adapterTempUser.Fill(tableTempUser);

                if ((table.Rows.Count > 0))
                {
                    //MessageBox.Show("OK, next time will be go to Main Menu of App");
                    //this.DialogResult = DialogResult.OK;

                    string idContact = table.Rows[0][0].ToString();
                    Global.SetGlobalUserId(idContact);
                    ContactMainForm ContactMainF = new ContactMainForm();
                    ContactMainF.Show(this);
                }
                else if ((tableTempUser.Rows.Count > 0))
                {
                    MessageBox.Show("Sorry, Please Wait For Admin To Accept", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            db.closeConnection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            pictureBoxLogin.Image = Image.FromFile("../../images/login.jpg");
        }

        private void linkLabelNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (radioButtonStudent.Checked == true)
            {
                RegisterForm RegisterF = new RegisterForm();
                RegisterF.ShowDialog(this);
            }
            else if (radioButtonHr.Checked == true)
            {
                RegisterHRForm RegisterHrF = new RegisterHRForm();
                RegisterHrF.ShowDialog(this);
            }
            else if (radioButtonTeacher.Checked == true)
            {
                RegisterContactForm RegisterContactF = new RegisterContactForm();
                RegisterContactF.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Cannot Create Admin Account!", "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm ForgotPassF = new ForgotPasswordForm();
            ForgotPassF.ShowDialog(this);
        }
    }
}
