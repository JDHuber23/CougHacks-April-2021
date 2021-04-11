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
        public CookedForm()
        {
            InitializeComponent();
        }

        private void cookedNewRecipeButton_Click(object sender, EventArgs e)
        {
            // Functionality when "New Recipe" button clicked.
            
            NewRecipeForm newRecipeForm = new NewRecipeForm();
            newRecipeForm.Show();
        }

        private void recipeSearchTB_TextChanged(object sender, EventArgs e)
        {
            // Searching for recipe that they cooked.
        }
    }
}
