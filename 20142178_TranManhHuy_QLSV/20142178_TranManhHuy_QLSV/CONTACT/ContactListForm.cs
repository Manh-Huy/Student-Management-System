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
    public partial class ContactListForm : Form
    {
        public ContactListForm()
        {
            InitializeComponent();
        }

        USER user = new USER();
        private void ContactListForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT id AS [ID], username AS [User Name], password AS [Password], email AS [Email] FROM Log_in_Contact"));
        }
        // Nạp data
        public void fillGrid(SqlCommand command)
        {
            dataGridViewUserList.ReadOnly = true;
            dataGridViewUserList.DataSource = user.getUsers(command);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Log_in_Contact WHERE";
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
                query = "SELECT * FROM Log_in_Contact";
                MessageBox.Show("Not Found", "Find", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            SqlCommand command = new SqlCommand(query);
            dataGridViewUserList.ReadOnly = true;
            dataGridViewUserList.DataSource = user.getUsers(command);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUserList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select A User To Delete!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = ((string)dataGridViewUserList.SelectedRows[0].Cells["User Name"].Value).Trim();
            if (username == "admin")
            {
                MessageBox.Show("Can Not Delete Admin!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userId = dataGridViewUserList.SelectedRows[0].Cells["id"].Value.ToString();

            MY_DB db = new MY_DB();
            SqlCommand deleteCommand = new SqlCommand("DELETE FROM Log_in_Contact WHERE id = @id", db.getConnection);
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
            fillGrid(new SqlCommand("SELECT id AS [ID], username AS [User Name], password AS [Password], email AS [Email] FROM Log_in_Contact"));

            db.closeConnection();
        }
    }
}
