using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20142178_TranManhHuy_QLSV
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void btnFind_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxStudentID.Text);
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, faculty, major, hometown, acayear, email, picture FROM std WHERE id = " + id);

            DataTable table = student.getStudents(command);

            if (table.Rows.Count > 0)
            {
                textBoxFirstName.Text = table.Rows[0]["fname"].ToString();
                textBoxLastName.Text = table.Rows[0]["lname"].ToString();
                dateTimePickerBirthDay.Value = (DateTime)table.Rows[0]["bdate"];

                // gender
                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    radioButtonFemale.Checked = true;
                }
                else
                {
                    radioButtonMale.Checked = true;
                }

                textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                textBoxAddress.Text = table.Rows[0]["address"].ToString();
                textBoxFaculty.Text = table.Rows[0]["faculty"].ToString();
                textBoxMajor.Text = table.Rows[0]["major"].ToString();
                textBoxHomeTown.Text = table.Rows[0]["hometown"].ToString();
                textBoxAcaYear.Text = table.Rows[0]["acayear"].ToString();
                textBoxEmail.Text = table.Rows[0]["email"].ToString();

                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxImage.Image = Image.FromStream(picture);
            }

            else
            {
                MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // kiểm tra nhập vào là kí tự

        private void textBoxStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
                Close();
            }
            else
            {
                MessageBox.Show("Student ID not exit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // chuc nang kiem tra du lieu input
        bool verif()
        {
            if ((textBoxFirstName.Text.Trim() == "")
                || (textBoxLastName.Text.Trim() == "")
                || (textBoxAddress.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
                || (textBoxFaculty.Text.Trim() == "")
                || (textBoxMajor.Text.Trim() == "")
                || (textBoxHomeTown.Text.Trim() == "")
                || (textBoxAcaYear.Text.Trim() == "")
                || (textBoxEmail.Text.Trim() == "")
                || (pictureBoxImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Kiểm tra kí tự nhập
        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddScourse_Click(object sender, EventArgs e)
        {
            string id = textBoxStudentID.Text;
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;

            StudentAddCourseForm StdAddCour = new StudentAddCourseForm(id, fname, lname);
            StdAddCour.Show(this);
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
    }
}
