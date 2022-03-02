using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLSV
{
    public partial class EditContactForm : Form
    {
        public EditContactForm()
        {
            InitializeComponent();
        }
        private void EditContactForm_Load(object sender, EventArgs e)
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
            opf.Filter = "Select Image(.jpg;.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox.Image = Image.FromFile(opf.FileName);

            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            string phone = textBoxPhone.Text;
            string address = textBoxAdrs.Text;
            string email = textBoxEmail.Text;

            try
            {
                int id = Convert.ToInt32(textBoxID.Text);

                int groupid = (int)comboBoxGroup.SelectedValue;

                MemoryStream pic = new MemoryStream();
                pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);

                if (contact.updateContact(id, fname, lname, groupid, phone, email, address, pic))
                {
                    MessageBox.Show("Contact Inormation UpDated", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectContactForm SelectContactF = new SelectContactForm();
            SelectContactF.ShowDialog();

            try
            {

                int contactId = Convert.ToInt32(SelectContactF.dataGridView.CurrentRow.Cells[0].Value.ToString());

                Contact contact = new Contact();
                DataTable table = contact.GetContactById(contactId);

                textBoxID.Text = table.Rows[0]["id"].ToString();
                textBoxFname.Text = table.Rows[0]["fname"].ToString();
                textBoxLname.Text = table.Rows[0]["lname"].ToString();
                comboBoxGroup.SelectedValue = table.Rows[0]["group_id"];
                textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                textBoxEmail.Text = table.Rows[0]["email"].ToString();
                textBoxAdrs.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["pic"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox.Image = Image.FromStream(picture);

            }
            catch (Exception)
            {

            }

        }

    }
}
