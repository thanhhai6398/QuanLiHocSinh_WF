
namespace ProjectQLSV
{
    partial class avgScoreByCourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewAVG = new System.Windows.Forms.DataGridView();
            this.chartAVG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAVG)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAVG
            // 
            this.dataGridViewAVG.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewAVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAVG.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAVG.Name = "dataGridViewAVG";
            this.dataGridViewAVG.Size = new System.Drawing.Size(308, 246);
            this.dataGridViewAVG.TabIndex = 0;
            // 
            // chartAVG
            // 
            this.chartAVG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea1.Name = "ChartArea1";
            this.chartAVG.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAVG.Legends.Add(legend1);
            this.chartAVG.Location = new System.Drawing.Point(3, 264);
            this.chartAVG.Name = "chartAVG";
            this.chartAVG.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartAVG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "AverageGrade";
            this.chartAVG.Series.Add(series1);
            this.chartAVG.Size = new System.Drawing.Size(896, 297);
            this.chartAVG.TabIndex = 1;
            this.chartAVG.Text = "chartAVG";
            // 
            // avgScoreByCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1003, 563);
            this.Controls.Add(this.chartAVG);
            this.Controls.Add(this.dataGridViewAVG);
            this.Name = "avgScoreByCourseForm";
            this.Text = "avgScoreByCourseForm";
            this.Load += new System.EventHandler(this.avgScoreByCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAVG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAVG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAVG;
    }
}