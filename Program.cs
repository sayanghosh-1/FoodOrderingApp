using FoodOrderingApp.factory;
using FoodOrderingApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;


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
            usr.Add(new User(101, "sayan", "sayan123", 13000, "KGP", "976763882", "ghoshsayan52@gmail.com"));
            usr.Add(new User(102, "abhi", "abhi123", 12000, "KOL", "976763882", "abhiburman20@gmail.com"));
            usr.Add(new User(103, "disha", "disha123", 9000, "DEL", "976373882", "ghoshsayan52@gmail.com"));
            usr.Add(new User(104, "ruchi", "ruchi123", 11000, "NGP", "9768373882", "abhiburman20@gmail.com"));
            usr.Add(new User(105, "sarayu", "sarayu123", 8000, "BSR", "9878373882", "ghoshsayan52@gmail.com"));

            orders.Add(new Orders(1001, 101, new DateTime(2020, 12, 08), 5, 1200, "PENDING"));
            orders.Add(new Orders(1001, 102, new DateTime(2020, 12, 08), 2, 600, "PENDING"));
            orders.Add(new Orders(1001, 103, new DateTime(2020, 12, 08), 4, 1000, "PENDING"));
            orders.Add(new Orders(1001, 104, new DateTime(2020, 12, 08), 1, 120, "PENDING"));

            food.Add(new Food(1, "Chicken Tikka", 120, 5));
            food.Add(new Food(2, "Mutton  Tikka", 120, 3));
            food.Add(new Food(3, "Panner  Tikka", 120, 2));
            food.Add(new Food(4, "Aaloo   Tikka", 120, 6));

            Console.WriteLine("************************************************************************************************************************\n"
            + "                                                                                                       \n"
            + "        ;) ( ;                       ██     ██ ███████ ██       ██████  ██████  ███    ███ ███████     \n"
            + "        :----:     o8Oo./            ██     ██ ██      ██      ██      ██    ██ ████  ████ ██          \n"
            + "       C|====| ._o8o8o8Oo_.          ██  █  ██ █████   ██      ██      ██    ██ ██ ████ ██ █████       \n"
            + "        |    |  `========/           ██ ███ ██ ██      ██      ██      ██    ██ ██  ██  ██ ██          \n"
            + "        `----'   `------'             ███ ███  ███████ ███████  ██████  ██████  ██      ██ ███████     \n"
            + "                                                                                                                                        "); 
            Console.WriteLine("************************************************************************************************************************");

            // Home
            Program mainObj = new Program();
            mainObj.mainLoginDisplay();
            Console.ReadLine();
        }
        
        private void mainLoginDisplay()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("                              Please Login Or Signup                                          ");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("3. Exit");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            mainLoginChoice();
        }
        private void mainLoginChoice()
        {
            try
            {
                Console.WriteLine("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Login();
                        break;
                    case 2:
                        SignUp();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Choose an option between 1 to 7");
                        Console.WriteLine("---------------------------------");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("\n Enter a valid value");
            }
            Console.WriteLine("\n");
            mainLoginDisplay();
        }
        private void Login()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("                     Are you an User or a Vendor ? Enter u/v...");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            char identity = Convert.ToChar(Console.ReadLine());
            if (identity == 'u' || identity == 'U')
            {
                Console.WriteLine("Enter your User Id");
                Console.WriteLine("--------------------------");
                uid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------------");
                Console.WriteLine("Enter your Password");
                Console.WriteLine("--------------------------");
                string password = Console.ReadLine();
                bool res = UserFactory.UserLogin(uid, password, usr);
                if (res == true)
                {
                    mainUserDisplay();
                }
                else
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Not Successful Login");
                    Console.WriteLine("--------------------------");
                }
            }
            else if (identity == 'v' || identity == 'V')
            {
                Console.WriteLine("Enter your Vendor Id");
                Console.WriteLine("--------------------------");
                int vendorId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------------");
                Console.WriteLine("Enter your Password");
                Console.WriteLine("--------------------------");
                string vendorPassword = Console.ReadLine();
                bool res = VendorFactory.VendorLogin(vendorId, vendorPassword, vendor);
                if (res == true)
                {
                    mainVendorDisplay();
                }
                else
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Not Successful Login");
                    Console.WriteLine("--------------------------");
                }
            }
            else
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Invalid Input.. Enter either u/v ...");
                Console.WriteLine("---------------------------------------");
            }
        }
        private void SignUp()
        {
            Console.WriteLine("                               CREATE A NEW ACCOUNT                                           ");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Enter your User Id");
            Console.WriteLine("--------------------------");
            int userId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------");
            Console.WriteLine("Enter your Name");
            Console.WriteLine("--------------------------");
            string userName = Console.ReadLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Enter your Password");
            Console.WriteLine("--------------------------");
            string userPassword = Console.ReadLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Enter Default Balance");
            Console.WriteLine("--------------------------");
            double userBal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------");
            Console.WriteLine("Enter your Address");
            Console.WriteLine("--------------------------");
            string userAddress = Console.ReadLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Enter your Phone Number");
            Console.WriteLine("--------------------------");
            string userPhone = Console.ReadLine();
            Console.WriteLine("Enter your Email");
            Console.WriteLine("--------------------------");
            string userEmail = Console.ReadLine();
            string res = UserFactory.UserSignup(userId, userName, userPassword, userBal, userAddress, userPhone, userEmail, usr);
            Console.WriteLine(res);
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
            Console.WriteLine("----------------------------------------------------------------------------------------------");
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
                        showFoodDetails();
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
                        showUserOrderDetails();
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
        
        private void mainVendorDisplay()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Welcome to Vendor Page. Please Enter your Choice from the list below.");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Show Vendor Details");
            Console.WriteLine("2. Show Food Details");
            Console.WriteLine("3. Show Order Details");
            Console.WriteLine("4. Add Food Item");
            Console.WriteLine("5. Update Food Cost");
            Console.WriteLine("6. Update Food Stock");
            Console.WriteLine("7. Manage Orders");
            Console.WriteLine("8. Exit");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            mainVendorChoice();
        }

        private void mainVendorChoice()
        {
            try
            {
                Console.WriteLine("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        showVendorDetails();
                        break;
                    case 2:
                        showFoodDetails();
                        break;
                    case 3:
                        showOrderDetails();
                        break;
                    case 4:
                        addFoodItem();
                        break;
                    case 5:
                        updateFoodCost();
                        break;
                    case 6:
                        updateFoodStock();
                        break;
                    case 7:
                        manageOrders();
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
            mainVendorDisplay();
        }
        public void showVendorDetails()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Welcome " + vendor.vendorName + " !!!");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(VendorFactory.vendorDeatils());
            Console.WriteLine("------------------------------------------");
            Console.ReadLine();
        }
        public void showOrderDetails()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                         ORDERS HISTORY DETAILS                                          ");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Orders[] orArr = OrdersFactory.orderDeatils(orders);
            Console.WriteLine("order Id      vendor Id      user Id         Date & Time          Quantity      Total Amount      Status");
            foreach (var o in orArr)
            {
                Console.WriteLine(o.ToString());
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            fileHandling();
            Console.ReadLine();
        }
        public void showFoodDetails()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("                 FOOD DETAILS                          ");
            Console.WriteLine("-------------------------------------------------------");
            Food[] foodArr = FoodFactory.showFood(food);
            Console.WriteLine("Food Id      Food Name      Food Cost        Food Stock");
            foreach (var f in foodArr)
            {
                Console.WriteLine(f.ToString());
            }
            Console.WriteLine("---------------------------------------------------------");
            Console.ReadLine();
        }
        public void addFoodItem()
        {
            showFoodDetails();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("                 ADD FOOD DETAILS                      ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enter Your Food ID ");
            int foodId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------");
            Console.WriteLine("Enter Your Food Name ");
            string foodName = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("Enter Your Food Cost ");
            double foodCost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------");
            Console.WriteLine("Enter Default Food Stock ");
            int foodStock = Convert.ToInt32(Console.ReadLine());
            string msg = FoodFactory.addFood(foodId, foodName, foodCost, foodStock, food);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(msg);
            Console.WriteLine("---------------------------------------------------------");
            Console.ReadLine();
        }
        public void updateFoodCost()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("                 Update FOOD DETAILS                   ");
            Console.WriteLine("-------------------------------------------------------");
            showFoodDetails();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enter Your Food ID ");
            int foodId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------");
            Console.WriteLine("Enter Your Food Cost ");
            double foodCost = Convert.ToInt32(Console.ReadLine());
            string msg = FoodFactory.updateCost(foodId, foodCost, food);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(msg);
            Console.WriteLine("---------------------------------------------------------");
            Console.ReadLine();
        }
        public void updateFoodStock()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("                 Update FOOD DETAILS                   ");
            Console.WriteLine("-------------------------------------------------------");
            showFoodDetails();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enter Your Food ID ");
            int foodId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------");
            Console.WriteLine("Update Your Food Stock ");
            int foodStock = Convert.ToInt32(Console.ReadLine());
            string msg = FoodFactory.updateStock(foodId, foodStock, food);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(msg);
            Console.WriteLine("---------------------------------------------------------");
            Console.ReadLine();
        }
        public void manageOrders()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("                 Manage Your Orders                    ");
            Console.WriteLine("-------------------------------------------------------");
            showOrderDetails();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enter Your Order ID ");
            int orderId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------");
            Console.WriteLine("Enter 'Y' to Accept or 'N' to Cancel Order");
            string orderStatus = Console.ReadLine();
            string msg = OrdersFactory.updateStatus(orderId, orderStatus, orders);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(msg);
            Console.WriteLine("---------------------------------------------------------");
            Console.ReadLine();
        }
        
        // --------------------------------------------------------------------------------------------------------------
        //                                         USER TASKS
        //*************************************************************************************************************
        private static void AddMoneyToWallet()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enter Amount to be Added...");
            Console.WriteLine("-------------------------------------------------------");
            double amount = Convert.ToDouble(Console.ReadLine());
            double newAmount = UserFactory.AddMoney(uid, amount, usr);
            if (newAmount == 0)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Transaction Unsuccessful. Please Check the inputs.");
                Console.WriteLine("-------------------------------------------------------");
            } 
            else
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Transaction Successful..");
                Console.WriteLine("New Wallet Balance = Rs. " + newAmount);
                Console.WriteLine("-------------------------------------------------------");
            }
            Console.ReadLine();
        }

        private static void showPersonalDetails()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                         ACCOUNT DETAILS                                          ");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n User ID       User Name       User Password         User Balance   User Address     User Phone");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            string user = UserFactory.showUserDetails(uid, usr);
            Console.WriteLine("\n"+user);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.ReadLine();
        }

        private static void showRestaurantDetails()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                         AVAILABLE RESTAURANTS                                          ");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n Vendor ID \t Vendor Name \t Vendor Phone \t Vendor Email \t     Vendor Address");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("\n"+ "   " + vendor.vendorId + "\t\t  " + vendor.vendorName + "\t  " + vendor.vendorPhone + "\t" + vendor.vendorEmail + "\t" + vendor.vendorAddress);
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.ReadLine();
        }

        private static void orderFood()
        {
            Program obj = new Program();
            obj.showFoodDetails();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enter the Food ID you want to order...");
            Console.WriteLine("-------------------------------------------------------");
            int fid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enter the  Food Quantity");
            Console.WriteLine("-------------------------------------------------------");
            int quantity = Convert.ToInt32(Console.ReadLine());
            bool res = OrdersFactory.FoodOrder(uid, usr, fid, food, vendor.vendorId, quantity, orders);
            if (res)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("             Successfully ordered Food");
                Console.WriteLine("-------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("        Food Order Unsuccessful. Try again.");
                Console.WriteLine("-------------------------------------------------------");
            }
            // Faile handling
            Program p = new Program();
            p.UserfileHandling();
            // mail
            string mailTo = UserFactory.getMail(uid, usr);
            Mail(mailTo);
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("     An Invoice of your Order is Mailed to " + mailTo);
            Console.WriteLine("---------------------------------------------------------------------");
            Console.ReadLine();
        }
        public void showUserOrderDetails()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                         ORDERS HISTORY DETAILS                                          ");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Orders[] orArr = OrdersFactory.showOrders(uid, usr, orders);
            Console.WriteLine("order Id      vendor Id      user Id         Date & Time          Quantity      Total Amount      Status");
            foreach (var o in orArr)
            {
                Console.WriteLine(o.ToString());
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            fileHandling();
            Console.ReadLine();
        }
        private static void cancelOrder()
        {
            Orders[] ord = OrdersFactory.cancellableOrders(uid, usr, orders);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                         ORDERS HISTORY DETAILS                                          ");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("order Id      vendor Id      user Id         Date & Time          Quantity      Total Amount      Status");
            foreach (var o in ord)
            {
                Console.WriteLine("\n" + o.ToString());
            }
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Enter The Order ID you want to cancel... Money will not be refunded..");
            Console.WriteLine("----------------------------------------------------------------------------");
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
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Order has been cancelled successfully..");
                Console.WriteLine("-------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Unable to cancel Order. Please check your inputs..");
                Console.WriteLine("-------------------------------------------------------");
            }
            Console.ReadLine();
        }
        //--------------------------------------------------------------------------------------------------------------
        //                                          Utilities
        //**************************************************************************************************************
        public void fileHandling()
        {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("If you need an Copy of your order type 'Y' or Type 'N' to proceed !");
            Console.WriteLine("--------------------------------------------------------------------");
            char c = Convert.ToChar(Console.ReadLine());
            if (c == 'y')
            {
                bool flag = utilities.FileHandling.Writer(orders.ToArray());
                if (flag)
                {
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("                   SUCCESS !!!                         ");
                    Console.WriteLine("-------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("                   Thank You !!!                       ");
                Console.WriteLine("-------------------------------------------------------");
            }
        }
        public void UserfileHandling()
        {
            Orders[] orArr = OrdersFactory.showOrders(uid, usr, orders);
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("If you need an Copy of your order type 'Y' or Type 'N' to proceed !");
            Console.WriteLine("--------------------------------------------------------------------");
            char c = Convert.ToChar(Console.ReadLine());
            if (c == 'y')
            {
                bool flag = utilities.FileHandling.UserWriter(uid, orArr, usr);
                if (flag)
                {
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("                   SUCCESS !!!                         ");
                    Console.WriteLine("-------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("                   Thank You !!!                       ");
                Console.WriteLine("-------------------------------------------------------");
            }
        }
        private static void Mail(string mailTo)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("foodorderingapp2020@gmail.com");
                mail.To.Add(mailTo);
                mail.Subject = "PROJECT .NET : Order on FoodOrderingApp";
                mail.Body = "<h1>Thankyou for Ordering !</h1><br>" +
                    "<h4>Your Invoice is attached with this mail<h4>";
                mail.IsBodyHtml = true;
                //mail.Attachments.Add(new Attachment("D:\\" + uid + "invoice.txt"));
                mail.Attachments.Add(new Attachment("C:\\Users\\ghosh\\Desktop\\FoodInvoices\\" + uid+"invoice.txt"));

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("foodorderingapp2020@gmail.com", "Food@2020");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
    }
}
