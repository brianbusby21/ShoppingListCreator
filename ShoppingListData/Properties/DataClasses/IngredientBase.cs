using System;

namespace ShoppingListSoftware.DataClasses
{
    public class IngredientBase
    {
        public string Name { get; private set; }
        public double Amount { get; set; }
        public UnitType Unit { get; set; }

        public IngredientBase(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("You must provide a name for this ingredient");
            }

            this.Name = name;
        }
        
    }
}
