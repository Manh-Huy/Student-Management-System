//using Microsoft.Office.Interop.Excel;
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
    public partial class ContactListStudentScoreList : Form
    {
        MY_DB mydb = new MY_DB();
        CONTACT contact = new CONTACT();
        SCORE score = new SCORE();
        bool isAddingItem = false;
        string contactID = Global.GlobalUserID;
        string fname;
        string lname;
        public ContactListStudentScoreList()
        {
            InitializeComponent();
        }
        public void getImageAbdUsername()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table = new System.Data.DataTable();

            SqlCommand command = new SqlCommand("SELECT MyContact.*, Log_in_Contact.* FROM MyContact INNER JOIN Log_in_Contact ON contactID = Id WHERE contactID = @id", mydb.getConnection);
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
        public void fillGrid(SqlCommand command)
        {
            dataGridViewScoreList.ReadOnly = true;
            dataGridViewScoreList.DataSource = contact.getContacts(command);
            dataGridViewScoreList.AllowUserToAddRows = false;
        }
        private void ContactListStudentScoreList_Load(object sender, EventArgs e)
        {
            getImageAbdUsername();

            isAddingItem = true;
            comboBoxSemesterInAddScore.Items.Add("All");
            comboBoxSemesterInAddScore.Text = "All";
            isAddingItem = false;
            mydb.openConnection();
            SqlCommand commandSemesterAddSccore = new SqlCommand("SELECT DISTINCT semester FROM Course", mydb.getConnection);
            SqlDataReader readerSemesterAddScore = commandSemesterAddSccore.ExecuteReader();
            while (readerSemesterAddScore.Read())
            {
                comboBoxSemesterInAddScore.Items.Add(readerSemesterAddScore.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
            }

            readerSemesterAddScore.Close();
            commandSemesterAddSccore.Dispose();

            mydb.openConnection();
            SqlCommand commandCourseAddScore = new SqlCommand("SELECT label FROM Course WHERE contactID = '" + contactID + "'", mydb.getConnection);
            SqlDataReader readerCourseAddScore = commandCourseAddScore.ExecuteReader();
            while (readerCourseAddScore.Read())
            {
                comboBoxCourseInAddCourse.Items.Add(readerCourseAddScore.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
            }

            readerCourseAddScore.Close();
            commandCourseAddScore.Dispose();
        }
        
        private void comboBoxSemesterInAddScore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isAddingItem)
            {
                return;
            }
            comboBoxCourseInAddCourse.Items.Clear();
            comboBoxCourseInAddCourse.ResetText();

            if (comboBoxSemesterInAddScore.Text == "All")
            {
                mydb.openConnection();
                SqlCommand commandCourseAddScore = new SqlCommand("SELECT label FROM Course WHERE contactID = '" + contactID + "'", mydb.getConnection);
                SqlDataReader readerCourseAddScore = commandCourseAddScore.ExecuteReader();
                while (readerCourseAddScore.Read())
                {
                    comboBoxCourseInAddCourse.Items.Add(readerCourseAddScore.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
                }

                readerCourseAddScore.Close();
                commandCourseAddScore.Dispose();
            }
            else
            {
                string semester = comboBoxSemesterInAddScore.Text;
                mydb.openConnection();
                SqlCommand commandCourseAddScore = new SqlCommand("SELECT label FROM Course WHERE contactID = '" + contactID + "' AND semester = '" + semester + "'", mydb.getConnection);
                SqlDataReader readerCourseAddScore = commandCourseAddScore.ExecuteReader();
                while (readerCourseAddScore.Read())
                {
                    comboBoxCourseInAddCourse.Items.Add(readerCourseAddScore.GetString(0)); // thêm vào combobox cột thứ 0 trong bảng
                }

                readerCourseAddScore.Close();
                commandCourseAddScore.Dispose();
            }
        }

        private void btnSearchStd_Click(object sender, EventArgs e)
        {
            string courseName = comboBoxCourseInAddCourse.Text;

            if (courseName == "")
            {
                MessageBox.Show("Please Choose Course", "Show Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // lấy courseId
            int courseID = 0;

            SqlCommand takeCourseIdCommand = new SqlCommand("SELECT * FROM Course WHERE label = '" + courseName + "'", mydb.getConnection);
            mydb.openConnection();
            SqlDataReader reader = takeCourseIdCommand.ExecuteReader();
            while (reader.Read())
            {
                courseID = reader.GetInt32(0);
            }

            if (courseID == 0)
            {
                MessageBox.Show("Error!", "Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            takeCourseIdCommand.Dispose();
            reader.Close();

            SqlCommand command = new SqlCommand("SELECT Score.studentId AS [Student ID], Std.fname AS [First Name], Std.lname AS [Last Name], Std.bdate AS [Birth Day], Score.score AS [Score], Score.result AS [Result] FROM Score INNER JOIN Std ON Std.id = Score.studentId WHERE courseId = '" + courseID + "'");
            fillGrid(command);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string courseName = comboBoxCourseInAddCourse.Text;

            if (dataGridViewScoreList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Student!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentID = (string)dataGridViewScoreList.SelectedRows[0].Cells["Student ID"].Value;

            // lấy courseId
            int courseID = 0;

            SqlCommand takeCourseIdCommand = new SqlCommand("SELECT * FROM Course WHERE label = '" + courseName + "'", mydb.getConnection);
            mydb.openConnection();
            SqlDataReader reader = takeCourseIdCommand.ExecuteReader();
            while (reader.Read())
            {
                courseID = reader.GetInt32(0);
            }

            if (courseID == 0)
            {
                MessageBox.Show("Error!", "Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            takeCourseIdCommand.Dispose();
            reader.Close();

            if ((MessageBox.Show("Are you sure you want to delete this score", "Remove score", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                if (score.deleteScore(studentID, courseID))
                {
                    MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewScoreList.DataSource = score.getStudentScore();
                }
                else
                {
                    MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
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
                            exportDataToWord(dataGridViewScoreList, saveFileDialog.FileName);
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
        }
        public void exportDataToWord(DataGridView DGV, string filename)
        {
            // lấy tên contact
            string nameContact = "";
            string courseName = comboBoxCourseInAddCourse.Text;

            mydb.openConnection();
            SqlCommand command = new SqlCommand("SELECT CONCAT(fname, ' ', lname)  FROM MyContact INNER JOIN Course ON Course.contactID = MyContact.contactID WHERE label = '" + courseName + "'", mydb.getConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                nameContact = reader.GetString(0); // thêm vào combobox cột thứ 0 trong bảng
            }

            reader.Close();
            command.Dispose();
            
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
                            "\t\t\t\t\t\t\t\t" + "SCORE LIST\n";

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

                        para1.Range.Text = "Course: " + comboBoxCourseInAddCourse.Text;
                        para1.Range.Font.Size = 12;
                        para1.Range.Bold = 0;
                        para1.Range.Underline = 0;
                        para1.Range.Font.Name = "Times New Roman";
                        para1.Range.InsertParagraphAfter();

                        para1.Range.Text = "Teacher: " + nameContact;
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
                                if (DGV.Columns[c].HeaderText == "Birth Day")
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
