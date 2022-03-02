
namespace ProjectQLSV
{
    partial class EditInfoForm
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
            this.buttonUpload = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxUname = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.labelUname = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.textBoxRePassword = new System.Windows.Forms.TextBox();
            this.labelRe_Password = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUid = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.Color.LightCoral;
            this.buttonUpload.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpload.Location = new System.Drawing.Point(458, 191);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(188, 32);
            this.buttonUpload.TabIndex = 32;
            this.buttonUpload.Text = "Upload File";
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Peru;
            this.pictureBox.Location = new System.Drawing.Point(456, 35);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(191, 136);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 31;
            this.pictureBox.TabStop = false;
            // 
            // textBoxUname
            // 
            this.textBoxUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxUname.Location = new System.Drawing.Point(182, 144);
            this.textBoxUname.Name = "textBoxUname";
            this.textBoxUname.Size = new System.Drawing.Size(229, 24);
            this.textBoxUname.TabIndex = 30;
            // 
            // textBoxLname
            // 
            this.textBoxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxLname.Location = new System.Drawing.Point(182, 104);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(229, 24);
            this.textBoxLname.TabIndex = 29;
            // 
            // textBoxFname
            // 
            this.textBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxFname.Location = new System.Drawing.Point(182, 67);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(229, 24);
            this.textBoxFname.TabIndex = 28;
            // 
            // labelUname
            // 
            this.labelUname.AutoSize = true;
            this.labelUname.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUname.Location = new System.Drawing.Point(46, 142);
            this.labelUname.Name = "labelUname";
            this.labelUname.Size = new System.Drawing.Size(105, 25);
            this.labelUname.TabIndex = 27;
            this.labelUname.Text = "Username:";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLname.Location = new System.Drawing.Point(37, 104);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(114, 25);
            this.labelLname.TabIndex = 26;
            this.labelLname.Text = "Last Name:";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFname.Location = new System.Drawing.Point(30, 65);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(121, 25);
            this.labelFname.TabIndex = 25;
            this.labelFname.Text = "First Name:";
            // 
            // textBoxRePassword
            // 
            this.textBoxRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxRePassword.Location = new System.Drawing.Point(182, 235);
            this.textBoxRePassword.Name = "textBoxRePassword";
            this.textBoxRePassword.PasswordChar = '*';
            this.textBoxRePassword.Size = new System.Drawing.Size(229, 24);
            this.textBoxRePassword.TabIndex = 24;
            // 
            // labelRe_Password
            // 
            this.labelRe_Password.AutoSize = true;
            this.labelRe_Password.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRe_Password.Location = new System.Drawing.Point(17, 233);
            this.labelRe_Password.Name = "labelRe_Password";
            this.labelRe_Password.Size = new System.Drawing.Size(134, 25);
            this.labelRe_Password.TabIndex = 23;
            this.labelRe_Password.Text = "Re-Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxPassword.Location = new System.Drawing.Point(182, 190);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(229, 24);
            this.textBoxPassword.TabIndex = 22;
            // 
            // textBoxUid
            // 
            this.textBoxUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxUid.Location = new System.Drawing.Point(182, 35);
            this.textBoxUid.Name = "textBoxUid";
            this.textBoxUid.Size = new System.Drawing.Size(229, 24);
            this.textBoxUid.TabIndex = 21;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Black;
            this.buttonCancel.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(401, 277);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 33);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Lime;
            this.buttonEdit.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(134, 277);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(108, 33);
            this.buttonEdit.TabIndex = 19;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(47, 188);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(104, 25);
            this.labelPassword.TabIndex = 18;
            this.labelPassword.Text = "Password:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(56, 31);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(95, 25);
            this.labelID.TabIndex = 17;
            this.labelID.Text = "ID User:";
            // 
            // EditInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(706, 343);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBoxUname);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.labelUname);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.textBoxRePassword);
            this.Controls.Add(this.labelRe_Password);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUid);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelID);
            this.Name = "EditInfoForm";
            this.Text = "EditInfoForm";
            this.Load += new System.EventHandler(this.EditInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBoxUname;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.Label labelUname;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.TextBox textBoxRePassword;
        private System.Windows.Forms.Label labelRe_Password;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUid;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelID;
    }
}