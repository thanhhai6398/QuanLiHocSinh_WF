using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjectQLSV
{
    class SCORE
    {
        MY_DB mdb = new MY_DB();
        public bool insertScore(int studentID, int courseID, float scoreValue, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Score (student_id,course_id,student_score,description) VALUES (@sid,@cid,@scr" +
                ",@descr)", mdb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@scr", SqlDbType.Float).Value = scoreValue;
            command.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;

            mdb.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool studentScoreExist(int studentId, int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM score WHERE student_id = @sid AND course_id = @cid", mdb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // tinh trung binh
        public DataTable getAvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mdb.getConnection;
            command.CommandText = "SELECT Course.label as Label, AVG(Score.student_score) as AverageGrade FROM Course, Score WHERE Course.Id =" +
            "Score.course_id GROUP BY Course.label";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //delete score bàng student id, và course id
        public bool deleteScore(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Score WHERE student_id = @sid AND course_id = @cid", mdb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            mdb.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable getAllScore(SqlCommand command)
        {
            command.Connection = mdb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
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
            return execCount("SELECT count(*) FROM (SELECT distinct student_id FROM Score) as Q");
        }
        public string totalPass()
        {
            return execCount("SELECT count(*) FROM (SELECT student_id, avg(student_score) as avgScore FROM Score GROUP BY student_id HAVING avg(student_score) >= 5) as Q");
        }
        public string totalFail()
        {
            return execCount("SELECT count(*) FROM (SELECT student_id, avg(student_score) as avgScore FROM Score GROUP BY student_id HAVING avg(student_score) < 5) as Q");
        }
    }
}
