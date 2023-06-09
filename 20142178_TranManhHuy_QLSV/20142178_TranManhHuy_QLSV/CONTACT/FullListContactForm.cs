using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class FullListContactForm : Form
    {
        CONTACT contact = new CONTACT();
        MY_DB mydb = new MY_DB();
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
        public FullListContactForm()
        {
            InitializeComponent();
        }

        private void FullListContactForm_Load(object sender, EventArgs e)
        {
            getImageAbdUsername();

            SqlCommand command = new SqlCommand("SELECT contactID AS [Contact ID], fname AS [First Name], lname AS [Last Name], [group] AS [Group], phone AS [Phone], email AS [Email], address AS [Address], picture AS [Picture] FROM MyContact INNER JOIN [Group] ON [group] = nameGroup WHERE hrID = '" + hrID + "'");
            fillGrid(command);

            ListBoxGroup.Items.Clear(); // xóa tất cả dữ liệu cũ trước khi đổ dữ liệu mới vào


            mydb.openConnection();

            SqlCommand commandGroup = new SqlCommand("SELECT DISTINCT nameGroup FROM [Group] WHERE hrID = '" + hrID + "'", mydb.getConnection);

            SqlDataReader reader = commandGroup.ExecuteReader();

            if (reader.HasRows)
            { // kiểm tra xem SqlDataReader có chứa dữ liệu hay không
                while (reader.Read())
                {
                    string groupName = reader.GetString(0);
                    ListBoxGroup.Items.Add(groupName);
                }
            }

            reader.Close();
            commandGroup.Dispose();
            mydb.closeConnection();

        }

        public void fillGrid(SqlCommand command)
        {
            dataGridViewContactList.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewContactList.RowTemplate.Height = 80;
            dataGridViewContactList.DataSource = contact.getContacts(command);
            picCol = (DataGridViewImageColumn)dataGridViewContactList.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewContactList.AllowUserToAddRows = false;
        }

        private void ListBoxGroup_DoubleClick(object sender, EventArgs e)
        {
            string groupName = ListBoxGroup.Text.ToString();
            SqlCommand command = new SqlCommand("SELECT contactID AS [Contact ID], fname AS [First Name], lname AS [Last Name], [group] AS [Group], phone AS [Phone], email AS [Email], address AS [Address], picture AS [Picture] FROM MyContact WHERE [group] = '" + groupName + "'");
            fillGrid(command);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT contactID AS [Contact ID], fname AS [First Name], lname AS [Last Name], [group] AS [Group], phone AS [Phone], email AS [Email], address AS [Address], picture AS [Picture] FROM MyContact INNER JOIN [Group] ON [group] = nameGroup WHERE hrID = '" + hrID + "'");
            fillGrid(command);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (dataGridViewContactList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Contact!", "Select Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string contactID = (string)dataGridViewContactList.SelectedRows[0].Cells["Contact ID"].Value;
            string firstName = (string)dataGridViewContactList.SelectedRows[0].Cells["First Name"].Value;
            string lastName = (string)dataGridViewContactList.SelectedRows[0].Cells["Last Name"].Value;
            string group = (string)dataGridViewContactList.SelectedRows[0].Cells["Group"].Value;

            CourseContactListForm courseContactListForm = new CourseContactListForm(contactID, group, firstName, lastName);
            courseContactListForm.Show(this);
        }
    }
}
