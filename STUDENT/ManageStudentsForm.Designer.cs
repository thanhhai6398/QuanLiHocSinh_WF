
namespace ProjectQLSV
{
    partial class ManageStudentsForm
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelBdate = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAdrs = new System.Windows.Forms.Label();
            this.labelPicture = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelTotalStd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAdrs = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(77, 38);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(49, 25);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFname.Location = new System.Drawing.Point(5, 90);
            this.labelFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(121, 25);
            this.labelFname.TabIndex = 1;
            this.labelFname.Text = "First Name:";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLname.Location = new System.Drawing.Point(12, 138);
            this.labelLname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(114, 25);
            this.labelLname.TabIndex = 2;
            this.labelLname.Text = "Last Name:";
            // 
            // labelBdate
            // 
            this.labelBdate.AutoSize = true;
            this.labelBdate.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBdate.Location = new System.Drawing.Point(19, 190);
            this.labelBdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBdate.Name = "labelBdate";
            this.labelBdate.Size = new System.Drawing.Size(107, 25);
            this.labelBdate.TabIndex = 3;
            this.labelBdate.Text = "BirthDate:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(45, 254);
            this.labelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(81, 25);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(45, 309);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 25);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Phone:";
            // 
            // labelAdrs
            // 
            this.labelAdrs.AutoSize = true;
            this.labelAdrs.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdrs.Location = new System.Drawing.Point(32, 362);
            this.labelAdrs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdrs.Name = "labelAdrs";
            this.labelAdrs.Size = new System.Drawing.Size(91, 25);
            this.labelAdrs.TabIndex = 6;
            this.labelAdrs.Text = "Address:";
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPicture.Location = new System.Drawing.Point(40, 432);
            this.labelPicture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(83, 25);
            this.labelPicture.TabIndex = 7;
            this.labelPicture.Text = "Picture:";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(412, 16);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(303, 25);
            this.labelSearch.TabIndex = 8;
            this.labelSearch.Text = "Search Fname, Lname, Address: ";
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonUpload.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpload.Location = new System.Drawing.Point(144, 538);
            this.buttonUpload.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(105, 46);
            this.buttonUpload.TabIndex = 9;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonDownload.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDownload.Location = new System.Drawing.Point(288, 538);
            this.buttonDownload.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(108, 46);
            this.buttonDownload.TabIndex = 10;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Orange;
            this.buttonAdd.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(18, 602);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(123, 42);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEdit.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(170, 602);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(112, 42);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Red;
            this.buttonRemove.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRemove.Location = new System.Drawing.Point(316, 602);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(123, 42);
            this.buttonRemove.TabIndex = 13;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonReset.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReset.Location = new System.Drawing.Point(478, 602);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(117, 42);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(1677, 8);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(147, 51);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelTotalStd
            // 
            this.labelTotalStd.AutoSize = true;
            this.labelTotalStd.BackColor = System.Drawing.Color.BlueViolet;
            this.labelTotalStd.Font = new System.Drawing.Font("VNI-Ariston", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelTotalStd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotalStd.Location = new System.Drawing.Point(1005, 602);
            this.labelTotalStd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalStd.Name = "labelTotalStd";
            this.labelTotalStd.Size = new System.Drawing.Size(217, 37);
            this.labelTotalStd.TabIndex = 16;
            this.labelTotalStd.Text = "Total Student:   ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Wheat;
            this.pictureBox1.Location = new System.Drawing.Point(144, 415);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFemale);
            this.groupBox1.Controls.Add(this.radioButtonMale);
            this.groupBox1.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(144, 233);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(250, 58);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonFemale.Location = new System.Drawing.Point(144, 21);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(98, 29);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonMale.Location = new System.Drawing.Point(13, 21);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(73, 29);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxID.Location = new System.Drawing.Point(144, 42);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(250, 23);
            this.textBoxID.TabIndex = 19;
            // 
            // textBoxFname
            // 
            this.textBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxFname.Location = new System.Drawing.Point(144, 90);
            this.textBoxFname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(250, 23);
            this.textBoxFname.TabIndex = 20;
            // 
            // textBoxLname
            // 
            this.textBoxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxLname.Location = new System.Drawing.Point(144, 138);
            this.textBoxLname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(250, 23);
            this.textBoxLname.TabIndex = 21;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPhone.Location = new System.Drawing.Point(144, 313);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(250, 23);
            this.textBoxPhone.TabIndex = 22;
            // 
            // textBoxAdrs
            // 
            this.textBoxAdrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxAdrs.Location = new System.Drawing.Point(144, 366);
            this.textBoxAdrs.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdrs.Name = "textBoxAdrs";
            this.textBoxAdrs.Size = new System.Drawing.Size(250, 23);
            this.textBoxAdrs.TabIndex = 23;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSearch.Location = new System.Drawing.Point(723, 16);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(415, 24);
            this.textBoxSearch.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(426, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(909, 522);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 192);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 23);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Value = new System.DateTime(2021, 4, 2, 0, 0, 0, 0);
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.Lime;
            this.button_Search.Font = new System.Drawing.Font("VNI-Ariston", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Search.Location = new System.Drawing.Point(1166, 4);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(103, 37);
            this.button_Search.TabIndex = 27;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // ManageStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1370, 654);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxAdrs);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTotalStd);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.labelAdrs);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBdate);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.labelID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageStudentsForm";
            this.Text = "ManageStudentsForm";
            this.Load += new System.EventHandler(this.ManageStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelBdate;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAdrs;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelTotalStd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAdrs;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Search;
    }
}