
namespace ProjectQLSV
{
    partial class StaticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelMale = new System.Windows.Forms.Panel();
            this.labelMale = new System.Windows.Forms.Label();
            this.panelFemale = new System.Windows.Forms.Panel();
            this.labelFemale = new System.Windows.Forms.Label();
            this.chartStatics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartStaticsPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTotal.SuspendLayout();
            this.panelMale.SuspendLayout();
            this.panelFemale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStaticsPie)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Font = new System.Drawing.Font("VNI-Ariston", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTotal.Location = new System.Drawing.Point(185, 12);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(417, 124);
            this.panelTotal.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(60, 38);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(278, 37);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total Students: 100%";
            this.labelTotal.MouseEnter += new System.EventHandler(this.labelTotal_MouseEnter);
            this.labelTotal.MouseLeave += new System.EventHandler(this.labelTotal_MouseLeave);
            // 
            // panelMale
            // 
            this.panelMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelMale.Controls.Add(this.labelMale);
            this.panelMale.Font = new System.Drawing.Font("VNI-Ariston", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMale.Location = new System.Drawing.Point(185, 142);
            this.panelMale.Name = "panelMale";
            this.panelMale.Size = new System.Drawing.Size(199, 95);
            this.panelMale.TabIndex = 1;
            // 
            // labelMale
            // 
            this.labelMale.AutoSize = true;
            this.labelMale.Font = new System.Drawing.Font("VNI-Ariston", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMale.Location = new System.Drawing.Point(14, 28);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(95, 37);
            this.labelMale.TabIndex = 1;
            this.labelMale.Text = "Male: ";
            this.labelMale.MouseEnter += new System.EventHandler(this.labelMale_MouseEnter);
            this.labelMale.MouseLeave += new System.EventHandler(this.labelMale_MouseLeave);
            // 
            // panelFemale
            // 
            this.panelFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelFemale.Controls.Add(this.labelFemale);
            this.panelFemale.Font = new System.Drawing.Font("VNI-Ariston", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFemale.Location = new System.Drawing.Point(390, 142);
            this.panelFemale.Name = "panelFemale";
            this.panelFemale.Size = new System.Drawing.Size(212, 95);
            this.panelFemale.TabIndex = 2;
            // 
            // labelFemale
            // 
            this.labelFemale.AutoSize = true;
            this.labelFemale.Font = new System.Drawing.Font("VNI-Ariston", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFemale.Location = new System.Drawing.Point(3, 28);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(131, 37);
            this.labelFemale.TabIndex = 1;
            this.labelFemale.Text = "Female: ";
            this.labelFemale.MouseEnter += new System.EventHandler(this.labelFemale_MouseEnter);
            this.labelFemale.MouseLeave += new System.EventHandler(this.labelFemale_MouseLeave);
            // 
            // chartStatics
            // 
            this.chartStatics.BackColor = System.Drawing.Color.Cornsilk;
            chartArea1.Name = "ChartArea1";
            this.chartStatics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatics.Legends.Add(legend1);
            this.chartStatics.Location = new System.Drawing.Point(12, 243);
            this.chartStatics.Name = "chartStatics";
            this.chartStatics.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Percent";
            this.chartStatics.Series.Add(series1);
            this.chartStatics.Size = new System.Drawing.Size(354, 300);
            this.chartStatics.TabIndex = 3;
            this.chartStatics.Text = "Chart Statics";
            // 
            // chartStaticsPie
            // 
            this.chartStaticsPie.BackColor = System.Drawing.Color.Cornsilk;
            chartArea2.Name = "ChartArea1";
            this.chartStaticsPie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStaticsPie.Legends.Add(legend2);
            this.chartStaticsPie.Location = new System.Drawing.Point(438, 243);
            this.chartStaticsPie.Name = "chartStaticsPie";
            this.chartStaticsPie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "PercentPie";
            this.chartStaticsPie.Series.Add(series2);
            this.chartStaticsPie.Size = new System.Drawing.Size(300, 300);
            this.chartStaticsPie.TabIndex = 4;
            this.chartStaticsPie.Text = "chart Statics Pie";
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(768, 639);
            this.Controls.Add(this.chartStaticsPie);
            this.Controls.Add(this.chartStatics);
            this.Controls.Add(this.panelFemale);
            this.Controls.Add(this.panelMale);
            this.Controls.Add(this.panelTotal);
            this.Name = "StaticsForm";
            this.Text = "StaticsForm";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelMale.ResumeLayout(false);
            this.panelMale.PerformLayout();
            this.panelFemale.ResumeLayout(false);
            this.panelFemale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStaticsPie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Panel panelMale;
        private System.Windows.Forms.Panel panelFemale;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Label labelFemale;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStaticsPie;
    }
}