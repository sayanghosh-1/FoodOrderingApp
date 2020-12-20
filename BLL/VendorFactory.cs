using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingApp.factory
{
    class VendorFactory
    {
        public static bool VendorLogin(int vendorId, string vendorPassword)
        {
            bool flag = false;
            bool verify = DBLL.VendorDAO.vendorLogin(vendorId, vendorPassword);
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
        public static bool vendorDeatils()
        {
            //return vendor.ToString();
            bool res = DBLL.VendorDAO.vendorDetails();
            if (res)
            {
                return true;
            }
            return false;
        }

    }
}