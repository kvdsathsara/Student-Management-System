using System;
using System.Data.SqlClient;

namespace CollegeManagement
{
    internal class Sqlconnection
    {
        public object ConnectionString { get; internal set; }

        public static implicit operator SqlConnection(Sqlconnection v)
        {
            throw new NotImplementedException();
        }
    }
}