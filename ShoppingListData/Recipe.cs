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
            //_recipeList = new List<Ingredient>();
            _recipeList = new Dictionary<string, Ingredient>();
            this.Name = name;
        }
        
        public void AddIngredient(Ingredient ingredient)
        {
            _recipeList.Add(ingredient.Name, ingredient);           
        }
       
        public void ModifyIngredient(Ingredient ingredient)
        {

        }

        public void RemoveIngredient(string ingredient)
        {

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
