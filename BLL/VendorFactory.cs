﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingApp.factory
{
    class VendorFactory
    {
        static Vendor vendor = new Vendor(1001, "Zomato", "zomato123", "976763882", "zomato@gmail.com", "kharaghpur");
        public static bool VendorLogin(int vendorId, string vendorPassword, Vendor v)
        {
            if (v.vendorId == vendorId)
            {
                if (v.vendorPassword == vendorPassword)
                {
                    Console.WriteLine("Successfuly Logged In..!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Incorrect Password. Try again..");
                    return false;
                }
            }
            Console.WriteLine("Incorrect Vendor ID. Try again...");
            return false;
        }
        public static string vendorDetails()
        {
            return vendor.ToString();
        }

    }
}