using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPantry
{
    class ShoppingList
    {

        Dictionary<FoodItem, int> items;

        public ShoppingList()
        {
            this.items = new Dictionary<FoodItem, int>();
        }

        public Dictionary<FoodItem, int> Items
        {
            get { return this.items; }
        }

        public void Add(FoodItem food, int servings)
        {
            items.Add(food, servings);
        }

        public void Remove(FoodItem food)
        {
            items.Remove(food);
        }
    }
}
