using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjectQLSV
{
    class MY_DB
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DVLN21C\\SQLEXPRESS;Initial Catalog=MYDB;Integrated Security=True");
        //get the connection
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        // open the connection
        public void OpenConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
        // close the connection
        public void CloseConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
