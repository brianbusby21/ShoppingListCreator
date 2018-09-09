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
        public int Amount { get; set; }

        public IngredientBase(string name)
        {
            this.Name = name;
        }
        
    }
}
