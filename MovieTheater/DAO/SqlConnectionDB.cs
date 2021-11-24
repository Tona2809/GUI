using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater
{
    class SqlConnectionDB
    {
        SqlConnection conn;
        public SqlConnectionDB(string connectionstring)
        {
            conn = new SqlConnection(connectionstring);
        }
        public bool Isconnection
        {
            get
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                return true;
            }
        }
    }
}
