using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _20142178_TranManhHuy_QLSV
{
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }

        //dat mau neu muon
        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;

        private void StaticsForm_Load(object sender, EventArgs e)
        {
            //get pannels color
            panTotalColor = PanelTotal.BackColor;
            panMaleColor = PanelMale.BackColor;
            panFemaleColor = PanelFemale.BackColor;
            //display the values
            STUDENT student = new STUDENT();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());

            double maleStudentsPercentage = (totalMale * (100 / total));
            double femaleStudentsPercentage = (totalFemale * (100 / total));
            LabelTotal.Text = ("Total Students: " + total.ToString());
            LabelMale.Text = ("Male: " + (maleStudentsPercentage.ToString("0.00") + "%"));
            LabelFemale.Text = ("Female: " + (femaleStudentsPercentage.ToString("0.00") + "%"));

            //Pie Chart
            PieChart.Series[0].ChartType = SeriesChartType.Pie;
            PieChart.Series["Student"].Points.Add(totalMale);
            PieChart.Series["Student"].Points[0].AxisLabel = (maleStudentsPercentage.ToString("0.00") + "%");
            PieChart.Series["Student"].Points[0].LegendText = "Male";
            PieChart.Series["Student"].Points[0].LabelForeColor = Color.White;
            PieChart.Series["Student"].Points[0].MarkerSize = 20;
            PieChart.Series["Student"].Points[0].Color = Color.Navy;
            //
            PieChart.Series["Student"].Points.Add(totalFemale);
            PieChart.Series["Student"].Points[1].AxisLabel = (femaleStudentsPercentage.ToString("0.00") + "%");
            PieChart.Series["Student"].Points[1].LegendText = "Female";
            PieChart.Series["Student"].Points[1].MarkerSize = 20;
            PieChart.Series["Student"].Points[1].LabelForeColor = Color.Black;
            PieChart.Series["Student"].Points[1].Color = Color.Orange;

            //BarChar
            BarChart.Series["Student"].Points.Add(totalMale);
            BarChart.Series["Student"].Points[0].AxisLabel = "Male";
            BarChart.Series["Student"].Points[0].LegendText = "Male";
            BarChart.Series["Student"].Points[0].Label = totalMale.ToString();
            BarChart.Series["Student"].Points[0].Color = Color.Navy;
            //
            BarChart.Series["Student"].Points.Add(totalFemale);
            BarChart.Series["Student"].Points[1].AxisLabel = "Female";
            BarChart.Series["Student"].Points[1].LegendText = "Female";
            BarChart.Series["Student"].Points[1].Label = totalFemale.ToString();
            BarChart.Series["Student"].Points[1].Color = Color.Orange;
        }

        //thu cac event lam viec voi Mouse
        private void LabelTotal_MouseEnter(object sender, EventArgs e)
        {
            LabelTotal.ForeColor = panTotalColor;
            PanelTotal.BackColor = Color.White;
        }

        private void LabelTotal_MouseLeave(object sender, EventArgs e)
        {
            LabelTotal.ForeColor = Color.White;
            PanelTotal.BackColor = panTotalColor;
        }

        private void LabelMale_MouseEnter(object sender, EventArgs e)
        {
            LabelMale.ForeColor = panMaleColor;
            PanelMale.BackColor = Color.White;
        }

        private void LabelMale_MouseLeave(object sender, EventArgs e)
        {
            LabelMale.ForeColor = Color.White;
            PanelMale.BackColor = panMaleColor;
        }

        private void LabelFemale_MouseEnter(object sender, EventArgs e)
        {
            LabelFemale.ForeColor = panFemaleColor;
            PanelFemale.BackColor = Color.White;
        }

        private void LabelFemale_MouseLeave(object sender, EventArgs e)
        {
            LabelFemale.ForeColor = Color.White;
            PanelFemale.BackColor = panFemaleColor;
        }
    }
}
