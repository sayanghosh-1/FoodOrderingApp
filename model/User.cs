/*author : Sayan Ghosh - 53373
 This is a Food ordering app that allows user to log in with their credentials and order food.
 User can also cancel the order after ordering.
*/
using FoodOrderingApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class is for storing User's personal data

namespace FoodOrderingApp
{
    class User
    {
        private int _userId;
        private string _userName;
        private string _userPassword;
        private double _userBalance;
        private string _userAddress;
        private string _userNumber;
        private string _userEmail;

        //Default Constructor
        public User()
        {

        }

        //Parameterized Constructor for object creation with values.
        public User(int userId, string userName, string userPassword, double userBalance, string userAddress, string userNumber, string userEmail)
        {
            this._userId = userId;
            this._userName = userName;
            this._userPassword = userPassword;
            this._userBalance = userBalance;
            this._userAddress = userAddress;
            this._userNumber = userNumber;
            this._userEmail = userEmail;
        }

        //ToString Method Overridden from Object class
        public override string ToString()
        {
            return string.Format("   " + this._userId + "\t" + "\t"+ this._userName.FirstWordCapitalize() + "\t" + "\t" + this._userPassword+ "\t" + "\t" + this._userBalance + "\t" + "\t" + this._userAddress + "\t" + "\t" + this._userNumber);
        }

        //Equals Method Overridden from Object class
        public override bool Equals(object obj)
        {
            if(obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                User u = (User)obj;
                return (_userId == u._userId) && (_userName == u._userName) && (_userPassword == u._userPassword)
                    && (_userBalance == u._userBalance) && (_userAddress == u._userAddress)
                    && (_userNumber == u._userNumber)
                    && (_userEmail == u._userEmail);
            }
        }

        //HashCode Method Overridden from Object class
        public override int GetHashCode()
        {
            User u1 = new User(101, "Sayan", "sayan123", 10000, "KGP", "9768373882", "ghoshsayan52@gmail.com");
            User u2 = u1;
            if (u1 == u2)
            {
                return 1;
            }
            return 0;
        }

        //Accessor and Mutators for the class variables

        //UserId accessor and Mutator
        public int UserId
        {
            get
            {
                return this._userId;
            }
            set
            {
                this._userId = value;

            }
        }

        //UserName accessor and Mutator
        public string UserName
        {
            get
            {
                return this._userName;
            }
            set
            {
                this._userName = value;

            }
        }

        //UserPassword accessor and Mutator
        public string UserPassword
        {
            get
            {
                return this._userPassword;
            }
            set
            {
                this._userPassword = value;

            }
        }

        //UserBalance accessor and Mutator
        public double UserBalance
        {
            get
            {
                return this._userBalance;
            }
            set
            {
                this._userBalance = value;

            }
        }

        //UserAddress accessor and Mutator
        public string UserAddress
        {
            get
            {
                return this._userAddress;
            }
            set
            {
                this._userAddress = value;

            }
        }

        //UserNumber accessor and Mutator
        public string UserNumber
        {
            get
            {
                return this._userNumber;
            }
            set
            {
                this._userNumber = value;

            }
        }
        public string UserEmail
        {
            get
            {
                return this._userEmail;
            }
            set
            {
                this._userEmail = value;

            }
        }

    }
}
