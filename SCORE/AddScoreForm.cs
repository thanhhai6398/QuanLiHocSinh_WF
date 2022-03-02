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
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            // lay thong tin all course
            comboBoxCourse.DataSource = course.getAllCourse(new System.Data.SqlClient.SqlCommand("SELECT * FROM Course"));
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";
            // dua no voi student
            SqlCommand command = new SqlCommand("SELECT id, fname, lname FROM std");
            dataGridViewStd.DataSource = student.getStudents(command);
        }

        private void dataGridViewStd_Click(object sender, EventArgs e)
        {
            // get the id of the selected student
            textBoxID.Text = dataGridViewStd.CurrentRow.Cells[0].Value.ToString();
        }
        private void buttonAddScore_Click(object sender, EventArgs e)
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
    }
}
