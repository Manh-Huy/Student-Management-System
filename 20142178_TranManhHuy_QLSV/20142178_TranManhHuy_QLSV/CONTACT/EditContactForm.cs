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
    public partial class EditContactForm : Form
    {
        public EditContactForm()
        {
            InitializeComponent();
        }

        string hrID = Global.GlobalUserID;
        MY_DB mydb = new MY_DB();
        CONTACT contact = new CONTACT();

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
        private void EditContactForm_Load(object sender, EventArgs e)
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
                SqlCommand selectGroupCommand = new SqlCommand("SELECT nameGroup FROM [Group] WHERE hrID = '" + hrID + "'", mydb.getConnection);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string contactID = textBoxContactID.Text;
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            string group = comboBoxGroup.Text;
            string phone = textBoxPhone.Text;
            string adrs = textBoxAddress.Text;
            MemoryStream picture = new MemoryStream();
            string email = textBoxEmail.Text;

            if (verif())
            {
                pictureBoxImage.Image.Save(picture, pictureBoxImage.Image.RawFormat);
                if (contact.updateContact(contactID, fname, lname, group, phone, email, adrs, picture))
                {
                    MessageBox.Show("The Contact Edited", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxFirstName.Text.Trim() == "")
                || (textBoxLastName.Text.Trim() == "")
                || (textBoxContactID.Text.Trim() == "")
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

        private void btnSelectContact_Click(object sender, EventArgs e)
        {
            if (textBoxContactID.Text == string.Empty)
            {
                MessageBox.Show("Emty Contact ID!", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = Int32.Parse(textBoxContactID.Text);
                SqlCommand command = new SqlCommand("SELECT MyContact.* FROM MyContact INNER JOIN [Group] ON [Group].nameGroup = MyContact.[group] WHERE contactID = @id AND hrID = '" + hrID + "'", mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    textBoxFirstName.Text = table.Rows[0]["fname"].ToString();
                    textBoxLastName.Text = table.Rows[0]["lname"].ToString();
                    comboBoxGroup.Text = table.Rows[0]["group"].ToString();
                    textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                    textBoxEmail.Text = table.Rows[0]["email"].ToString();
                    textBoxAddress.Text = table.Rows[0]["address"].ToString();

                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBoxImage.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("Contact ID Does Not Exist!", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
