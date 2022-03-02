
namespace ProjectQLSV
{
    partial class EditCourseForm
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
            this.labelSelectionCourse = new System.Windows.Forms.Label();
            this.labelLable = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectionCourse
            // 
            this.labelSelectionCourse.AutoSize = true;
            this.labelSelectionCourse.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectionCourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSelectionCourse.Location = new System.Drawing.Point(22, 29);
            this.labelSelectionCourse.Name = "labelSelectionCourse";
            this.labelSelectionCourse.Size = new System.Drawing.Size(127, 25);
            this.labelSelectionCourse.TabIndex = 0;
            this.labelSelectionCourse.Text = "Select Course:";
            // 
            // labelLable
            // 
            this.labelLable.AutoSize = true;
            this.labelLable.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLable.Location = new System.Drawing.Point(83, 76);
            this.labelLable.Name = "labelLable";
            this.labelLable.Size = new System.Drawing.Size(66, 25);
            this.labelLable.TabIndex = 1;
            this.labelLable.Text = "Label:";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriod.Location = new System.Drawing.Point(69, 126);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(80, 25);
            this.labelPeriod.TabIndex = 2;
            this.labelPeriod.Text = "Period:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(32, 181);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(117, 25);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Font = new System.Drawing.Font("VNI-Centur", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabel.Location = new System.Drawing.Point(173, 80);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(285, 28);
            this.textBoxLabel.TabIndex = 5;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Font = new System.Drawing.Font("VNI-Centur", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(173, 187);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(282, 96);
            this.richTextBoxDescription.TabIndex = 7;
            this.richTextBoxDescription.Text = "";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Blue;
            this.buttonEdit.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(173, 295);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(285, 37);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("VNI-Centur", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(173, 35);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(285, 29);
            this.comboBoxCourse.TabIndex = 10;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("VNI-Centur", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(173, 126);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(285, 28);
            this.numericUpDown.TabIndex = 11;
            this.numericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(592, 344);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.labelLable);
            this.Controls.Add(this.labelSelectionCourse);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectionCourse;
        private System.Windows.Forms.Label labelLable;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}