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

namespace ProjectQLSV
{
    public partial class AvgResultByScoreForm : Form
    {
        public AvgResultByScoreForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        private void AvgResultByScoreForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT distinct std.id as 'Student ID', lname as 'Last Name', fname as 'First Name' FROM std,Score WHERE Score.student_id=std.id", mydb.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            dataGridViewAvgResultByScore.DataSource = table;

            SqlCommand command1 = new SqlCommand("SELECT label as Label FROM Course", mydb.getConnection);
            DataTable table1 = new DataTable();
            adapter = new SqlDataAdapter(command1);
            adapter.Fill(table1);

            for (int i = 0; i < table1.Rows.Count; i++)
            {
                dataGridViewAvgResultByScore.Columns.Add(table1.Rows[i][0].ToString(), table1.Rows[i][0].ToString());
            }

            SqlCommand sqlCommand = new SqlCommand("SELECT student_id as 'Student ID', label as Label, student_score as Score FROM Course, Score WHERE Course.Id=Score.course_id", mydb.getConnection);
            DataTable table2 = new DataTable();
            adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(table2);
            //MessageBox.Show(table2.Rows[0][0].ToString());
            int stId;
            int dtStId;
            for (int i = 0; i < table2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewAvgResultByScore.Rows.Count; j++)
                {
                    stId = Convert.ToInt32(table2.Rows[i][0].ToString());
                    dtStId = Convert.ToInt32(dataGridViewAvgResultByScore.Rows[j].Cells[0].Value.ToString());
                    if (stId == dtStId)
                    {
                        dataGridViewAvgResultByScore.Rows[j].Cells[table2.Rows[i][1].ToString()].Value = table2.Rows[i][2].ToString();
                        break;
                    }
                }
            }
            dataGridViewAvgResultByScore.Columns.Add("Average Score", "Average Score");
            dataGridViewAvgResultByScore.Columns.Add("Result", "Result");

            SqlCommand sqlCommand1 = new SqlCommand("SELECT student_id as 'Student ID', avg(student_score) as AvgScore FROM Score GROUP BY student_id", mydb.getConnection);
            DataTable table3 = new DataTable();
            adapter = new SqlDataAdapter(sqlCommand1);
            adapter.Fill(table3);

            float ScAvg;
            //MessageBox.Show(table3.Rows[0][0].ToString());
            for (int i = 0; i < table3.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewAvgResultByScore.Rows.Count; j++)
                {
                    stId = Convert.ToInt32(table3.Rows[i][0].ToString());
                    dtStId = Convert.ToInt32(dataGridViewAvgResultByScore.Rows[j].Cells[0].Value.ToString());
                    if (stId == dtStId)
                    {
                        dataGridViewAvgResultByScore.Rows[j].Cells["Average Score"].Value = table3.Rows[i][1].ToString();
                        ScAvg = float.Parse(table3.Rows[i][1].ToString());
                        if (ScAvg >= 9)
                            dataGridViewAvgResultByScore.Rows[j].Cells["Result"].Value = 'A';
                        else if (ScAvg >= 7)
                            dataGridViewAvgResultByScore.Rows[j].Cells["Result"].Value = 'B';
                        else if (ScAvg > 6.5)
                            dataGridViewAvgResultByScore.Rows[j].Cells["Result"].Value = 'C';
                        else if (ScAvg >= 5)
                            dataGridViewAvgResultByScore.Rows[j].Cells["Result"].Value = 'D';
                        else
                            dataGridViewAvgResultByScore.Rows[j].Cells["Result"].Value = 'E';
                        break;
                    }
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            while (dataGridViewAvgResultByScore.Rows.Count != 1 && dataGridViewAvgResultByScore.Rows.Count != 0)
            {
                foreach (DataGridViewRow item in this.dataGridViewAvgResultByScore.Rows)
                {
                    if(item.Cells[0].Value.ToString()!= textBoxSearch.Text || item.Cells[2].Value.ToString() != textBoxSearch.Text)
                    {
                        dataGridViewAvgResultByScore.Rows.Remove(item);
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        Bitmap bitmap;
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //Resize DataGridView to full height.
            int height = dataGridViewAvgResultByScore.Height;
            dataGridViewAvgResultByScore.Height = dataGridViewAvgResultByScore.RowCount * dataGridViewAvgResultByScore.RowTemplate.Height;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(dataGridViewAvgResultByScore.Width, dataGridViewAvgResultByScore.Height);
            dataGridViewAvgResultByScore.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, dataGridViewAvgResultByScore.Width, dataGridViewAvgResultByScore.Height));

            //Resize DataGridView back to original height.
            dataGridViewAvgResultByScore.Height = height;

            //Show the Print Preview Dialog.
            printPreviewDialog1.ShowDialog();
        }

        private void dataGridViewAvgResultByScore_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewAvgResultByScore.CurrentRow.Cells[0].Value.ToString();
            textBoxFName.Text = dataGridViewAvgResultByScore.CurrentRow.Cells[2].Value.ToString();
            textBoxLName.Text = dataGridViewAvgResultByScore.CurrentRow.Cells[1].Value.ToString();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
