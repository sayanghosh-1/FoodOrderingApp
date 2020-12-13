using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FoodOrderingApp.Test
{
    [TestFixture]
    class UserFactoryTest
    {
        [Test]
        public void When_UserWill_Login_expects_true()
        {
            // arrange
            List<User> usr = new List<User>();
            usr.Add(new User(101, "sayan", "sayan123", 13000, "KGP", "976763882", "ghoshsayan52@gmail.com"));
            // act
            bool actualValue = UserFactory.UserLogin(101, "sayan123", usr);
            // assert
            Assert.AreEqual(true, actualValue);
        }

        [Test]
        public void When_UserWillClick_ShowUserDetails()
        {
            List<User> usr = new List<User>();
            usr.Add(new User(101, "sayan", "sayan123", 13000, "KGP", "976763882", "ghoshsayan52@gmail.com"));
            string res = usr.ElementAt(0).ToString();
            string actualValue = UserFactory.showUserDetails(101, usr);
            Assert.AreEqual(res, actualValue);
        }
        [Test]
        public void Get_User_Email()
        {
            List<User> usr = new List<User>();
            usr.Add(new User(101, "sayan", "sayan123", 13000, "KGP", "976763882", "ghoshsayan52@gmail.com"));
            string email = usr.ElementAt(0).UserEmail;
            string actualValue = UserFactory.getMail(101, usr);
            Assert.AreEqual(email, actualValue);
        }

        [Test]
        public void Add_Money_to_User_Wallet()
        {
            List<User> usr = new List<User>();
            usr.Add(new User(101, "sayan", "sayan123", 13000, "KGP", "976763882", "ghoshsayan52@gmail.com"));
            double actualValue = UserFactory.AddMoney(101, 500, usr);
            Assert.AreEqual(13500, actualValue);
        }

        [Test]
        public void SignUp_A_New_User()
        {
            List<User> usr = new List<User>();
            usr.Add(new User(101, "sayan", "sayan123", 13000, "KGP", "976763882", "ghoshsayan52@gmail.com"));
            string actualValue = UserFactory.UserSignup(106, "neha", "neha123", 5000, "JKD", "9866666986", "neha@gmail.com", usr);
            string res = "ThankYou ! neha, You have Successfully Created a New Account !";
            Assert.AreEqual(res, actualValue);
        }
    }
}
