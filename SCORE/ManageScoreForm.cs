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
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }
        MY_DB mdb = new MY_DB();
        SCORE score = new SCORE();
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();
        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mdb.getConnection;
            command.CommandText = "SELECT Score.student_id as 'Student ID' , std.fname as 'First Name', std.lname as 'Last Name', Score.course_id as 'Course ID', Score.student_score as Score FROM std, Course, Score WHERE std.id =" +
                "Score.student_id AND Score.course_id = Course.Id";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewManageScore.DataSource = table;
            dataGridViewManageScore.RowTemplate.Height = 30; //size
            dataGridViewManageScore.AllowUserToAddRows = false;

            // lay thong tin all course
            comboBoxCourse.DataSource = course.getAllCourse(new System.Data.SqlClient.SqlCommand("SELECT * FROM Course"));
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";
        }
        private void buttonShowSTD_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id as ID, fname as 'First Name', lname as 'Last Name', bdate as 'Birth date' FROM std");
            dataGridViewManageScore.DataSource = student.getStudents(command);
        }
        private void buttonShowSCR_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mdb.getConnection;
            command.CommandText = "SELECT Score.student_id as 'Student ID', std.fname as 'First Name', std.lname as 'Last Name', Score.course_id as 'Course ID', Course.label as Label, Score.student_score as Score FROM std, Course, Score WHERE std.id =" +
            "Score.student_id AND Score.course_id = Course.Id";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewManageScore.DataSource = table;
            dataGridViewManageScore.RowTemplate.Height = 50; //size
            dataGridViewManageScore.AllowUserToAddRows = false;
        }

        private void dataGridViewManageScore_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewManageScore.CurrentRow.Cells[0].Value.ToString();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(textBoxID.Text);
                int courseID = Convert.ToInt32(comboBoxCourse.SelectedValue);
                float scoreValue = float.Parse(textBoxScore.Text.Trim());
                string description = richTextBoxDes.Text;
                // check if the score is already set for this student on this score
                if (!score.studentScoreExist(studentID, courseID))
                {
                    if (score.insertScore(studentID, courseID, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This course Are Already set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAVG_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            dataGridViewManageScore.ReadOnly = true;
            dataGridViewManageScore.RowTemplate.Height = 50; //size
            dataGridViewManageScore.DataSource = score.getAvgScoreByCourse();
            dataGridViewManageScore.AllowUserToAddRows = false;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This Score", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //int rows = dataGridViewManageScore.Rows.Count;
                //for (int i = rows - 1; i >= 0; i--)
                {
                    if (dataGridViewManageScore.CurrentRow.Cells[0].Selected)
                    {
                        int studentID = Convert.ToInt32(dataGridViewManageScore.CurrentRow.Cells[0].Value.ToString());
                        int courseID = Convert.ToInt32(dataGridViewManageScore.CurrentRow.Cells[3].Value.ToString());
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

