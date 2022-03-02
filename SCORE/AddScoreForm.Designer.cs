
namespace ProjectQLSV
{
    partial class AddScoreForm
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
            this.labelD = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelDes = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.richTextBoxDes = new System.Windows.Forms.RichTextBox();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.buttonAddScore = new System.Windows.Forms.Button();
            this.dataGridViewStd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStd)).BeginInit();
            this.SuspendLayout();
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelD.Location = new System.Drawing.Point(42, 49);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(118, 25);
            this.labelD.TabIndex = 0;
            this.labelD.Text = "Student ID:";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourse.Location = new System.Drawing.Point(33, 85);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(127, 25);
            this.labelCourse.TabIndex = 1;
            this.labelCourse.Text = "Select Course:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(97, 122);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(63, 25);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score:";
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDes.Location = new System.Drawing.Point(43, 162);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(117, 25);
            this.labelDes.TabIndex = 3;
            this.labelDes.Text = "Description:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxID.Location = new System.Drawing.Point(170, 56);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(205, 24);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxScore.Location = new System.Drawing.Point(170, 124);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(205, 24);
            this.textBoxScore.TabIndex = 5;
            // 
            // richTextBoxDes
            // 
            this.richTextBoxDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.richTextBoxDes.Location = new System.Drawing.Point(170, 164);
            this.richTextBoxDes.Name = "richTextBoxDes";
            this.richTextBoxDes.Size = new System.Drawing.Size(205, 90);
            this.richTextBoxDes.TabIndex = 6;
            this.richTextBoxDes.Text = "";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(170, 87);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(205, 26);
            this.comboBoxCourse.TabIndex = 7;
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAddScore.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddScore.Location = new System.Drawing.Point(214, 316);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(111, 34);
            this.buttonAddScore.TabIndex = 8;
            this.buttonAddScore.Text = "Add Score";
            this.buttonAddScore.UseVisualStyleBackColor = false;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // dataGridViewStd
            // 
            this.dataGridViewStd.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dataGridViewStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStd.Location = new System.Drawing.Point(391, 32);
            this.dataGridViewStd.Name = "dataGridViewStd";
            this.dataGridViewStd.Size = new System.Drawing.Size(466, 346);
            this.dataGridViewStd.TabIndex = 9;
            this.dataGridViewStd.Click += new System.EventHandler(this.dataGridViewStd_Click);
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.dataGridViewStd);
            this.Controls.Add(this.buttonAddScore);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.richTextBoxDes);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelDes);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.labelD);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.RichTextBox richTextBoxDes;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Button buttonAddScore;
        private System.Windows.Forms.DataGridView dataGridViewStd;
    }
}