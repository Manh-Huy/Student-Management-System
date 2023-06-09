using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20142178_TranManhHuy_QLSV
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentListViewDataSet.Std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.studentListViewDataSet.Std);

            SqlCommand command = new SqlCommand("SELECT * FROM Std");
            DataGridViewStudentList.ReadOnly = true;
            // xử lý hỉnh ảnh, code có tham khảo msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridViewStudentList.RowTemplate.Height = 80;
            DataGridViewStudentList.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridViewStudentList.Columns[13];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridViewStudentList.AllowUserToAddRows = false;

            // dùng combo box lấy tên các niên khóa
            comboBoxAcaYear.DataSource = student.getAcayear();
            comboBoxAcaYear.DisplayMember = "acayear";
            //comboBoxAcaYear.ValueMember = "id";
            comboBoxAcaYear.SelectedItem = null;

            // dùng combo box lấy tên khoa
            comboBoxFaculty.DataSource = student.getFaculty();
            comboBoxFaculty.DisplayMember = "faculty";
            //comboBoxFaculty.ValueMember = "id";
            comboBoxFaculty.SelectedItem = null;

            // dùng combo box lấy tên ngành
            comboBoxMajor.DataSource = student.getMajor();
            comboBoxMajor.DisplayMember = "major";
            //comboBoxMajor.ValueMember = "id";
            comboBoxMajor.SelectedItem = null;
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Std");
            DataGridViewStudentList.ReadOnly = true;
            // xử lý hỉnh ảnh, code có tham khảo msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridViewStudentList.RowTemplate.Height = 80;
            DataGridViewStudentList.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridViewStudentList.Columns[13];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridViewStudentList.AllowUserToAddRows = false;
        }

        private void DataGridViewStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStdF = new UpdateDeleteStudentForm();
            // thứ tự của các cột stt,id, fname, lname, bd, grd,...
            updateDeleteStdF.textBoxStudentID.Text = DataGridViewStudentList.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStdF.textBoxFirstName.Text = DataGridViewStudentList.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStdF.textBoxLastName.Text = DataGridViewStudentList.CurrentRow.Cells[3].Value.ToString();
            updateDeleteStdF.dateTimePickerBirthDay.Value = (DateTime)DataGridViewStudentList.CurrentRow.Cells[4].Value;

            //gender
            if ((DataGridViewStudentList.CurrentRow.Cells[5].Value.ToString().Trim() == "Female"))
            {
                updateDeleteStdF.radioButtonFemale.Checked = true;
            }
            else
            {
                updateDeleteStdF.radioButtonMale.Checked = true;
            }

            updateDeleteStdF.textBoxPhone.Text = DataGridViewStudentList.CurrentRow.Cells[6].Value.ToString();
            updateDeleteStdF.textBoxAddress.Text = DataGridViewStudentList.CurrentRow.Cells[7].Value.ToString();
            updateDeleteStdF.textBoxFaculty.Text = DataGridViewStudentList.CurrentRow.Cells[8].Value.ToString();
            updateDeleteStdF.textBoxMajor.Text = DataGridViewStudentList.CurrentRow.Cells[9].Value.ToString();
            updateDeleteStdF.textBoxHomeTown.Text = DataGridViewStudentList.CurrentRow.Cells[10].Value.ToString();
            updateDeleteStdF.textBoxAcaYear.Text = DataGridViewStudentList.CurrentRow.Cells[11].Value.ToString();
            updateDeleteStdF.textBoxEmail.Text = DataGridViewStudentList.CurrentRow.Cells[12].Value.ToString();

            // code xử lý hình ảnh up lên
            byte[] pic;
            pic = (byte[])DataGridViewStudentList.CurrentRow.Cells[13].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStdF.pictureBoxImage.Image = Image.FromStream(picture);
            this.Show();
            updateDeleteStdF.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Std WHERE";
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
            if (!string.IsNullOrEmpty(textBoxID.Text))
            {
                string id = textBoxID.Text;
                query += " id = " + id; 
            }

            //textbox FirstName
            if (!string.IsNullOrEmpty(textBoxFirstName.Text))
            {
                checkQueryChange();

                string fname = textBoxFirstName.Text;
                query += " fname = '" + fname + "'";
            }

            //textbox LastName
            if (!string.IsNullOrEmpty(textBoxLastName.Text))
            {
                checkQueryChange();

                string lname = textBoxLastName.Text;
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
            if (!string.IsNullOrEmpty(textBoxAddress.Text))
            {
                checkQueryChange();

                string address = textBoxAddress.Text;
                query += " address = '" + address + "'";
            }

            // comboBox Faculty
            if (!string.IsNullOrEmpty(comboBoxFaculty.Text))
            {
                checkQueryChange();

                string faculty = comboBoxFaculty.Text;
                query += " faculty = '" + faculty + "'";
            }

            // comboBox Major
            if (!string.IsNullOrEmpty(comboBoxMajor.Text))
            {
                checkQueryChange();

                string major = comboBoxMajor.Text;
                query += " major = '" + major + "'";
            }

            //textbox Hometown
            if (!string.IsNullOrEmpty(textBoxHometown.Text))
            {
                checkQueryChange();

                string hometown = textBoxHometown.Text;
                query += " hometown = '" + hometown + "'";
            }

            // comboBox Academic Year
            if (!string.IsNullOrEmpty(comboBoxAcaYear.Text))
            {
                checkQueryChange();

                string acayear = comboBoxAcaYear.Text;
                query += " acayear = '" + acayear + "'";
            }

            // nếu không chọn bất kì lựa chọn nào thì sẽ hiện ta tất cả thông tin trong bảng Std và thông báo
            if(query == temp)
            {
                query = "SELECT * FROM Std";
                MessageBox.Show("Not Found", "Find", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            SqlCommand command = new SqlCommand(query);
            
            DataGridViewStudentList.ReadOnly = true;
            // xử lý hỉnh ảnh, code có tham khảo msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridViewStudentList.RowTemplate.Height = 80;
            DataGridViewStudentList.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridViewStudentList.Columns[13];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridViewStudentList.AllowUserToAddRows = false;
        }
    }
}
