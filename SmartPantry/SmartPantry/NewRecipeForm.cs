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
    public partial class NewRecipeForm : Form
    {
        public NewRecipeForm()
        {
            InitializeComponent();
        }
        private void recipeNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ingredient1_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantity1_TextChanged(object sender, EventArgs e)
        {

        }


        private void saveRecipeButton_Click(object sender, EventArgs e)
        {
            string successMessage = "Save successful!";
            string successTitle = "Success!";
            string failedMessage = "Save not completed.";
            string failedTitle = "Error";
            /* Pseudocode below:
             * if(save successful)
             *      MessageBox.Show(successMessage, successTitle);
             * else
             *      MessageBox.Show(failedMessage, failedTitle);
             */
        }

        private void addRecipeItemButton_Click(object sender, EventArgs e)
        {

        }
    }
}
