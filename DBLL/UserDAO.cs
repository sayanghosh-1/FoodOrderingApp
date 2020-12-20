﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FoodOrderingApp.DBLL
{
    class UserDAO
    {
        static SqlCommand cmd = null;

        public static Boolean showDetails(int uid)
        {
            SqlConnection con = DBLL.DBConnection.EstablishConnection();
            bool flag = false;
            cmd = new SqlCommand("spGetUserById", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", uid);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine("   " + rdr[0] + "\t" + "\t" + rdr[1] + "\t" + "\t" + rdr[2] + "\t" + "\t" + rdr[3] + "\t" + "\t" + rdr[4] + "\t" + "\t" + rdr[5]);
                flag = true;
            }
            return flag;
            con.Close();
        }
        public static bool UserLogin(int uId, string password)
        {
            SqlConnection con = DBLL.DBConnection.EstablishConnection();
            bool flag = false;
            string SqlQuerry = "spGetUserLoginById";
            cmd = new SqlCommand(SqlQuerry, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", uId);
            cmd.Parameters.AddWithValue("@Pass", password);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("WELCOME  " + rdr[1] + " !!!");
                flag = true;
            }

            return flag;
            con.Close();
        }

    }
}
