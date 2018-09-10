using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListData
{
    public class ShoppingListItem : IngredientBase
    {
        public ShoppingListItem(double amount, string name)
            :base(name)
        {
            this.Amount = amount;
        }
    }
}
