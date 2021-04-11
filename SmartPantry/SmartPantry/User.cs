using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPantry
{
    class User
    {
        private ShoppingList shoppingList;
        List<FoodItem> mykitchen;
        List<Recipe> recipes;
        public User ()
        {
            shoppingList = new ShoppingList();
            mykitchen = new List<FoodItem>();
            recipes = new List<Recipe>();
        }
        
        public ShoppingList UserShoppingList
        {
            get { return shoppingList; }
            set { shoppingList = value; }
        }

        public List<FoodItem> MyKitchen
        {
            get { return mykitchen; }
            set { mykitchen = value; }
        }

        public List<Recipe> Recipes
        {
            get { return recipes; }
            set { recipes = value; }
        }
    } 

}
