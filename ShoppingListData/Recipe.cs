using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListData
{
    public class Recipe
    {        
        //private List<Ingredient> _recipeList;
        private readonly Dictionary<string, Ingredient> _recipeList;

        public string Name { get; private set; }

        public Recipe(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("You must provide a name for this recipe");
            }

            _recipeList = new Dictionary<string, Ingredient>();
            this.Name = name;
        }
       

        public bool AddIngredient(Ingredient ingredient)
        {
            if (ingredient != null)
            {
                _recipeList.Add(ingredient.Name, ingredient);
                return true;
            }
            //No ingredient object
            return false;
                       
        }
       
        public void ModifyIngredient(Ingredient ingredient)
        {
            
        }

        public bool RemoveIngredient(string ingredient)
        {
            if (!string.IsNullOrWhiteSpace(ingredient))
            {
                if (_recipeList.ContainsKey(ingredient))
                {
                    _recipeList.Remove(ingredient);
                    return true;
                }
            }
            //no ingredient passed or does not exist in recipe
            return false;                                             
        }

        public void DisplayRecipe()
        {
            foreach (var item in _recipeList)
            {
                Console.WriteLine("{0}, {1}", item.Value.Amount, item.Key);
            }
        }


    }
}
