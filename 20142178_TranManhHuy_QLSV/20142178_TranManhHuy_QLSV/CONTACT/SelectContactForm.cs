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
    public partial class SelectContactForm : Form
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
        public SelectContactForm()
        {
            InitializeComponent();
        }

        private void SelectContactForm_Load(object sender, EventArgs e)
        {
            getImageAbdUsername();
            SqlCommand command = new SqlCommand("SELECT contactID AS [Contact ID], fname AS [First Name], lname AS [Last Name], [group] AS [Group] FROM MyContact INNER JOIN [Group] ON MyContact.[group] = [Group].nameGroup WHERE hrID = '" + hrID + "'");
            fillGrid(command);
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridViewSelectContactForm.ReadOnly = true;
            dataGridViewSelectContactForm.DataSource = contact.getContacts(command);
            dataGridViewSelectContactForm.AllowUserToAddRows = false;
        }

        int temp = 0; // biến tạm để biết người dùng có chọn vào datagridview hay không
        private void dataGridViewSelectContactForm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewSelectContactForm.Rows[e.RowIndex];

            string contactID = row.Cells["Contact ID"].Value.ToString();

            HumanResourceMainForm HrMainF = new HumanResourceMainForm(contactID);
            HrMainF.Shown += (s, args) => this.Close();

            HrMainF.Show();
            temp = 1;
            
        }

        private void SelectContactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (temp == 1)
            {
                return;
            }
            else
            {
                HumanResourceMainForm HrMainF = new HumanResourceMainForm();
                HrMainF.Show();
            }
        }
    }
}
