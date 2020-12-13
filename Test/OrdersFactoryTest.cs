using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;

namespace FoodOrderingApp.Test
{
    [TestFixture]
    class OrdersFactoryTest
    {
        static List<User> usr = new List<User>();
        static List<Food> food = new List<Food>();
        static List<Orders> orders = new List<Orders>();
        [Test]
        public void When_UserWill_OrderFood_expects_true()
        {
            // arrange
            usr.Add(new User(102, "abhi", "abhi123", 12000, "KOL", "976763882", "abhiburman20@gmail.com"));
            orders.Add(new Orders(1001, 102, new DateTime(2020, 12, 08), 2, 600, "PENDING"));
            food.Add(new Food(2, "Mutton  Tikka", 120, 3));
            // act
            bool actualValue = factory.OrdersFactory.FoodOrder(102, usr, 2, food, 1001, 2, orders);
            // assert
            Assert.AreEqual(true, actualValue);
        }

        [Test]
        public void Show_Orders()
        {
            // act
            Orders[] actualvalue = factory.OrdersFactory.showOrders(102, usr, orders);
            // assert
            Assert.AreEqual(orders, actualvalue);
        }
        [Test]
        public void cancellableOrders()
        {
            // act
            Orders[] actualvalue = factory.OrdersFactory.cancellableOrders(102, usr, orders);
            // assert
            Assert.AreEqual(orders, actualvalue);
        }
        [Test]
        public void cancelUserOrder()
        {
            //arrange
            orders.Add(new Orders(1001, 101, new DateTime(2020, 12, 08), 5, 1200, "PENDING"));
            usr.Add(new User(101, "sayan", "sayan123", 13000, "KGP", "976763882", "ghoshsayan52@gmail.com"));
            // act
            bool actualvalue = factory.OrdersFactory.cancelUserOrder(101, usr, orders.ElementAt(0).orderId, orders);
            // assert
            Assert.AreEqual(true, actualvalue);
        }
        [Test]
        public void orderDeatils()
        {
            // act
            Orders[] actualvalue = factory.OrdersFactory.orderDeatils(orders);
            // assert
            Assert.AreEqual(orders, actualvalue);
        }
        [Test]
        public void updateStatus()
        {
            //act
            String actualvalue = factory.OrdersFactory.updateStatus(1, "ACCEPTED", orders);
            // assert
            Assert.AreEqual("Please Enter Y or N !", actualvalue);
        }
    }
}
