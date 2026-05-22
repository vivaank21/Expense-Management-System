using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace ExpenseManagerUI
{
    public static class DBConnection
    {
        // Connection String
        public static string cs =
            ConfigurationManager
            .ConnectionStrings["Mycon"]
            .ConnectionString;

        // Common SqlConnection Object
        public static SqlConnection con =
            new SqlConnection(cs);
    }
}