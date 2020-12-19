using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingApp.utilities
{
    class FileHandling
    {
        public static bool Writer(Orders[] obj)
        {
            bool isSuccess = false;
            var filePath = @"D:\orders.txt";
            //var filePath = @"C:\Users\ghosh\Desktop\FoodInvoices\orders.txt";
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("--------------------------------------------------------------------------------------------");
                    sw.WriteLine("                               THANKYOU FOR ORDERING                                        ");
                    sw.WriteLine("--------------------------------------------------------------------------------------------");
                    sw.WriteLine("                               ;) ( ;                                                       ");
                    sw.WriteLine("                               :----:     o8Oo./                                            ");
                    sw.WriteLine("    FOOD ORDERING APP         C|====| ._o8o8o8Oo_.             BY SAYAN & ABHI              ");
                    sw.WriteLine("                               |    |  `========/                                           ");
                    sw.WriteLine("                               `----'   `------'                                            ");
                    sw.WriteLine("--------------------------------------------------------------------------------------------");
                    sw.WriteLine("order Id      vendor Id      user Id         Date & Time          Quantity      Total Amount");
                    for (int s = 0; s < obj.Length; s++)
                    {
                        sw.WriteLine("-----------------------------------------------------------------------------------------------------------\n"
                                   + "    " + obj[s].orderId + "\t" + "\t" + obj[s].vendorId + "\t" + "\t" + obj[s].userId + "\t"
                                   + obj[s].orderDate + "\t" + "     " + obj[s].orderQuantity + "\t" + "\t" + "   " + obj[s].orderAmount);
                    }
                    isSuccess = true;
                    return isSuccess;
                }
            }
        }
        public static bool UserWriter(int uid, Orders[] obj, List<User> usr)
        {
            bool isSuccess = false;
            var filePath = @"D:\" + DateTime.Now.ToString("hh_mm_tt_") + uid + "_invoice.txt";
            //var filePath = @"C:\Users\ghosh\Desktop\FoodInvoices\" + DateTime.Now.ToString("hh_mm_tt_") + uid +"invoice.txt";
            using (FileStream fs = new FileStream(filePath, FileMode.CreateNew))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("--------------------------------------------------------------------------------------------");
                    sw.WriteLine("                               THANKYOU FOR ORDERING                                        ");
                    sw.WriteLine("--------------------------------------------------------------------------------------------");
                    sw.WriteLine("                               ;) ( ;                                                       ");
                    sw.WriteLine("                               :----:     o8Oo./                                            ");
                    sw.WriteLine("    FOOD ORDERING APP         C|====| ._o8o8o8Oo_.             BY SAYAN & ABHI              ");
                    sw.WriteLine("                               |    |  `========/                                           ");
                    sw.WriteLine("                               `----'   `------'                                            ");
                    sw.WriteLine("--------------------------------------------------------------------------------------------");
                    sw.WriteLine("order Id      vendor Id      user Id         Date & Time          Quantity      Total Amount");
                    for (int s = obj.Length-1; s < obj.Length; s++)
                    {
                        sw.WriteLine("-----------------------------------------------------------------------------------------------------------\n"
                                   + "    " + obj[s].orderId + "\t" + "\t" + obj[s].vendorId + "\t" + "\t" + obj[s].userId + "\t"
                                   + obj[s].orderDate + "\t" + "     " + obj[s].orderQuantity + "\t" + "\t" + "   " + obj[s].orderAmount);
                    }
                    isSuccess = true;
                    return isSuccess;
                }
            }
        }
        public static bool Readdata(Orders[] obj)
        {
            bool isSuccess = false;
            var filePath = @"D:\invoice.txt";

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] col = line.Split(' ');
                Console.WriteLine("{0}{1}{2}{3}", col[0], col[1], col[2], col[3]);

            }
            isSuccess = true;
            return isSuccess;
        }
    }
}
