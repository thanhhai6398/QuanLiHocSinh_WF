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
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }
        private void AddContactForm_Load(object sender, EventArgs e)
        {
            Group group = new Group();

            comboBoxGroup.DataSource = group.getGroups(Globals.GlobalUserId);
            comboBoxGroup.DisplayMember = "name";
            comboBoxGroup.ValueMember = "id";

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox.Image = Image.FromFile(opf.FileName);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            int id = Convert.ToInt32(textBoxID.Text);
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            string phone = textBoxPhone.Text;
            string address = textBoxAdrs.Text;
            string email = textBoxEmail.Text;
            int userid = Globals.GlobalUserId;

            try
            {
                int groupid = (int)comboBoxGroup.SelectedValue;

                MemoryStream pic = new MemoryStream();
                pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);

                if (contact.CheckId(Convert.ToInt32(textBoxID.Text))== false)
                {
                    if (contact.insertContact(id, fname, lname, groupid, phone, email, address, userid, pic))
                    {
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("One Or More Fields Are Empty", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
