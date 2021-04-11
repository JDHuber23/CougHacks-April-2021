using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPantry
{
    public class FlatStorage
    {
        // recipes

        // food items
        
        // shopping list
        
        // user

        public void SaveToFile(string username)
        {
            using (StreamWriter file = new StreamWriter(@Path.GetFullPath(Directory.GetCurrentDirectory()) + username + ".txt")
            {
                
            }
        }

        public void ReadFromFile(string username)
        {
            using (StreamReader file = new StreamReader(Path.GetFullPath(Directory.GetCurrentDirectory()) + "\\" + username + ".txt"))
            {
                string line = file.ReadLine();
                while (line != null)
                {
                    string[] lineArray = line.Split(',');


                }
            }
        }
    }
}
