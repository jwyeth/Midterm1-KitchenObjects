using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm1KitchenObjects
{
    public class Recipe
    {
        public string Name { get; set;}
        public int TotalCalories { get; set; }
        public double TotalCost { get; set; }
        public List<Ingredients> Ingredients { get; set; }
        public List<string> Steps { get; set; }

        public Recipe(string Name, int TotalCalories, double TotalCost, List<Ingredients> Ingredients, List<string> Steps)

        {
            this.Name = Name;
            this.TotalCalories = TotalCalories;
            this.TotalCost = TotalCost;
            this.Ingredients = Ingredients;
            this.Steps = Steps;
        }

        public Recipe()
        {

            foreach (Ingredients i in Ingredients)
            {
                Console.WriteLine($"{i.Calories}");
                TotalCalories += i.Calories;
                Console.WriteLine(TotalCalories);
            }


        }
        public virtual void DisplayInfo()
        {

            Console.WriteLine($"\nRecipe name: {Name}, \nTotal calories: {TotalCalories}, \nTotal cost: {TotalCost}, \nSteps:");
        }


        public void CalculateTotalCalories()
        {

        }

    }
}
