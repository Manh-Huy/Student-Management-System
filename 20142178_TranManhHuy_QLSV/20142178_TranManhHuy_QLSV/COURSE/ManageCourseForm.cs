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
    public partial class ManageCourseForm : Form
    {
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        COURSE course = new COURSE();
        MY_DB mydb = new MY_DB();
        int pos;

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            mydb.openConnection();
            SqlCommand selectGroupCommand = new SqlCommand("SELECT DISTINCT nameGroup FROM [Group]", mydb.getConnection);
            SqlDataReader reader = selectGroupCommand.ExecuteReader();
            while (reader.Read())
            {
                comboBoxGroup.Items.Add(reader.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
            }

            reader.Close();
            selectGroupCommand.Dispose();
            mydb.closeConnection();
            reloadListBoxData();
        }
        void reloadListBoxData()
        {
            ListBoxCourses.DataSource = course.getAllCourses();
            ListBoxCourses.DisplayMember = "label";
            ListBoxCourses.ValueMember = "id";
            ListBoxCourses.SelectedItem = null;

            lblTotalCourses.Text = ("Total Courses: " + course.totalCourses());
        }

        // dung lay data theo chi muc index, dùng datarow để lấy dữ liệu hàng của table
        void showData(int index)
        {
            DataRow dr = course.getAllCourses().Rows[index];

            ListBoxCourses.SelectedIndex = index;

            textBoxCourseID.Text = dr.ItemArray[0].ToString();

            textBoxLabel.Text = dr.ItemArray[1].ToString();

            comboBoxGroup.Text = dr.ItemArray[2].ToString();

            textBoxContactID.Text = dr.ItemArray[3].ToString();

            numericUpDownPeriod.Value = int.Parse(dr.ItemArray[4].ToString());

            textBoxSemester.Text = dr.ItemArray[5].ToString();
            
            comboBoxDay.Text = dr.ItemArray[6].ToString();

            textBoxClassPeriodStart.Text = dr.ItemArray[7].ToString();

            textBoxClassPeriodEnd.Text = dr.ItemArray[8].ToString();

            textBoxTimeStart.Text = dr.ItemArray[9].ToString();

            textBoxTimeEnd.Text = dr.ItemArray[10].ToString();

            textBoxDescription.Text = dr.ItemArray[11].ToString();
        }

        private void ListBoxCourses_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)ListBoxCourses.SelectedItem;
            pos = ListBoxCourses.SelectedIndex;
            showData(pos);
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (verif() == false)
            {
                MessageBox.Show("Empty Fields", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(textBoxCourseID.Text);
            string label = textBoxLabel.Text;
            string groupName = comboBoxGroup.Text;
            string contactID = textBoxContactID.Text;
            int hours = (int)numericUpDownPeriod.Value;
            string semester = textBoxSemester.Text;
            string description = textBoxDescription.Text;
            string day = comboBoxDay.Text;
            int classPeriodStart = Convert.ToInt32(textBoxClassPeriodStart.Text);
            int classPeriodEnd = Convert.ToInt32(textBoxClassPeriodEnd.Text);
            COURSE course = new COURSE();

            if (label.Trim() == "") // có hàm verif() nên không cần kiểm tra cái này
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.checkCourseName(label))
            {
                if (course.insertCourse(id, label, groupName, contactID, hours, semester, day, classPeriodStart, classPeriodEnd, description))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (verif() == false)
            {
                MessageBox.Show("Empty Fields", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(textBoxCourseID.Text);
            string label = textBoxLabel.Text;
            string groupName = comboBoxGroup.Text;
            string contactID = textBoxContactID.Text;
            int hours = (int)numericUpDownPeriod.Value;
            string semester = textBoxSemester.Text;
            string day = comboBoxDay.Text;
            int classPeriodStart = Convert.ToInt32(textBoxClassPeriodStart.Text);
            int classPeriodEnd = Convert.ToInt32(textBoxClassPeriodEnd.Text);
            string description = textBoxDescription.Text;


            if (!course.checkCourseName(label, Convert.ToInt32(textBoxCourseID.Text)))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, label, groupName, contactID, hours, semester, day, classPeriodStart, classPeriodEnd, description))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadListBoxData();
            }
            else
            {
                MessageBox.Show("Course Not Update", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int courseID = Convert.ToInt32(textBoxCourseID.Text);
                if (MessageBox.Show("Are You Sure Want To Delete This Course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Enter A Valid Numeric ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pos < (course.getAllCourses().Rows.Count - 1))
            {
                pos++;
                showData(pos);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos--;
                showData(pos);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourses().Rows.Count - 1;
            showData(pos);
        }

        private void ListBoxCourses_DoubleClick(object sender, EventArgs e)
        {
            string namecourse = textBoxLabel.Text;
            string semester = textBoxSemester.Text;
            CourseStudentListForm CourStdListF = new CourseStudentListForm(namecourse, semester);
            CourStdListF.Show(this);
        }

        private void btnSearchContact_Click(object sender, EventArgs e)
        {
            if (comboBoxGroup.Text == null)
            {
                MessageBox.Show("Please Choose Group Contact!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                InfoContactByGroupForm InfoContactByGroupForm = new InfoContactByGroupForm(comboBoxGroup.Text);
                InfoContactByGroupForm.ShowDialog();
                string contactID = InfoContactByGroupForm.ContactID;
                textBoxContactID.Text = contactID;
            }
        }

        // chuc nang kiem tra du lieu input
        bool verif()
        {
            if ((textBoxCourseID.Text.Trim() == "")
                || (textBoxLabel.Text.Trim() == "")
                || (comboBoxGroup.Text.Trim() == "")
                || (textBoxContactID.Text.Trim() == "")
                || (numericUpDownPeriod.Text.Trim() == "")
                || (textBoxSemester.Text.Trim() == "")
                || (textBoxDescription.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
