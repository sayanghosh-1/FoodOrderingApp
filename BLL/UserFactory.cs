﻿using FoodOrderingApp.DBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingApp
{
    class UserFactory
    {
        static List<User> usr = new List<User>();
        public static string UserSignup(int userId, string userName, string userPassword, double userBal, string userAddress, string userNumber, string userEmail, List<User> usr)
        {
            string msg = " ";
            bool checker = false;
            foreach (var u in usr)
            {
                if (u.UserId == userId)
                {
                    checker = true;
                    msg = "The user Id is Already taken, Please try something else !";
                }
            }
            if (checker == false)
            {
                usr.Add(new User(userId, userName, userPassword, userBal, userAddress, userNumber, userEmail));
                msg = "ThankYou ! " + userName + ", You have Successfully Created a New Account !";
            }
            return msg;
        }
        public static double AddMoney(int uid, double amt, List<User> usr)
        {
            foreach (var u in usr)
            {
                if(u.UserId == uid && amt > 0)
                {
                    u.UserBalance = u.UserBalance + amt;
                    return u.UserBalance ;
                }
            }
            return 0;
        }

        public static bool UserLogin(int uid, string password)
        {
            bool flag = false;
            bool verify = DBLL.UserDAO.UserLogin(uid, password);
            if (verify == true)
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------");
                Console.WriteLine("                             SUCCESSFULLY LOGGED IN !!!                                       ");
                Console.WriteLine("----------------------------------------------------------------------------------------------");
                flag = true;
            }
            else
            {
                Console.WriteLine("Incorrect Password. Try again..");
            }
            return flag;
        }
        public static bool showUserDetails(int uid)
        {
            /*string user="";
            foreach(var u in usr)
            {
                if(u.UserId == uid)
                {
                    user = u.ToString();

                }
            }
            return user;*/
            bool res = UserDAO.showDetails(uid);
            if (res)
            {
                return true;
            }
            return false;
        }
        public static string getMail(int uid, List<User> usr)
        {
            String mail = " ";
            foreach(var u in usr)
            {
                if (u.UserId == uid)
                {
                    mail = u.UserEmail;
                }
            }
            return mail;
        }

        public static string generateOTP()
        {
            Random rnd = new Random();
            return rnd.Next(1000, 9999).ToString();
        }
    }
}
