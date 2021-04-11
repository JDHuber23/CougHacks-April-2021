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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cookedButton_Click(object sender, EventArgs e)
        {
            /*
             * This section for what happens when the "I cooked something!" button is clicked.
             * Basically, if you make something that uses more than one ingredient,
             * you can click here to deduct entire recipes worth of ingredients at once.
             * The ingredients and amounts (servings/serving sizes) will then be deducted
             * from the master food list. Ex: PB&J
             */

        }

        private void ateButton_Click(object sender, EventArgs e)
        {
            /* This section for what happens when the "I ate something!" button is clicked.
             * Basically, if you eat something individually (i.e. snacking) you go here
             * to deduct the amount. Ex: two servings of potato chips.
             */
        }

        private void shoppingButton_Click(object sender, EventArgs e)
        {
            /* This section for what happens when the "Shopping List" button is clicked.
             * If you click here, lists all food items currently in your shopping list.
             */
        }

        private void allFoodLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clicked on an item in the list.
        }

        private void pantryLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clicked on an item in the list.
        }

        private void refrigeratorLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clicked on an item in the list.
        }

        private void freezerLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clicked on an item in the list.
        }

        private void recipesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clicked on an item in the list.
        }
    }
}
