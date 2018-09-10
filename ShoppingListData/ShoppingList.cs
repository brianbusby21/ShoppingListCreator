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
        private readonly Dictionary<string, ShoppingListItem> _shoppingList;
        private readonly Dictionary<string, Recipe> _recipeCollection;

        public ShoppingList(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("You must provide a name for this Grocery List");
            }

            _shoppingList = new Dictionary<string, ShoppingListItem>();
            _recipeCollection = new Dictionary<string, Recipe>();
            this.Name = name;
        }

        public string Name { get; private set; }

        public bool AddRecipe(Recipe recipe)
        {
            if (recipe != null)
            {
                _recipeCollection.Add(recipe.Name, recipe);
                return true;
            }
            //No ingredient object
            return false;
        }

        public void ModifyRecipe(Recipe recipe)
        {

        }

        public bool RemoveRecipe(string recipe)
        {
            if (!string.IsNullOrWhiteSpace(recipe))
            {
                if (_recipeCollection.ContainsKey(recipe))
                {
                    _recipeCollection.Remove(recipe);
                    return true;
                }
            }
            //no ingredient passed or does not exist in recipe
            return false;
        }

        public void CreateShoppingtList()
        {

        }
    }
}
