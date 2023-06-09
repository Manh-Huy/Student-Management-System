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
using System.Windows.Forms.DataVisualization.Charting;

namespace _20142178_TranManhHuy_QLSV
{
    public partial class StatisticResultForm : Form
    {
        SCORE score = new SCORE();
        MY_DB mydb = new MY_DB();
        public StatisticResultForm()
        {
            InitializeComponent();
        }

        private void StatisticResultForm_Load(object sender, EventArgs e)
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand("SELECT label FROM Course", mydb.getConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxSelectCourse.Items.Add(reader.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
            }

            reader.Close();
            command.Dispose();
            mydb.closeConnection();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // xóa hết các dữ liệu của barchart, piechart
            BarChart.Series["Student"].Points.Clear();
            PieChart.Series["Student"].Points.Clear();

            string course = comboBoxSelectCourse.Text;
            mydb.openConnection();
            SqlCommand command = new SqlCommand("SELECT Course.label AS [Course Name], AVG(Score.score) AS [Average Grade] FROM Course, Score WHERE Course.id = Score.courseId AND Course.label = '" + course + "'  GROUP BY Course.label", mydb.getConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                textBoxAvgGade.Text = reader.GetDouble(1).ToString();
            }

            reader.Close();
            command.Dispose();
            mydb.closeConnection();

            //display the values
            double totalStudent = Convert.ToDouble(score.totalCourseStudent(course));
            double totalStudentKem = Convert.ToDouble(score.totalCourseStudentByType(course, "Kém"));
            double totalStudentYeu = Convert.ToDouble(score.totalCourseStudentByType(course, "Yếu"));
            double totalStudentTBinh = Convert.ToDouble(score.totalCourseStudentByType(course, "Trung Bình"));
            double totalStudentKha = Convert.ToDouble(score.totalCourseStudentByType(course, "Khá"));
            double totalStudentGioi = Convert.ToDouble(score.totalCourseStudentByType(course, "Giỏi"));

            double StudentKemPercentage = (totalStudentKem * (100 / totalStudent));
            double StudentYeuPercentage = (totalStudentYeu * (100 / totalStudent));
            double StudentTBinhPercentage = (totalStudentTBinh * (100 / totalStudent));
            double StudentKhaPercentage = (totalStudentKha * (100 / totalStudent));
            double StudentGioiPercentage = (totalStudentGioi * (100 / totalStudent));

            labelTotal.Text = ("Total Students: " + totalStudent.ToString());
            labelKem.Text = ("Kém: " + (StudentKemPercentage.ToString("0.00") + "%"));
            labelYeu.Text = ("Yếu: " + (StudentYeuPercentage.ToString("0.00") + "%"));
            labelTB.Text = ("T.Bình: " + (StudentTBinhPercentage.ToString("0.00") + "%"));
            labelKha.Text = ("Khá: " + (StudentKhaPercentage.ToString("0.00") + "%"));
            labelGioi.Text = ("Giỏi: " + (StudentGioiPercentage.ToString("0.00") + "%"));

            //Pie Chart
            PieChart.Series[0].ChartType = SeriesChartType.Pie;
            PieChart.Series["Student"].Points.Add(totalStudentKem);
            PieChart.Series["Student"].Points[0].AxisLabel = (StudentKemPercentage.ToString("0.00") + "%");
            PieChart.Series["Student"].Points[0].LegendText = "Kém";
            PieChart.Series["Student"].Points[0].LabelForeColor = Color.White;
            PieChart.Series["Student"].Points[0].MarkerSize = 20;
            PieChart.Series["Student"].Points[0].Color = Color.Red;
            //
            PieChart.Series[0].ChartType = SeriesChartType.Pie;
            PieChart.Series["Student"].Points.Add(totalStudentYeu);
            PieChart.Series["Student"].Points[1].AxisLabel = (StudentYeuPercentage.ToString("0.00") + "%");
            PieChart.Series["Student"].Points[1].LegendText = "Yếu";
            PieChart.Series["Student"].Points[1].LabelForeColor = Color.White;
            PieChart.Series["Student"].Points[1].MarkerSize = 20;
            PieChart.Series["Student"].Points[1].Color = Color.Orange;
            //
            PieChart.Series[0].ChartType = SeriesChartType.Pie;
            PieChart.Series["Student"].Points.Add(totalStudentTBinh);
            PieChart.Series["Student"].Points[2].AxisLabel = (StudentTBinhPercentage.ToString("0.00") + "%");
            PieChart.Series["Student"].Points[2].LegendText = "Trung Bình";
            PieChart.Series["Student"].Points[2].LabelForeColor = Color.White;
            PieChart.Series["Student"].Points[2].MarkerSize = 20;
            PieChart.Series["Student"].Points[2].Color = Color.Yellow;
            //
            PieChart.Series[0].ChartType = SeriesChartType.Pie;
            PieChart.Series["Student"].Points.Add(totalStudentKha);
            PieChart.Series["Student"].Points[3].AxisLabel = (StudentKhaPercentage.ToString("0.00") + "%");
            PieChart.Series["Student"].Points[3].LegendText = "Khá";
            PieChart.Series["Student"].Points[3].LabelForeColor = Color.White;
            PieChart.Series["Student"].Points[3].MarkerSize = 20;
            PieChart.Series["Student"].Points[3].Color = Color.Green;
            //
            PieChart.Series[0].ChartType = SeriesChartType.Pie;
            PieChart.Series["Student"].Points.Add(totalStudentGioi);
            PieChart.Series["Student"].Points[4].AxisLabel = (StudentGioiPercentage.ToString("0.00") + "%");
            PieChart.Series["Student"].Points[4].LegendText = "Giỏi";
            PieChart.Series["Student"].Points[4].LabelForeColor = Color.White;
            PieChart.Series["Student"].Points[4].MarkerSize = 20;
            PieChart.Series["Student"].Points[4].Color = Color.Blue;
            //BarChar
            BarChart.Series["Student"].Points.Add(totalStudentKem);
            BarChart.Series["Student"].Points[0].AxisLabel = "Kém";
            BarChart.Series["Student"].Points[0].LegendText = "Kém";
            BarChart.Series["Student"].Points[0].Label = totalStudentKem.ToString();
            BarChart.Series["Student"].Points[0].Color = Color.Red;
            //
            BarChart.Series["Student"].Points.Add(totalStudentYeu);
            BarChart.Series["Student"].Points[1].AxisLabel = "Yếu";
            BarChart.Series["Student"].Points[1].LegendText = "Yếu";
            BarChart.Series["Student"].Points[1].Label = totalStudentYeu.ToString();
            BarChart.Series["Student"].Points[1].Color = Color.Orange;
            //
            BarChart.Series["Student"].Points.Add(totalStudentTBinh);
            BarChart.Series["Student"].Points[2].AxisLabel = "Trung Bình";
            BarChart.Series["Student"].Points[2].LegendText = "Trung Bình";
            BarChart.Series["Student"].Points[2].Label = totalStudentTBinh.ToString();
            BarChart.Series["Student"].Points[2].Color = Color.Yellow;
            //
            BarChart.Series["Student"].Points.Add(totalStudentKha);
            BarChart.Series["Student"].Points[3].AxisLabel = "Khá";
            BarChart.Series["Student"].Points[3].LegendText = "Khá";
            BarChart.Series["Student"].Points[3].Label = totalStudentKha.ToString();
            BarChart.Series["Student"].Points[3].Color = Color.Green;
            //
            BarChart.Series["Student"].Points.Add(totalStudentGioi);
            BarChart.Series["Student"].Points[4].AxisLabel = "Giỏi";
            BarChart.Series["Student"].Points[4].LegendText = "Giỏi";
            BarChart.Series["Student"].Points[4].Label = totalStudentGioi.ToString();
            BarChart.Series["Student"].Points[4].Color = Color.Blue;
        }

        private void btnSeeAllCourse_Click(object sender, EventArgs e)
        {
            AvgScoreByCourseForm AvgScoreByCourseForm = new AvgScoreByCourseForm();
            AvgScoreByCourseForm.Show(this);
        }
    }
}
