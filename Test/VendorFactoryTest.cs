using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FoodOrderingApp.Test
{
    [TestFixture]
    class VendorFactoryTest
    {
        [Test]
        public void When_VendorWill_Login_expects_true()
        {
            // arrange
            Vendor v = new Vendor(1001, "Zomato", "zomato123", "976763882", "zomato@gmail.com", "kharaghpur");
            // act
            bool actualValue = factory.VendorFactory.VendorLogin(1001,"zomato123",v);
            // assert
            Assert.AreEqual(true, actualValue);
        }
    }
}
