using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20142178_TranManhHuy_QLSV
{
    public partial class ManageStudentsForm : Form
    {
        public ManageStudentsForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        string selectStdCommand = "SELECT stt AS STT, id AS ID, fname AS [First Name], lname AS [Last Name], bdate AS BirthDate, gender AS Gender, phone AS Phone, address AS [Address], faculty AS Faculty, major AS Major, hometown AS Hometown, acayear AS [Academic Year], email AS Email, picture AS Picture, selected_Course AS [Selected Course] FROM Std";

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand(selectStdCommand));

            // dùng combo box lấy tên các niên khóa
            comboBoxFAcaYear.DataSource = student.getAcayear();
            comboBoxFAcaYear.DisplayMember = "acayear";
            //comboBoxAcaYear.ValueMember = "id";
            comboBoxFAcaYear.SelectedItem = null;

            // dùng combo box lấy tên khoa
            comboBoxFFaculty.DataSource = student.getFaculty();
            comboBoxFFaculty.DisplayMember = "faculty";
            //comboBoxFaculty.ValueMember = "id";
            comboBoxFFaculty.SelectedItem = null;

            // dùng combo box lấy tên ngành
            comboBoxFMajor.DataSource = student.getMajor();
            comboBoxFMajor.DisplayMember = "major";
            //comboBoxMajor.ValueMember = "id";
            comboBoxFMajor.SelectedItem = null;
        }

        // copy lai phan truoc de nap data
        public void fillGrid(SqlCommand command)
        {
            dataGridViewStudentList.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewStudentList.RowTemplate.Height = 80;
            dataGridViewStudentList.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridViewStudentList.Columns[13];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewStudentList.AllowUserToAddRows = false;

            // dem sinh vien
            lblTotal.Text = ("Total Students: " + dataGridViewStudentList.Rows.Count);
        }

        private void dataGridViewStudentList_Click(object sender, EventArgs e)
        {
            textBoxStudentID.Text = dataGridViewStudentList.CurrentRow.Cells[1].Value.ToString();
            textBoxFirstName.Text = dataGridViewStudentList.CurrentRow.Cells[2].Value.ToString();
            textBoxLastName.Text = dataGridViewStudentList.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerBirthDay.Value = (DateTime)dataGridViewStudentList.CurrentRow.Cells[4].Value;

            //gender
            if ((dataGridViewStudentList.CurrentRow.Cells[5].Value.ToString().Trim() == "Female"))
            {
                radioButtonFemale.Checked = true;
            }
            else
            {
                radioButtonMale.Checked = true;
            }

            textBoxPhone.Text = dataGridViewStudentList.CurrentRow.Cells[6].Value.ToString();
            textBoxAddress.Text = dataGridViewStudentList.CurrentRow.Cells[7].Value.ToString();
            textBoxFaculty.Text = dataGridViewStudentList.CurrentRow.Cells[8].Value.ToString();
            textBoxMajor.Text = dataGridViewStudentList.CurrentRow.Cells[9].Value.ToString();
            textBoxHomeTown.Text = dataGridViewStudentList.CurrentRow.Cells[10].Value.ToString();
            textBoxAcaYear.Text = dataGridViewStudentList.CurrentRow.Cells[11].Value.ToString();
            textBoxEmail.Text = dataGridViewStudentList.CurrentRow.Cells[12].Value.ToString();

            // image
            byte[] pic;
            pic = (byte[])dataGridViewStudentList.CurrentRow.Cells[13].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxImage.Image = Image.FromStream(picture);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //string query = "SELECT * FROM Std WHERE";
            string query = selectStdCommand + " WHERE";
            string temp = query;

            // kiểm tra câu lệnh query có thay đổi không (nhập nhiều hơn 1 tính năng để tìm kiếm)
            void checkQueryChange()
            {
                if (query != temp)
                {
                    query += " AND";
                }
            }

            //textbox ID
            if (!string.IsNullOrEmpty(textBoxFID.Text))
            {
                string id = textBoxFID.Text;
                query += " id = " + id;
            }

            //textbox FirstName
            if (!string.IsNullOrEmpty(textBoxFFirstName.Text))
            {
                checkQueryChange();

                string fname = textBoxFFirstName.Text;
                query += " fname = '" + fname + "'";
            }

            //textbox LastName
            if (!string.IsNullOrEmpty(textBoxFLastName.Text))
            {
                checkQueryChange();

                string lname = textBoxFLastName.Text;
                query += " lname = '" + lname + "'";
            }

            //radiobutton Male
            if (radioButtonFindMale.Checked)
            {
                checkQueryChange();

                string gender = "Male";
                query += " gender = '" + gender + "'";
            }

            //radiobutton Female
            if (radioButtonFindFemale.Checked)
            {
                checkQueryChange();

                string gender = "Female";
                query += " gender = '" + gender + "'";
            }

            //textbox Address
            if (!string.IsNullOrEmpty(textBoxFAddress.Text))
            {
                checkQueryChange();

                string address = textBoxFAddress.Text;
                query += " address = '" + address + "'";
            }

            // comboBox Faculty
            if (!string.IsNullOrEmpty(comboBoxFFaculty.Text))
            {
                checkQueryChange();

                string faculty = comboBoxFFaculty.Text;
                query += " faculty = '" + faculty + "'";
            }

            // comboBox Major
            if (!string.IsNullOrEmpty(comboBoxFMajor.Text))
            {
                checkQueryChange();

                string major = comboBoxFMajor.Text;
                query += " major = '" + major + "'";
            }

            //textbox Hometown
            if (!string.IsNullOrEmpty(textBoxFHometown.Text))
            {
                checkQueryChange();

                string hometown = textBoxFHometown.Text;
                query += " hometown = '" + hometown + "'";
            }

            // comboBox Academic Year
            if (!string.IsNullOrEmpty(comboBoxFAcaYear.Text))
            {
                checkQueryChange();

                string acayear = comboBoxFAcaYear.Text;
                query += " acayear = '" + acayear + "'";
            }

            // nếu không chọn bất kì lựa chọn nào thì sẽ hiện ta tất cả thông tin trong bảng Std và thông báo
            if (query == temp)
            {
                query = selectStdCommand;
                MessageBox.Show("Not Found", "Find", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            SqlCommand command = new SqlCommand(query);
            fillGrid(command);
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnDownloadImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + textBoxStudentID.Text);
            if ((pictureBoxImage.Image == null))
            {
                MessageBox.Show("No Image in the PictureBox");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxImage.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxStudentID.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxAddress.Text = "";
            textBoxPhone.Text = "";
            textBoxFaculty.Text = "";
            textBoxMajor.Text = "";
            textBoxHomeTown.Text = "";
            textBoxAcaYear.Text = "";
            textBoxEmail.Text = "";
            pictureBoxImage.Image = null;
            radioButtonMale.Checked = true;
            dateTimePickerBirthDay.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();

            int id = Convert.ToInt32(textBoxStudentID.Text);
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            DateTime bdate = dateTimePickerBirthDay.Value;
            string phone = textBoxPhone.Text;
            string adrs = textBoxAddress.Text;
            string falty = textBoxFaculty.Text;
            string major = textBoxMajor.Text;
            string htown = textBoxHomeTown.Text;
            string acayear = textBoxAcaYear.Text;
            string email = textBoxEmail.Text;
            string gender = "Male";
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePickerBirthDay.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                pictureBoxImage.Image.Save(pic, pictureBoxImage.Image.RawFormat);
                if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, falty, major, htown, acayear, email, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            fillGrid(new SqlCommand(selectStdCommand));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();

            int id = Convert.ToInt32(textBoxStudentID.Text);
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            DateTime bdate = dateTimePickerBirthDay.Value;
            string phone = textBoxPhone.Text;
            string adrs = textBoxAddress.Text;
            string falty = textBoxFaculty.Text;
            string major = textBoxMajor.Text;
            string htown = textBoxHomeTown.Text;
            string acayear = textBoxAcaYear.Text;
            string email = textBoxEmail.Text;
            string gender = "Male";
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePickerBirthDay.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                pictureBoxImage.Image.Save(pic, pictureBoxImage.Image.RawFormat);
                if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, falty, major, htown, acayear, email, pic))
                {
                    MessageBox.Show("Student Updated", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            fillGrid(new SqlCommand(selectStdCommand));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBoxStudentID.Text);

            if (student.deleteStudent(id))
            {
                MessageBox.Show("Delete Student", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // clear fields after delete
                textBoxStudentID.Text = "";
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxAddress.Text = "";
                textBoxPhone.Text = "";
                textBoxFaculty.Text = "";
                textBoxMajor.Text = "";
                textBoxHomeTown.Text = "";
                textBoxAcaYear.Text = "";
                textBoxEmail.Text = "";
                dateTimePickerBirthDay.Value = DateTime.Now;
                pictureBoxImage.Image = null;

                fillGrid(new SqlCommand(selectStdCommand));
            }
            else
            {
                MessageBox.Show("Student ID not exit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool verif()
        {
            if ((textBoxFirstName.Text.Trim() == "")
                || (textBoxLastName.Text.Trim() == "")
                || (textBoxAddress.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
                || (pictureBoxImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand(selectStdCommand));
            textBoxFID.Text = "";
            textBoxFFirstName.Text = "";
            textBoxFLastName.Text = "";
            radioButtonFindFemale.Checked = false;
            radioButtonFindMale.Checked = false;
            textBoxFAddress.Text = "";
            textBoxFHometown.Text = "";
            comboBoxFAcaYear.SelectedItem = null;
            comboBoxFFaculty.SelectedItem = null;
            comboBoxFMajor.SelectedItem = null;
        }

        private void dataGridViewStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewStudentList.Rows[e.RowIndex];

            string studentID = row.Cells["ID"].Value.ToString();
            string firstName = row.Cells["First Name"].Value.ToString();
            string lastName = row.Cells["Last Name"].Value.ToString();


            DetailStudentCourseForm DetailCourseF = new DetailStudentCourseForm(studentID, firstName, lastName);
            DetailCourseF.Show(this);
        }
    }
}
