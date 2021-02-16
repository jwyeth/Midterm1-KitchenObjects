using System;

namespace Midterm1KitchenObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the kitchen!");
            Kitchen k = new Kitchen();
            bool running = true;
            while (running == true)
            {
                MainMenu();
                Console.Write("\nPlease enter the number coresponding to the action you'd like to perform: ");
                int menuSelection = int.Parse(Console.ReadLine());

                switch (menuSelection)
                {
                    case 1:
                        k.DisplayPantry();
                        break;

                    case 2:
                        k.DisplayRecipes();
                        break;

                    case 3:
                        Recipe selectedRecipe = k.SelectRecipe();
                        //k.DisplayPantry();
                        selectedRecipe.DisplayInfo();
                        if (k.PrepareRecipe(selectedRecipe) == true)
                        {
                            Console.WriteLine($"\nWe were able to successfully prepare {selectedRecipe.Name}. Enjoy!");
                        }
                        else
                        {
                            Console.WriteLine($"\nIt doesn't look like we have all of the ingredients to prepare {selectedRecipe.Name}");
                        }
                        break;

                    case 4:
                        running = false;
                        break;
                }
            }
               
        }

        public static void MainMenu()
        {
            Console.WriteLine("\n----AVAILABLE ACTIONS----\n");
            Console.WriteLine("1) View Foods in Pantry");
            Console.WriteLine("2) View Recipes");
            Console.WriteLine("3) Prepare Recipe");
            Console.WriteLine("4) Quit");

        }
    }
}
