using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FoodOrderingApp.DBLL
{
    class OrderDAO
    {
        static SqlCommand cmd = null;

        public static Boolean orderDetails()
        {
            SqlConnection con = DBLL.DBConnection.EstablishConnection();
            bool flag = false;
            string SqlQuerry = "SELECT * FROM orderTable";
            cmd = new SqlCommand(SqlQuerry, con);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@Id", uid);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------\n"
                                   + "    " + rdr[0] + "\t" + "\t" + rdr[1] + "\t" + "\t" + rdr[2] + "\t"
                                   + rdr[4] + "\t" + "     " + rdr[3] + "\t" + "\t" + "   " + rdr[5] + "\t" + " " + rdr[6] + "\t" + " " + rdr[7]);
                flag = true;
            }
            con.Close();
            return flag;
        }
        public static Boolean orderDetailsUser(int uid)
        {
            SqlConnection con = DBLL.DBConnection.EstablishConnection();
            bool flag = false;
            string SqlQuerry = "spGetOrderUserById";
            cmd = new SqlCommand(SqlQuerry, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", uid);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------\n"
                                   + "    " + rdr[0] + "\t" + "\t" + rdr[1] + "\t" + "\t" + rdr[2] + "\t"
                                   + rdr[3] + "\t" + "     " + rdr[4] + "\t" + "\t" + "   " + rdr[5] + "\t" + "\t" + " " + rdr[6]);
                flag = true;
            }
            con.Close();
            return flag;
        }
        public static bool orderUpdateAvail(int orderId, string Status)
        {
            SqlConnection con = DBLL.DBConnection.EstablishConnection();
            string SqlQuerry = "spUpdateOrderStatusById";
            cmd = new SqlCommand(SqlQuerry, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", orderId);
            cmd.Parameters.AddWithValue("@Status", Status);
            int rd = cmd.ExecuteNonQuery();
            Console.WriteLine(rd);
            if (rd >= 0)
            {
                //Console.WriteLine("------------------------------------------");
                //Console.WriteLine("Order Id " + rd[1] + " has been " + Status);
                return true;
            }
            con.Close();
            return false;
        }
        public static Boolean orderCancel(int oid)
        {
            SqlConnection con = DBLL.DBConnection.EstablishConnection();
            bool flag = false;
            string SqlQuerry = "spCancelOrderById";
            cmd = new SqlCommand(SqlQuerry, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", oid);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Order Id " + rd[1] + " has been Cancelled !");
                flag = true;
            }
            con.Close();
            return flag;
        }
    }
}
