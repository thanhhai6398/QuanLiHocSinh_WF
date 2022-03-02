
namespace ProjectQLSV
{
    partial class ShowFullContactForm
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelShowAll = new System.Windows.Forms.Label();
            this.labelFullAddress = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 65);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(243, 316);
            this.listBox.TabIndex = 0;
            this.listBox.Click += new System.EventHandler(this.listBox_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(261, 65);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(793, 316);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ColumnHeaderMouseClick);
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("VNI-Ariston", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(10, 23);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(74, 29);
            this.labelGroup.TabIndex = 2;
            this.labelGroup.Text = "Group";
            // 
            // labelShowAll
            // 
            this.labelShowAll.AutoSize = true;
            this.labelShowAll.Font = new System.Drawing.Font("VNI-Ariston", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowAll.Location = new System.Drawing.Point(256, 23);
            this.labelShowAll.Name = "labelShowAll";
            this.labelShowAll.Size = new System.Drawing.Size(107, 29);
            this.labelShowAll.TabIndex = 3;
            this.labelShowAll.Text = "Show All";
            // 
            // labelFullAddress
            // 
            this.labelFullAddress.AutoSize = true;
            this.labelFullAddress.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullAddress.Location = new System.Drawing.Point(256, 392);
            this.labelFullAddress.Name = "labelFullAddress";
            this.labelFullAddress.Size = new System.Drawing.Size(136, 25);
            this.labelFullAddress.TabIndex = 4;
            this.labelFullAddress.Text = "Full Address:";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox.Location = new System.Drawing.Point(398, 392);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(307, 24);
            this.textBox.TabIndex = 5;
            // 
            // ShowFullContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1066, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelFullAddress);
            this.Controls.Add(this.labelShowAll);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.listBox);
            this.Name = "ShowFullContactForm";
            this.Text = "ShowFullContactForm";
            this.Load += new System.EventHandler(this.ShowFullContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelShowAll;
        private System.Windows.Forms.Label labelFullAddress;
        private System.Windows.Forms.TextBox textBox;
    }
}