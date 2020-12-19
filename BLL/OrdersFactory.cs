using FoodOrderingApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingApp.factory
{
    class OrdersFactory
    {
        static List<Orders> orders = new List<Orders>();

        public static bool FoodOrder(int uid, List<User> user, int fid, List<Food> food, int vid, int quantity, List<Orders> orders)
        {
            foreach(var f in food)
            {
                if(f.FoodId == fid && f.FoodStock > 0 && quantity <= f.FoodStock)
                {
                    foreach(var u in user)
                    {
                        if(u.UserId == uid)
                        {
                            if (u.UserBalance >= f.FoodCost)
                            {
                                double amount = f.FoodCost * quantity;
                                Console.WriteLine("\n Total Amount to be paid = Rs. " + amount);
                                orders.Add(new Orders(vid, uid, DateTime.Now, quantity, amount, "PENDING"));
                                u.UserBalance = u.UserBalance - amount;
                                Console.WriteLine("\n Remaining Wallet Balance = Rs. " + u.UserBalance);
                                f.FoodStock = f.FoodStock - quantity;
                                return true;
                            }
                            Console.WriteLine("Insufficient Wallet Balance...");
                            return false;
                        }
                    }
                    return false;
                }
            }
            Console.WriteLine("Unable to continue with the order..");
            return false;
        }

        public static Orders[] showOrders(int uid, List<User> user, List<Orders> orders)
        {
            List<Orders> ord = new List<Orders>();
            foreach (var u in user)
            {
                if (u.UserId == uid)
                {
                    foreach(var o in orders)
                    {
                        if(o.userId == uid)
                        {
                            ord.Add(o);
                        }
                    }
                }
            }
            return ord.ToArray();
        }

        public static Orders[] cancellableOrders(int uid, List<User> user, List<Orders> orders)
        {
            List<Orders> ord = new List<Orders>();
            foreach (var u in user)
            {
                if (u.UserId == uid)
                {
                    foreach (var o in orders)
                    {
                        if (o.orderStatus == "PENDING" || o.orderStatus == "APPROVED")
                        {
                            ord.Add(o);
                        }
                    }
                }
            }
            return ord.ToArray();
        }
        public static bool cancelUserOrder(int uid, List<User> user, int oid, List<Orders> orders)
        {

            Orders[] ord = cancellableOrders(uid, user, orders);
            foreach(var u in user)
            {
                if(u.UserId == uid)
                {
                    foreach(var o in ord)
                    {
                        if(o.orderId == oid)
                        {
                            orders.Remove(o);
                            return true;
                        }
                    }
                    throw new UserDefinedException("Unable to cancel Order. Order ID is not correct..");
                }
            }
            throw new UserDefinedException("Unable to cancel Order. User ID is not correct..");
        }
        public static Orders[] orderDeatils(List<Orders> orders)
        {
            return orders.ToArray();
        }
        public static string updateStatus(int orderId, string orderStatus, List<Orders> orders)
        {
            string msg = " ";
            if (orderStatus == "Y" || orderStatus == "y")
            {
                foreach (var o in orders)
                {
                    if (o.orderId == orderId)
                    {
                        o.orderStatus = "APPROVED";
                        msg = "Order Id " + orderId + " has been Approved !";
                    }
                    else
                    {
                        msg = "Please enter a valid Order Id";
                    }
                }
            }
            else if (orderStatus == "n" || orderStatus == "N")
            {
                foreach (var o in orders)
                {
                    if (o.orderId == orderId)
                    {
                        o.orderStatus = "CANCELLED";
                        msg = "Order Id " + orderId + " has been Cancelled !";
                    }
                    else
                    {
                        msg = "Please enter a valid Order Id";
                    }
                }
            }
            else
            {
                msg = "Please Enter Y or N !";
            }
            return msg;

        }
    }
}
