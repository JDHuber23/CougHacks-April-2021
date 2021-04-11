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
                foreach (string item in user.UserShoppingList.Items.Keys)
                {
                    file.WriteLine("-" + item + "|" + user.UserShoppingList.Items[item]);
                }
                file.WriteLine("RECIPES");
                foreach (Recipe recipe in user.Recipes)
                {
                    file.Write("-" + recipe.Name + "|" + recipe.Instructions);
                    foreach (string item in recipe.Ingredients.Keys)
                    {
                        file.Write("|" + item + "|" + recipe.Ingredients[item]);
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
                
                if (line.StartsWith("FOODITEMS"))
                {
                    line = file.ReadLine();
                    while (!line.StartsWith("SHOPPINGLIST"))
                    {
                        string[] itemArray = line.TrimStart('-').Split('|');
                        FoodItem item = new FoodItem(itemArray[0], itemArray[1],
                            DateTime.Parse(itemArray[3]), int.Parse(itemArray[2]));
                        user.MyKitchen.Add(item);
                        line = file.ReadLine();
                    }
                }

                if (line.StartsWith("SHOPPINGLIST"))
                {
                    line = file.ReadLine();
                    while(!line.StartsWith("RECIPES"))
                    {
                        string[] itemArray = line.TrimStart('-').Split('|');
                        user.UserShoppingList.Add(itemArray[0], int.Parse(itemArray[1]));
                        line = file.ReadLine();
                    }
                }
                
                if (line.StartsWith("RECIPES"))
                {
                    line = file.ReadLine();
                    while(line != null)
                    {
                        string[] recipeArray = line.TrimStart('-').Split('|');
                        Dictionary<string, int> ingredients = new Dictionary<string, int>();

                        for (int i = 2; i < recipeArray.Length - 1; i += 2)
                        {
                            ingredients.Add(recipeArray[i], int.Parse(recipeArray[i + 1]));
                        }

                        user.Recipes.Add(new Recipe(recipeArray[0], ingredients, recipeArray[1]));
                        line = file.ReadLine();
                    }
                }
                
            }
            this.user = user;
            return user;
        }
    }
}
