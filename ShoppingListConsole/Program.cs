using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingListData;

namespace ShoppingListConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredient01 = new Ingredient(10, "Chicken");
            var ingredient02 = new Ingredient(85, "50/50 Spring Mix");
            var ingredient03 = new Ingredient(300, "Cucumber");
            var ingredient04 = new Ingredient(3, "Grape Tomatoes");
            var ingredient05 = new Ingredient(0, "");

            var recipe01 = new Recipe("Chicken Salad");
            recipe01.AddIngredient(ingredient01);
            recipe01.AddIngredient(ingredient02);
            recipe01.AddIngredient(ingredient03);
            recipe01.AddIngredient(ingredient04);

            recipe01.DisplayRecipe();
            Console.ReadLine();

        }
    }
}
