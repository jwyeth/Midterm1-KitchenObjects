using System;

namespace Midterm1KitchenObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Kitchen!");
            Kitchen k = new Kitchen();
            while (true)
            {


                Recipe selectedRecipe = k.SelectRecipe();
                k.DisplayPantry();
                k.PrepareRecipe(selectedRecipe);




            }
               
        }
    }
}
