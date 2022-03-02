
namespace ProjectQLSV
{
    partial class ManageScoreForm
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAVG = new System.Windows.Forms.Button();
            this.buttonShowSTD = new System.Windows.Forms.Button();
            this.buttonShowSCR = new System.Windows.Forms.Button();
            this.dataGridViewManageScore = new System.Windows.Forms.DataGridView();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.richTextBoxDes = new System.Windows.Forms.RichTextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelDes = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageScore)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAdd.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(46, 297);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 31);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Red;
            this.buttonRemove.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRemove.Location = new System.Drawing.Point(204, 297);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(92, 31);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAVG
            // 
            this.buttonAVG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAVG.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAVG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAVG.Location = new System.Drawing.Point(46, 342);
            this.buttonAVG.Name = "buttonAVG";
            this.buttonAVG.Size = new System.Drawing.Size(250, 31);
            this.buttonAVG.TabIndex = 6;
            this.buttonAVG.Text = "Average Score By Course";
            this.buttonAVG.UseVisualStyleBackColor = false;
            this.buttonAVG.Click += new System.EventHandler(this.buttonAVG_Click);
            // 
            // buttonShowSTD
            // 
            this.buttonShowSTD.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonShowSTD.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowSTD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonShowSTD.Location = new System.Drawing.Point(404, 23);
            this.buttonShowSTD.Name = "buttonShowSTD";
            this.buttonShowSTD.Size = new System.Drawing.Size(206, 36);
            this.buttonShowSTD.TabIndex = 7;
            this.buttonShowSTD.Text = "Show Student";
            this.buttonShowSTD.UseVisualStyleBackColor = false;
            this.buttonShowSTD.Click += new System.EventHandler(this.buttonShowSTD_Click);
            // 
            // buttonShowSCR
            // 
            this.buttonShowSCR.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonShowSCR.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowSCR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonShowSCR.Location = new System.Drawing.Point(740, 23);
            this.buttonShowSCR.Name = "buttonShowSCR";
            this.buttonShowSCR.Size = new System.Drawing.Size(195, 36);
            this.buttonShowSCR.TabIndex = 8;
            this.buttonShowSCR.Text = "Show Score";
            this.buttonShowSCR.UseVisualStyleBackColor = false;
            this.buttonShowSCR.Click += new System.EventHandler(this.buttonShowSCR_Click);
            // 
            // dataGridViewManageScore
            // 
            this.dataGridViewManageScore.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewManageScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageScore.Location = new System.Drawing.Point(347, 65);
            this.dataGridViewManageScore.Name = "dataGridViewManageScore";
            this.dataGridViewManageScore.Size = new System.Drawing.Size(639, 381);
            this.dataGridViewManageScore.TabIndex = 9;
            this.dataGridViewManageScore.Click += new System.EventHandler(this.dataGridViewManageScore_Click);
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(136, 100);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(205, 24);
            this.comboBoxCourse.TabIndex = 17;
            // 
            // richTextBoxDes
            // 
            this.richTextBoxDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richTextBoxDes.Location = new System.Drawing.Point(136, 177);
            this.richTextBoxDes.Name = "richTextBoxDes";
            this.richTextBoxDes.Size = new System.Drawing.Size(205, 90);
            this.richTextBoxDes.TabIndex = 16;
            this.richTextBoxDes.Text = "";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxScore.Location = new System.Drawing.Point(136, 137);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(205, 23);
            this.textBoxScore.TabIndex = 15;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxID.Location = new System.Drawing.Point(136, 65);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(205, 23);
            this.textBoxID.TabIndex = 14;
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDes.Location = new System.Drawing.Point(12, 173);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(117, 25);
            this.labelDes.TabIndex = 13;
            this.labelDes.Text = "Description:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(66, 133);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(63, 25);
            this.labelScore.TabIndex = 12;
            this.labelScore.Text = "Score:";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourse.Location = new System.Drawing.Point(4, 99);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(127, 25);
            this.labelCourse.TabIndex = 11;
            this.labelCourse.Text = "Select Course:";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelD.Location = new System.Drawing.Point(13, 65);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(118, 25);
            this.labelD.TabIndex = 10;
            this.labelD.Text = "Student ID:";
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(998, 458);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.richTextBoxDes);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelDes);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.dataGridViewManageScore);
            this.Controls.Add(this.buttonShowSCR);
            this.Controls.Add(this.buttonShowSTD);
            this.Controls.Add(this.buttonAVG);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAVG;
        private System.Windows.Forms.Button buttonShowSTD;
        private System.Windows.Forms.Button buttonShowSCR;
        private System.Windows.Forms.DataGridView dataGridViewManageScore;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.RichTextBox richTextBoxDes;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelD;
    }
}