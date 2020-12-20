using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FoodOrderingApp.DBLL
{
    class VendorDAO
    {
        static SqlCommand cmd = null;

        public static Boolean vendorDetails()
        {
            SqlConnection con = DBLL.DBConnection.EstablishConnection();
            bool flag = false;
            string SqlQuerry = "SELECT vendorId, vendorName, vendorPhone, vendorEmail, vendorAddress FROM vendorTable";
            cmd = new SqlCommand(SqlQuerry, con);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@Id", uid);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine("Vendor ID : " + rdr[0] + "\n" + "Vendor Name : " + rdr[1] + "\n" + "Vendor Phone : " + rdr[2] + "\n" + "Vendor Email : " + rdr[3] + "\n" + "Vendor location : " + rdr[4]);
                flag = true;
            }
            return flag;
            con.Close();
        }
        public static bool vendorLogin(int vendorId, string vendorPassword)
        {
            SqlConnection con = DBLL.DBConnection.EstablishConnection();
            bool flag = false;
            string SqlQuerry = "VendorVerification" ;
            cmd = new SqlCommand(SqlQuerry, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", vendorId);
            cmd.Parameters.AddWithValue("@Pass", vendorPassword);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("WELCOME  " + rdr[1]       + " !!!");
                flag = true;
            }
            
            return flag;
            con.Close();
        }
    }
}
