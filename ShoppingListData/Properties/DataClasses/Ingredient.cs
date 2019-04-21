using ShoppingListData.DataClasses;
using System;

namespace ShoppingListSoftware
{
    public class Ingredient : IngredientBase
    {

        public Ingredient(double amount, UnitType Unit, string name)
            :base(name)
        {            
            this.Amount = amount;
            this.Unit = Unit;
        }
            
            
    }
}
