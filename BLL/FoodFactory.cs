using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingApp.factory
{
    class FoodFactory
    {
        List<Food> food = new List<Food>();

        public static Food[] showFood(List<Food> food)
        {
            List<Food> list = new List<Food>();
            foreach (var f in food)
            {
                if(f.FoodStock > 0)
                {
                    list.Add(f);
                }
            }
            return list.ToArray();
        }
        public static string addFood(int foodId, string foodName, double foodCost, int foodStock, List<Food> food)
        {
            food.Add(new Food(foodId, foodName, foodCost, foodStock));
            return "Your Food item " + foodName + " is sucessfully added !";
        }
        public static string updateCost(int foodId, double foodCost, List<Food> food)
        {
            string foodName = " ";
            foreach (var f in food)
            {
                if (f.FoodId == foodId)
                {
                    foodName = f.FoodName;
                    f.FoodCost = foodCost;
                }
            }
            return "Your Food item " + foodName + " is sucessfully updated with cost : " + foodCost;
        }
        public static string updateStock(int foodId, int foodStock, List<Food> food)
        {
            string foodName = " ";
            foreach (var f in food)
            {
                if (f.FoodId == foodId)
                {
                    foodName = f.FoodName;
                    f.FoodStock = foodStock;
                }
            }
            return "Your Stock of Food item " + foodName + " is sucessfully updated with : " + foodStock;
        }

    }
}
