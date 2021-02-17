using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compouds
{
    public partial class Form1 : Form
    {
        string suit = "";
        bool thisCondition = false;
        bool thatCondition = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void hurricaneButton_Click(object sender, EventArgs e)
        {
            //get the inputted category

            //check the inputted category with a switch block
        }

        private void heartButton_Click(object sender, EventArgs e)
        {
            //set suit value

            //set button colour to goldenrod, (other buttons black)
        }

        private void diamondButton_Click(object sender, EventArgs e)
        {
            //set suit value

            //set button colour to goldenrod, (other buttons black)
        }

        private void clubButton_Click(object sender, EventArgs e)
        {
            //set suit value

            //set button colour to goldenrod, (other buttons black)
        }

        private void spadeButton_Click(object sender, EventArgs e)
        {
            //set suit value

            //set button colour to goldenrod, (other buttons black)
        }

        private void orButton_Click(object sender, EventArgs e)
        {
            //use compound if statements to check what suit
            //has been selected and output the colour of the suit
        }

        private void thisButton_Click(object sender, EventArgs e)
        {
            //set thisCondition to opposite of what it currently 
            //is, and change BackColor to Black for false and 
            //Goldenrod for true
        }

        private void thatButton_Click(object sender, EventArgs e)
        {
            //set thatCondition to opposite of what it currently 
            //is, and change BackColor to Black for false and 
            //Goldenrod for true
        }

        private void andButton_Click(object sender, EventArgs e)
        {
            //use compuond if statements to see if both conditions
            //are true, false, or different
        }
    }
}
