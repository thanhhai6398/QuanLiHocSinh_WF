using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using oWord = Microsoft.Office.Interop.Word;

namespace ProjectQLSV
{
    public partial class PrintStudentForm : Form
    {
        public PrintStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        
        private void PrintForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id as ID, fname as 'First Name', lname as 'Last Name', bdate as 'Birth date', gender as Gender, phone as Phone, address as Address, picture as Picture from std");
            fillGrid(command);
            if (radioButtonNO.Checked)
            {
                dateTimePickerStart.Enabled = false;
                dateTimePickerEnd.Enabled = false;
            }
        }
        private void radioButtonYES_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerStart.Enabled = true;
            dateTimePickerEnd.Enabled = true;
        }

        private void radioButtonNO_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerStart.Enabled = false;
            dateTimePickerEnd.Enabled = false;
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridViewStudent.ReadOnly = true;
            // xu ly hinh anh
            DataGridViewImageColumn picture = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            dataGridViewStudent.RowTemplate.Height = 80; //co gang de pic dep, dang tim auto-size
            dataGridViewStudent.DataSource = student.getStudents(command);
            picture = (DataGridViewImageColumn)dataGridViewStudent.Columns[7];
            picture.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewStudent.AllowUserToAddRows = false;
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string query;
            if (radioButtonYES.Checked)
            {
                string bdate1 = dateTimePickerStart.Value.ToString("yyyy-MM-dd");
                string bdate2 = dateTimePickerEnd.Value.ToString("yyyy-MM-dd");
                if (radioButtonFemale.Checked)
                {
                    query = "SELECT id as ID, fname as First_Name, lname as Last_Name, bdate as Birth_date, gender as Gender, phone as Phone, address as Address, picture as Picture FROM std WHERE gender= 'Female' AND bdate BETWEEN '" + bdate1 + " 'AND' " + bdate2 + "'";
                }
                else if (radioButtonMale.Checked)
                {
                    query = "SELECT id as ID, fname as First_Name, lname as Last_Name, bdate as Birth_date, gender as Gender, phone as Phone, address as Address, picture as Picture FROM std WHERE gender= 'Male' AND bdate BETWEEN'" + bdate1 + " 'AND' " + bdate2 + "'";

                }
                else
                {
                    query = "SELECT id as ID, fname as First_Name, lname as Last_Name, bdate as Birth_date, gender as Gender, phone as Phone, address as Address, picture as Picture FROM std WHERE bdate BTWEEN'" + bdate1 + "'AND'" + bdate2+  "'";
                }
                command = new SqlCommand(query);
                fillGrid(command);
            }
            else
            {
                if (radioButtonFemale.Checked)
                {
                    query = "SELECT id as ID, fname as First_Name, lname as Last_Name, bdate as Birth_date, gender as Gender, phone as Phone, address as Address, picture as Picture FROM std WHERE gender= 'Female'";
                }
                else if (radioButtonMale.Checked)
                {
                    query = "SELECT id as ID, fname as First_Name, lname as Last_Name, bdate as Birth_date, gender as Gender, phone as Phone, address as Address, picture as Picture FROM std WHERE gender= 'Male'";
                }
                else
                {
                    query = "SELECT id as ID, fname as First_Name, lname as Last_Name, bdate as Birth_date, gender as Gender, phone as Phone, address as Address, picture as Picture FROM std";
                }
                command = new SqlCommand(query);
                fillGrid(command);                
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.docx)| *.docx";
            sfd.FileName = "export.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Data_To_Word(dataGridViewStudent, sfd.FileName);
            }
        }
        public void Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0) 
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];
                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop
                oWord.Document oDoc = new oWord.Document();
                oDoc.Application.Visible = true;
                //page orintation
                oDoc.PageSetup.Orientation = oWord.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";
                    }
                }
                //table format
                oRange.Text = oTemp;
                object Separator = oWord.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = oWord.WdAutoFitBehavior.wdAutoFitContent;
                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                    Type.Missing, Type.Missing, ref ApplyBorders,
                    Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();
                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;
                //add header now manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }
                //table style
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = oWord.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                //header text
                foreach (oWord.Section section1 in oDoc.Application.ActiveDocument.Sections)
                {
                    oWord.Range headerRange = section1.Headers[oWord.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Text = "TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT TPHCM" + Environment.NewLine + $"Khoa: CÔNG NGHỆ THÔNG TIN" + Environment.NewLine + $"                                                         DANH SÁCH SINH VIÊN" + Environment.NewLine + $"Lớp: IT03";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = oWord.WdParagraphAlignment.wdAlignParagraphLeft;
                    headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdTeal;
                }
                //footer text
                foreach (oWord.Section section2 in oDoc.Application.ActiveDocument.Sections)
                {
                    oWord.Range footerRange = section2.Footers[oWord.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Collapse(oWord.WdCollapseDirection.wdCollapseEnd);
                    TabStop tabStop = footerRange.Paragraphs.TabStops.Add(3.25F, oWord.WdTabAlignment.wdAlignTabCenter);
                    footerRange.Paragraphs.TabStops.Add(6.5F, oWord.WdTabAlignment.wdAlignTabLeft);

                    footerRange.Fields.Add(footerRange, oWord.WdFieldType.wdFieldPage,"\t",true);
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                    footerRange.Font.Size = 20;
                    footerRange.Text = "\tĐóng dấu xác nhận\t" + Environment.NewLine + $"Chữ ký";
                    footerRange.InsertAfter ("                                                                                               Ngày ...... Tháng ...... Năm.....") ;
                }

                //save image
                for (r = 0; r <= RowCount - 1; r++)
                {
                    byte[] imgbyte = (byte[])dataGridViewStudent.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(70, 70)));
                    Clipboard.SetDataObject(finalPic);
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 8).Range.Paste();
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 8).Range.InsertParagraph();
                }
                //save the file
                oDoc.SaveAs(filename);

            }
        }
        Bitmap bitmap;
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //Resize DataGridView to full height.
            int height = dataGridViewStudent.Height;
            dataGridViewStudent.Height = dataGridViewStudent.RowCount * dataGridViewStudent.RowTemplate.Height;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(dataGridViewStudent.Width, dataGridViewStudent.Height);
            dataGridViewStudent.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, dataGridViewStudent.Width, dataGridViewStudent.Height));

            //Resize DataGridView back to original height.
            dataGridViewStudent.Height = height;

            //Show the Print Preview Dialog.
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
