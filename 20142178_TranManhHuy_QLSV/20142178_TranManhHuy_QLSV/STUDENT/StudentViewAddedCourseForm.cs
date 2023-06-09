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
    public partial class StudentViewAddedCourseForm : Form
    {
        public StudentViewAddedCourseForm()
        {
            InitializeComponent();
        }

        COURSE course = new COURSE();
        MY_DB mydb = new MY_DB();
        string studentID;
        string firstName;
        string lastName;

        public StudentViewAddedCourseForm(string stdId, string fname, string lastname)
        {
            studentID = stdId;
            firstName = fname;
            lastName = lastname;
            InitializeComponent();
        }

        private void StudentViewAddedCourseForm_Load(object sender, EventArgs e)
        {
            textBoxStudentID.Text = studentID;
            textBoxFirstName.Text = firstName;
            textBoxLastName.Text = lastName;

            SqlCommand command = new SqlCommand("SELECT courseName AS [Course Name], semester AS Semester FROM CourseStudent WHERE studentId = '" + studentID + "'");
            fillGrid(command);
        }
        
        public void fillGrid(SqlCommand command)
        {
            dataGridViewStudentViewAddedCourse.ReadOnly = true;
            dataGridViewStudentViewAddedCourse.DataSource = course.getCourses(command);
            dataGridViewStudentViewAddedCourse.AllowUserToAddRows = false;
        }

        private void btnDeleteScourse_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có course nào được chọn hay không
            if (dataGridViewStudentViewAddedCourse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select At Least One Course To Delete!", "Delete Courses", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lặp qua từng hàng được chọn và xóa course
            foreach (DataGridViewRow row in dataGridViewStudentViewAddedCourse.SelectedRows)
            {
                string Id = textBoxStudentID.Text.ToString();
                string courseName = row.Cells["Course Name"].Value.ToString();

                SqlCommand sqlCommand = new SqlCommand("DELETE FROM CourseStudent WHERE studentId = @id AND courseName = @cour", mydb.getConnection);

                mydb.openConnection();

                sqlCommand.Parameters.AddWithValue("@id", Id);
                sqlCommand.Parameters.AddWithValue("@cour", courseName);

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("An Error Occurred While Deleting The Course " + courseName + ".", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Hiển thị thông báo khi xóa hoàn tất
            MessageBox.Show("Delete The Course Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh lại datagridview
            SqlCommand command = new SqlCommand("SELECT courseName AS [Course Name], semester AS Semester FROM CourseStudent WHERE studentId = '" + studentID + "'");
            dataGridViewStudentViewAddedCourse.ReadOnly = true;
            dataGridViewStudentViewAddedCourse.DataSource = course.getCourses(command);

            // cập nhật dữ liệu vào bảng Std
            string selectedCourse = "";
            SqlCommand selectcommand = new SqlCommand("SELECT courseName FROM CourseStudent WHERE studentId = '" + studentID + "'", mydb.getConnection);
            SqlDataReader reader = selectcommand.ExecuteReader();
            while (reader.Read())
            {
                string nameCourseAdded = reader.GetString(0);
                selectedCourse += nameCourseAdded;
                selectedCourse += " ";
            }

            selectcommand.Dispose();
            reader.Close();

            SqlCommand updateStdCommand = new SqlCommand("UPDATE Std SET selected_Course = '" + selectedCourse + "' WHERE id = '" + studentID + "'", mydb.getConnection);
            updateStdCommand.ExecuteNonQuery();

            mydb.closeConnection();
        }
    }
}
