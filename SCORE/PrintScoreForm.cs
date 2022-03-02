using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using oWord = Microsoft.Office.Interop.Word;

namespace ProjectQLSV
{
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
        }
        MY_DB mdb = new MY_DB();
        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mdb.getConnection;
            command.CommandText = "SELECT Score.student_id as 'Student ID', std.fname as 'First Name', std.lname as 'Last Name', Score.course_id as 'Course ID', Course.label as Label, Score.student_score as Score FROM std, Course, Score WHERE std.id =" +
                "Score.student_id AND Score.course_id = Course.Id";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewPrint.DataSource = table;
            dataGridViewPrint.RowTemplate.Height = 50; //size
            dataGridViewPrint.AllowUserToAddRows = false;
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.docx)| *.docx";
            sfd.FileName = "export.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Data_To_Word(dataGridViewPrint, sfd.FileName);
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
                foreach (Microsoft.Office.Interop.Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    oWord.Range headerRange = section.Headers[oWord.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, oWord.WdFieldType.wdFieldPage);
                    headerRange.Text = "TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT TPHCM" + Environment.NewLine + $"Khoa: CÔNG NGHỆ THÔNG TIN" + Environment.NewLine + $"BẢNG ĐIỂM" + Environment.NewLine + $"Lớp: IT03";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = oWord.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                //footer text
                foreach (oWord.Section section2 in oDoc.Application.ActiveDocument.Sections)
                {
                    oWord.Range footerRange = section2.Footers[oWord.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Collapse(oWord.WdCollapseDirection.wdCollapseEnd);
                    TabStop tabStop = footerRange.Paragraphs.TabStops.Add(3.25F, oWord.WdTabAlignment.wdAlignTabCenter);
                    footerRange.Paragraphs.TabStops.Add(6.5F, oWord.WdTabAlignment.wdAlignTabLeft);

                    footerRange.Fields.Add(footerRange, oWord.WdFieldType.wdFieldPage, "\t", true);
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                    footerRange.Font.Size = 20;
                    footerRange.Text = "\tĐóng dấu xác nhận\t" + Environment.NewLine + $"Chữ ký";
                    footerRange.InsertAfter("                                                                                               Ngày ...... Tháng ...... Năm.....");
                }
                //save the file
                oDoc.SaveAs(filename);

            }
        }
        Bitmap bitmap;
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //Resize DataGridView to full height.
            int height = dataGridViewPrint.Height;
            dataGridViewPrint.Height = dataGridViewPrint.RowCount * dataGridViewPrint.RowTemplate.Height * 2;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(dataGridViewPrint.Width, dataGridViewPrint.Height);
            dataGridViewPrint.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, dataGridViewPrint.Width, dataGridViewPrint.Height));

            //Resize DataGridView back to original height.
            dataGridViewPrint.Height = height;

            //Show the Print Preview Dialog.
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
