using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Stock
{
    class Recipe
    {
        public List<IngredientsQuantity> ingredientsList { get; }
        public int nPeopleServed { get; }
        public int minutesToPrepare { get; }
        public string name { get; }
        public int Id { get; }

        public Recipe(List<IngredientsQuantity> _ingredientsList, int _nPeopleServed, int _minutesToPrepare, string _name, int _id=0)
        {
            ingredientsList = _ingredientsList;
            nPeopleServed = _nPeopleServed;
            minutesToPrepare = _minutesToPrepare;
            name = _name;
            Id = _id;
        }
    }
    class IngredientsQuantity
    {
        public int Id { get; set; }
        public string ingredient { get; set; }
        public int Quantity { get; set; }
        public string unit { get; set; }
        public int ExpectedQuantity { get; set; }
    }
    class Plan
    {
        public int Id { get; }
        public int RecipeId { get; }
        public DateTime Date { get; }

        public Plan(int _Id, int _recipeIp, DateTime _date)
        {
            Id = _Id;
            RecipeId = _recipeIp;
            Date = _date;
        }
    }
}
