using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm1KitchenObjects
{
    class Ingredients
    {
        public string Name { get; set; }
        public string FoodGroup { get; set; }
        public int Calories { get; set; }
        public double Cost { get; set; }

        public Ingredients(string Name, string FoodGroup, int Calories, double Cost)
        {
            this.Name = Name;
            this.FoodGroup = FoodGroup;
            this.Calories = Calories;
            this.Cost = Cost;
        }

    }

}
