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
                    checker = false;
                    
                }
                else
                {
                    checker = true;
                }
            }
            if (checker == true)
            {
                usr.Add(new User(userId, userName, userPassword, userBal, userAddress, userNumber, userEmail));
                msg = "ThankYou ! " + userName + ", You have Successfully Created a New Account !";
            }
            else
            {
                msg = "The user Id is Already taken, Please try something else !";
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

        public static bool UserLogin(int uid, string password, List<User> usr)
        {
            foreach (var u in usr)
            {
                if(u.UserId == uid)
                {
                    if (u.UserPassword == password)
                    {
                        Console.WriteLine("----------------------------------------------------------------------------------------------");
                        Console.WriteLine("                             SUCCESSFULLY LOGGED IN !!!                                       ");
                        Console.WriteLine("----------------------------------------------------------------------------------------------");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Password. Try again..");
                        return false;
                    }
                }
            }
            Console.WriteLine("Incorrect User ID. Try again...");
            return false;
        }
        public static string showUserDetails(int uid, List<User> usr)
        {
            string user="";
            foreach(var u in usr)
            {
                if(u.UserId == uid)
                {
                    user = u.ToString();

                }
            }
            return user;
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
    }
}
