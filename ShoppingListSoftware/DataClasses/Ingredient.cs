using System;

namespace ShoppingListSoftware.DataClasses
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
