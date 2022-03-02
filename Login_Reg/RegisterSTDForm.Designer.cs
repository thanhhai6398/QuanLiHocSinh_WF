
namespace ProjectQLSV
{
    partial class RegisterSTDForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxRePassword = new System.Windows.Forms.TextBox();
            this.labelRe_Password = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ariston", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 80);
            this.label1.TabIndex = 17;
            this.label1.Text = "Account Register";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(111, 133);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(118, 25);
            this.labelUserName.TabIndex = 15;
            this.labelUserName.Text = "User Name:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxUserName.Location = new System.Drawing.Point(235, 135);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(229, 24);
            this.textBoxUserName.TabIndex = 13;
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.Lime;
            this.buttonReg.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReg.Location = new System.Drawing.Point(147, 278);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(106, 31);
            this.buttonReg.TabIndex = 12;
            this.buttonReg.Text = "Register";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("VNI-Centur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCancel.Location = new System.Drawing.Point(355, 278);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(96, 31);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxRePassword
            // 
            this.textBoxRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxRePassword.Location = new System.Drawing.Point(235, 226);
            this.textBoxRePassword.Name = "textBoxRePassword";
            this.textBoxRePassword.PasswordChar = '*';
            this.textBoxRePassword.Size = new System.Drawing.Size(229, 24);
            this.textBoxRePassword.TabIndex = 21;
            // 
            // labelRe_Password
            // 
            this.labelRe_Password.AutoSize = true;
            this.labelRe_Password.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRe_Password.Location = new System.Drawing.Point(88, 224);
            this.labelRe_Password.Name = "labelRe_Password";
            this.labelRe_Password.Size = new System.Drawing.Size(134, 25);
            this.labelRe_Password.TabIndex = 20;
            this.labelRe_Password.Text = "Re-Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxPassword.Location = new System.Drawing.Point(235, 181);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(229, 24);
            this.textBoxPassword.TabIndex = 19;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("VNI-Ariston", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(118, 179);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(104, 25);
            this.labelPassword.TabIndex = 18;
            this.labelPassword.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font(".VnTime", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "<<Have an account? Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegisterSTDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(565, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRePassword);
            this.Controls.Add(this.labelRe_Password);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonCancel);
            this.Name = "RegisterSTDForm";
            this.Text = "RegisterSTDForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxRePassword;
        private System.Windows.Forms.Label labelRe_Password;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label2;
    }
}