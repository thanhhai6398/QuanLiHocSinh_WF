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
    public partial class StaticResultForm : Form
    {
        public StaticResultForm()
        {
            InitializeComponent();
        }

        private void StaticResultForm_Load(object sender, EventArgs e)
        {
            SCORE score = new SCORE();
            DataTable table = score.getAvgScoreByCourse();
            labelMCB.Text = "Mang May Tinh CB: " + table.Rows[0]["AverageGrade"].ToString();
            labelAI.Text = "AI: " + table.Rows[1]["AverageGrade"].ToString();
            labelAV1.Text = "Anh Van 1: " + table.Rows[2]["AverageGrade"].ToString();
            labelPython.Text = "Python: " + table.Rows[3]["AverageGrade"].ToString();
            labelHDH.Text = "He Dieu Hanh: " + table.Rows[4]["AverageGrade"].ToString();
            labelCNXH.Text = "CNXH: " + table.Rows[5]["AverageGrade"].ToString();
            labelCSDL.Text = "Co So Du Lieu: " + table.Rows[6]["AverageGrade"].ToString();
            labelWF.Text = "Lap Trinh Windows: " + table.Rows[7]["AverageGrade"].ToString();
            //display the values            
            double total = Convert.ToDouble(score.totalStudent());
            double totalPass = Convert.ToDouble(score.totalPass());
            double totalFail = Convert.ToDouble(score.totalFail());
            //tinh %
            double PassStudentsPercentage = (totalPass * (100 / total));
            double FailStudentsPercentage = (totalFail * (100 / total));
            labelPass.Text = ("Pass: " + (PassStudentsPercentage.ToString("0.00") + "%"));
            labelFail.Text = ("Fail: " + (FailStudentsPercentage.ToString("0.00") + "%"));
        }

    }
}
