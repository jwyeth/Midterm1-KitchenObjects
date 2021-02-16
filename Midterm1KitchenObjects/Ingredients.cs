using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm1KitchenObjects
{
    public class Ingredients
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

        public Ingredients()
        {

            List<Ingredients> Foods = new List<Ingredients>();

            Ingredients food1 = new Ingredients("Tomato", "Fruit", 90, 1.00);
            Ingredients food2 = new Ingredients("Beef", "Meat", 180, 2.00);
            Ingredients food3 = new Ingredients("Cheese", "Dairy", 90, 1.00);
            Foods.Add(food1);
            Foods.Add(food2);
            Foods.Add(food3);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name}, {FoodGroup}, {Calories}, {Cost}");
        }
    }

}
