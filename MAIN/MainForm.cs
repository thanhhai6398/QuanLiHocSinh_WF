using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLSV
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewStudentForm addnew = new AddNewStudentForm();
            addnew.Show(this);
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsListForm stdlist = new StudentsListForm();
            stdlist.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm update = new UpdateDeleteStudentForm();
            update.Show(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm statics = new StaticsForm();
            statics.Show(this); 
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentForm print = new PrintStudentForm();
            print.Show(this);
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentsForm mngStd = new ManageStudentsForm();
            mngStd.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addC = new AddCourseForm();
            addC.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm removeC = new RemoveCourseForm();
            removeC.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm editC = new EditCourseForm();
            editC.Show(this);
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm manageC = new ManageCourseForm();
            manageC.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourseForm printC = new PrintCourseForm();
            printC.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm addScr = new AddScoreForm();
            addScr.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm removeScr = new RemoveScoreForm();
            removeScr.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm manageScr = new ManageScoreForm();
            manageScr.Show(this);
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avgScoreByCourseForm avg = new avgScoreByCourseForm();
            avg.Show(this);
        }

        private void printScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintScoreForm printScr = new PrintScoreForm();
            printScr.Show(this);
        }

        private void aVGResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgResultByScoreForm avg = new AvgResultByScoreForm();
            avg.Show(this);
        }

        private void staticsResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticResultForm staRe = new StaticResultForm();
            staRe.Show(this);
        }
    }
}
