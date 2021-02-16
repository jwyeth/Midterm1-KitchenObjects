using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm1KitchenObjects
{
    public class Kitchen
    {
        public Dictionary<string, int> Pantry { get; set; }
        public List<Recipe> Recipes { get; set; }


        public Kitchen()
        {
        
            List<Ingredients> Foods = new List<Ingredients>();

            Ingredients tomato = new Ingredients("Tomato", "Fruit", 90, 1.00);
            Ingredients beef = new Ingredients("Beef", "Meat", 180, 2.00);
            Ingredients cheese = new Ingredients("Cheese", "Dairy", 90, 1.00);
            Foods.Add(tomato);
            Foods.Add(beef);
            Foods.Add(cheese);

            Pantry = new Dictionary<string, int>();
            Pantry.Add("Tomato", 1);
            Pantry.Add("Beef", 1);
            Pantry.Add("Cheese", 1);

            Recipes = new List<Recipe>();
            List<string> Steps = new List<string>();

            

            Recipe recipe1 = new Recipe("Tacos", 0, 2.00, new List<Ingredients>() {  tomato, beef, cheese }, new List<string>() { "Brown beef", "Drain grease" });
            Recipes.Add(recipe1);
            CalculateTotalCalories();
            CalculateTotalCost();


        }

        public void DisplayRecipes()
        {
            int i = 1;
            foreach (Recipe r in Recipes)
            {
                Console.WriteLine($"{i}) {r.Name}");
            }
        }

        public Recipe SelectRecipe()
        {
            Console.WriteLine("\nHere are the available recipes: ");
            DisplayRecipes();
            Console.Write("\nWhich recipe would you like to prepare? ");
            int selectedRecipe = int.Parse(Console.ReadLine());
            int selectedRecipeIndex = selectedRecipe - 1;

            Recipes[selectedRecipeIndex].DisplayInfo();
            return Recipes[selectedRecipeIndex];

        }

        public bool PrepareRecipe(Recipe selectedRecipe)
        {
            bool haveAllIngredients = true;

            foreach(Ingredients i in selectedRecipe.Ingredients)
            {
                int result;
                Pantry.TryGetValue(i.Name.ToString(), out result);
                Console.WriteLine(result);
                Console.WriteLine(i.Name);

                if (result == 0)
                {
                    haveAllIngredients = false;
                }
            }
            
            if (haveAllIngredients == true)
            {
                foreach(Ingredients i in selectedRecipe.Ingredients)
                {
                    Pantry[i.Name.ToString()] -= 1;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayPantry()
        {
            foreach(KeyValuePair<string, int> kvp in Pantry)
            {
                Console.WriteLine($"Food: {kvp.Key}\nQuantity: {kvp.Value}");
            }
        }

        public void CalculateTotalCalories()
        {
            int totalCalories = 0;
            foreach(Recipe r in Recipes)
                {
                foreach (Ingredients i in r.Ingredients)
                {
                    totalCalories += i.Calories;
                }
            r.TotalCalories = totalCalories;
            }
        }

        public void CalculateTotalCost()
        {
            double totalCost = 0.00;
            foreach(Recipe r in Recipes)
            {
                foreach(Ingredients i in r.Ingredients)
                {
                    totalCost += i.Cost;
                }
                r.TotalCost = totalCost;
            }
        }




    }



}
