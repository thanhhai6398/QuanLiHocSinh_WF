
namespace ProjectQLSV
{
    partial class RemoveScoreForm
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
            this.dataGridViewRemoveScore = new System.Windows.Forms.DataGridView();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemoveScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRemoveScore
            // 
            this.dataGridViewRemoveScore.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridViewRemoveScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRemoveScore.GridColor = System.Drawing.Color.Teal;
            this.dataGridViewRemoveScore.Location = new System.Drawing.Point(27, 34);
            this.dataGridViewRemoveScore.Name = "dataGridViewRemoveScore";
            this.dataGridViewRemoveScore.Size = new System.Drawing.Size(738, 297);
            this.dataGridViewRemoveScore.TabIndex = 0;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Red;
            this.buttonRemove.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRemove.Location = new System.Drawing.Point(331, 355);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(148, 38);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove Score";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // RemoveScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.dataGridViewRemoveScore);
            this.Name = "RemoveScoreForm";
            this.Text = "RemoveScoreForm";
            this.Load += new System.EventHandler(this.RemoveScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemoveScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRemoveScore;
        private System.Windows.Forms.Button buttonRemove;
    }
}