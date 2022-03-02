using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLSV
{
    public partial class ShowFullContactForm : Form
    {
        public ShowFullContactForm()
        {
            InitializeComponent();
        }

        private void ShowFullContactForm_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn piccol = new DataGridViewImageColumn();
            dataGridView.RowTemplate.Height = 80;
            // cau truc lay tu gợi ý của SV
            Contact contact = new Contact();
            SqlCommand command = new SqlCommand("SELECT mycontact.fname as 'First Name', mycontact.lname as 'Last Name', mygroups.name as 'Group', mycontact.phone as Phone, mycontact.email as Email, mycontact.address as Address, mycontact.pic as Picture " +
                "FROM mycontact INNER JOIN mygroups on mycontact.group_id = mygroups.id WHERE mycontact.userid = @userid");
            command.Parameters.Add("@userid", SqlDbType.Int).Value = Globals.GlobalUserId;
            dataGridView.DataSource = contact.SelectContactlist(command);
            
            piccol = (DataGridViewImageColumn)dataGridView.Columns[6];
            piccol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (IsOdd(1))
                {
                    dataGridView.Rows[1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
            Group group = new Group();
            listBox.DataSource = group.getGroups(Globals.GlobalUserId);
            listBox.DisplayMember = "name";
            listBox.ValueMember = "id";

            listBox.SelectedItem = null;
            dataGridView.ClearSelection();
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
        // Sinh viên gợi ý cách sort
        private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void listBox_Click(object sender, EventArgs e)
        {
            DStheoGroup();
            Group group = new Group();
            listBox.DataSource = group.getGroups(Globals.GlobalUserId);
            listBox.DisplayMember = "name";
            listBox.ValueMember = "id";

            listBox.SelectedItem = null;
            dataGridView.ClearSelection();
        }
        public void DStheoGroup()
        {
            int groupID = Convert.ToInt32(listBox.SelectedValue);
            DataGridViewImageColumn piccol = new DataGridViewImageColumn();
            dataGridView.RowTemplate.Height = 80;
            // cau truc lay tu gợi ý của SV
            Contact contact = new Contact();
            SqlCommand command = new SqlCommand("SELECT mycontact.fname as 'First Name', mycontact.lname as 'Last Name', mygroups.name as 'Group', mycontact.phone as Phone, mycontact.email as Email, mycontact.address as Address, mycontact.pic as Picture " +
                "FROM mycontact INNER JOIN mygroups on mycontact.group_id = mygroups.id WHERE mycontact.userid = @userid and mygroups.id = @groupID");
            command.Parameters.Add("@userid", SqlDbType.Int).Value = Globals.GlobalUserId;
            command.Parameters.Add("@groupID", SqlDbType.Int).Value = groupID;
            dataGridView.DataSource = contact.SelectContactlist(command);

            piccol = (DataGridViewImageColumn)dataGridView.Columns[6];
            piccol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (IsOdd(1))
                {
                    dataGridView.Rows[1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            ListByGroup listbycourse = new ListByGroup();
            listbycourse.textBoxFname.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            listbycourse.textBoxLname.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            listbycourse.textBoxGroup.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            listbycourse.Show(this);
        }
    }
}
