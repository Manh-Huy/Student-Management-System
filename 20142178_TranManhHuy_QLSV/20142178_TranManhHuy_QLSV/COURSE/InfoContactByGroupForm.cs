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
    public partial class InfoContactByGroupForm : Form
    {
        CONTACT contact = new CONTACT();
        string groupName;
        string contactID;

        public string ContactID { get => contactID; set => contactID = value; }

        public InfoContactByGroupForm()
        {
            InitializeComponent();
        }
        public InfoContactByGroupForm(string group)
        {
            groupName = group;
            InitializeComponent();
        }

        private void InfoContactByGroupForm_Load(object sender, EventArgs e)
        {
            textBoxGroup.Text = groupName;
            SqlCommand command = new SqlCommand("SELECT contactID AS [Contact ID], fname AS [First Name], lname AS [Last Name], [group] AS [Group], phone AS [Phone], email AS [Email], address AS [Address], picture AS [Picture] FROM MyContact WHERE [group] = '" + groupName + "'");
            fillGrid(command);

        }
        public void fillGrid(SqlCommand command)
        {
            dataGridViewInfoContact.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewInfoContact.RowTemplate.Height = 80;
            dataGridViewInfoContact.DataSource = contact.getContacts(command);
            picCol = (DataGridViewImageColumn)dataGridViewInfoContact.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewInfoContact.AllowUserToAddRows = false;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (dataGridViewInfoContact.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Contact!", "Select Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ContactID = (string)dataGridViewInfoContact.SelectedRows[0].Cells["Contact ID"].Value;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
