using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLSV
{
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course");
            // dùng combobox lay ten Course
            comboBoxCourse.DataSource = course.getAllCourse(command);
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";
            comboBoxCourse.SelectedItem = null;
        }
        // courses name and id
        public void fillCombo(int index)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course");
            comboBoxCourse.DataSource = course.getAllCourse(command);
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";
            comboBoxCourse.SelectedIndex = index;
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBoxCourse.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                textBoxLabel.Text = table.Rows[0][1].ToString();
                numericUpDown.Value = Int32.Parse(table.Rows[0][2].ToString());
                richTextBoxDescription.Text = table.Rows[0][3].ToString();
            }
            catch { }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string name = textBoxLabel.Text;
            int hrs = (int)numericUpDown.Value;
            string descr = richTextBoxDescription.Text;
            int id = (int)comboBoxCourse.SelectedValue;
            // lay lai phan kiem tra ten course
            if (!course.checkCourseName(name, Convert.ToInt32(comboBoxCourse.SelectedValue )))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, name, hrs, descr))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillCombo(comboBoxCourse.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
