using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System;
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


namespace _20142178_TranManhHuy_QLSV
{
    public partial class PrintStudentForm : Form
    {
        public PrintStudentForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void PrintStudentForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT stt AS STT, id AS ID, fname AS [First Name], lname AS [Last Name], bdate AS BirthDate, gender AS Gender, phone AS Phone, address AS [Address], faculty AS Faculty, major AS Major, hometown AS Hometown, acayear AS [Academic Year], email AS Email, picture AS Picture FROM Std");
            fillGrid(command);
            // dieu khien cac radiobutton chuyen trang thai
            if (RadioButtonNo.Checked)
            {
                DateTimePickerStartTime.Enabled = false;
                DateTimePickerEndTime.Enabled = false;
            }
        }

        private void RadioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            DateTimePickerStartTime.Enabled = true;
            DateTimePickerEndTime.Enabled = true;
        }

        private void RadioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            DateTimePickerStartTime.Enabled = false;
            DateTimePickerEndTime.Enabled = false;
        }

        //copy lại
        public void fillGrid(SqlCommand command)
        {
            dataGridViewStudentList.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewStudentList.RowTemplate.Height = 80;
            dataGridViewStudentList.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridViewStudentList.Columns[13];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewStudentList.AllowUserToAddRows = false;

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            String query = "SELECT stt AS STT, id AS ID, fname AS [First Name], lname AS [Last Name], bdate AS BirthDate, gender AS Gender, phone AS Phone, address AS [Address], faculty AS Faculty, major AS Major, hometown AS Hometown, acayear AS [Academic Year], email AS Email, picture AS Picture FROM Std ";
            if (RadioButtonYes.Checked)
            {
                string date1 = DateTimePickerStartTime.Value.ToString("yyyy-MM-dd");
                string date2 = DateTimePickerEndTime.Value.ToString("yyyy-MM-dd");

                if (RadioButtonMale.Checked)
                {
                    query += "WHERE gender = 'Male' AND bdate BETWEEN '" + date1 + " 'AND' " + date2 + "'";
                }
                else if (RadioButtonFemale.Checked)
                {
                    query += "WHERE gender = 'Female' AND bdate BETWEEN '" + date1 + " 'AND' " + date2 + "'";

                }
                else
                {
                    query += "WHERE bdate BETWEEN '" + date1 + " 'AND' " + date2 + "'";
                }

                command = new SqlCommand(query);
                fillGrid(command);
            }
            else  // neu khong can theo date
            {
                if (RadioButtonMale.Checked)
                {
                    query += "WHERE gender = 'Male'";
                }
                else if (RadioButtonFemale.Checked)
                {
                    query += "WHERE gender = 'Female'";
                }
                else
                {
                    // chọn All
                    query = "SELECT stt AS STT, id AS ID, fname AS [First Name], lname AS [Last Name], bdate AS BirthDate, gender AS Gender, phone AS Phone, address AS [Address], faculty AS Faculty, major AS Major, hometown AS Hometown, acayear AS [Academic Year], email AS Email, picture AS Picture FROM Std ";

                }

                command = new SqlCommand(query);
                fillGrid(command);
            }
        }

        private void btnSavetoTextFile_Click(object sender, EventArgs e)
        {
            if (comboBoxSaveToFile.Text == "")
            {
                MessageBox.Show("Please Choose Type File To Save", "Save File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxSaveToFile.Text == "File Txt")
            {
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\students_list.txt";
                using (var writer = new StreamWriter(path))
                {
                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }

                    DateTime bdate;

                    for (int i = 0; i < dataGridViewStudentList.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewStudentList.Columns.Count - 1; j++)
                        {
                            if (j == 4)
                            {
                                bdate = Convert.ToDateTime(dataGridViewStudentList.Rows[i].Cells[j].Value.ToString());
                                writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" + "|");
                            }
                            else if (j == dataGridViewStudentList.Columns.Count - 2)
                            {
                                writer.Write("\t" + dataGridViewStudentList.Rows[i].Cells[j].Value.ToString());
                            }
                            else
                            {
                                writer.Write("\t" + dataGridViewStudentList.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                            }
                        }
                        writer.WriteLine("");
                        writer.WriteLine("-------------------------------------------------------------------------------------");
                    }
                }
                MessageBox.Show("Save To Text File Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxSaveToFile.Text == "File Word")
            {
                if (dataGridViewStudentList.Rows.Count > 0)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    try
                    {
                        saveFileDialog.Filter = "Word Documents (.docx)|.docx";
                        saveFileDialog.FileName = ".docx";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            exportDataToWord(dataGridViewStudentList, saveFileDialog.FileName);
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
            else if (comboBoxSaveToFile.Text == "File Excel")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FileName = "students_list.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = false;
                    Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                    Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;

                    // đưa tiêu đề từ DataGridView vào Excel
                    for (int i = 1; i <= dataGridViewStudentList.Columns.Count - 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridViewStudentList.Columns[i - 1].HeaderText;
                    }

                    // đưa dữ liệu từ DataGridView vào Excel
                    for (int i = 0; i < dataGridViewStudentList.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewStudentList.Columns.Count - 1; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridViewStudentList.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    // lưu file Excel và đóng ứng dụng Excel
                    workbook.SaveAs(saveFileDialog.FileName);
                    workbook.Close(true, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                    excel.Quit();

                    // thông báo thành công
                    MessageBox.Show("Save To Excel File Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudentList.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                try
                {
                    saveFileDialog.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog.FileName = ".docx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        exportDataToWord(dataGridViewStudentList, saveFileDialog.FileName);
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
                    Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application();
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
                            "\t\t\t\t\t\t\t\t" + "ALL STUDENT LIST\n";

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
                                if (DGV.Columns[c].HeaderText == "BirthDate")
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
