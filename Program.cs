using FoodOrderingApp.factory;
using FoodOrderingApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingApp
{
    class Program
    {
        static int uid;
        static List<User> usr = new List<User>();
        static List<Food> food = new List<Food>();
        static List<Orders> orders = new List<Orders>();
        static Vendor vendor = new Vendor(1001, "Zomato", "zomato123", "976763882", "zomato@gmail.com", "Kharagpur");
        static void Main(string[] args)
        {
            usr.Add(new User(101, "sayan", "sayan123", 13000, "KGP", "976763882"));
            usr.Add(new User(102, "abhi", "abhib123", 12000, "KOL", "976763882"));
            usr.Add(new User(103, "disha", "disha123", 9000, "DEL", "976373882"));
            usr.Add(new User(104, "ruchi", "ruchi123", 11000, "NGP", "9768373882"));
            usr.Add(new User(105, "sarayu", "sarayu123", 8000, "BSR", "9878373882"));


            food.Add(new Food(1, "Chicken Biryani", 250.50, 4));
            food.Add(new Food(2, "Mutton Kebab", 270.50, 5));
            food.Add(new Food(3, "Chicken Keema", 200.50, 6));

            Console.WriteLine("***************************** Welcome to Our Food Ordering App *****************************************");

            //Login for User and Vendor
            Console.WriteLine("\n Please Log In with your credentials to order food...");

            Console.WriteLine("\n Are you an User or a Vendor ? Enter u/v...");
            char identity = Convert.ToChar(Console.ReadLine());
            if(identity == 'u' || identity == 'U')
            {
                Console.WriteLine("\n Enter your User Id");
                uid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n Enter your Password");
                string password = Console.ReadLine();
                bool res = UserFactory.UserLogin(uid, password, usr);
                if (res == true)
                {
                    Program mainObj = new Program();
                    mainObj.mainUserDisplay();
                }
                else
                {
                    Console.WriteLine("Not Successful Login");
                }
            }
            else if (identity == 'v' || identity == 'V')
            {
                /*Console.WriteLine("\n Enter your Vendor Id");
                int uid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n Enter your Password");
                string password = Console.ReadLine();
                bool res = UserFactory.Login(uid, password, usr);
                if (res == true)
                {
                    Program mainObj = new Program();
                    mainObj.mainVendorDisplay();
                }
                else
                {
                    Console.WriteLine("Not Successful Login");
                }*/
            }
            else
            {
                Console.WriteLine("\n Invalid Input.. Enter either u/v ...");
            }
            Console.ReadLine();
        }

        private void mainUserDisplay()
        {
            Console.WriteLine("All Options are given below. Please Enter your Choice from the list below.");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Show Restaurant Details");
            Console.WriteLine("2. Show Food Menu");
            Console.WriteLine("3. Show Personal and Wallet Details of User");
            Console.WriteLine("4. Add money to wallet");
            Console.WriteLine("5. Order Food");
            Console.WriteLine("6. Show Previous Order Details of User");
            Console.WriteLine("7. Cancel an Ordered Food");
            Console.WriteLine("8. Exit");
            mainUserChoice();
        }

        private void mainUserChoice()
        {
            try
            {
                Console.WriteLine("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        showRestaurantDetails();
                        break;

                    case 2:
                        showFoodMenu();
                        break;

                    case 3:
                        showPersonalDetails();
                        break;

                    case 4:
                        AddMoneyToWallet();
                        break;
                        
                    case 5:
                        orderFood();
                        break;
                        
                    case 6:
                        showOrderDetails();
                        break;

                    case 7:
                        cancelOrder();
                        break;

                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n Choose an option between 1 to 7");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("\n Enter a valid value");
            }
            Console.WriteLine("\n");
            mainUserDisplay();
        }

        private static void showFoodMenu()
        {
            Food[] f1 = FoodFactory.showFood(food);
            Console.WriteLine("\n ***************************** Food Menu for Today *****************************************");
            Console.WriteLine("\n Food Id  Food Name   Food Cost   Food Stock");
            foreach(var f in f1)
            {
                Console.WriteLine("\n" + f.ToString());
            }
            
        }
        private static void AddMoneyToWallet()
        {
            Console.WriteLine("\n Enter Amount to be Added...");
            double amount = Convert.ToDouble(Console.ReadLine());
            double newAmount = UserFactory.AddMoney(uid, amount, usr);
            if (newAmount == 0)
            {
                Console.WriteLine("\n Transaction Unsuccessful. Please Check the inputs.");
            } 
            else
            {
                Console.WriteLine("\n Transaction Successful..");
                Console.WriteLine("\n New Wallet Balance = Rs. " + newAmount);
            }

        }

        private static void showPersonalDetails()
        {
            Console.WriteLine("\n User ID \t User Name \t User Password \t User Balance \t User Address \t User Phone");
            string user = UserFactory.showUserDetails(uid, usr);
            Console.WriteLine("\n"+user);
        }

        private static void showRestaurantDetails()
        {
            Console.WriteLine("\n Vendor ID \t Vendor Name \t Vendor Phone \t Vendor Email \t Vendor Address");
            Console.WriteLine("\n"+ vendor.vendorId + "\t\t" + vendor.vendorName + "\t\t" + vendor.vendorPhone + "\t" + vendor.vendorEmail + "\t" + vendor.vendorAddress);
        }

        private static void orderFood()
        {
            showFoodMenu();
            Console.WriteLine("\n Enter the Food ID you want to order...");
            int fid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter the  Food Quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());
            bool res = OrdersFactory.FoodOrder(uid, usr, fid, food, vendor.vendorId, quantity, orders);
            if (res)
            {
                Console.WriteLine("Successfully ordered Food");
            }
            else
            {
                Console.WriteLine("Food Order Unsuccessful. Try again.");
            }
        }

        private static void showOrderDetails()
        {
            Orders[] ord = OrdersFactory.showOrders(uid, usr, orders);
            Console.WriteLine("\n ***************************** Your Order Details *****************************************");
            Console.WriteLine("\n order Id    vendor Id    user Id    Date & Time \t\t  Quantity   Total Amount   Status");
            foreach (var o in ord)
            {
                Console.WriteLine("\n" + o.ToString());
            }
        }

        private static void cancelOrder()
        {
            Orders[] ord = OrdersFactory.cancellableOrders(uid, usr, orders);
            Console.WriteLine("\n ***************************** Your Order Details *****************************************");
            Console.WriteLine("\n order Id    vendor Id    user Id    Date & Time \t\t  Quantity   Total Amount   Status");
            foreach (var o in ord)
            {
                Console.WriteLine("\n" + o.ToString());
            }
            Console.WriteLine("\n Enter The Order ID you want to cancel... Money will not be refunded..");
            int oid = Convert.ToInt32(Console.ReadLine());
            bool res = false;
            try
            {
                res = OrdersFactory.cancelUserOrder(uid, usr, oid, orders);
            }
            catch (UserDefinedException e)
            {
                Console.WriteLine(e.Message);
            }
            if (res)
            {
                Console.WriteLine("Order has been cancelled successfully..");
            }
            else
            {
                //Console.WriteLine("Unable to cancel Order. Please check your inputs..");
            }
        }
    }
}
