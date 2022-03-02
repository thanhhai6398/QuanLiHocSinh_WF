using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLSV
{
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        MY_DB mdb = new MY_DB();
        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mdb.getConnection;
            command.CommandText = "SELECT Score.student_id as 'Student ID', std.fname as 'First Name', std.lname as 'Last Name', Score.course_id as 'Course ID', Course.label as Label, Score.student_score as Score FROM std, Course, Score WHERE std.id =" +
            "Score.student_id AND Score.course_id = Course.Id";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewRemoveScore.DataSource = table;
            dataGridViewRemoveScore.RowTemplate.Height = 30; //size
            dataGridViewRemoveScore.AllowUserToAddRows = false;
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(dataGridViewRemoveScore.CurrentRow.Cells[0].Value.ToString());
            int courseID = Convert.ToInt32(dataGridViewRemoveScore.CurrentRow.Cells[3].Value.ToString());
            if (MessageBox.Show("Are You Sure You Want To Delete This Score", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //int rows = dataGridViewRemoveScore.Rows.Count;
                //for (int i = rows - 1; i >= 0; i--)
                {
                    if (dataGridViewRemoveScore.CurrentRow.Cells[0].Selected)
                    {                       
                        if (score.deleteScore(studentID, courseID))
                        {
                            MessageBox.Show("Score Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Score Not Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

       
    }
}
