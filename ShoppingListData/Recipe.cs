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
        private string _name;
       
        public Recipe(string name)
        {
            //_recipeList = new List<Ingredient>();
            _recipeList = new Dictionary<string, Ingredient>();
            this.Name = name;
        }

        public string Name
        {
            get { return _name; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
            }                
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
