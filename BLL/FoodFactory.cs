﻿using System;
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

    }
}
