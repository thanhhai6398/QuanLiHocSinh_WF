using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLSV
{
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }
        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;
        private void StaticsForm_Load(object sender, EventArgs e)
        {
            //get panels color
            panTotalColor = panelTotal.BackColor;
            panMaleColor = panelMale.BackColor;
            panFemaleColor = panelFemale.BackColor;
            //display the values
            STUDENT student = new STUDENT();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());
            //tinh %
            double maleStudentsPercentage = (totalMale * (100 / total));
            double femaleStudentsPercentage = (totalFemale * (100 / total));
            labelTotal.Text = ("Total Students: " + total.ToString());
            labelMale.Text = ("Male: " + (maleStudentsPercentage.ToString("0.00") + "%"));
            labelFemale.Text= ("Female: "+ (femaleStudentsPercentage.ToString("0.00")+ "%"));

            //Ve bieu do dang cot
            chartStatics.Series["Percent"].Points.AddXY("Male", totalMale);
            chartStatics.Series["Percent"].Points.AddXY("Female", totalFemale);
            chartStatics.Series["Percent"].Points.AddXY("Total", total);
            chartStatics.ChartAreas[0].AxisY.Maximum = 30;
            chartStatics.Titles.Add("BIEU DO HINH COT");

            //Ve bieu do tron
            chartStaticsPie.Series["PercentPie"].Points.AddXY("Male", maleStudentsPercentage);
            chartStaticsPie.Series["PercentPie"].Points.AddXY("Female", femaleStudentsPercentage);
            chartStaticsPie.Titles.Add("BIEU DO TRON");
        }
        
        //Cac event lam viec voi Mouse
        private void labelTotal_MouseEnter(object sender, EventArgs e)
        {
            labelTotal.ForeColor = panTotalColor;
            panelTotal.BackColor = Color.White;
        }

        private void labelTotal_MouseLeave(object sender, EventArgs e)
        {
            labelTotal.ForeColor = Color.White;
            panelTotal.BackColor = panTotalColor;
        }

        private void labelMale_MouseEnter(object sender, EventArgs e)
        {
            labelMale.ForeColor = panMaleColor;
            panelMale.BackColor = Color.White;
        }

        private void labelMale_MouseLeave(object sender, EventArgs e)
        {
            labelMale.ForeColor = Color.White;
            panelMale.BackColor = panMaleColor;
        }

        private void labelFemale_MouseEnter(object sender, EventArgs e)
        {
            labelFemale.ForeColor = panFemaleColor;
            panelFemale.BackColor = Color.White;
        }

        private void labelFemale_MouseLeave(object sender, EventArgs e)
        {
            labelFemale.ForeColor = Color.White;
            panelFemale.BackColor = panFemaleColor;
        }
    }
}
