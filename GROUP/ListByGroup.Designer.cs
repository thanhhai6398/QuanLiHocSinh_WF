
namespace ProjectQLSV
{
    partial class ListByGroup
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
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.BackgroundColor = System.Drawing.Color.HotPink;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Location = new System.Drawing.Point(263, 34);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(410, 336);
            this.dataGridViewList.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSave.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(263, 386);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(164, 41);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save To File";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxLname
            // 
            this.textBoxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxLname.Location = new System.Drawing.Point(12, 140);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(180, 24);
            this.textBoxLname.TabIndex = 54;
            // 
            // textBoxFname
            // 
            this.textBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxFname.Location = new System.Drawing.Point(12, 63);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(181, 24);
            this.textBoxFname.TabIndex = 53;
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLname.Location = new System.Drawing.Point(7, 112);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(114, 25);
            this.labelLname.TabIndex = 52;
            this.labelLname.Text = "Last Name:";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFname.Location = new System.Drawing.Point(7, 35);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(121, 25);
            this.labelFname.TabIndex = 51;
            this.labelFname.Text = "First Name:";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxGroup.Location = new System.Drawing.Point(12, 221);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(180, 24);
            this.textBoxGroup.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Group:";
            // 
            // ListByGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(707, 440);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewList);
            this.Name = "ListByGroup";
            this.Text = "ListByGroup";
            this.Load += new System.EventHandler(this.ListByCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelFname;
        public System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxLname;
        public System.Windows.Forms.TextBox textBoxFname;
    }
}