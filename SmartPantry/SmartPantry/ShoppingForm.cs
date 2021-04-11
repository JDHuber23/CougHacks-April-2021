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
    public partial class ShoppingForm : Form
    {
        private User user;
        public ShoppingForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void newShoppingItemButton_Click(object sender, EventArgs e)
        {
            // Functionality when "New Shopping Item" button pushed.
            NewFood newFood = new NewFood(user);
            newFood.Show();
        }
    }
}
