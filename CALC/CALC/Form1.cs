using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

// TODO:
// Fix the mess that is the varible names
// Orginize a little
// Add more things.


namespace CALC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Varibles that the upgrades and "click" button use.
        int clicks = 0;
        int multiplier = 1;
        int test = 1;
        int double_Price = 10;
        int upgrade_two = 100;

        private void display_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_One_Click(object sender, EventArgs e)
        {
            

                if (clicks == 0)
                {
                    clicks = clicks + multiplier;
                    display_Box.Text = (clicks.ToString());
                }
                else if (clicks < 0)
                {
                    MessageBox.Show("Game Over");
                }
                else
                {
                    clicks = clicks + test * multiplier;
                    display_Box.Text = (clicks.ToString());
                }
        }

        private void clicker_Auto_Click(object sender, EventArgs e)
        {
            
            //This is the coin multiplier upgrade
            if (clicks >= double_Price)
            {
                
                multiplier = multiplier * 2;
                clicks = clicks - double_Price;
                display_Box.Text = (clicks.ToString());
                double_Price = double_Price * 4;
                MessageBox.Show("Coin Multiplier added. The new price to upgrade this is (" + double_Price + ") coin(s).");
                
            }
            else
            {   
                MessageBox.Show("You need more coins. The price to upgrade is (" + double_Price + ") more coin(s).");
            }

        }

        private void one_Hundread_Button_Click(object sender, EventArgs e)
        {
            // This is the upgrade that instantly adds a bunch of coins.
            if (clicks >= upgrade_two)
            {
                clicks = clicks + upgrade_two;
                display_Box.Text = (clicks.ToString());
                upgrade_two = upgrade_two * 10;


                MessageBox.Show("Coin Multiplier added. The new price to upgrade this is (" + upgrade_two + ") coin(s).");
                one_Hundread_Button.Text = upgrade_two + " Clicks.";
            }
            else
            {
                MessageBox.Show("You need more coins. The price to upgrade is (" + upgrade_two + ") more coin(s).");
            }

        }
    }
}
