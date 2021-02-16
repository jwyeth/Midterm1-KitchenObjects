﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm1KitchenObjects
{
    public class Kitchen
    {
        //Dictionary<Ingredients, int> Pantry = new Dictionary<Ingredients, int>();
        public Dictionary<string, int> Pantry { get; set; }
        public List<Recipe> Recipes { get; set; }


        public Kitchen()
        {
            Pantry = new Dictionary<string, int>();
            Pantry.Add("Beef", 1);
            Pantry.Add("Cheese", 1);
            Pantry.Add("Tomato", 0);

            Recipes = new List<Recipe>();
            List<string> Steps = new List<string>();

            Recipe recipe1 = new Recipe("Tacos", 600, 2.00, new List<string>() { "Beef", "Cheese", "Tomato" }, new List<string>() { "Brown beef", "Drain grease" });
            Recipes.Add(recipe1);

        }

        public void DisplayRecipes()
        {
            foreach (Recipe r in Recipes)
            {
                Console.WriteLine($"{r.Name}");
            }
        }

        public Recipe SelectRecipe()
        {
            Console.WriteLine("Here are the available recipes: ");
            DisplayRecipes();
            Console.Write("Which recipe would you like to pick? ");
            int selectedRecipeIndex = int.Parse(Console.ReadLine());

            Recipes[selectedRecipeIndex].DisplayInfo();
            return Recipes[selectedRecipeIndex];

        }

        public void PrepareRecipe(Recipe selectedRecipe)
        {

            foreach(string i in selectedRecipe.Ingredients)
            {
                int result;
                Pantry.TryGetValue(i, out result);

                if (result > 0)
                {
                    Console.WriteLine($"It looks like we have {i} in our pantry.");
                }
            }

        }

        public void DisplayPantry()
        {
            foreach(KeyValuePair<string, int> kvp in Pantry)
            {
                
              
                Console.WriteLine($"Food item: {kvp.Key}\nQuantity: {kvp.Value}");
            }
        }

    }



}
