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
    public partial class HumanResourceListForm : Form
    {
        USER user = new USER();
        public HumanResourceListForm()
        {
            InitializeComponent();
        }

        private void HumanResourceListForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT id AS [ID], fname AS [First Name], lname AS [Last Name], username AS [User Name], password AS [Password], bdate AS [BirthDate], gender AS Gender, phone AS [Phone Number], address AS [Address], hometown AS [Hometown], email AS [Email], picture AS [Picture] FROM HumanResource"));
        }

        // Nạp data
        public void fillGrid(SqlCommand command)
        {
            dataGridViewHrList.ReadOnly = true;
            dataGridViewHrList.DataSource = user.getUsers(command);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewHrList.RowTemplate.Height = 80;
            picCol = (DataGridViewImageColumn)dataGridViewHrList.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewHrList.AllowUserToAddRows = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT id AS [ID], fname AS [First Name], lname AS [Last Name], username AS [User Name], password AS [Password], bdate AS [BirthDate], gender AS Gender, phone AS [Phone Number], address AS [Address], hometown AS [Hometown], email AS [Email], picture AS [Picture] FROM HumanResource WHERE";
            string temp = query;

            // kiểm tra câu lệnh query có thay đổi không (nhập nhiều hơn 1 tính năng để tìm kiếm)
            void checkQueryChange()
            {
                if (query != temp)
                {
                    query += " AND";
                }
            }

            //textbox UserName
            if (!string.IsNullOrEmpty(textBoxUserName.Text))
            {
                string username = textBoxUserName.Text;
                query += " username = '" + username + "'";
            }

            //textbox Email
            if (!string.IsNullOrEmpty(textBoxEmail.Text))
            {
                checkQueryChange();

                string email = textBoxEmail.Text;
                query += " email = '" + email + "'";
            }

            if (query == temp)
            {
                query = "SELECT id AS [ID], fname AS [First Name], lname AS [Last Name], username AS [User Name], password AS [Password], bdate AS [BirthDate], gender AS Gender, phone AS [Phone Number], address AS [Address], hometown AS [Hometown], email AS [Email], picture AS [Picture] FROM HumanResource";
                MessageBox.Show("Not Found", "Find", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            SqlCommand command = new SqlCommand(query);
            fillGrid(command);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewHrList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select A User To Delete!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = ((string)dataGridViewHrList.SelectedRows[0].Cells["User Name"].Value).Trim();
            if (username == "admin")
            {
                MessageBox.Show("Can Not Delete Admin!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userId = dataGridViewHrList.SelectedRows[0].Cells["id"].Value.ToString();

            MY_DB db = new MY_DB();
            SqlCommand deleteCommand = new SqlCommand("DELETE FROM HumanResource WHERE id = @id", db.getConnection);
            deleteCommand.Parameters.AddWithValue("@id", userId);

            db.openConnection();

            if (deleteCommand.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Delete Successful!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delete Unsuccessful!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            // Refresh lại datagridview
            fillGrid(new SqlCommand("SELECT id AS [ID], fname AS [First Name], lname AS [Last Name], username AS [User Name], password AS [Password], bdate AS [BirthDate], gender AS Gender, phone AS [Phone Number], address AS [Address], hometown AS [Hometown], email AS [Email], picture AS [Picture] FROM HumanResource"));
            db.closeConnection();
        }
    }
}
