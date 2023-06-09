using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20142178_TranManhHuy_QLSV
{
    public partial class MainForm : Form
    {
        string username;
        string password;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(string uname, string pass)
        {
            username = uname;
            password = pass;
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm AddStdF = new AddStudentForm();
            AddStdF.Show(this);
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm StdList = new StudentListForm();
            StdList.Show(this);
        }

        private void authenticationUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthenticationUserForm AuUser = new AuthenticationUserForm();
            AuUser.Show(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (username == "admin" && password == "admin")
            {
                uSERMANAGEMENTToolStripMenuItem.Enabled = true;
            }
            else
            {
                uSERMANAGEMENTToolStripMenuItem.Enabled = false;
            }
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserListForm UserLF = new UserListForm();
            UserLF.Show(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm StdSF = new StaticsForm();
            StdSF.Show(this);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm UpDeSF = new UpdateDeleteStudentForm();
            UpDeSF.Show(this);
        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentsForm StdManageF = new ManageStudentsForm();
            StdManageF.Show(this);
        }

        private void printStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentForm StdPrintF = new PrintStudentForm();
            StdPrintF.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm AddCF = new AddCourseForm();
            AddCF.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm RemoveCF = new RemoveCourseForm();
            RemoveCF.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm EditCF = new EditCourseForm();
            EditCF.Show(this);
        }

        private void manageCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm ManageCF = new ManageCourseForm();
            ManageCF.Show(this);
        }

        private void printCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintCourseForm PrintCF = new PrintCourseForm();
            PrintCF.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm AddSF = new AddScoreForm();
            AddSF.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm RemoveSF = new RemoveScoreForm();
            RemoveSF.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoresForm ManageScoresF = new ManageScoresForm();
            ManageScoresF.Show(this);
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgScoreByCourseForm avgScoreByCourseF = new AvgScoreByCourseForm();
            avgScoreByCourseF.Show(this);
        }

        private void authenticationHumanResourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthenticationHumanResourceForm AuHmReF = new AuthenticationHumanResourceForm();
            AuHmReF.Show(this);
        }

        private void humanResourceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HumanResourceListForm HrLF = new HumanResourceListForm();
            HrLF.Show(this);
        }

        private void aVGResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgResultByScore AvgResultByScoreF = new AvgResultByScore();
            AvgResultByScoreF.Show(this);
        }

        private void statisticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticResultForm StatisticResultF = new StatisticResultForm();
            StatisticResultF.Show(this);
        }

        private void authenticationContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthenticationContactForm AuContactF = new AuthenticationContactForm();
            AuContactF.Show(this);
        }

        private void contactListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactListForm ContactListF = new ContactListForm();
            ContactListF.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AvgResultByScore AvgScoreF = new AvgResultByScore();
            AvgScoreF.Show(this);
        }
    }
}
