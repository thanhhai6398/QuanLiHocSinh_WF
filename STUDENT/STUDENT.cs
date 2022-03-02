using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace ProjectQLSV
{
    class STUDENT
    {
        MY_DB mdb = new MY_DB();
        //insert a new student
        public bool InsertStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO std(id, fname, lname, bdate, gender, phone, address, picture)" +
                "VALUES (@id,@fn, @ln, @bdt, @gdr, @phn, @adrs, @pic)", mdb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

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
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mdb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //delete by id
        public bool deleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM std WHERE id = @id", mdb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        //update information
        public bool updateStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET fname=@fn, lname=@ln, bdate=@bdt, gender=@gdr,phone=@phn, ad" +
            "dress=@adrs, picture=@pic WHERE id=@ID", mdb.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
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
        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mdb.getConnection);
            mdb.OpenConnection();
            string count = command.ExecuteScalar().ToString();
            mdb.CloseConnection();
            return count;
        }
        public string totalStudent()
        {
            return execCount("SELECT count(*) FROM std");
        }
        public string totalMaleStudent()
        {
            return execCount("SELECT count(*) FROM std WHERE gender='Male'");
        }
        public string totalFemaleStudent()
        {
            return execCount("SELECT count(*) FROM std WHERE gender='Female'");
        }
        
    }
}