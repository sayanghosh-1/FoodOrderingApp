/**
 * @author : Abhijeet Burman - 53247.
 */
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingApp
{
    /**
     * Vendor class used to display Vendor information.
     */
    class Vendor
    {
        private int _vendorId;
        private string _vendorName;
        private string _vendorPassword;
        private string _vendorPhone;
        private string _vendorEmail;
        private string _vendorAddress;

        /**
         * Default Constructor.
         */
        public Vendor()
        {

        }
        /**
         * Parameterised Constructor to initialize used to get details through constructor.
         */
        public Vendor(int vendorId, string vendorName, string vendorPassword, string vendorPhone, string vendorEmail, string vendorAddress)
        {
            this._vendorId = vendorId;
            this._vendorName = vendorName;
            this._vendorPassword = vendorPassword;
            this._vendorPhone = vendorPhone;
            this._vendorEmail = vendorEmail;
            this._vendorAddress = vendorAddress;
        }

        /**
         * ToString() returns a string which represents the current stack object.
         */
        public override string ToString()
        {
            return string.Format("\n Vendor Id : {0} \n Vendor Name : {1} \n Vendor Password : {2} \n Vendor Phone : {3} \n Vendor Email : {4} \n Vendor Address : {5}",
                                  this._vendorId, this._vendorName, this._vendorPassword, this._vendorPhone, this._vendorEmail, this.vendorAddress);
        }

        /**
         * Equals() is used to compare the content of a string.
         */
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Vendor v = (Vendor)obj;
                return (_vendorId == v._vendorId)
                        && (_vendorName == v._vendorName)
                        && (_vendorPassword == v._vendorPassword)
                        && (_vendorPhone == v._vendorPhone)
                        && (_vendorEmail == v._vendorEmail)
                        && (_vendorAddress == v._vendorAddress);
            }
        }

        /**
         * GetHashCode() return an int value for the object address.
         */
        public override int GetHashCode()
        {
            Vendor v1 = new Vendor(100, "Abhi", "Abhi1234", "8280179400", "abhi20@gmail.com", "Chennai");
            Vendor v2 = v1;
            if (v1 == v2)
            {
                return 1;
            }
            return 0;
        }
        /**
         * Accessor and Mutator.
         */
        public int vendorId
        {
            get
            {
                return this._vendorId;
            }
            set
            {
                this._vendorId = value;
            }
        }
        public string vendorName
        {
            get
            {
                return this._vendorName;
            }
            set
            {
                this._vendorName = value;
            }
        }
        public string vendorPassword
        {
            get
            {
                return this._vendorPassword;
            }
            set
            {
                this._vendorPassword = value;
            }
        }
        public string vendorPhone
        {
            get
            {
                return this._vendorPhone;
            }
            set
            {
                this._vendorPhone = value;
            }
        }
        public string vendorEmail
        {
            get
            {
                return this._vendorEmail;
            }
            set
            {
                this._vendorEmail = value;
            }
        }
        public string vendorAddress
        {
            get
            {
                return this._vendorAddress;
            }
            set
            {
                this._vendorAddress = value;
            }
        }
    }
}
