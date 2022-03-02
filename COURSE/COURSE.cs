using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjectQLSV
{
    class COURSE
    {
        MY_DB mdb = new MY_DB();
        //insert
        public bool InsertCourse(int Id, string label,int period, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Course(Id,label,period,description)" +
                "VALUES (@cID,@cName, @cPeriod, @cDes)", mdb.getConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@cPeriod", SqlDbType.Int).Value = period;
            command.Parameters.Add("@cDes", SqlDbType.VarChar).Value = description;

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
        //Get all Course
        public DataTable getAllCourse(SqlCommand command)
        {
            command.Connection = mdb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //get Course By Id
        public DataTable getCourseById(int Id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course where Id=@cID");
            command.Parameters.Add("@cID", SqlDbType.Int).Value = Id;
            command.Connection = mdb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //delete by id
        public bool deleteCourse(int Id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Course WHERE Id = @cID", mdb.getConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = Id;
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
        public bool updateCourse(int Id, string label, int period, string description)
        {
            SqlCommand command = new SqlCommand("UPDATE Course SET label=@cName, period=@cPeriod, description=@cDes WHERE Id=@cID", mdb.getConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@cPeriod", SqlDbType.Int).Value = period;
            command.Parameters.Add("@cDes", SqlDbType.VarChar).Value = description;
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
        // tim course trung ten
        public bool checkCourseName(string courseName, int courseId = 0)
        {
            // id <> @cID de phan biet xem co ton tai khong chi la parameter
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE label=@cName And id <> @cID", mdb.getConnection);
            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                // neu phat hien có 1 don ton tai trung ten
                return false;
            }
            else
            {
                return true;
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
        public string totalCourse()
        {
            return execCount("SELECT count(*) FROM Course");
        }

    }
}
