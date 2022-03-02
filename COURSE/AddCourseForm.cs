using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLSV
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
            int Id = Convert.ToInt32(textBoxID.Text);
            string label = textBoxLabel.Text;
            int period = Convert.ToInt32(textBoxPeriod.Text);
            string description = richTextBoxDescription.Text;
            // thoi luong >10
            if (period <10)
            {
                MessageBox.Show("The period > 10", "Invalid Period", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (label.Trim() == "")// lam viec voi string xoa het cac khoang trang,truoc sau chi lay ten
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.checkCourseName(label))
            {
                if (course.InsertCourse(Id, label, period, description))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
