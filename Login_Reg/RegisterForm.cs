using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLSV
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            int id = Convert.ToInt32(textBoxUid.Text);
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            string username = textBoxUname.Text;
            string password = textBoxPassword.Text;
            MemoryStream pic = new MemoryStream();
            pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);

            if(textBoxPassword.Text != textBoxRePassword.Text)
            {
                MessageBox.Show("Not Match!!!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!user.usernameExist(textBoxUname.Text))
            {
                
                if (user.insertUser(id,fname, lname, username,password, pic))
                {
                    MessageBox.Show("New User Added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("This User Existed", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }           
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show(this);
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(.jpg;.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox.Image = Image.FromFile(opf.FileName);

            }
        }
    }
}
