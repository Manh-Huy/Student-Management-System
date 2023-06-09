using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

//using static System.Net.Mime.MediaTypeNames;

namespace _20142178_TranManhHuy_QLSV
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
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
                try
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
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Số lỗi cho lỗi ràng buộc khóa chính
                    {
                        MessageBox.Show("ID Student Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        // button browse image
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void textBoxStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

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

        private void btnAddByFileExcel_Click(object sender, EventArgs e)
        {
            // Mở dialog box để người dùng chọn tệp Excel
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog1.Title = "Select a Excel File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Mở tệp Excel
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                //Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"F:\Desktop\Data.xlsx");
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(openFileDialog1.FileName);
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

                // Tạo DataTable để lưu dữ liệu
                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("fname");
                dt.Columns.Add("lname");
                dt.Columns.Add("bdate");
                dt.Columns.Add("gender");
                dt.Columns.Add("phone");
                dt.Columns.Add("address");
                dt.Columns.Add("faculty");
                dt.Columns.Add("major");
                dt.Columns.Add("hometown");
                dt.Columns.Add("acayear");
                dt.Columns.Add("email");

                // Lặp qua các hàng và cột trong bảng tính Excel để lấy dữ liệu
                for (int i = 2; i <= xlRange.Rows.Count; i++) // Bỏ qua hàng đầu tiên, vì nó là tiêu đề
                {
                    DataRow row = dt.NewRow();
                    //row["id"] = xlRange.Cells[i, 1].Value2.ToString();
                    if (xlRange.Cells[i, 1].Value2 != null)
                    {
                        row["id"] = xlRange.Cells[i, 1].Value2.ToString();
                    }
                    else
                    {
                        break;
                    }
                    row["fname"] = xlRange.Cells[i, 2].Value2.ToString();
                    row["lname"] = xlRange.Cells[i, 3].Value2.ToString();
                    row["bdate"] = DateTime.FromOADate(double.Parse(xlRange.Cells[i, 4].Value2.ToString())).ToString("yyyy-MM-dd");
                    row["gender"] = xlRange.Cells[i, 5].Value2.ToString();
                    row["phone"] = xlRange.Cells[i, 6].Value2.ToString();
                    row["address"] = xlRange.Cells[i, 7].Value2.ToString();
                    row["faculty"] = xlRange.Cells[i, 8].Value2.ToString();
                    row["major"] = xlRange.Cells[i, 9].Value2.ToString();
                    row["hometown"] = xlRange.Cells[i, 10].Value2.ToString();
                    row["acayear"] = xlRange.Cells[i, 11].Value2.ToString();
                    row["email"] = xlRange.Cells[i, 12].Value2.ToString();
                    dt.Rows.Add(row);
                }

                // Đóng tệp Excel
                xlWorkbook.Close();
                xlApp.Quit();

                string connectionString = @"Data Source=DESKTOP-FEQAJ4I\SQLEXPRESS;Initial Catalog=QLSVDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=true";

                // Tạo kết nối
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Tạo câu lệnh SQL để chèn dữ liệu vào bảng

                    string sql = "INSERT INTO Std (id, fname, lname, bdate, gender, phone, address, faculty, major, hometown, acayear, email) VALUES (@id, @fname, @lname, @bdate, @gender, @phone, @address, @faculty, @major, @hometown, @acayear, @email)";
                    //string sql = "INSERT INTO Std (id) VALUES (@id)";

                    // Thực thi câu lệnh SQL cho mỗi hàng trong DataTable
                    foreach (DataRow row in dt.Rows)
                    {
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@id", row["id"]);
                        command.Parameters.AddWithValue("@fname", row["fname"]);
                        command.Parameters.AddWithValue("@lname", row["lname"]);
                        command.Parameters.AddWithValue("@bdate", DateTime.ParseExact(row["bdate"].ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture));
                        command.Parameters.AddWithValue("@gender", row["gender"]);
                        command.Parameters.AddWithValue("@phone", row["phone"]);
                        command.Parameters.AddWithValue("@address", row["address"]);
                        command.Parameters.AddWithValue("@faculty", row["faculty"]);
                        command.Parameters.AddWithValue("@major", row["major"]);
                        command.Parameters.AddWithValue("@hometown", row["hometown"]);
                        command.Parameters.AddWithValue("@acayear", row["acayear"]);
                        command.Parameters.AddWithValue("@email", row["email"]);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                MessageBox.Show("Add Student Succesfully", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
              
