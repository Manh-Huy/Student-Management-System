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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20142178_TranManhHuy_QLSV
{
    public partial class HumanResourceMainForm : Form
    {
        MY_DB mydb = new MY_DB();
        CONTACT contact = new CONTACT();
        GROUP group = new GROUP();
        string hrID = Global.GlobalUserID;
        public HumanResourceMainForm()
        {
            InitializeComponent();
        }

        string contactID = "";
        public HumanResourceMainForm(string idcontact)
        {
            contactID = idcontact;
            InitializeComponent();
        }

        private void HumanResourceMainForm_Load(object sender, EventArgs e)
        {
            if (contactID != "")
            {
                textBoxContactID.Text = contactID;
            }
            getImageAbdUsername();

            mydb.openConnection();
            SqlCommand selectGroupCommand = new SqlCommand("SELECT DISTINCT nameGroup FROM [Group]", mydb.getConnection);
            SqlDataReader reader = selectGroupCommand.ExecuteReader();
            while (reader.Read())
            {
                comboBoxRemoveSelectGroup.Items.Add(reader.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
                comboBoxEditSelectGroup.Items.Add(reader.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
            }

            reader.Close();
            selectGroupCommand.Dispose();
            mydb.closeConnection();
        }
        public void getImageAbdUsername()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM HumanResource WHERE id = @hrid", mydb.getConnection);
            command.Parameters.Add("@hrid", SqlDbType.NVarChar).Value = Global.GlobalUserID;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0 )
            {
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxHr.Image = Image.FromStream(picture);

                lblWelcomeHr.Text = "Welcome Back (" + table.Rows[0]["username"].ToString() + ")";
            }
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            AddContactForm AddContactF = new AddContactForm();
            AddContactF.Show(this);
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
           EditContactForm EditContactF = new EditContactForm();
            EditContactF.Show(this);
        }

        private void btnSelectContact_Click(object sender, EventArgs e)
        {
            SelectContactForm selectContactF = new SelectContactForm();
            selectContactF.Shown += (s, args) => this.Close();
            selectContactF.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int idcontact = Int32.Parse(textBoxContactID.Text);
            if (contactID == "")
            {
                MessageBox.Show("Empty Fields", "Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (contact.deleteContact(idcontact))
                {
                    MessageBox.Show("Remove Contact Successfully!", "Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error!", "Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnShowFullList_Click(object sender, EventArgs e)
        {
            FullListContactForm FullListContactForm = new FullListContactForm();
            FullListContactForm.Show();
        }

        private void btnAddGroupName_Click(object sender, EventArgs e)
        {
            if (textBoxGroupName.Text == "")
            {
                MessageBox.Show("Empty Fields", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (group.insertGroup(hrID, textBoxGroupName.Text))
                {
                    MessageBox.Show("Add Group Successfully", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // lỗi trùng khóa chính
                {
                    MessageBox.Show("This Group Name Exist", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Add Group Unsuccessfully", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textBoxNewName.Text == "")
            {
                MessageBox.Show("Empty Fields", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (group.updateGroup(comboBoxEditSelectGroup.Text, textBoxNewName.Text))
            {
                MessageBox.Show("Edit Group Successfully", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Edit Group Unsuccessfully", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveGroup_Click(object sender, EventArgs e)
        {
            if (comboBoxRemoveSelectGroup.Text == "")
            {
                MessageBox.Show("Empty Fields", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (group.deleteGroup(comboBoxRemoveSelectGroup.Text))
            {
                MessageBox.Show("Delete Group Successfully", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delete Group Unsuccessfully", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            comboBoxEditSelectGroup.Items.Clear();
            comboBoxRemoveSelectGroup.Items.Clear();
            comboBoxEditSelectGroup.ResetText();
            comboBoxRemoveSelectGroup.ResetText();

            if (contactID != "")
            {
                textBoxContactID.Text = contactID;
            }
            getImageAbdUsername();

            mydb.openConnection();
            SqlCommand selectGroupCommand = new SqlCommand("SELECT DISTINCT nameGroup FROM [Group]", mydb.getConnection);
            SqlDataReader reader = selectGroupCommand.ExecuteReader();
            while (reader.Read())
            {
                comboBoxRemoveSelectGroup.Items.Add(reader.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
                comboBoxEditSelectGroup.Items.Add(reader.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
            }

            reader.Close();
            selectGroupCommand.Dispose();
            mydb.closeConnection();
        }
    }
}
