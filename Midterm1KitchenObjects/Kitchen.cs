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

            Ingredients Tomato = new Ingredients("Tomato", "Fruit", 90, 1.00);
            Ingredients Beef = new Ingredients("Beef", "Meat", 180, 2.00);
            Ingredients Cheese = new Ingredients("Cheese", "Dairy", 90, 1.00);
            Ingredients Tortilla = new Ingredients("Ingredients", "Grains", 80, 1.00);
            Foods.Add(Tomato);
            Foods.Add(Beef);
            Foods.Add(Cheese);
            Foods.Add(Tortilla);

            Ingredients SpaghettiSauce = new Ingredients("SpaghettiSauce", "Soup?", 90, 1.00);
            Ingredients Spaghetti = new Ingredients("Spaghetti", "Pasta", 90, 1.00);
            Foods.Add(SpaghettiSauce);
            Foods.Add(Spaghetti);

            Pantry = new Dictionary<string, int>();
            Pantry.Add("Tomato", 1);
            Pantry.Add("Beef", 1);
            Pantry.Add("Cheese", 1);
            Pantry.Add("Tortilla", 1);
            Pantry.Add("SpaghettiSauce", 1);
            Pantry.Add("Spaghetti", 1);


            Recipes = new List<Recipe>();
            List<string> Steps = new List<string>();

            

            Recipe recipe1 = new Recipe("Tacos", 0, 0.00, new List<Ingredients>() {  Tomato, Beef, Cheese, Tortilla }, new List<string>() { "Brown beef", "Drain grease", "Mix in seasoning", "Serve" });
            Recipe recipe2 = new Recipe("Spaghetti", 0, 0.00, new List<Ingredients>() { Spaghetti, SpaghettiSauce, Beef }, new List<string>() { "Cook noodles", "Brown beef", "Drain grease", "Mix beef and sauce", "Serve" });
            Recipes.Add(recipe1);
            Recipes.Add(recipe2);
            CalculateTotalCalories();
            CalculateTotalCost();


        }

        public void DisplayRecipes()
        {
            int i = 1;
            foreach (Recipe r in Recipes)
            {
                Console.WriteLine($"{i}) {r.Name}");
                i++;
            }
        }

        public Recipe SelectRecipe()
        {
            Console.WriteLine("\nHere are the available recipes: ");
            DisplayRecipes();
            Console.Write("\nWhich recipe would you like to prepare? ");
            int selectedRecipe = int.Parse(Console.ReadLine());
            int selectedRecipeIndex = selectedRecipe - 1;

            //Recipes[selectedRecipeIndex].DisplayInfo();
            return Recipes[selectedRecipeIndex];

        }

        public bool PrepareRecipe(Recipe selectedRecipe)
        {
            bool haveAllIngredients = true;

            foreach(Ingredients i in selectedRecipe.Ingredients)
            {
                int result;
                Pantry.TryGetValue(i.Name.ToString(), out result);


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
