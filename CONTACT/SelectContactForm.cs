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
    public partial class SelectContactForm : Form
    {
        public SelectContactForm()
        {
            InitializeComponent();
        }

        private void SelectContactForm_Load(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            SqlCommand command = new SqlCommand("SELECT  id as 'ID' ,  fname  as 'First Name',  lname  as 'Last Name',  group_id  as 'Group ID' FROM  mycontact  WHERE  userid  = @uid");
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
            dataGridView.DataSource = contact.SelectContactlist(command);
            dataGridView.RowTemplate.Height = 50; //size
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
