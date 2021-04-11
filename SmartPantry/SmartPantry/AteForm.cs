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
    public partial class AteForm : Form
    {
        User user;
        public AteForm(User user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void ateNewFoodButton_Click(object sender, EventArgs e)
        {
            // Functionality when "New Food" button clicked.
            NewFood newFood = new NewFood(user);
            newFood.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
