using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement
{
    internal class ClassConnect
    {
        //connection string
        string connstring = @"Data Source=DESKTOP-BM9KUSR ; Initial catalog=College; Integrated Security=True ";

        //method to get a  connection object
        public SqlConnection GetDatabaseConnection()
        {
            SqlConnection conobj = new SqlConnection(connstring);
            conobj.Open();
            return conobj;
        }
    }
}
