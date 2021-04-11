using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace SmartPantry
{
    public class FlatStorage
    {
        // recipes

        // food items

        // shopping list

        // user

        private User user;

        public FlatStorage(User user)
        {
            this.user = user;
        }

        public void SaveToFile()
        {
            using (StreamWriter file = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\\" + user.Username + ".txt"))
            {
                file.WriteLine("FOODITEMS");
                foreach (FoodItem item in user.MyKitchen)
                {
                    file.WriteLine("-" + item.Name + "|" 
                        + item.Location + "|" + item.TotalServings + "|" + item.ExpirationDate);
                }
                file.WriteLine("SHOPPINGLIST");
                foreach (FoodItem item in user.UserShoppingList.Items.Keys)
                {
                    file.WriteLine("-" + item.Name + "|" + user.UserShoppingList.Items[item]);
                }
                file.WriteLine("RECIPES");
                foreach (Recipe recipe in user.Recipes)
                {
                    file.Write("-" + recipe.Name + "|" + recipe.Instructions + "|");
                    foreach (FoodItem item in recipe.Ingredients.Keys)
                    {
                        file.Write(item.Name + "|" + recipe.Ingredients[item]);
                    }
                    file.WriteLine();
                }
            }
        }

        public User ReadFromFile(string username)
        {
            User user = new User(username);
            using (StreamReader file = new StreamReader(Path.GetFullPath(Directory.GetCurrentDirectory()) + "\\" + username + ".txt"))
            {
                string line = file.ReadLine();
                while (line != null)
                {
                    string[] lineArray = line.Split(',');


                }
            }

            return user;
        }
    }
}
