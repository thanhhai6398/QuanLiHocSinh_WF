using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjectQLSV
{
    class Group
    {
        MY_DB mydb = new MY_DB();
        public bool insertGroup(int id, string gname, int userid)
        {
            SqlCommand command = new SqlCommand("INSERT INTO mygroups (id, name, userid) VALUES (@id, @gn, @uid)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@gn", SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

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
        // update khi thay doi ten
        public bool updateGroup(int gid, string gname)
        {
            SqlCommand command = new SqlCommand("UPDATE mygroups SET name = @name WHERE id= @id", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("@id", SqlDbType.Int).Value = gid;
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
        // xoa
        public bool deleteGroup(int groupid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM mygroups WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = groupid;
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
        // chuc nang này quan trong, xac dinh group cho userId nào đó
        public DataTable getGroups(int userid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mygroups WHERE userid = @uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool groupExist(string name, int userid = 0, int groupid = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mygroups WHERE name = @name AND userid = @uid AND id <> @gid", mydb.getConnection);    
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
                        
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
