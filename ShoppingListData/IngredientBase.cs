using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListData
{
    public class IngredientBase
    {
        public string Name { get; private set; }
        public double Amount { get; set; }

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
