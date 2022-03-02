using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLSV
{
    public partial class EditInfoForm : Form
    {
        public EditInfoForm()
        {
            InitializeComponent();
        }
        User user = new User();
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditInfoForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = user.getUserById(Globals.GlobalUserId);
            textBoxUid.Text = table.Rows[0]["Id"].ToString();
            textBoxFname.Text = table.Rows[0]["f_name"].ToString();
            textBoxLname.Text = table.Rows[0]["l_name"].ToString();
            textBoxUname.Text = table.Rows[0]["uname"].ToString();
            textBoxPassword.Text = table.Rows[0]["pwd"].ToString();
            textBoxRePassword.Text = table.Rows[0]["pwd"].ToString();
            byte[] pic = (byte[])table.Rows[0]["fig"];
            MemoryStream picture = new MemoryStream(pic);
            pictureBox.Image = Image.FromStream(picture);
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(textBoxUid.Text);
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            string username = textBoxUname.Text;
            string password = textBoxPassword.Text;
            if (textBoxPassword.Text != textBoxRePassword.Text)
            {
                MessageBox.Show("Not Match!!!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(textBoxUid.Text);
                    MemoryStream pic = new MemoryStream();
                    pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);
                    if (user.updateUser(id, fname, lname, username, password, pic))
                    {
                        MessageBox.Show("User Information Updated", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxUid.Text.Trim() == "") || (textBoxFname.Text.Trim() == "")
            || (textBoxLname.Text.Trim() == "") || (textBoxUname.Text.Trim() == "")
            || (textBoxPassword.Text.Trim() == "") || (pictureBox.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
