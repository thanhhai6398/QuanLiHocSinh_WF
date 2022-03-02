using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLSV
{
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int CourseId = Convert.ToInt32(textBoxID.Text);
                // message before the delete
                if ((MessageBox.Show("Are You Sure You Want To Delete This Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (course.deleteCourse(CourseId))
                    {
                        MessageBox.Show("Course Deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
