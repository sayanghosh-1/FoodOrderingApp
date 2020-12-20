using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodOrderingApp.factory;
using NUnit.Framework;

namespace FoodOrderingApp.Test
{
    [TestFixture]
    class FoodFactoryTest
    {
        [Test]
        public void Show_Food_Details()
        {
            bool actualvalue = factory.FoodFactory.showFood();
            // assert
            Assert.AreEqual(true, actualvalue);
        }

        [Test]
        public void Add_Food_Details()
        {
            List<Food> food = new List<Food>();
            string actualValue = FoodFactory.addFood(5, "Chicken Keema", 280.50, 5, food);
            string res = "Your Food item Chicken Keema is sucessfully added !";
            Assert.AreEqual(res, actualValue);
        }

        [Test]
        public void Update_Food_Cost()
        {
            List<Food> food = new List<Food>();
            food.Add(new Food(1, "Chicken Tikka", 120, 5));
            string actualValue = FoodFactory.updateCost(1, 150.50, food);
            string res = "Your Food item Chicken Tikka is sucessfully updated with cost : 150.5";
            Assert.AreEqual(res, actualValue);
        }

        [Test]
        public void Update_Food_Stock()
        {
            List<Food> food = new List<Food>();
            food.Add(new Food(1, "Chicken Tikka", 120, 5));
            string actualValue = FoodFactory.updateStock(1, 10, food);
            string res = "Your Stock of Food item Chicken Tikka is sucessfully updated with : 10";
            Assert.AreEqual(res, actualValue);
        }
    }
}
