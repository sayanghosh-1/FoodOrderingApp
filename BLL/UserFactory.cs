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
                        Console.WriteLine("Successfuly Logged In..");
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
    }
}
