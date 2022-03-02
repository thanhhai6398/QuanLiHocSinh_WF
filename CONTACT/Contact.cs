using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectQLSV
{
    class Contact
    {
        MY_DB mydb = new MY_DB();
        public bool insertContact(int id, string fname, string lname, int groupid, string phone, string email, string address, int userid,  MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO mycontact(id, fname, lname, group_id, phone, email, address, pic, userid) VALUES (@id, @fn, @ln, @grp, @phn, @mail, @adrs, @pic, @userid)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.Text).Value = address;
            command.Parameters.Add("@userid", SqlDbType.Int).Value = userid;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
       
            mydb.OpenConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.CloseConnection();
                return true;
            }
            else
            {
                mydb.CloseConnection();
                return false;
            }
        }
        public bool updateContact(int contactid, string fname, string lname, int groupid, string phone, string email, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE mycontact SET fname = @fn, lname = @ln, group_id = @gid, phone = @phn, email = @mail, address = @adrs, picture = @pic", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.Text).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.CloseConnection();
                return true;
            }
            else
            {
                mydb.CloseConnection();
                return false;
            }
        }
    // Delete
        public bool deleteContact(int contactid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM mycontact WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
            mydb.OpenConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.CloseConnection();
                return true;
            }
            else
            {
                mydb.CloseConnection();
                return false;
            }
        }

        // nap du lieu
        public DataTable SelectContactlist(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public string FullContactList(bool check)
        {
            string str_command = "SELECT fname[First Name], lname[Last Name], dbo.mygroups.name[Group Name], phone[Phone] FROM mycontact INNER JOIN mygroups on mycontact.group_id = mygroups.id WHERE mycontact.userid = @userid";
            if(check == false)
            {
                str_command += "AND dbo.mycontact.group_id = @GroupID";
            }
            return str_command;
        }
        //lay du lieu theo id
        public DataTable GetContactById(int contactId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mycontact WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("id", SqlDbType.Int).Value = contactId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //kiem tra contactId ton tai
        public bool CheckId(int contactid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.mycontact WHERE id = @contactid", mydb.getConnection);
            command.Parameters.Add("@contactid", SqlDbType.Int).Value = contactid;
            mydb.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.CloseConnection();
                return true;
            }
            else
            {
                mydb.CloseConnection();
                return false;
            }
        }
    }
}
        
