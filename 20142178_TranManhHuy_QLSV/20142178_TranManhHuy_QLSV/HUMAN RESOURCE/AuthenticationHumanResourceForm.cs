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
    public partial class AuthenticationHumanResourceForm : Form
    {
        public AuthenticationHumanResourceForm()
        {
            InitializeComponent();
        }

        USER user = new USER();

        string stringcon = @"Data Source=DESKTOP-FEQAJ4I\SQLEXPRESS;Initial Catalog=QLSVDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=true";

        private void AuthenticationHumanResourceForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT id AS [ID],fname AS [First Name], lname AS [Last Name], username AS [User Name], password AS [Password], email AS [Email], picture AS [Picture] FROM Temp_HumanResource"));

        }
        // Nạp data
        public void fillGrid(SqlCommand command)
        {
            dataGridViewTemp_HumanResourceList.ReadOnly = true;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewTemp_HumanResourceList.RowTemplate.Height = 80;
            dataGridViewTemp_HumanResourceList.DataSource = user.getUsers(command);
            picCol = (DataGridViewImageColumn)dataGridViewTemp_HumanResourceList.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewTemp_HumanResourceList.AllowUserToAddRows = false;
        }

        private void ButtonApprove_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (dataGridViewTemp_HumanResourceList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select At Least One User To Approve!", "Approved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy danh sách các ID của hàng được chọn
            List<string> selectedIds = new List<string>();
            foreach (DataGridViewRow row in dataGridViewTemp_HumanResourceList.SelectedRows)
            {
                string id = row.Cells["ID"].Value.ToString();
                selectedIds.Add(id);
            }

            // Thực hiện thêm thông tin user vào bảng chính và xóa khỏi bảng tạm thời
            using (SqlConnection connection = new SqlConnection(stringcon))
            {
                connection.Open();

                int successCount = 0;

                foreach (string userId in selectedIds)
                {
                    // Thêm thông tin user vào bảng chính
                    SqlCommand selectCommand = new SqlCommand("SELECT * FROM Temp_HumanResource WHERE id = @id", connection);
                    selectCommand.Parameters.AddWithValue("@id", userId);

                    SqlDataReader reader = selectCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        // Thêm thông tin user vào bảng chính
                        SqlCommand insertCommand = new SqlCommand("INSERT INTO HumanResource (id, fname, lname, username, password, email, picture) VALUES (@Id, @fn, @ln, @username, @password, @email, @pic)", connection);
                        insertCommand.Parameters.AddWithValue("@Id", reader["Id"].ToString());
                        insertCommand.Parameters.AddWithValue("@fn", reader["fname"].ToString());
                        insertCommand.Parameters.AddWithValue("@ln", reader["lname"].ToString());
                        insertCommand.Parameters.AddWithValue("@username", reader["username"].ToString());
                        insertCommand.Parameters.AddWithValue("@password", reader["password"].ToString());
                        insertCommand.Parameters.AddWithValue("@email", reader["email"].ToString());
                        insertCommand.Parameters.AddWithValue("@pic", (byte[])reader["picture"]);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            successCount++;
                        }
                    }
                    reader.Close();

                    // Xóa thông tin user khỏi bảng tạm thời
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM Temp_HumanResource WHERE id = @id", connection);
                    deleteCommand.Parameters.AddWithValue("@id", userId);

                    int rowsDeleted = deleteCommand.ExecuteNonQuery();

                    if (rowsDeleted == 0)
                    {
                        MessageBox.Show("An Error Occurred While Deleting The User From The Temporary Table!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (successCount > 0)
                {
                    MessageBox.Show(successCount + " User(s) Have Been Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An Error Occurred While Adding Users.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Refresh lại datagridview
            fillGrid(new SqlCommand("SELECT id AS [ID],fname AS [First Name], lname AS [Last Name], username AS [User Name], password AS [Password], email AS [Email], picture AS [Picture] FROM Temp_HumanResource"));
        }

        private void ButtonReject_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có user được chọn hay không
            if (dataGridViewTemp_HumanResourceList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select At Least One User To Reject!", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lặp qua từng hàng được chọn và xóa user
            foreach (DataGridViewRow row in dataGridViewTemp_HumanResourceList.SelectedRows)
            {
                string userId = row.Cells["id"].Value.ToString();

                // Xóa thông tin user khỏi bảng tạm thời
                using (SqlConnection connection = new SqlConnection(stringcon))
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Temp_HumanResource WHERE id = @id", connection);

                    sqlCommand.Parameters.AddWithValue("@id", userId);

                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("An Error Occurred While Rejecting The User With ID " + userId + ".", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            // Hiển thị thông báo khi xóa hoàn tất
            MessageBox.Show("Selected Users Have Been Rejected!", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh lại datagridview
            fillGrid(new SqlCommand("SELECT id AS [ID],fname AS [First Name], lname AS [Last Name], username AS [User Name], password AS [Password], email AS [Email], picture AS [Picture] FROM Temp_HumanResource"));
        }

        private void ButtonApproveAll_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();

            db.openConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Temp_HumanResource");

            DataTable table = user.getUsers(selectCommand);
            string id;
            string fname;
            string lname;
            string username;
            string password;
            string email;
            MemoryStream pic;

            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    id = table.Rows[i].Field<string>("Id");
                    fname = table.Rows[i].Field<string>("fname");
                    lname = table.Rows[i].Field<string>("lname");
                    username = table.Rows[i].Field<string>("username");
                    password = table.Rows[i].Field<string>("password");
                    email = table.Rows[i].Field<string>("email");
                    pic = new MemoryStream(Convert.FromBase64String(table.Rows[i].Field<string>("picture")));


                    SqlCommand InsertCommand = new SqlCommand("INSERT INTO HumanResource (id, fname, lname, username, password, email, picture) VALUES (@Id, @fn, @ln, @username, @password, @email, @pic)", db.getConnection);

                    InsertCommand.Parameters.AddWithValue("@Id", id);
                    InsertCommand.Parameters.AddWithValue("@fn", fname);
                    InsertCommand.Parameters.AddWithValue("@ln", lname);
                    InsertCommand.Parameters.AddWithValue("@username", username);
                    InsertCommand.Parameters.AddWithValue("@password", password);
                    InsertCommand.Parameters.AddWithValue("@email", email);
                    InsertCommand.Parameters.AddWithValue("@pic", pic);

                }

                MessageBox.Show("Approve All Users Successful!", "Approved All", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Any User To Approve!", "Approved All", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand deleteCommand = new SqlCommand("DELETE FROM Temp_Log_in", db.getConnection);
            deleteCommand.ExecuteNonQuery();

            // Refresh lại datagridview
            fillGrid(new SqlCommand("SELECT id AS [ID],fname AS [First Name], lname AS [Last Name], username AS [User Name], password AS [Password], email AS [Email], picture AS [Picture] FROM Temp_HumanResource"));
            db.closeConnection();
        }

        private void ButtonRejectAll_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();

            SqlCommand deleteCommand = new SqlCommand("DELETE FROM Temp_HumanResource", db.getConnection);

            db.openConnection();

            if (deleteCommand.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("All Users has been rejected!", "Rejected All", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Any User To Reject!", "Rejected All", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (deleteCommand.ExecuteNonQuery() == -1)
            {
                MessageBox.Show("An Error Occurred While Rejecting All User!", "Rejected All", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresh lại datagridview
            fillGrid(new SqlCommand("SELECT id AS [ID],fname AS [First Name], lname AS [Last Name], username AS [User Name], password AS [Password], email AS [Email], picture AS [Picture] FROM Temp_HumanResource"));

            db.closeConnection();
        }
    }
}
