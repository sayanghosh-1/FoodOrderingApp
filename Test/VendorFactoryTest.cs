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
        // arrange
        static Vendor v = new Vendor(1001, "Zomato", "zomato123", "976763882", "zomato@gmail.com", "kharaghpur");
        [Test]
        public void When_VendorWill_Login_expects_true()
        {
            // act
            bool actualValue = factory.VendorFactory.VendorLogin(1001,"zomato123",v);
            // assert
            //Assert.AreEqual(true, actualValue);
            Assert.That(true, Is.EqualTo(actualValue));
        }
        [Test]
        public void vendorDeatils()
        {
            // act
            string actualvalue = factory.VendorFactory.vendorDeatils();
            // assert
            //Assert.AreEqual(v.ToString(), actualvalue);
            Assert.That(v.ToString(), Is.EqualTo(actualvalue));
        }
    }
}
