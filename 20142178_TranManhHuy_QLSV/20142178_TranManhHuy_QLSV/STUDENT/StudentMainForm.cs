using Microsoft.Office.Interop.Word;
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
    public partial class StudentMainForm : Form
    {
        MY_DB mydb = new MY_DB();
        
        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        bool isAddingItem = false;
        string studentID = Global.GlobalUserID;
        string fname;
        string lname;
        public StudentMainForm()
        {
            InitializeComponent();
        }
        public void getImageAbdUsername()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table = new System.Data.DataTable();

            SqlCommand command = new SqlCommand("SELECT Std.*, Log_in.* FROM Std INNER JOIN Log_in ON Log_in.Id = Std.id WHERE Log_in.Id  = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = Global.GlobalUserID;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxHr.Image = Image.FromStream(picture);

                lblWelcomeHr.Text = "Welcome Back (" + table.Rows[0]["username"].ToString() + ")";

                fname = table.Rows[0]["fname"].ToString();
                lname = table.Rows[0]["lname"].ToString();
            }
        }
        public void fillGrid(string position, SqlCommand command)
        {
            if (position == "pageCourse")
            {
                dataGridViewCourseContactList.ReadOnly = true;
                dataGridViewCourseContactList.DataSource = student.getStudents(command);
                dataGridViewCourseContactList.AllowUserToAddRows = false;
            }
            else if (position == "pageTimetable")
            {
                dataGridViewTimetable.ReadOnly = true;
                dataGridViewTimetable.DataSource = student.getStudents(command);
                dataGridViewTimetable.AllowUserToAddRows = false;
                dataGridViewTimetable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            else if (position == "pageNotification")
            {
                dataGridViewNotificationList.ReadOnly = true;
                dataGridViewNotificationList.DataSource = student.getStudents(command);
                dataGridViewNotificationList.AllowUserToAddRows = false;
            }
            else if (position == "pageScore")
            {
                dataGridViewScoreList.ReadOnly = true;
                dataGridViewScoreList.DataSource = student.getStudents(command);
                dataGridViewScoreList.AllowUserToAddRows = false;
            }

        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            getImageAbdUsername();

            // Tab page Course
            isAddingItem = true;
            comboBoxSelectSemester.Items.Add("All");
            comboBoxSelectSemester.Text = "All";
            isAddingItem = false;

            SqlCommand command = new SqlCommand("SELECT id AS ID, label AS [Course Name], period AS Period, description AS Description FROM Course INNER JOIN CourseStudent ON CourseStudent.courseName = Course.label WHERE CourseStudent.studentId = '" + studentID + "'");
            fillGrid("pageCourse", command);

            mydb.openConnection();
            SqlCommand commandSemester = new SqlCommand("SELECT DISTINCT semester FROM Course", mydb.getConnection);
            SqlDataReader reader = commandSemester.ExecuteReader();
            while (reader.Read())
            {
                comboBoxSelectSemester.Items.Add(reader.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
            }

            // Tab page Timetable
            SqlCommand commandTimetable = new SqlCommand("SELECT Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday FROM TimeTableStudent INNER JOIN Course ON TimeTableStudent.courseID = Course.id INNER JOIN CourseStudent ON CourseStudent.courseName = Course.label WHERE CourseStudent.studentId = '" + studentID + "' AND Course.semester = 'HK1'");
            fillGrid("pageTimetable", commandTimetable);

            comboBoxSemesterForTimetable.Text = "HK1";

            mydb.openConnection();
            SqlCommand commandSemesterTimetable = new SqlCommand("SELECT DISTINCT semester FROM Course", mydb.getConnection);
            SqlDataReader readerTimetable = commandSemesterTimetable.ExecuteReader();
            while (readerTimetable.Read())
            {
                comboBoxSemesterForTimetable.Items.Add(readerTimetable.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
            }

            readerTimetable.Close();
            commandSemesterTimetable.Dispose();

            // Tab page Notification
            isAddingItem = true;
            comboBoxSemesterInNotification.Items.Add("All");
            comboBoxSemesterInNotification.Text = "All";
            isAddingItem = false;

            mydb.openConnection();
            SqlCommand commandSemesterNotification = new SqlCommand("SELECT DISTINCT semester FROM Course", mydb.getConnection);
            SqlDataReader readerNotification = commandSemesterNotification.ExecuteReader();
            while (readerNotification.Read())
            {
                comboBoxSemesterInNotification.Items.Add(readerNotification.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
            }

            readerNotification.Close();
            commandSemesterNotification.Dispose();

            mydb.openConnection();
            SqlCommand commandCourseNotification = new SqlCommand("SELECT courseName FROM CourseStudent WHERE studentId = '" + studentID + "'", mydb.getConnection);
            SqlDataReader readerCourse = commandCourseNotification.ExecuteReader();
            while (readerCourse.Read())
            {
                comboBoxCourseinNotification.Items.Add(readerCourse.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
            }

            readerCourse.Close();
            commandCourseNotification.Dispose();

            SqlCommand commandNotification = new SqlCommand("SELECT Notification.id AS STT, Notification.fullName AS [Sender], Notification.courseName AS [Course Name], Notification.title AS [Title], Notification.timeSend AS [Time Send] FROM Notification INNER JOIN CourseStudent ON CourseStudent.courseName = Notification.courseName WHERE CourseStudent.studentId = '" + studentID + "'");
            fillGrid("pageNotification", commandNotification);

            // Tab page Score
            isAddingItem = true;
            comboBoxSemesterInScore.Items.Add("All");
            comboBoxSemesterInScore.Text = "All";
            isAddingItem = false;
            mydb.openConnection();
            SqlCommand commandSemesterScore = new SqlCommand("SELECT DISTINCT semester FROM Course", mydb.getConnection);
            SqlDataReader readerSemesterScore = commandSemesterScore.ExecuteReader();
            while (readerSemesterScore.Read())
            {
                comboBoxSemesterInScore.Items.Add(readerSemesterScore.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
            }

            readerSemesterScore.Close();
            commandSemesterScore.Dispose();

            SqlCommand commandScore = new SqlCommand("SELECT Score.studentId AS [Student ID], Course.label AS [Course Name], Score.score AS [Score], Score.description AS [Description], Score.result AS [Result] FROM Score INNER JOIN Course ON Course.id = Score.courseId WHERE Score.studentId = '" + studentID + "'");
            fillGrid("pageScore", commandScore);

            lblAvgScore.Text = ("Average Score (All Semester): " + score.avgAllCourseStudent(studentID));
        }
        private void comboBoxCourseinNotification_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseName = comboBoxCourseinNotification.Text;
            SqlCommand commandNotification = new SqlCommand("SELECT Notification.id AS STT, Notification.fullName AS [Sender], Notification.courseName AS [Course Name], Notification.title AS [Title], Notification.timeSend AS [Time Send] FROM Notification INNER JOIN CourseStudent ON CourseStudent.courseName = Notification.courseName WHERE CourseStudent.studentId = '" + studentID + "' AND CourseStudent.courseName = '" + courseName + "'");
            fillGrid("pageNotification", commandNotification);
        }
        private void comboBoxSemesterInNotification_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isAddingItem)
            {
                return;
            }
            comboBoxCourseinNotification.Items.Clear();
            comboBoxCourseinNotification.ResetText();

            if (comboBoxSemesterInNotification.Text == "All")
            {
                mydb.openConnection();
                SqlCommand commandCourseNotification = new SqlCommand("SELECT courseName FROM CourseStudent WHERE studentId = '" + studentID + "'", mydb.getConnection);
                SqlDataReader readerCourse = commandCourseNotification.ExecuteReader();
                while (readerCourse.Read())
                {
                    comboBoxCourseinNotification.Items.Add(readerCourse.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
                }

                readerCourse.Close();
                commandCourseNotification.Dispose();
            }
            else
            {
                string semester = comboBoxSemesterInNotification.Text;
                mydb.openConnection();
                SqlCommand commandCourseNotification = new SqlCommand("SELECT courseName FROM CourseStudent WHERE studentId = '" + studentID + "' AND semester = '" + semester + "'", mydb.getConnection);
                SqlDataReader readerCourse = commandCourseNotification.ExecuteReader();
                while (readerCourse.Read())
                {
                    comboBoxCourseinNotification.Items.Add(readerCourse.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
                }

                readerCourse.Close();
                commandCourseNotification.Dispose();
            }
        }

        private void comboBoxSemesterForTimetable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string semester = comboBoxSemesterForTimetable.Text;
            SqlCommand commandTimetable = new SqlCommand("SELECT Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday FROM TimeTableStudent INNER JOIN Course ON TimeTableStudent.courseID = Course.id INNER JOIN CourseStudent ON CourseStudent.courseName = Course.label WHERE CourseStudent.studentId = '" + studentID + "' AND Course.semester = '" + semester + "'");
            fillGrid("pageTimetable", commandTimetable);
        }

        private void comboBoxSelectSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isAddingItem)
            {
                return;
            }

            if (comboBoxSelectSemester.Text == "All")
            {
                SqlCommand command = new SqlCommand("SELECT id AS ID, label AS [Course Name], period AS Period, description AS Description FROM Course INNER JOIN CourseStudent ON CourseStudent.courseName = Course.label WHERE CourseStudent.studentId = '" + studentID + "'");
                fillGrid("pageCourse", command);
            }
            else
            {
                string semester = comboBoxSelectSemester.Text;

                SqlCommand command = new SqlCommand("SELECT id AS ID, label AS [Course Name], period AS Period, description AS Description FROM Course INNER JOIN CourseStudent ON CourseStudent.courseName = Course.label WHERE CourseStudent.studentId = '" + studentID + "' AND CourseStudent.semester ='" + semester + "'");
                fillGrid("pageCourse", command);
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            StudentAddCourseForm StdAddCourseF = new StudentAddCourseForm(studentID, fname, lname);
            StdAddCourseF.Show(this);
        }
        private void btnShowAllCourse_Click(object sender, EventArgs e)
        {
            string semester = comboBoxSemesterInNotification.Text;
            if (semester == "All")
            {
                SqlCommand commandNotification = new SqlCommand("SELECT Notification.id AS STT, Notification.fullName AS [Sender], Notification.courseName AS [Course Name], Notification.title AS [Title], Notification.timeSend AS [Time Send] FROM Notification INNER JOIN CourseStudent ON CourseStudent.courseName = Notification.courseName WHERE CourseStudent.studentId = '" + studentID + "'");
                fillGrid("pageNotification", commandNotification);
            }
            else
            {
                SqlCommand commandNotification = new SqlCommand("SELECT Notification.id AS STT, Notification.fullName AS [Sender], Notification.courseName AS [Course Name], Notification.title AS [Title], Notification.timeSend AS [Time Send] FROM Notification INNER JOIN CourseStudent ON CourseStudent.courseName = Notification.courseName WHERE CourseStudent.studentId = '" + studentID + "' AND CourseStudent.semester = '" + semester + "'");
                fillGrid("pageNotification", commandNotification);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dataGridViewNotificationList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Course!", "Select Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dataGridViewNotificationList.SelectedRows[0].Cells["STT"].Value;

            mydb.openConnection();

            SqlCommand command = new SqlCommand("SELECT content FROM Notification WHERE id = " + id, mydb.getConnection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            { // kiểm tra xem SqlDataReader có chứa dữ liệu hay không
                while (reader.Read())
                {
                    textBoxContent.Text = reader.GetString(0);
                }
            }

            reader.Close();
            command.Dispose();
            mydb.closeConnection();
        }

        private void btnSearchStd_Click(object sender, EventArgs e)
        {
            string semester = comboBoxSemesterInScore.Text;
            if (semester == "All")
            {
                SqlCommand commandScore = new SqlCommand("SELECT Score.studentId AS [Student ID], Course.label AS [Course Name], Score.score AS [Score], Score.description AS [Description], Score.result AS [Result] FROM Score INNER JOIN Course ON Course.id = Score.courseId WHERE Score.studentId = '" + studentID + "'");
                fillGrid("pageScore", commandScore);

                lblAvgScore.Text = ("Average Score (All Semester): " + score.avgAllCourseStudent(studentID));
            }
            else
            {
                SqlCommand commandScore = new SqlCommand("SELECT Score.studentId AS [Student ID], Course.label AS [Course Name], Score.score AS [Score], Score.description AS [Description], Score.result AS [Result] FROM Score INNER JOIN Course ON Course.id = Score.courseId WHERE Score.studentId = '" + studentID + "' AND Course.semester = '" + semester + "'");
                fillGrid("pageScore", commandScore);

                lblAvgScore.Text = ("Average Score (" + semester + "): " + score.avgCourseStudentBySemester(studentID, semester));
            }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourseContactList.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                try
                {
                    saveFileDialog.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog.FileName = ".docx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        exportDataToWord("pageCourse", dataGridViewCourseContactList, saveFileDialog.FileName);
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

        private void btnPrintTimetable_Click(object sender, EventArgs e)
        {
            if (dataGridViewTimetable.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                try
                {
                    saveFileDialog.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog.FileName = ".docx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        exportDataToWord("pageTimetable", dataGridViewTimetable, saveFileDialog.FileName);
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

        private void btnPrintScore_Click(object sender, EventArgs e)
        {
            if (dataGridViewScoreList.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                try
                {
                    saveFileDialog.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog.FileName = ".docx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        exportDataToWord("pageScore", dataGridViewScoreList, saveFileDialog.FileName);
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
        public void exportDataToWord(string position, DataGridView DGV, string filename)
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

                        if (position == "pageCourse")
                        {
                            para1.Range.Text = "\t\t\t\t\tCỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM\n" +
                            "\t\t\t\t\t\t\t\t\t\t\tĐộc lập – Tự do – Hạnh phúc\n" +
                            "\t\t\t\t\t\t\t\t\t\t\t\t\t" + time + "\n" +
                            "\t\t\t\t\t\t\t\t" + "COURSE LIST\n";
                        }
                        else if (position == "pageTimetable")
                        {
                            para1.Range.Text = "\t\t\t\t\tCỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM\n" +
                            "\t\t\t\t\t\t\t\t\t\t\tĐộc lập – Tự do – Hạnh phúc\n" +
                            "\t\t\t\t\t\t\t\t\t\t\t\t\t" + time + "\n" +
                            "\t\t\t\t\t\t\t\t" + "TIMETABLE\n";
                        }
                        else if (position == "pageScore")
                        {
                            para1.Range.Text = "\t\t\t\t\tCỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM\n" +
                            "\t\t\t\t\t\t\t\t\t\t\tĐộc lập – Tự do – Hạnh phúc\n" +
                            "\t\t\t\t\t\t\t\t\t\t\t\t\t" + time + "\n" +
                            "\t\t\t\t\t\t\t\t" + "SCORE LIST\n";
                        }

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

                        para1.Range.Text = "Student ID: " + studentID;
                        para1.Range.Font.Size = 12;
                        para1.Range.Bold = 0;
                        para1.Range.Underline = 0;
                        para1.Range.Font.Name = "Times New Roman";
                        para1.Range.InsertParagraphAfter();

                        para1.Range.Text = "Full Name: " + fname + " " + lname;
                        para1.Range.Font.Size = 12;
                        para1.Range.Bold = 0;
                        para1.Range.Underline = 0;
                        para1.Range.Font.Name = "Times New Roman";
                        para1.Range.InsertParagraphAfter();

                        if (position == "pageCourse")
                        {
                            para1.Range.Text = "Semester: " + comboBoxSelectSemester.Text;
                        }
                        else if (position == "pageTimetable")
                        {
                            para1.Range.Text = "Semester: " + comboBoxSemesterForTimetable.Text;
                        }
                        else if (position == "pageScore")
                        {
                            para1.Range.Text = "Semester: " + comboBoxSemesterInScore.Text;
                        }
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
    }
}
