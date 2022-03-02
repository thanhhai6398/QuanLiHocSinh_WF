using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectQLSV
{
    class User
    {
        MY_DB db = new MY_DB();
        public DataTable getUserById(int userid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE Id = @uid", db.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
            // function to insert a new user
        public bool insertUser(int Id, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO hr (Id, f_name, l_name , uname, pwd, fig ) VALUES (@uid, @fn, @ln, @un, @pass, @pic)", db.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.CloseConnection();
                return true;
            }

            else
            {
                db.CloseConnection();
                return false;
            }
        }
        //kiem tra ton tai
        public bool usernameExist(string username, int userid = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE uname = @un AND Id <> @uid", db.getConnection);

            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Update
        public bool updateUser(int userid, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE hr SET f_name = @fn, l_name = @ln, uname = @un, pwd = @pass, fig = @pic WHERE Id = @uid", db.getConnection);
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.CloseConnection();
                return true;
            }
            else
            {
                db.CloseConnection();
                return false;
            }
        }
    }
}
