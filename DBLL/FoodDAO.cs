using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FoodOrderingApp.DBLL
{
    class FoodDAO
    {
        static SqlCommand cmd = null;

        public static Boolean foodDetails()
        {
            SqlConnection con = DBLL.DBConnection.EstablishConnection();
            bool flag = false;
            string SqlQuerry = "SELECT * FROM foodTable";
            cmd = new SqlCommand(SqlQuerry, con);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@Id", uid);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine("---------------------------------------------------------------\n" +
                                "    " + rdr[0] + "\t" + "   " + rdr[1] + "\t" + rdr[2] + "\t" + "\t" + rdr[3]);
                flag = true;
            }
            con.Close();
            return flag;
        }
    }
}
