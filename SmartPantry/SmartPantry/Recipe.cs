using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPantry
{
    class Recipe
    {
        string name;
        Dictionary<FoodItem, int> Ingredients;
        // Store recipes somewhere.

        
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }


        public Dictionary<FoodItem, int> ingredients
        {
            get { return Ingredients; }
            set { Ingredients = value; }
        }

    }
}
