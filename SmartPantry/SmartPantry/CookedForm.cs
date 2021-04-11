using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPantry
{
    public partial class CookedForm : Form
    {
        User user;
        public CookedForm(User user)
        {
            InitializeComponent();
            this.user = user;
            foreach (var recipe in user.Recipes)
            {
                cookedRecipeList.Items.Add(recipe.Name);
            }
        }

        private void cookedNewRecipeButton_Click(object sender, EventArgs e)
        {
            // Functionality when "New Recipe" button clicked.
            
            NewRecipeForm newRecipeForm = new NewRecipeForm(user);
            newRecipeForm.Show();
        }

        private void recipeSearchTB_TextChanged(object sender, EventArgs e)
        {
            // Searching for recipe that they cooked.
        }
    }
}
