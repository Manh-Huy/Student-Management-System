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
using System.Windows.Input;
using System.Xml.Linq;

namespace _20142178_TranManhHuy_QLSV
{
    public partial class StudentAddCourseForm : Form
    {
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();
        string studentID;
        string firstName;
        string lastName;
        public StudentAddCourseForm()
        {
            InitializeComponent();
        }

        public StudentAddCourseForm(string stdId, string fname, string lastname)
        {
            studentID = stdId;
            firstName = fname;
            lastName = lastname;
            InitializeComponent();
        }

        private void StudentAddCourseForm_Load(object sender, EventArgs e)
        {
            textBoxStudentID.Text = studentID;
            textBoxFirstName.Text = firstName;
            textBoxLastName.Text = lastName;

            ////// dùng combo box lấy semester
            ////comboBoxSelectSemester.DataSource = course.getAllSemester();
            ////comboBoxSelectSemester.DisplayMember = "semester";
            ////comboBoxSelectSemester.SelectedItem = null;

            mydb.openConnection();
            SqlCommand command = new SqlCommand("SELECT DISTINCT semester FROM Course", mydb.getConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxSelectSemester.Items.Add(reader.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
            }

            reader.Close();
            command.Dispose();
            mydb.closeConnection();
        }

        private void comboBoxSelectSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxAvailableCourses.Items.Clear(); // xóa tất cả dữ liệu cũ trước khi đổ dữ liệu mới vào

            mydb.openConnection();

            string semester = comboBoxSelectSemester.Text;

            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE semester = '" + semester + "'", mydb.getConnection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            { // kiểm tra xem SqlDataReader có chứa dữ liệu hay không
                while (reader.Read())
                {
                    string courseName = reader.GetString(1);
                    ListBoxAvailableCourses.Items.Add(courseName);
                }
            }

            reader.Close();
            command.Dispose();
            mydb.closeConnection();
        }

        private void ListBoxAvailableCourses_DoubleClick(object sender, EventArgs e)
        {
            int count = 0;
            string courseName = ListBoxAvailableCourses.Text;

            foreach (var item in ListBoxSelectedCourses.Items)
            {
                if (courseName == item.ToString())
                {
                    count++;
                    break;
                }
            }

            if (count > 0)
            {
                MessageBox.Show("You Have Been Choosed This Course", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ListBoxSelectedCourses.Items.Add(courseName);
            }
        }

        private void ListBoxSelectedCourses_DoubleClick(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            string selectedItem = listBox.SelectedItem.ToString();
            ListBoxSelectedCourses.Items.Remove(selectedItem);
        }

        private void btnAddScourse_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (ListBoxSelectedCourses.Items.Count == 0)
            {
                MessageBox.Show("Please Choose Course To Add", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var item in ListBoxSelectedCourses.Items)
            {
                string courseName = item.ToString();

                SqlCommand selectSimilarCourseCommand = new SqlCommand("SELECT * FROM CourseStudent WHERE courseName = '" + courseName + "' AND studentId = '" + studentID + "'", mydb.getConnection);

                mydb.openConnection();

                DataTable table = course.getCourses(selectSimilarCourseCommand);

                if (table.Rows.Count > 0)   // kiểm tra xem khóa học đã đăng kí trước đó chưa
                {
                    MessageBox.Show("The Course " + courseName + " Is Added", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand selectSemesterCommand = new SqlCommand("SELECT semester FROM Course WHERE label = '" + courseName + "'", mydb.getConnection);

                    string semester = selectSemesterCommand.ExecuteScalar().ToString();

                    SqlCommand insertCommand = new SqlCommand("INSERT INTO CourseStudent (studentId, fname, lname, courseName, semester) VALUES (@id, @fname, @lname, @label, @semester)", mydb.getConnection);

                    insertCommand.Parameters.Add("@id", SqlDbType.Int).Value = studentID;
                    insertCommand.Parameters.Add("@fname", SqlDbType.NVarChar).Value = firstName;
                    insertCommand.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lastName;
                    insertCommand.Parameters.Add("@label", SqlDbType.NVarChar).Value = courseName;
                    insertCommand.Parameters.Add("@semester", SqlDbType.NVarChar).Value = semester;

                    if ((insertCommand.ExecuteNonQuery() == 1))
                    {
                        temp++;
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                        return;
                    }
                }
            }

            if (temp > 0)
            {
                MessageBox.Show("The Course(s) Have Been Added!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // cập nhật dữ liệu vào bảng Std
                string selectedCourse = "";
                SqlCommand command = new SqlCommand("SELECT courseName FROM CourseStudent WHERE studentId = '" + studentID + "'", mydb.getConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string nameCourseAdded = reader.GetString(0);
                    selectedCourse += nameCourseAdded;
                    selectedCourse += " ";
                }

                command.Dispose();
                reader.Close();

                SqlCommand updateStdCommand = new SqlCommand("UPDATE Std SET selected_Course = '" + selectedCourse + "' WHERE id = '" + studentID + "'", mydb.getConnection);
                updateStdCommand.ExecuteNonQuery();
            }
            mydb.closeConnection();
        }

        private void btnViewAddedCourse_Click(object sender, EventArgs e)
        {
            StudentViewAddedCourseForm StdAddCour = new StudentViewAddedCourseForm(studentID, firstName, lastName);
            StdAddCour.Show(this);
        }

        private void btnShowTimetable_Click(object sender, EventArgs e)
        {
            TimetableStudentForm TimetableStudentF = new TimetableStudentForm(studentID, firstName, lastName);
            TimetableStudentF.Show(this);
        }
    }
}
