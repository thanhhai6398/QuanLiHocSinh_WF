using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLSV
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            if (radioButtonSTD.Checked)
            {
                SqlCommand cmd = new SqlCommand("SELECT * from Login where UserName=@UserName and Password =@Password", db.getConnection);

                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = textBoxUserName.Text;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = textBoxPassword.Text;

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Successfully loged in");
                    //after successful it will redirect  to next page .  
                    MainForm settingsForm = new MainForm();
                    settingsForm.Show();
                }
                else
                {
                    MessageBox.Show("Please enter Correct Username and Password");
                }
            }
            if (radioButtonHR.Checked)
            {
                SqlCommand cmd = new SqlCommand("SELECT * from hr where uname=@UserName and pwd =@Password", db.getConnection);

                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = textBoxUserName.Text;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = textBoxPassword.Text;

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    int userid = Convert.ToInt16(table.Rows[0][0].ToString());
                        Globals.SetGlobalUserId(userid);
                    this.DialogResult = DialogResult.OK;

                    MessageBox.Show("Successfully loged in");
                    //after successful it will redirect  to next page .  
                    HRMainForm settingsForm = new HRMainForm();
                    settingsForm.Show();
                }
                else
                {
                    MessageBox.Show("Please enter Correct Username and Password");
                }
            }
        }


        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.Show(this);
        }

        private void buttonRegSTD_Click(object sender, EventArgs e)
        {
            RegisterSTDForm RegSTD = new RegisterSTDForm();
            RegSTD.Show(this);
        }
    }
}
