using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListData
{
    public class ShoppingList
    {
        //private List<Ingredient> _recipeList;
        private readonly Dictionary<string, GroceryListItem> _groceryList;

        public ShoppingList(string name)
        {
            //_recipeList = new List<Ingredient>();
            _groceryList = new Dictionary<string, GroceryListItem>();
            this.Name = name;
        }

        public string Name { get; private set; }

        public void CreateGrocerytList(Recipe recipe)
        {

        }
    }
}
