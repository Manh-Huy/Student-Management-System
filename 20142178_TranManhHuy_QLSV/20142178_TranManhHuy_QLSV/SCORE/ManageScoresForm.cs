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
    public partial class ManageScoresForm : Form
    {
        public ManageScoresForm()
        {
            InitializeComponent();
        }

        MY_DB mydb = new MY_DB();
        SCORE score = new SCORE();
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();
        string data = "score";

        private void ManageScoresForm_Load(object sender, EventArgs e)
        {
            // populate datagridview with students socres
            dataGridViewManageScore.DataSource = score.getStudentScore();

            // populate combobox with courses id and name
            comboBoxSelectCourse.DataSource = course.getAllCourses();
            comboBoxSelectCourse.DisplayMember = "label";
            comboBoxSelectCourse.ValueMember = "id";
        }

        private void btnShowScores_Click(object sender, EventArgs e)
        {
            data = "score";
            dataGridViewManageScore.DataSource = score.getStudentScore();
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            data = "std";
            SqlCommand command = new SqlCommand("SELECT id, fname,lname, bdate FROM Std");
            dataGridViewManageScore.DataSource = student.getStudents(command);
        }
        // tính năng thêm vào
        // method to get data from datagridview
        void getDataFromDatagridView()
        {
            // nếu người dùng chọn hiển thị dữ liệu sinh viên
            // Sau đó khi ta nhấp vào datagridview
            // nó sẽ chỉ hiển thị id sinh viên trong text
            if (data == "std")
            {
                textBoxStudentID.Text = dataGridViewManageScore.CurrentRow.Cells[0].Value.ToString();
                // sau khi click vào thì ở combobox chỉ hiện các course của sinh viên đang học
                comboBoxSelectCourse.DataSource = null;
                comboBoxSelectCourse.Items.Clear();
                SqlCommand stdCourseCommand = new SqlCommand("SELECT * FROM CourseStudent WHERE studentId = '" + textBoxStudentID.Text + "'");
                comboBoxSelectCourse.DataSource = course.getCourses(stdCourseCommand);
                comboBoxSelectCourse.DisplayMember = "courseName";
                comboBoxSelectCourse.ValueMember = "courseName";

                
            }
            // nếu người dùng chọn hiển thị dữ liệu điểm của sinh viên
            // sau đó khi ta bấm vào một datagridview
            // nó sẽ hiển thị id sinh viên trong text và khóa học trong combobox
            else if (data == "score")
            {
                textBoxStudentID.Text = dataGridViewManageScore.CurrentRow.Cells[0].Value.ToString();
                //comboBoxSelectCourse.SelectedValue = dataGridViewManageScore.CurrentRow.Cells[3].Value;

                // sau khi click vào thì ở combobox chỉ hiện các course của sinh viên đang học
                comboBoxSelectCourse.DataSource = null;
                comboBoxSelectCourse.Items.Clear();
                SqlCommand stdCourseCommand = new SqlCommand("SELECT * FROM CourseStudent WHERE studentId = '" + textBoxStudentID.Text + "'");
                comboBoxSelectCourse.DataSource = course.getCourses(stdCourseCommand);
                comboBoxSelectCourse.DisplayMember = "courseName";
                comboBoxSelectCourse.ValueMember = "courseName";
            }
        }

        // on datagridview click --> get data to fields
        private void dataGridViewManageScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDatagridView();
        }

        // open a new form -> show the average score by course
        // tương tự Student, có thêm hàm tính trung bình, và vẽ đồ thị vào form
        private void btnAverageScoreByCourse_Click(object sender, EventArgs e)
        {
            AvgScoreByCourseForm avgScoreByCourseF = new AvgScoreByCourseForm();
            avgScoreByCourseF.Show(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string studentID = textBoxStudentID.Text;
                //int courseID = Convert.ToInt32(comboBoxSelectCourse.SelectedValue);

                // lấy courseId
                int courseID = 0;
                string courseName = comboBoxSelectCourse.SelectedValue.ToString();

                SqlCommand takeCourseIdCommand = new SqlCommand("SELECT * FROM Course WHERE label = '" + courseName + "'", mydb.getConnection);
                mydb.openConnection();
                SqlDataReader reader = takeCourseIdCommand.ExecuteReader();
                while (reader.Read())
                {
                    courseID = reader.GetInt32(0);
                }

                if (courseID == 0)
                {
                    MessageBox.Show("Error!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                takeCourseIdCommand.Dispose();
                reader.Close();

                float scoreValue = Convert.ToInt32(textBoxScore.Text);
                string description = textDescription.Text;

                if (!score.studentScoreExist(studentID, courseID))
                {
                    if (score.insertScore(studentID, courseID, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                mydb.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string studentID = dataGridViewManageScore.CurrentRow.Cells[0].Value.ToString();
            int courseID = Convert.ToInt32(dataGridViewManageScore.CurrentRow.Cells[3].Value.ToString());

            if ((MessageBox.Show("Are you sure you want to delete this score", "Remove score", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                if (score.deleteScore(studentID, courseID))
                {
                    MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewManageScore.DataSource = score.getStudentScore();
                }
                else
                {
                    MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
