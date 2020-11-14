// Jennifer Mohr & Nazmun Nahar
// CIS 3309 Section 001
// Sunday, April 5th, 2020
// Game Project - Yahtzee Game

// Welcome Form 
// Form that allows for the players to input their names and start the game, user can access rules and exit the form as well

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }


        // Event handler for the start button, takes the names entered and creates the players and opens the game form
        private void btnStart_Click(object sender, EventArgs e)
        {


                Globals.YahtzeeGame.setPlayerOne(txtPlayerOne.Text);
                Globals.YahtzeeGame.setPlayerTwo(txtPlayerTwo.Text);

                gameForm f2 = new gameForm();
                f2.ShowDialog();
                
            
        }

        // Event handler for the exit button, exits the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for opening the rules form
        private void btnRules_Click(object sender, EventArgs e)
        {
            Rules ruleForm = new Rules();
            ruleForm.ShowDialog();
        }

        // Event handler for OK button, validates that names were entered and enables the start button
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPlayerOne.Text == "" || txtPlayerTwo.Text == "")
            {
                MessageBox.Show("You must enter names for both players!");
            }
            else
            {

                btnStart.Enabled = true;

            }
        }
    }
}
