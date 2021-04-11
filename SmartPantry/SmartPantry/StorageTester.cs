using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPantry
{
    public static class StorageTester
    {

        public static void test()
        {
            User user = new User("dummy");
            user.UserShoppingList = new ShoppingList();
            FoodItem cactus = new FoodItem("cactus", "freezer", DateTime.Now, 5);
            user.UserShoppingList.Add(cactus.Name, 15);
            user.MyKitchen.Add(cactus);
            Recipe cactusSoup = new Recipe("Cactus Soup", new Dictionary<string, int> { { cactus.Name, 5 } }, "Put the cactus in water. Cactus Soup!");
            user.Recipes.Add(cactusSoup);

            FlatStorage storage = new FlatStorage(user);
            storage.SaveToFile();

            User newUser = storage.ReadFromFile("dummy");
            Console.WriteLine(newUser.Username);
        }
    }
}
