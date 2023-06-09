using Microsoft.Office.Interop.Word;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace _20142178_TranManhHuy_QLSV
{
    public partial class ContactHistoryNotificationSent : Form
    {
        CONTACT contact = new CONTACT();
        MY_DB mydb = new MY_DB();
        bool isAddingItem = false;
        string contactID;
        string fullName;
        public ContactHistoryNotificationSent()
        {
            InitializeComponent();
        }
        public ContactHistoryNotificationSent(string contactid, string fullname)
        {
            contactID = contactid;
            fullName = fullname;
            InitializeComponent();
        }
        public void getImageAbdUsername()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table = new System.Data.DataTable();

            SqlCommand command = new SqlCommand("SELECT MyContact.*, Log_in_Contact.* FROM MyContact INNER JOIN Log_in_Contact ON contactID = Id WHERE contactID = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = Global.GlobalUserID;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxHr.Image = Image.FromStream(picture);

                lblWelcomeHr.Text = "Welcome Back (" + table.Rows[0]["username"].ToString() + ")";
            }
        }

        private void ContactHistoryNotificationSent_Load(object sender, EventArgs e)
        {
            getImageAbdUsername();

            isAddingItem = true;
            comboBoxSemesterInNotification.Items.Add("All");
            comboBoxSemesterInNotification.Text = "All";
            isAddingItem = false;

            mydb.openConnection();
            SqlCommand commandSemesterNotification = new SqlCommand("SELECT DISTINCT semester FROM Course", mydb.getConnection);
            SqlDataReader readerNotification = commandSemesterNotification.ExecuteReader();
            while (readerNotification.Read())
            {
                comboBoxSemesterInNotification.Items.Add(readerNotification.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
            }

            readerNotification.Close();
            commandSemesterNotification.Dispose();

            mydb.openConnection();
            SqlCommand commandCourseNotification = new SqlCommand("SELECT label FROM Course WHERE contactID = '" + contactID + "'", mydb.getConnection);
            SqlDataReader readerCourse = commandCourseNotification.ExecuteReader();
            while (readerCourse.Read())
            {
                comboBoxCourseinNotification.Items.Add(readerCourse.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
            }

            readerCourse.Close();
            commandCourseNotification.Dispose();

            SqlCommand command = new SqlCommand("SELECT Notification.id AS STT, courseName AS [Course Name], title AS [Title], timeSend AS [Time Send] FROM Notification WHERE contactID = '" + contactID + "'");
            fillGrid(command);
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridViewNotificationList.ReadOnly = true;
            dataGridViewNotificationList.DataSource = contact.getContacts(command);
            dataGridViewNotificationList.AllowUserToAddRows = false;
        }

        private void comboBoxSemesterInNotification_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isAddingItem)
            {
                return;
            }
            comboBoxCourseinNotification.Items.Clear();
            comboBoxCourseinNotification.ResetText();

            if (comboBoxSemesterInNotification.Text == "All")
            {
                mydb.openConnection();
                SqlCommand commandCourseNotification = new SqlCommand("SELECT label FROM Course WHERE contactID = '" + contactID + "'", mydb.getConnection);
                SqlDataReader readerCourse = commandCourseNotification.ExecuteReader();
                while (readerCourse.Read())
                {
                    comboBoxCourseinNotification.Items.Add(readerCourse.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
                }

                readerCourse.Close();
                commandCourseNotification.Dispose();
            }
            else
            {
                string semester = comboBoxSemesterInNotification.Text;
                mydb.openConnection();
                SqlCommand commandCourseNotification = new SqlCommand("SELECT label FROM Course WHERE contactID = '" + contactID + "' AND semester = '" + semester + "'", mydb.getConnection);
                SqlDataReader readerCourse = commandCourseNotification.ExecuteReader();
                while (readerCourse.Read())
                {
                    comboBoxCourseinNotification.Items.Add(readerCourse.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
                }

                readerCourse.Close();
                commandCourseNotification.Dispose();
            }
        }
        private void comboBoxCourseinNotification_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseName = comboBoxCourseinNotification.Text;
            SqlCommand command = new SqlCommand("SELECT Notification.id AS STT, courseName AS [Course Name], title AS [Title], timeSend AS [Time Send] FROM Notification WHERE contactID = '" + contactID + "' AND courseName = '" + courseName + "'");
            fillGrid(command);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dataGridViewNotificationList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Course!", "Select Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dataGridViewNotificationList.SelectedRows[0].Cells["STT"].Value;

            mydb.openConnection();

            SqlCommand command = new SqlCommand("SELECT content FROM Notification WHERE id = " + id, mydb.getConnection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            { // kiểm tra xem SqlDataReader có chứa dữ liệu hay không
                while (reader.Read())
                {
                    textBoxContent.Text = reader.GetString(0);
                }
            }

            reader.Close();
            command.Dispose();
            mydb.closeConnection();
        }

        private void btnShowAllCourse_Click(object sender, EventArgs e)
        {
            string semester = comboBoxSemesterInNotification.Text;
            if (semester == "All")
            {
                SqlCommand command = new SqlCommand("SELECT Notification.id AS STT, courseName AS [Course Name], title AS [Title], timeSend AS [Time Send] FROM Notification WHERE contactID = '" + contactID + "'");
                fillGrid(command);
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT Notification.id AS STT, courseName AS [Course Name], title AS [Title], timeSend AS [Time Send] FROM Notification INNER JOIN Course ON Course.label = Notification.courseName WHERE Notification.contactID = '" + contactID + "' AND Course.semester = '" + semester + "'");
                fillGrid(command);
            }
        }
    }
}
