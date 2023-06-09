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
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        MY_DB mydb = new MY_DB();
        CONTACT contact = new CONTACT();
        string hrID = Global.GlobalUserID;


        public void getImageAbdUsername()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM HumanResource WHERE id = @hrid", mydb.getConnection);
            command.Parameters.Add("@hrid", SqlDbType.NVarChar).Value = Global.GlobalUserID;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxHr.Image = Image.FromStream(picture);

                lblWelcomeHr.Text = "Welcome Back (" + table.Rows[0]["username"].ToString() + ")";
            }
        }
        private void AddContactForm_Load(object sender, EventArgs e)
        {
            getImageAbdUsername();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM HumanResource WHERE id = @hrid", mydb.getConnection);
            command.Parameters.Add("@hrid", SqlDbType.NVarChar).Value = Global.GlobalUserID;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                mydb.openConnection();
                SqlCommand selectGroupCommand = new SqlCommand("SELECT DISTINCT nameGroup FROM [Group] WHERE hrID = '" + hrID + "'", mydb.getConnection);
                SqlDataReader reader = selectGroupCommand.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxGroup.Items.Add(reader.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
                }

                reader.Close();
                selectGroupCommand.Dispose();
                mydb.closeConnection();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string contactID = textBoxID.Text;
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            string group = comboBoxGroup.Text;
            string phone = textBoxPhone.Text;
            string adrs = textBoxAddress.Text;
            MemoryStream picture = new MemoryStream();
            
            string email = textBoxEmail.Text;
            
            if (verif())
            {
                try
                {
                    pictureBoxImage.Image.Save(picture, pictureBoxImage.Image.RawFormat);
                    if (contact.insertContact(contactID, fname, lname, group, phone, email, adrs, picture))
                    {
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Số lỗi cho lỗi ràng buộc khóa chính
                    {
                        MessageBox.Show("ID Contact Already Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verif()
        {
            if ((textBoxFirstName.Text.Trim() == "")
                || (textBoxLastName.Text.Trim() == "")
                || (textBoxID.Text.Trim() == "")
                || (comboBoxGroup.Text.Trim() == "")
                || (textBoxAddress.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
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
