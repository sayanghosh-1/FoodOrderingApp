/**
 * @author : Abhijeet Burman - 53247.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingApp
{
    /**
     *Orders class used to display Order information.
     */
    class Orders
    {
        private int _orderId;
        private int _vendorId;
        private int _userId;
        private DateTime _orderDate;
        private int _orderQuantity;
        private double _orderAmount;
        private string _orderStatus;
        static int count = 0;

        /**
         * Default Constructor.
         */
        public Orders()
        {

        }
        /**
         * Parameterised Constructor to initialize used to get details through constructor.
         */
        public Orders(int vendorId, int userId, DateTime orderDate, int orderQuantity, double orderAmount, string orderStatus)
        {
            count++;
            this._orderId = this._orderId + count;
            this._vendorId = vendorId;
            this._userId = userId;
            this._orderDate = orderDate;
            this._orderQuantity = orderQuantity;
            this._orderAmount = orderAmount;
            this._orderStatus = orderStatus;
        }

        /**
         * ToString() returns a string which represents the current stack object.
         */
        public override string ToString()
        {
            return string.Format("-----------------------------------------------------------------------------------------------------------\n"
                                   + "    " + this._orderId + "\t" + "\t" + this._vendorId + "\t" + "\t" + this._userId + "\t"
                                   + this._orderDate + "\t" + "     " + this._orderQuantity + "\t" + "\t" + "   " + this._orderAmount + "\t" + "\t" + " " + this.orderStatus);
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
                Orders v = (Orders)obj;
                return (_orderId == v._orderId)
                        && (_vendorId == v._vendorId)
                        && (_userId == v._userId)
                        && (_orderDate == v._orderDate)
                        && (_orderQuantity == v._orderQuantity)
                        && (_orderAmount == v._orderAmount)
                        && (_orderStatus == v._orderStatus);
            }
        }

        /**
         * GetHashCode() return an int value for the object address.
         */
        public override int GetHashCode()
        {
            Orders v1 = new Orders(101, 102, new DateTime(2020, 11, 02), 5, 1200, "Pending");
            Orders v2 = v1;
            if (v1 == v2)
            {
                return 1;
            }
            return 0;
        }
        /**
         * Accessor and Mutator.
         */
        public int orderId
        {
            get
            {
                return this._orderId;
            }
            set
            {
                this._orderId = value;
            }
        }
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
        public int userId
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
        public DateTime orderDate
        {
            get
            {
                return this._orderDate;
            }
            set
            {
                this._orderDate = value;
            }
        }
        public int orderQuantity
        {
            get
            {
                return this._orderQuantity;
            }
            set
            {
                this._orderQuantity = value;
            }
        }
        public double orderAmount
        {
            get
            {
                return this._orderAmount;
            }
            set
            {
                this._orderAmount = value;
            }
        }
        public string orderStatus
        {
            get
            {
                return this._orderStatus;
            }
            set
            {
                this._orderStatus = value;
            }
        }
    }
}