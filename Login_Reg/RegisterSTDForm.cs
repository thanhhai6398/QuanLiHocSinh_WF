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
    public partial class RegisterSTDForm : Form
    {
        public RegisterSTDForm()
        {
            InitializeComponent();
        }
        MY_DB mdb = new MY_DB();
        //insert a new student
        public bool InsertAccount(string userName , string Password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Login(UserName, Password) VALUES (@name, @pass)", mdb.getConnection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = Password;
            mdb.OpenConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mdb.CloseConnection();
                return true;
            }
            else
            {
                mdb.CloseConnection();
                return false;
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            if (textBoxPassword.Text != textBoxRePassword.Text)
            {
                MessageBox.Show("Not Match!!!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {

                if (InsertAccount(username, password))
                {
                    MessageBox.Show("New Account Added", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private bool verif()
        {
            if ((textBoxUserName.Text.Trim() == "") || (textBoxPassword.Text.Trim() == "") || (textBoxRePassword.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show(this);
        }
    }
}
