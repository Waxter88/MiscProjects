using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG1210
{
    internal static class Data
    {

        //Add a Helper internal static class named Data (Data.cs) to the library that provides a SQLConnection object for the two
        //Data Access classes in the library.
        internal static SqlConnection con = new SqlConnection();
        
        static Data()
        {
            con.ConnectionString = global::PROG1210.Properties.Settings.Default.MoviesConnectionString;
        }
    }
}
