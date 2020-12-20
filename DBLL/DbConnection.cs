using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FoodOrderingApp.DBLL
{
    class DBConnection
    {
        public static SqlConnection EstablishConnection()
        {
            SqlConnection con = null;
            string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            con = new SqlConnection();
            con.ConnectionString = cs;
            con.Open();
            return con;
        }
    }
}
