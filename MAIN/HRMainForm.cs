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
    public partial class HRMainForm : Form
    {
        public HRMainForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        Group group = new Group();

        public void getImageAndUsername()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE Id = @uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if((table.Rows.Count > 0))
            {
                byte[] pic = (byte[])table.Rows[0]["fig"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
                labelUsername.Text = "Welcome Back (" + table.Rows[0]["uname"].ToString() + ")";
            }

        }
        private void labelLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelEditInfo_Click(object sender, EventArgs e)
        {
            EditInfoForm editInfo = new EditInfoForm();
            editInfo.Show(this);
        }
        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            AddContactForm add = new AddContactForm();
            add.Show(this);
        }

        private void buttonEditContact_Click(object sender, EventArgs e)
        {
            EditContactForm edit = new EditContactForm();
            edit.Show(this);
        }

        private void HumanResourceForm_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
            Group group = new Group();

            comboBoxEdit.DataSource = group.getGroups(Globals.GlobalUserId);
            comboBoxEdit.DisplayMember = "name";
            comboBoxEdit.ValueMember = "id";

            comboBoxRemove.DataSource = group.getGroups(Globals.GlobalUserId);
            comboBoxRemove.DisplayMember = "name";
            comboBoxRemove.ValueMember = "id";
        }

        private void buttonSelectConTact_Click(object sender, EventArgs e)
        {
            SelectContactForm seC = new SelectContactForm();
            seC.Show(this);
        }
        private void buttonRemoveContact_Click(object sender, EventArgs e)
        {
            int contactid = Convert.ToInt32(textBoxContactID.Text);
            Contact contact = new Contact();
            if (contact.deleteContact(contactid))
            {
                MessageBox.Show("Contact Deleted", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Detete Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonShowFContact_Click(object sender, EventArgs e)
        {
            ShowFullContactForm showFull = new ShowFullContactForm();
            showFull.Show(this);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdG.Text);
            string gname = textBoxNameG.Text;
            int userid = Convert.ToInt32(Globals.GlobalUserId);
            if (!group.groupExist(textBoxNameG.Text))
            {
                if (group.insertGroup(id, gname, userid))
                {
                    MessageBox.Show("New Group Added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("This Group Name Existed", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string gname = textBoxNameG.Text;

            if (!group.groupExist(gname))
            {
                try
                {
                    int gid = (int)comboBoxEdit.SelectedValue;

                    if (group.updateGroup(gid,gname))
                    {
                        MessageBox.Show("Group Information Updated", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("This Group Not Existed", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int gid = (int)comboBoxRemove.SelectedValue;

            if (group.deleteGroup(gid))
            {
                MessageBox.Show("Group Deleted", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Detete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
