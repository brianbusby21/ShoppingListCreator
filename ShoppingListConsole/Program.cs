using System;
using ShoppingListSoftware.DataClasses;

namespace ShoppingListConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredient01 = new Ingredient(10, UnitType.Ounces, "Chicken");
            var ingredient02 = new Ingredient(85, UnitType.Grams, "50/50 Spring Mix");
            var ingredient03 = new Ingredient(300, UnitType.Grams, "Cucumber");
            var ingredient04 = new Ingredient(3, UnitType.Ounces, "Grape Tomatoes");
            //var ingredient05 = new Ingredient(0, "");

            var ingredient05 = new Ingredient(2, UnitType.Each, "Whole Boiled Eggs");
            var ingredient06 = new Ingredient(4, UnitType.Each, "Whole Boiled Egg Whites");
            var ingredient07 = new Ingredient(85, UnitType.Grams, "50/50 Spring Mix");
            var ingredient08 = new Ingredient(0.5, UnitType.Each, "Avocado");
            var ingredient09 = new Ingredient(85, UnitType.Grams, "Brocoli");

            var recipe01 = new Recipe("Chicken Salad");
            recipe01.AddIngredient(ingredient01);
            recipe01.AddIngredient(ingredient02);
            recipe01.AddIngredient(ingredient03);
            recipe01.AddIngredient(ingredient04);

            var recipe02 = new Recipe("Egg Salad");
            recipe02.AddIngredient(ingredient05);
            recipe02.AddIngredient(ingredient06);
            recipe02.AddIngredient(ingredient07);
            recipe02.AddIngredient(ingredient08);

            recipe01.DisplayRecipe();
            Console.ReadLine();
            recipe02.DisplayRecipe();

            var shoppingList01 = new ShoppingList("Mid-Month Shopping List");

            shoppingList01.AddRecipe(recipe01);
            shoppingList01.AddRecipe(recipe02);
            shoppingList01.CreateShoppingtList();
            Console.WriteLine();
            shoppingList01.DisplayShoppingList();
            Console.ReadLine();

        

        }
    }
}
