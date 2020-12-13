/*author : Sayan Ghosh - 53373
 This is a Food ordering app that allows user to log in with their credentials and order food.
 User can also cancel the order after ordering.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class is for storing Food Menu details

namespace FoodOrderingApp
{
    class Food
    {
        private int _foodId;
        private string _foodName;
        private double _foodCost;
        private int _foodStock;

        //Default Constructor
        public Food()
        {

        }

        //Parameterized Constructor for object creation with values.
        public Food(int foodId, string foodName, double foodCost, int foodStock)
        {
            this._foodId = foodId;
            this._foodName = foodName;
            this._foodCost = foodCost;
            this._foodStock = foodStock;
        }

        //ToString Method Overridden from Object class
        public override string ToString()
        {
            /* return string.Format("\n Food Id = {0} \n Food Name = {1} \n Food Cost = {2} \n Food Stock = {3}",
                                  this._foodId, this._foodName, this._foodCost, this._foodStock);
             */
            return string.Format("---------------------------------------------------------------\n" +
                                "    " + this._foodId + "\t" + "   " + this._foodName + "\t" + this._foodCost + "\t" + "\t" + this._foodStock);
        }

        //Equals Method Overridden from Object class
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Food f = (Food)obj;
                return (_foodId == f._foodId) && (_foodName == f._foodName) && (_foodCost == f._foodCost)
                    && (_foodStock == f._foodStock);
            }
        }

        //HashCode Method Overridden from Object class
        public override int GetHashCode()
        {
            Food f1 = new Food(1, "Chicken Tikka", 120, 5);
            Food f2 = f1;
            if (f1 == f2)
            {
                return 1;
            }
            return 0;
        }

        //Accessor and Mutators for the class variables

        //foodId accessor and Mutator
        public int FoodId
        {
            get
            {
                return this._foodId;
            }
            set
            {
                this._foodId = value;

            }
        }

        //foodName accessor and Mutator
        public string FoodName
        {
            get
            {
                return this._foodName;
            }
            set
            {
                this._foodName = value;

            }
        }

        //foodCost accessor and Mutator
        public double FoodCost
        {
            get
            {
                return this._foodCost;
            }
            set
            {
                this._foodCost = value;

            }
        }

        //foodStock accessor and Mutator
        public int FoodStock
        {
            get
            {
                return this._foodStock;
            }
            set
            {
                this._foodStock = value;

            }
        }

    }
}