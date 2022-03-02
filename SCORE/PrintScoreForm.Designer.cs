
namespace ProjectQLSV
{
    partial class PrintScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintScoreForm));
            this.dataGridViewPrint = new System.Windows.Forms.DataGridView();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPrint
            // 
            this.dataGridViewPrint.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dataGridViewPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrint.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewPrint.Location = new System.Drawing.Point(29, 23);
            this.dataGridViewPrint.Name = "dataGridViewPrint";
            this.dataGridViewPrint.Size = new System.Drawing.Size(636, 322);
            this.dataGridViewPrint.TabIndex = 0;
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.BackColor = System.Drawing.Color.Blue;
            this.buttonSaveToFile.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSaveToFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSaveToFile.Location = new System.Drawing.Point(118, 365);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(151, 38);
            this.buttonSaveToFile.TabIndex = 1;
            this.buttonSaveToFile.Text = "Save To File";
            this.buttonSaveToFile.UseVisualStyleBackColor = false;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.Green;
            this.buttonPrint.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPrint.Location = new System.Drawing.Point(470, 365);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(110, 38);
            this.buttonPrint.TabIndex = 2;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // PrintScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(689, 431);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.dataGridViewPrint);
            this.Name = "PrintScoreForm";
            this.Text = "PrintScoreForm";
            this.Load += new System.EventHandler(this.PrintScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrint;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}