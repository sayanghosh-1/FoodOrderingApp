using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;

namespace FoodOrderingApp.Test
{
    [TestFixture]
    class FileHandlingTest
    {
        static List<Orders> orders = new List<Orders>();
        static List<User> usr = new List<User>();
        [Test]
        public void Writer()
        {
            // act
            bool actualvalue = utilities.FileHandling.Writer(orders.ToArray());
            // assert
            Assert.AreEqual(true, actualvalue);
        }
        //[Test]
        //public void UserWriter()
        //{
        //    //arrange
        //    orders.Add(new Orders(1001, 101, new DateTime(2020, 12, 08), 5, 1200, "PENDING"));
        //    usr.Add(new User(101, "sayan", "sayan123", 13000, "KGP", "976763882", "ghoshsayan52@gmail.com"));
        //    // act
        //    bool actualvalue = utilities.FileHandling.UserWriter(101, orders.ToArray(), usr);
        //    // assert
        //    Assert.AreEqual(true, actualvalue);
        //}
    }
}
