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
    public partial class EditCourseForm : Form
    {
        MY_DB mydb = new MY_DB();
        public EditCourseForm()
        {
            InitializeComponent();
        }

        COURSE course = new COURSE();

        private void EditCourseForm_Load(object sender, EventArgs e)
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

            // dùng combo box lấy tên course
            comboBoxCourse.DataSource = course.getAllCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";
            comboBoxCourse.SelectedItem = null;
        }

        // courses name and id
        public void fillCombo(int index)
        {
            comboBoxCourse.DataSource = course.getAllCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";
            comboBoxCourse.SelectedIndex = index;
        }

        //khi selected index change
        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // lấy dữ liệu
                int id = Convert.ToInt32(comboBoxCourse.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCoursesById(id);
                textBoxCourseName.Text = table.Rows[0][1].ToString();
                comboBoxGroup.Text = table.Rows[0][2].ToString();
                textBoxContactID.Text = table.Rows[0][3].ToString();
                numericUpDownPeriod.Value = Int32.Parse(table.Rows[0][4].ToString());
                textBoxSemester.Text = table.Rows[0][5].ToString();
                comboBoxDay.Text = table.Rows[0][6].ToString();
                textBoxClassPeriodStart.Text = table.Rows[0][7].ToString();
                textBoxClassPeriodEnd.Text = table.Rows[0][8].ToString();
                textBoxTimeStart.Text = table.Rows[0][9].ToString();
                textBoxTimeEnd.Text = table.Rows[0][10].ToString();
                textBoxDescription.Text = table.Rows[0][11].ToString();
            }
            catch { }
        }
        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            if (verif() == false)
            {
                MessageBox.Show("Empty Fields", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string name = textBoxCourseName.Text;
            string groupName = comboBoxGroup.Text;
            string contactID = textBoxContactID.Text;
            int hours = (int)numericUpDownPeriod.Value;
            string description = textBoxDescription.Text;
            string semes = textBoxSemester.Text;
            int id = (int)comboBoxCourse.SelectedValue;
            string day = comboBoxDay.Text;
            int classPeriodStart = Convert.ToInt32(textBoxClassPeriodStart.Text);
            int classPeriodEnd = Convert.ToInt32(textBoxClassPeriodEnd.Text);

            if (!course.checkCourseName(name, Convert.ToInt32(comboBoxCourse.SelectedValue)))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, name, groupName, contactID, hours, semes, day, classPeriodStart, classPeriodEnd, description))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillCombo(comboBoxCourse.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Course Not Update", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            if ((comboBoxCourse.Text.Trim() == "")
                || (textBoxCourseName.Text.Trim() == "")
                || (comboBoxGroup.Text.Trim() == "")
                || (textBoxContactID.Text.Trim() == "")
                || (numericUpDownPeriod.Text.Trim() == "")
                || (textBoxSemester.Text.Trim() == "")
                || (comboBoxDay.Text.Trim() == "")
                || (textBoxClassPeriodStart.Text.Trim() == "")
                || (textBoxClassPeriodEnd.Text.Trim() == "")
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
