using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLSV
{
    public partial class ManageCourseForm : Form
    {
        public ManageCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        int pos;
        // load du liệu lên
        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }
        //listbox voi courses name and id
        void reloadListBoxData()
        {
            listBoxCourse.DataSource = course.getAllCourse(new System.Data.SqlClient.SqlCommand("SELECT Id as ID, label as Label, period as Period, description as Description FROM Course"));
            listBoxCourse.ValueMember = "id";
            listBoxCourse.DisplayMember = "label";
            listBoxCourse.SelectedItem = null;
            
            labelTotal.Text = ("Total Courses: " + course.totalCourse());
        }
        
        // dung lay data theo chi muc index, dung datarow de lay du liệu hàng cua table, sv có thë dùng cách dã làm tù truóc
        void showData(int index)
        {
            DataRow dr = course.getAllCourse(new System.Data.SqlClient.SqlCommand("SELECT Id as ID, label as Label, period as Period, description as Description FROM Course")).Rows[index];
            listBoxCourse.SelectedIndex = index;
            textBoxID.Text = dr.ItemArray[0].ToString();
            textBoxLabel.Text = dr.ItemArray[1].ToString();
            numericUpDown.Value = int.Parse(dr.ItemArray[2].ToString());
            richTextBoxDes.Text = dr.ItemArray[3].ToString();
        }

        private void listBoxCourse_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBoxCourse.SelectedItem;
            pos = listBoxCourse.SelectedIndex;
            showData(pos);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // copy lai phan truoc
            int id = Convert.ToInt32(textBoxID.Text);
            string name = textBoxLabel.Text;
            int hrs = (int)numericUpDown.Value;
            string descr = richTextBoxDes.Text;
            if (name.Trim() == "")
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (course.checkCourseName(name))
            {
                if (course.InsertCourse(id, name, hrs, descr))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Course Name Already exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string name = textBoxLabel.Text;
            int hrs = (int)numericUpDown.Value;
            string descr = richTextBoxDes.Text;
            int id = int.Parse(textBoxID.Text);
            //kiem tra ton tai và trùng
            if (!course.checkCourseName(name, Convert.ToInt32(textBoxID.Text)))
            {
                MessageBox.Show("This Course Name Already exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, name, hrs, descr))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadListBoxData();
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pos = 0;
        }
        //Remove bang id
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int courseID = Convert.ToInt32(textBoxID.Text);
                if (MessageBox.Show("Are Yousure You Want To Delete This Course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //clear fields
                        textBoxID.Text = "";
                        textBoxLabel.Text = "";
                        numericUpDown.Value = 10;
                        richTextBoxDes.Text = "";

                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter A Valid Numeric ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pos = 0;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pos < (course.getAllCourse(new System.Data.SqlClient.SqlCommand("SELECT Id as ID, label as Label, period as Period, description as Description FROM Course")).Rows.Count - 1))
            {
                pos = pos + 1;
                showData(pos);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                showData(pos);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourse(new System.Data.SqlClient.SqlCommand("SELECT Id as ID, label as Label, period as Period, description as Description FROM Course")).Rows.Count - 1;
            showData(pos);
        }
    }
}
