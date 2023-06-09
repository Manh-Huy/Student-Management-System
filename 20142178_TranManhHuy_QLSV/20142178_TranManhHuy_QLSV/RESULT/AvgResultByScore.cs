//using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20142178_TranManhHuy_QLSV
{
    public partial class AvgResultByScore : Form
    {
        STUDENT student = new STUDENT();
        public AvgResultByScore()
        {
            InitializeComponent();
        }

        private void AvgResultByScore_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id AS [ID], fname AS [First Name], lname AS [Last Name], faculty AS [Faculty], major AS [Major], acayear AS [Academic Year] FROM Std");

            dataGridViewAvgRusultScore.ReadOnly = true;
            dataGridViewAvgRusultScore.DataSource = student.getStudents(command);
            dataGridViewAvgRusultScore.AllowUserToAddRows = false;

            // dùng combo box lấy tên các niên khóa
            comboBoxFAcaYear.DataSource = student.getAcayear();
            comboBoxFAcaYear.DisplayMember = "acayear";
            //comboBoxAcaYear.ValueMember = "id";
            comboBoxFAcaYear.SelectedItem = null;

            // dùng combo box lấy tên khoa
            comboBoxFFaculty.DataSource = student.getFaculty();
            comboBoxFFaculty.DisplayMember = "faculty";
            //comboBoxFaculty.ValueMember = "id";
            comboBoxFFaculty.SelectedItem = null;

            // dùng combo box lấy tên ngành
            comboBoxFMajor.DataSource = student.getMajor();
            comboBoxFMajor.DisplayMember = "major";
            //comboBoxMajor.ValueMember = "id";
            comboBoxFMajor.SelectedItem = null;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT id AS [ID], fname AS [First Name], lname AS [Last Name], faculty AS [Faculty], major AS [Major], acayear AS [Academic Year] FROM Std WHERE";
            string temp = query;

            // kiểm tra câu lệnh query có thay đổi không (nhập nhiều hơn 1 tính năng để tìm kiếm)
            void checkQueryChange()
            {
                if (query != temp)
                {
                    query += " AND";
                }
            }

            //textbox ID
            if (!string.IsNullOrEmpty(textBoxFID.Text))
            {
                string id = textBoxFID.Text;
                query += " id = " + id;
            }

            //textbox FirstName
            if (!string.IsNullOrEmpty(textBoxFFName.Text))
            {
                checkQueryChange();

                string fname = textBoxFFName.Text;
                query += " fname = '" + fname + "'";
            }

            //textbox LastName
            if (!string.IsNullOrEmpty(textBoxFLName.Text))
            {
                checkQueryChange();

                string lname = textBoxLastName.Text;
                query += " lname = '" + lname + "'";
            }

            // comboBox Faculty
            if (!string.IsNullOrEmpty(comboBoxFFaculty.Text))
            {
                checkQueryChange();

                string faculty = comboBoxFFaculty.Text;
                query += " faculty = '" + faculty + "'";
            }

            // comboBox Major
            if (!string.IsNullOrEmpty(comboBoxFMajor.Text))
            {
                checkQueryChange();

                string major = comboBoxFMajor.Text;
                query += " major = '" + major + "'";
            }

            // comboBox Academic Year
            if (!string.IsNullOrEmpty(comboBoxFAcaYear.Text))
            {
                checkQueryChange();

                string acayear = comboBoxFAcaYear.Text;
                query += " acayear = '" + acayear + "'";
            }

            // nếu không chọn bất kì lựa chọn nào thì sẽ hiện ta tất cả thông tin trong bảng Std và thông báo
            if (query == temp)
            {
                query = "SELECT id AS [ID], fname AS [First Name], lname AS [Last Name], faculty AS [Faculty], major AS [Major], acayear AS [Academic Year] FROM Std";
                MessageBox.Show("Not Found", "Find", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            SqlCommand command = new SqlCommand(query);

            dataGridViewAvgRusultScore.ReadOnly = true;
            dataGridViewAvgRusultScore.DataSource = student.getStudents(command);
            dataGridViewAvgRusultScore.AllowUserToAddRows = false;
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id AS [ID], fname AS [First Name], lname AS [Last Name], faculty AS [Faculty], major AS [Major], acayear AS [Academic Year] FROM Std");

            dataGridViewAvgRusultScore.ReadOnly = true;
            dataGridViewAvgRusultScore.DataSource = student.getStudents(command);
            dataGridViewAvgRusultScore.AllowUserToAddRows = false;
        }

        private void dataGridViewAvgRusultScore_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxStudentID.Text = dataGridViewAvgRusultScore.CurrentRow.Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridViewAvgRusultScore.CurrentRow.Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridViewAvgRusultScore.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnShowScores_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Score.courseId AS [Course ID], Course.label AS [Course Name], Score.score AS [Score], Score.description AS[Description] , Score.result AS [Result] FROM Course INNER JOIN Score ON Score.courseId = Course.id WHERE score.studentId = '" + textBoxStudentID.Text + "'");
            dataGridViewAvgRusultScore.ReadOnly = true;
            dataGridViewAvgRusultScore.DataSource = student.getStudents(command);
            dataGridViewAvgRusultScore.AllowUserToAddRows = false;

            // xóa hết các dữ liệu của barchart
            BarChart.Series["Course"].Points.Clear();


            //BarChar
            BarChart.ChartAreas[0].AxisX.Minimum = 0;
            BarChart.ChartAreas[0].AxisX.Maximum = 10;
            BarChart.ChartAreas[0].AxisX.Title = "Score";
            BarChart.ChartAreas[0].AxisY.Title = "Course";
            BarChart.Legends.Clear();  // xóa chú thích
            // xóa các đường kẻ ngang, dọc trong barchar
            BarChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0; 
            BarChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;


            List<string> courseList = new List<string>();

            if (dataGridViewAvgRusultScore.RowCount > 0)
            {
                foreach (DataGridViewRow row in dataGridViewAvgRusultScore.Rows)
                {
                    string course = row.Cells["Course Name"].Value.ToString();
                    courseList.Add(course);
                }
            }

            List<float> scoreList = new List<float>();

            if (dataGridViewAvgRusultScore.RowCount > 0)
            {
                foreach (DataGridViewRow row in dataGridViewAvgRusultScore.Rows)
                {
                    float score = float.Parse(row.Cells["Score"].Value.ToString());
                    scoreList.Add(score);
                }
            }

            Random random = new Random();
            for (int i = 0; i < courseList.Count; i++)
            {
                float score = scoreList[i];
                string course = courseList[i];

                Color randomColor = Color.FromArgb(
                    random.Next(256), // Giá trị màu đỏ (0-255)
                    random.Next(256), // Giá trị màu xanh lá cây (0-255)
                    random.Next(256)  // Giá trị màu xanh lam (0-255)
                );

                BarChart.Series["Course"].Points.Add(score);
                BarChart.Series["Course"].Points[i].AxisLabel = course;
                BarChart.Series["Course"].Points[i].LegendText = course;
                BarChart.Series["Course"].Points[i].Label = score.ToString();
                BarChart.Series["Course"].Points[i].Color = randomColor;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridViewAvgRusultScore.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                try
                {
                    saveFileDialog.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog.FileName = ".docx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        exportDataToWord(dataGridViewAvgRusultScore, saveFileDialog.FileName);
                    }
                    MessageBox.Show("Data Exported Successfully !!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void exportDataToWord(DataGridView DGV, string filename)
        {
            try
            {
                if (DGV.Rows.Count != 0)
                {
                    // Tạo đường dẫn đến word
                    _Application oWord = new Microsoft.Office.Interop.Word.Application();
                    int RowCount = DGV.Rows.Count;
                    int ColumnCount = DGV.Columns.Count;
                    _Document wordDoc = oWord.Documents.Add();
                    wordDoc.Application.Visible = true;
                    wordDoc.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;

                    object missing = System.Reflection.Missing.Value;
                    Paragraph para1 = wordDoc.Content.Paragraphs.Add(ref missing);
                    string time = "Ngày " + DateTime.Today.Day.ToString("00") + " Tháng " + DateTime.Today.Month.ToString("00") + " Năm "
                        + DateTime.Today.Year.ToString("0000");
                    foreach (Microsoft.Office.Interop.Word.Section section in wordDoc.Sections)
                    {
                        //Get the header range and add the header details.
                        Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                        headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        //para1.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;   // Màu

                        //// Thêm ảnh vào vị trí mong muốn
                        //InlineShape picture = wordDoc.InlineShapes.AddPicture(@"F:\Desktop\logo.jpg");
                        //Selection selection = (Selection)picture.Range;
                        //selection.MoveLeft(WdUnits.wdCharacter, 99999, WdMovementType.wdMove);
                        //selection.MoveUp(WdUnits.wdLine, 99999, WdMovementType.wdMove);

                        para1.Range.Font.Bold = 1;        // Độ Đậm Chữ
                        para1.Range.Font.Size = 14;
                        para1.Range.Font.Name = "Times New Roman";
                        headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                        para1.Range.Text = "\t\t\t\t\tCỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM\n" +
                            "\t\t\t\t\t\t\t\t\t\t\tĐộc lập – Tự do – Hạnh phúc\n" +
                            "\t\t\t\t\t\t\t\t\t\t\t\t\t" + time + "\n" +
                            "\t\t\t\t\t\t\t\t" + " RESLUT LIST\n";

                        para1.Range.InsertParagraphAfter();

                        //Khai báo đường dẫn tới file hình ảnh
                        string imagePath = @"F:\Desktop\Windows Programming\logo.jpg";
                        // Chọn vị trí để chèn hình ảnh
                        Microsoft.Office.Interop.Word.Range range = wordDoc.Range();
                        // Thêm hình ảnh vào văn bản
                        InlineShape picture = range.InlineShapes.AddPicture(imagePath);

                        // Thay đổi kích thước hình ảnh (nếu cần thiết)
                        //picture.Width = 150;
                        //picture.Height = 60;

                        para1.Range.Text = "Student ID: " + textBoxStudentID.Text;
                        para1.Range.Font.Size = 12;
                        para1.Range.Bold = 0;
                        para1.Range.Underline = 0;
                        para1.Range.Font.Name = "Times New Roman";
                        para1.Range.InsertParagraphAfter();

                        para1.Range.Text = "Full Name: " + textBoxFirstName.Text + " " + textBoxLastName.Text;
                        para1.Range.Font.Size = 12;
                        para1.Range.Bold = 0;
                        para1.Range.Underline = 0;
                        para1.Range.Font.Name = "Times New Roman";
                        para1.Range.InsertParagraphAfter();

                        Microsoft.Office.Interop.Word.Range footersRange = section.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        para1.Range.Fields.Add(footersRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                        para1.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        para1.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;   // Màu
                        para1.Range.Font.Bold = 2;        // Độ Đậm Chữ
                        para1.Range.Font.Size = 14;
                        para1.Range.Font.Name = "Times New Roman";
                        para1.Range.Text = "TP.HCM, " + time;


                        section.Borders.Enable = 1;
                        section.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                        section.Borders.OutsideLineWidth = WdLineWidth.wdLineWidth300pt;
                        section.Borders.OutsideColor = WdColor.wdColorBlack;

                    }
                    Table table = wordDoc.Tables.Add(para1.Range, DGV.Rows.Count + 1, DGV.Columns.Count, ref missing, ref missing);
                    // Table table = wordDoc.Tables.Add(wordDoc.Range(), DGV.RowCount + 1, DGV.ColumnCount);
                    table.Borders.Enable = 1;
                    // Thêm tên cột cho bảng
                    var headerRow = table.Rows[1];
                    for (int i = 0; i < DGV.ColumnCount; i++)
                    {
                        headerRow.Cells[i + 1].Range.Text = DGV.Columns[i].HeaderText;
                    }

                    // Thêm dữ liệu từ DataGridView vào bảng
                    for (int r = 0; r <= RowCount - 1; r++)
                    {
                        for (int c = 0; c < ColumnCount; c++)
                        {

                            if (DGV.Rows[r].Cells[c].Value != null)
                            {
                                // Check ở cột Có tên là Birth Date thì không in ra giờ 
                                if (DGV.Columns[c].HeaderText == "Birthdate")
                                {
                                    DateTime dt = (DateTime)DGV.Rows[r].Cells[c].Value;
                                    string Bdate = dt.ToString("dd/MM/yyyy");
                                    table.Cell(r + 2, c + 1).Range.InsertAfter(Bdate);
                                }

                                // Nếu tên cột là "Picture", chèn hình ảnh vào ô tương ứng


                                /*Để chèn hình ảnh vào ô tương ứng nếu tên cột là "Picture", 
                                    sử dụng câu lệnh kiểm tra if (DGV.Columns[c].HeaderText == "Picture"), 
                                        và chèn hình ảnh vào bằng cách sử dụng đoạn mã tương tự như trong đoạn mã ban đầu.*/

                                else if (DGV.Columns[c].HeaderText == "Picture")
                                {
                                    byte[] imgbyte = (byte[])DGV.Rows[r].Cells[c].Value;
                                    if (imgbyte != null)
                                    {
                                        MemoryStream ms = new MemoryStream(imgbyte);
                                        System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                                        System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new Size(90, 90)));
                                        Clipboard.SetDataObject(finalPic);
                                        table.Cell(r + 2, c + 1).Range.Paste();
                                    }
                                }
                                else
                                {
                                    table.Cell(r + 2, c + 1).Range.Text = DGV.Rows[r].Cells[c].Value.ToString();
                                }
                            }
                            else
                            {
                                table.Cell(r + 2, c + 1).Range.Text = "";
                            }
                        }
                    }

                    // Lưu tài liệu Word
                    wordDoc.SaveAs2(filename);
                }
            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
