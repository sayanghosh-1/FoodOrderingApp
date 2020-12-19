using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FoodOrderingApp.DBLL
{
    class DbConnection
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public SqlConnection EstablishConnection()
        {
            string cs = "Data Source=localhost;Initial Catalog=sample;Integrated Security=True;";
            con = new SqlConnection();
            con.ConnectionString = cs;
            return con;
        }
        public bool ReadData()
        {
            bool SuccessFlag = false;
            cmd = new 
        }
}
