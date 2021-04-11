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

        private void ingredient2_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantity2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ingredient3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void quantity3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ingredient4_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantity4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ingredient5_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantity5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ingredient6_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantity6_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveRecipeButton_Click(object sender, EventArgs e)
        {
            string successMessage = "Save successful!";
            string successTitle = "Success!";
            string failedMessage = "Save not completed.";
            string failedTitle = "Error";
            /*
             * if(save successful)
             *      MessageBox.Show(successMessage, successTitle);
             * else
             *      MessageBox.Show(failedMessage, failedTitle);
             */
        }
    }
}
