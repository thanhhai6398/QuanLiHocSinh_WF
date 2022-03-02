
namespace ProjectQLSV
{
    partial class AvgResultByScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvgResultByScoreForm));
            this.labelStudentID = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelStudentResult = new System.Windows.Forms.Label();
            this.dataGridViewAvgResultByScore = new System.Windows.Forms.DataGridView();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvgResultByScore)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentID.Location = new System.Drawing.Point(12, 84);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(118, 25);
            this.labelStudentID.TabIndex = 0;
            this.labelStudentID.Text = "Student ID:";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(9, 122);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(121, 25);
            this.labelFName.TabIndex = 1;
            this.labelFName.Text = "First Name:";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.Location = new System.Drawing.Point(16, 165);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(114, 25);
            this.labelLName.TabIndex = 2;
            this.labelLName.Text = "Last Name:";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(12, 210);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(255, 25);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Search By ID, First Name:";
            // 
            // labelStudentResult
            // 
            this.labelStudentResult.AutoSize = true;
            this.labelStudentResult.Font = new System.Drawing.Font("VNI-Vivi", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentResult.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelStudentResult.Location = new System.Drawing.Point(121, 9);
            this.labelStudentResult.Name = "labelStudentResult";
            this.labelStudentResult.Size = new System.Drawing.Size(206, 40);
            this.labelStudentResult.TabIndex = 4;
            this.labelStudentResult.Text = "Student Result";
            // 
            // dataGridViewAvgResultByScore
            // 
            this.dataGridViewAvgResultByScore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewAvgResultByScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvgResultByScore.Location = new System.Drawing.Point(333, 84);
            this.dataGridViewAvgResultByScore.Name = "dataGridViewAvgResultByScore";
            this.dataGridViewAvgResultByScore.Size = new System.Drawing.Size(937, 336);
            this.dataGridViewAvgResultByScore.TabIndex = 5;
            this.dataGridViewAvgResultByScore.Click += new System.EventHandler(this.dataGridViewAvgResultByScore_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPrint.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPrint.Location = new System.Drawing.Point(30, 332);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(90, 40);
            this.buttonPrint.TabIndex = 6;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(219, 332);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 40);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxID.Location = new System.Drawing.Point(140, 86);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(187, 24);
            this.textBoxID.TabIndex = 8;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxFName.Location = new System.Drawing.Point(140, 122);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(187, 24);
            this.textBoxFName.TabIndex = 9;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxLName.Location = new System.Drawing.Point(140, 165);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(187, 24);
            this.textBoxLName.TabIndex = 10;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSearch.Location = new System.Drawing.Point(140, 253);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(187, 24);
            this.textBoxSearch.TabIndex = 11;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Green;
            this.buttonSearch.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(12, 244);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(91, 38);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
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
            // AvgResultByScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1282, 450);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridViewAvgResultByScore);
            this.Controls.Add(this.labelStudentResult);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelStudentID);
            this.Name = "AvgResultByScoreForm";
            this.Text = "AvgResultByScoreForm";
            this.Load += new System.EventHandler(this.AvgResultByScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvgResultByScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelStudentResult;
        private System.Windows.Forms.DataGridView dataGridViewAvgResultByScore;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}