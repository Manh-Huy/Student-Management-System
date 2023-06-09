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
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }

        MY_DB mydb = new MY_DB();
        SCORE score = new SCORE();
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            comboBoxSelectCourse.DataSource = course.getAllCourses();
            comboBoxSelectCourse.DisplayMember = "label";
            comboBoxSelectCourse.ValueMember = "id";

            SqlCommand command = new SqlCommand("SELECT id AS ID, fname AS [First Name], lname AS [Last Name] FROM Std");
            dataGridViewScoreList.DataSource = student.getStudents(command);
        }

        private void dataGridViewScoreList_Click(object sender, EventArgs e)
        {
            textBoxStudentID.Text = dataGridViewScoreList.CurrentRow.Cells[0].Value.ToString();

            SqlCommand stdCourseCommand = new SqlCommand("SELECT * FROM CourseStudent WHERE studentId = '" + textBoxStudentID.Text + "'");
            comboBoxSelectCourse.DataSource = null;
            comboBoxSelectCourse.Items.Clear();
            comboBoxSelectCourse.DataSource = course.getCourses(stdCourseCommand);
            comboBoxSelectCourse.DisplayMember = "courseName";
            comboBoxSelectCourse.ValueMember = "courseName";
        }

        private void btnAddScore_Click(object sender, EventArgs e)
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

                float scoreValue = float.Parse(textBoxScore.Text);
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
    }
}
