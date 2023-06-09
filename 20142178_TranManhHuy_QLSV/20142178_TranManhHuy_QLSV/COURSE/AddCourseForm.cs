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
    public partial class AddCourseForm : Form
    {
        string contactID;
        MY_DB mydb = new MY_DB();
        public AddCourseForm()
        {
            InitializeComponent();
        }
        public AddCourseForm(string id)
        {
            contactID = id;
            InitializeComponent();
        }
        private void AddCourseForm_Load(object sender, EventArgs e)
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
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (verif() == false)
            {
                MessageBox.Show("Empty Fields", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // check if the name is not empty
            // check if this course already exists
            // the course hours number must be > 10, we can do it from the numericDropDown Tool,
            // or by using the if condition
            // the description is optional
            int Cid = Convert.ToInt32(textBoxCourseID.Text);
            string name = textBoxLabel.Text;
            string groupName = comboBoxGroup.Text;
            string contactID = textBoxContactID.Text;
            int hrs = Convert.ToInt32(textBoxPeriod.Text);
            string semes = textBoxSemester.Text;
            string day = comboBoxDay.Text;
            int classPeriodStart = Convert.ToInt32(textBoxClassPeriodStart.Text);
            int classPeriodEnd = Convert.ToInt32(textBoxClassPeriodEnd.Text);
            string descr = textBoxDescription.Text;

            COURSE course = new COURSE();
            if (name.Trim() == "") // lam viec với string xóa hết các khoảng trắng, trước sau chỉ lấy tên // có hàm verif rồi nên không cần
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.checkCourseName(name))
            {
                try
                {
                    if (course.insertCourse(Cid, name, groupName, contactID, hrs, semes, day, classPeriodStart, classPeriodEnd, descr))
                    {
                        MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Số lỗi cho lỗi ràng buộc khóa chính
                    {
                        MessageBox.Show("ID Course Already Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if ((textBoxCourseID.Text.Trim() == "")
                || (textBoxLabel.Text.Trim() == "")
                || (comboBoxGroup.Text.Trim() == "")
                || (textBoxContactID.Text.Trim() == "")
                || (textBoxPeriod.Text.Trim() == "")
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
