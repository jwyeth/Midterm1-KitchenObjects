using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm1KitchenObjects
{
    class Recipe
    {
        public string Name { get; set;}
        public int TotalCalories { get; set; }
        public double TotalCost { get; set; }
        public List<Ingredients> Food { get; set; }
        public List<string> Steps { get; set; }

        public Recipe(string Name, int TotalCalories, double TotalCost, List<Ingredients> Food, List<string> Steps)
        {
            this.Name = Name;
            this.TotalCalories = TotalCalories;
            this.TotalCost = TotalCost;
            this.Food = Food;
            this.Steps = Steps;
        }
    }
}
