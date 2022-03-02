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
    public partial class avgScoreByCourseForm : Form
    {
        public avgScoreByCourseForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void avgScoreByCourseForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            fillGrid(command);
            fillChart();
        }
        
        public void fillGrid(SqlCommand command)
        {
            dataGridViewAVG.ReadOnly = true;
            dataGridViewAVG.RowTemplate.Height = 30; //size
            dataGridViewAVG.DataSource = score.getAvgScoreByCourse();
            dataGridViewAVG.AllowUserToAddRows = false;
            
        }
        public void fillChart()
        {
            chartAVG.DataSource = score.getAvgScoreByCourse();
            chartAVG.Series["AverageGrade"].XValueMember = "label";
            chartAVG.Series["AverageGrade"].YValueMembers = "AverageGrade";
            chartAVG.Titles.Add("BIEU DO HINH COT");
        }
    }
}
