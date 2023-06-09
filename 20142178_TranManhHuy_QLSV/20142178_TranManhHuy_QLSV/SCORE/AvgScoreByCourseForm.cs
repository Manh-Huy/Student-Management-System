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
    public partial class AvgScoreByCourseForm : Form
    {
        public AvgScoreByCourseForm()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        private void AvgScoreByCourseForm_Load(object sender, EventArgs e)
        {
            dataGridViewAvgScoreByCourse.DataSource = score.getAvgScoreByCourse();
        }
    }
}
