// Jennifer Mohr & Nazmun Nahar
// CIS 3309 Section 001
// Sunday, April 5th, 2020
// Game Project - Yahtzee Game

// Game Form 
// Form that controls the entire game and allows players to play

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
    public partial class gameForm : Form
    {
        Roll playerRoll = new Roll();
        bool playerOneTurn = false;
        int rollsLeft;

        public gameForm()
        {
            InitializeComponent();

            // Starts player one's turn when the form is opened
            playTheGame();
        }

        // Method that makes it so the players cannot select a button unless they've already rolled during their turn
        // if they have rolled, it disables the buttons that they cannot press because there is already a value recorded
        // for them
        public void disableButtons()
        {
            if (picDice1.Visible == false)
            {
                btnOnes.Enabled = false;
                btnTwos.Enabled = false;
                btnThrees.Enabled = false;
                btnFours.Enabled = false;
                btnFives.Enabled = false;
                btnSixes.Enabled = false;
                btnThreeOfAKind.Enabled = false;
                btnFourOfAKind.Enabled = false;
                btnSmallStraight.Enabled = false;
                btnLargeStraight.Enabled = false;
                btnYahtzee.Enabled = false;
                btnChance.Enabled = false;
                btnFullHouse.Enabled = false;
            }
            else
            {
                if(playerOneTurn == true)
                {
                    disablePlayerOneButtons();
                }
                else
                {
                    disablePlayerTwoButtons();
                }
            }
        }


        // Method that switches the turns of player one and player two, this occurs after each turn
        public void switchTurns()
        {
            if (playerOneTurn == true)
            { 
                playerOneTurn = false;
                lblPlayerOneTurn.Visible = false;
                lblPlayerTwoTurn.Visible = true;
                disableButtons();

            }
            else
            {
                playerOneTurn = true;
                lblPlayerOneTurn.Visible = true;
                lblPlayerTwoTurn.Visible = false;
                disableButtons();
            }
        }


        // Method that changes what picture of dice is displayed based on the value of the dice in the roll
        public void changeDiceDisplay()
        {
            Dice[] DiceDisplay = playerRoll.getDiceRoll();
            
                if(DiceDisplay[0].getValue() == 1){
                picDice1.Image = Properties.Resources._1;
                }else if(DiceDisplay[0].getValue() == 2){
                picDice1.Image = Properties.Resources._2;
            }
            else if(DiceDisplay[0].getValue() == 3){
                picDice1.Image = Properties.Resources._3;
            }
            else if(DiceDisplay[0].getValue() == 4){
                picDice1.Image = Properties.Resources._4;
            }
            else if(DiceDisplay[0].getValue() == 5){
                picDice1.Image = Properties.Resources._5;
            }
            else if(DiceDisplay[0].getValue() == 6){
                picDice1.Image = Properties.Resources._6;
            }

            if (DiceDisplay[1].getValue() == 1)
            {
                picDice2.Image = Properties.Resources._1;
            }
            else if (DiceDisplay[1].getValue() == 2)
            {
                picDice2.Image = Properties.Resources._2;
            }
            else if (DiceDisplay[1].getValue() == 3)
            {
                picDice2.Image = Properties.Resources._3;
            }
            else if (DiceDisplay[1].getValue() == 4)
            {
                picDice2.Image = Properties.Resources._4;
            }
            else if (DiceDisplay[1].getValue() == 5)
            {
                picDice2.Image = Properties.Resources._5;
            }
            else if (DiceDisplay[1].getValue() == 6)
            {
                picDice2.Image = Properties.Resources._6;
            }

            if (DiceDisplay[2].getValue() == 1)
            {
                picDice3.Image = Properties.Resources._1;
            }
            else if (DiceDisplay[2].getValue() == 2)
            {
                picDice3.Image = Properties.Resources._2;
            }
            else if (DiceDisplay[2].getValue() == 3)
            {
                picDice3.Image = Properties.Resources._3;
            }
            else if (DiceDisplay[2].getValue() == 4)
            {
                picDice3.Image = Properties.Resources._4;
            }
            else if (DiceDisplay[2].getValue() == 5)
            {
                picDice3.Image = Properties.Resources._5;
            }
            else if (DiceDisplay[2].getValue() == 6)
            {
                picDice3.Image = Properties.Resources._6;
            }

            if (DiceDisplay[3].getValue() == 1)
            {
                picDice4.Image = Properties.Resources._1;
            }
            else if (DiceDisplay[3].getValue() == 2)
            {
                picDice4.Image = Properties.Resources._2;
            }
            else if (DiceDisplay[3].getValue() == 3)
            {
                picDice4.Image = Properties.Resources._3;
            }
            else if (DiceDisplay[3].getValue() == 4)
            {
                picDice4.Image = Properties.Resources._4;
            }
            else if (DiceDisplay[3].getValue() == 5)
            {
                picDice4.Image = Properties.Resources._5;
            }
            else if (DiceDisplay[3].getValue() == 6)
            {
                picDice4.Image = Properties.Resources._6;
            }

            if (DiceDisplay[4].getValue() == 1)
            {
                picDice5.Image = Properties.Resources._1;
            }
            else if (DiceDisplay[4].getValue() == 2)
            {
                picDice5.Image = Properties.Resources._2;
            }
            else if (DiceDisplay[4].getValue() == 3)
            {
                picDice5.Image = Properties.Resources._3;
            }
            else if (DiceDisplay[4].getValue() == 4)
            {
                picDice5.Image = Properties.Resources._4;
            }
            else if (DiceDisplay[4].getValue() == 5)
            {
                picDice5.Image = Properties.Resources._5;
            }
            else if (DiceDisplay[4].getValue() == 6)
            {
                picDice5.Image = Properties.Resources._6;
            }

        }

        // Method that occurs when the game is over and there are no turns left
        public void endTheGame()
        {

            // disables all of the buttons
            btnOnes.Enabled = false;
            btnTwos.Enabled = false;
            btnThrees.Enabled = false;
            btnFours.Enabled = false;
            btnFives.Enabled = false;
            btnSixes.Enabled = false;
            btnThreeOfAKind.Enabled = false;
            btnFourOfAKind.Enabled = false;
            btnSmallStraight.Enabled = false;
            btnLargeStraight.Enabled = false;
            btnYahtzee.Enabled = false;
            btnChance.Enabled = false;
            btnFullHouse.Enabled = false;

            // displays the totals/subtotals to the user
            txtBonusPlayer1.Text = Globals.YahtzeeGame.PlayerOne.upperScores.getBonus().ToString();
            txtBonusPlayer2.Text = Globals.YahtzeeGame.PlayerTwo.upperScores.getBonus().ToString();
            txtSubtotalPlayer1.Text = Globals.YahtzeeGame.PlayerOne.upperScores.getUpperSubtotal().ToString(); 
            txtSubtotalPlayer2.Text = Globals.YahtzeeGame.PlayerTwo.upperScores.getUpperSubtotal().ToString();
            txtLowerTotalPlayer1.Text = Globals.YahtzeeGame.PlayerOne.lowerScores.getLowerTotal().ToString();
            txtLowerTotalPlayer2.Text = Globals.YahtzeeGame.PlayerTwo.lowerScores.getLowerTotal().ToString();

            // sets the player's total attribute to the total of each section
            int upperTotal1 = Globals.YahtzeeGame.PlayerOne.upperScores.getUpperTotal();
            Globals.YahtzeeGame.PlayerOne.setUpperSubtotal(upperTotal1);

            int lowerTotal1 = Globals.YahtzeeGame.PlayerOne.lowerScores.getLowerTotal();
            Globals.YahtzeeGame.PlayerOne.setLowerSubtotal(lowerTotal1);

            int upperTotal2 = Globals.YahtzeeGame.PlayerTwo.upperScores.getUpperTotal();
            Globals.YahtzeeGame.PlayerTwo.setUpperSubtotal(upperTotal2);

            int lowerTotal2 = Globals.YahtzeeGame.PlayerTwo.lowerScores.getLowerTotal();
            Globals.YahtzeeGame.PlayerTwo.setLowerSubtotal(lowerTotal2);

            // more displays of the totals/subtotals to the user
            txtFinalLowerPlayer1.Text = lowerTotal1.ToString();
            txtFinalLowerPlayer2.Text = lowerTotal2.ToString();
            txtFinalUpperPlayer1.Text = upperTotal1.ToString();
            txtFinalUpperPlayer2.Text = upperTotal2.ToString();
            txtTotalScorePlayer1.Text = Globals.YahtzeeGame.PlayerOne.getTotalScore().ToString();
            txtTotalScorePlayer2.Text = Globals.YahtzeeGame.PlayerTwo.getTotalScore().ToString();

            // gets the winner of the game
            Player winner = Globals.YahtzeeGame.getWinner();

            // if there is no winner, the game ended in a tie
            if(winner == null)
            {
                MessageBox.Show("There's a tie!");
            }
            else // if there is a winner, displays who won in a message box
            {
                string winnerName = winner.getName();
                string winnerMessage = "The winner is " + winnerName + ". Congratulations!";
                MessageBox.Show(winnerMessage);
            }
        }

        // method that runs one single turn from a single player
        public void playTheGame()
        {
            // if there are no turns left, it ends the game
            if (Globals.YahtzeeGame.getTurnsLeft() == 0)
            {
                endTheGame();
            }
            else // if there are turns left, the roll button is enabled and the hold checkboxes are reset
            {    // the rolls get set back up to 3 and the turns are decremented
                 // the turns are then switched to the other player
                btnRoll.Enabled = true;
                btnRoll.Focus();
                Globals.YahtzeeGame.decrementTurns();
                rollsLeft = 3;
                checkDice1.Checked = false;
                checkDice2.Checked = false;
                checkDice3.Checked = false;
                checkDice4.Checked = false;
                checkDice5.Checked = false;
                txtRollsLeft.Text = rollsLeft.ToString();
                switchTurns();


            }
        }

        // event handler for the roll button
        private void btnRoll_Click(object sender, EventArgs e)
        {
            // decrements the rolls left and shows the user the visualization of the dice
            rollsLeft--;
            txtRollsLeft.Text = rollsLeft.ToString();
            checkDice1.Visible = true;
            checkDice2.Visible = true;
            checkDice3.Visible = true;
            checkDice4.Visible = true;
            checkDice5.Visible = true;
            picDice1.Visible = true;
            picDice2.Visible = true;
            picDice3.Visible = true;
            picDice4.Visible = true;
            picDice5.Visible = true;

            // enables the correct buttons
            disableButtons();
            
            // rolls the dice and gets new values for the dice that aren't held
            playerRoll.rollTheDice();

            // updates the display of the dice to match the roll's values
            changeDiceDisplay();

            // if there are no rolls left, the rolls button is disabled and the user has to choose a category
            if(rollsLeft == 0)
            {
                btnRoll.Enabled = false;
            }


        }

        // Event handler for the Ones button 
        private void btnOnes_Click(object sender, EventArgs e)
        {
            checkDice1.Visible = false;
            checkDice2.Visible = false;
            checkDice3.Visible = false;
            checkDice4.Visible = false;
            checkDice5.Visible = false;
            picDice1.Visible = false;
            picDice2.Visible = false;
            picDice3.Visible = false;
            picDice4.Visible = false;
            picDice5.Visible = false;

            int value = playerRoll.getUpper(1); // gets the value of the roll

            // if the roll will result in a 0, notifies the user of this to be sure they want to continue
            if (value == 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to select Ones? You will get a score of 0.", "Ones", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes: // if the user says yes to selecting ones, gives the user a 0 for this category
                        if (playerOneTurn)
                        {
                            txtOnesPlayer1.Text = "0";
                            Globals.YahtzeeGame.PlayerOne.upperScores.setOnes(0);
                            playTheGame();
                        }
                        else if (!playerOneTurn)
                        {
                            txtOnesPlayer2.Text = "0";
                            Globals.YahtzeeGame.PlayerTwo.upperScores.setOnes(0);
                            playTheGame();
                        }
                        break;
                    case DialogResult.No: // if the user says no, shows the dice and allows them to choose another category
                        picDice1.Visible = true;
                        picDice2.Visible = true;
                        picDice3.Visible = true;
                        picDice4.Visible = true;
                        picDice5.Visible = true;
                        if (rollsLeft != 0) // if they can't roll again, doesn't display the hold buttons
                        {
                            checkDice1.Visible = true;
                            checkDice2.Visible = true;
                            checkDice3.Visible = true;
                            checkDice4.Visible = true;
                            checkDice5.Visible = true;
                        }
                        break;
                }
            }
            else // sets the category to the value of the roll and goes to the next turn`
            {
                if (playerOneTurn)
                {
                    txtOnesPlayer1.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerOne.upperScores.setOnes(value);
                    disableButtons();
                    playTheGame();
                }
                else if (!playerOneTurn)
                {
                    txtOnesPlayer2.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerTwo.upperScores.setOnes(value);
                    disableButtons();
                    playTheGame();
                }
            }

            
        }

       

        private void btnTwos_Click(object sender, EventArgs e)
        {
            checkDice1.Visible = false;
            checkDice2.Visible = false;
            checkDice3.Visible = false;
            checkDice4.Visible = false;
            checkDice5.Visible = false;
            picDice1.Visible = false;
            picDice2.Visible = false;
            picDice3.Visible = false;
            picDice4.Visible = false;
            picDice5.Visible = false;

            int value = playerRoll.getUpper(2); // gets the value of the roll

            // if the roll will result in a 0, notifies the user of this to be sure they wanted to continue
            if (value == 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to select Twos? You will get a score of 0.", "Twos", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes: // if the user says yes to selecting twos, gives the user a 0 for this category
                        if (playerOneTurn)
                        {
                            txtTwosPlayer1.Text = "0";
                            Globals.YahtzeeGame.PlayerOne.upperScores.setTwos(0);
                            playTheGame();
                        }
                        else if (!playerOneTurn)
                        {
                            txtTwosPlayer2.Text = "0";
                            Globals.YahtzeeGame.PlayerTwo.upperScores.setTwos(0);
                            playTheGame();
                        }
                        break;
                    case DialogResult.No: // if the user says no, shows the dice and allows them to choose another category
                        picDice1.Visible = true;
                        picDice2.Visible = true;
                        picDice3.Visible = true;
                        picDice4.Visible = true;
                        picDice5.Visible = true;
                        if (rollsLeft != 0) // if they can't roll again, doesn't display the hold buttons
                        {
                            checkDice1.Visible = true;
                            checkDice2.Visible = true;
                            checkDice3.Visible = true;
                            checkDice4.Visible = true;
                            checkDice5.Visible = true;
                        }
                        break;
                }
            }
            else // sets the category to the value of the roll and goes to the next turn`
            {
                if (playerOneTurn)
                {
                    txtTwosPlayer1.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerOne.upperScores.setTwos(value);
                    playTheGame();
                }
                else if (!playerOneTurn)
                {
                    txtTwosPlayer2.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerTwo.upperScores.setTwos(value);
                    playTheGame();
                }
            }
        }

        private void btnThrees_Click(object sender, EventArgs e)
        {
            checkDice1.Visible = false;
            checkDice2.Visible = false;
            checkDice3.Visible = false;
            checkDice4.Visible = false;
            checkDice5.Visible = false;
            picDice1.Visible = false;
            picDice2.Visible = false;
            picDice3.Visible = false;
            picDice4.Visible = false;
            picDice5.Visible = false;

            int value = playerRoll.getUpper(3); // gets the value of the roll

            if (value == 0)
            {
                // if the roll will result in a 0, notifies the user of this to be sure they want to continue
                DialogResult dr = MessageBox.Show("Are you sure you want to select Threes? You will get a score of 0.", "Threes", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes: // if the user says yes to selecting threes, gives the user a 0 for this category
                        if (playerOneTurn)
                        {
                            txtThreesPlayer1.Text = "0";
                            Globals.YahtzeeGame.PlayerOne.upperScores.setThrees(0);
                            playTheGame();
                        }
                        else if (!playerOneTurn)
                        {
                            txtThreesPlayer2.Text = "0";
                            Globals.YahtzeeGame.PlayerTwo.upperScores.setThrees(0);
                            playTheGame();
                        }
                        break;
                    case DialogResult.No: // if the user says no, shows the dice and allows them to choose another category
                        picDice1.Visible = true;
                        picDice2.Visible = true;
                        picDice3.Visible = true;
                        picDice4.Visible = true;
                        picDice5.Visible = true;
                        if (rollsLeft != 0) // if they can't roll again, doesn't display the hold buttons
                        {
                            checkDice1.Visible = true;
                            checkDice2.Visible = true;
                            checkDice3.Visible = true;
                            checkDice4.Visible = true;
                            checkDice5.Visible = true;
                        }
                        break;
                }
            }
            else // sets the category to the value of the roll and goes to the next turn`
            {
                if (playerOneTurn)
                {
                    txtThreesPlayer1.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerOne.upperScores.setThrees(value);
                    playTheGame();
                }
                else if (!playerOneTurn)
                {
                    txtThreesPlayer2.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerTwo.upperScores.setThrees(value);
                    playTheGame();
                }
            }
        }

        private void btnFours_Click(object sender, EventArgs e)
        {
            checkDice1.Visible = false;
            checkDice2.Visible = false;
            checkDice3.Visible = false;
            checkDice4.Visible = false;
            checkDice5.Visible = false;
            picDice1.Visible = false;
            picDice2.Visible = false;
            picDice3.Visible = false;
            picDice4.Visible = false;
            picDice5.Visible = false;

            int value = playerRoll.getUpper(4); // gets the value of the roll

            if (value == 0)
            {
                // if the roll will result in a 0, notifies the user of this to be sure they want to continue
                DialogResult dr = MessageBox.Show("Are you sure you want to select Fours? You will get a score of 0.", "Fours", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes: // if the user says yes to selecting fours, gives the user a 0 for this category
                        if (playerOneTurn)
                        {
                            txtFoursPlayer1.Text = "0";
                            Globals.YahtzeeGame.PlayerOne.upperScores.setFours(0);
                            playTheGame();
                        }
                        else if (!playerOneTurn)
                        {
                            txtFoursPlayer2.Text = "0";
                            Globals.YahtzeeGame.PlayerTwo.upperScores.setFours(0);
                            playTheGame();
                        }
                        break;
                    case DialogResult.No: // if the user says no, shows the dice and allows them to choose another category
                        picDice1.Visible = true;
                        picDice2.Visible = true;
                        picDice3.Visible = true;
                        picDice4.Visible = true;
                        picDice5.Visible = true;
                        if (rollsLeft != 0) // if they can't roll again, doesn't display the hold buttons
                        {
                            checkDice1.Visible = true;
                            checkDice2.Visible = true;
                            checkDice3.Visible = true;
                            checkDice4.Visible = true;
                            checkDice5.Visible = true;
                        }
                        break;
                }
            }
            else // sets the category to the value of the roll and goes to the next turn`
            {
                if (playerOneTurn)
                {
                    txtFoursPlayer1.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerOne.upperScores.setFours(value);
                    playTheGame();
                }
                else if (!playerOneTurn)
                {
                    txtFoursPlayer2.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerTwo.upperScores.setFours(value);
                    playTheGame();
                }
            }
        }

        private void btnFives_Click(object sender, EventArgs e)
        {
            checkDice1.Visible = false;
            checkDice2.Visible = false;
            checkDice3.Visible = false;
            checkDice4.Visible = false;
            checkDice5.Visible = false;
            picDice1.Visible = false;
            picDice2.Visible = false;
            picDice3.Visible = false;
            picDice4.Visible = false;
            picDice5.Visible = false;

            int value = playerRoll.getUpper(5); // gets the value of the roll

            if (value == 0) 
            {
                // if the roll will result in a 0, notifies the user of this to be sure they want to continue
                DialogResult dr = MessageBox.Show("Are you sure you want to select Fives? You will get a score of 0.", "Fives", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes: // if the user says yes to selecting fives, gives the user a 0 for this category
                        if (playerOneTurn)
                        {
                            txtFivesPlayer1.Text = "0";
                            Globals.YahtzeeGame.PlayerOne.upperScores.setFives(0);
                            playTheGame();
                        }
                        else if (!playerOneTurn)
                        {
                            txtFivesPlayer2.Text = "0";
                            Globals.YahtzeeGame.PlayerTwo.upperScores.setFives(0);
                            playTheGame();
                        }
                        break;
                    case DialogResult.No: // if the user says no, shows the dice and allows them to choose another category
                        picDice1.Visible = true;
                        picDice2.Visible = true;
                        picDice3.Visible = true;
                        picDice4.Visible = true;
                        picDice5.Visible = true;
                        if (rollsLeft != 0) // if they can't roll again, doesn't display the hold buttons
                        {
                            checkDice1.Visible = true;
                            checkDice2.Visible = true;
                            checkDice3.Visible = true;
                            checkDice4.Visible = true;
                            checkDice5.Visible = true;
                        }
                        break;
                }
            }
            else // sets the category to the value of the roll and goes to the next turn`
            {
                if (playerOneTurn)
                {
                    txtFivesPlayer1.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerOne.upperScores.setFives(value);
                    playTheGame();
                }
                else if (!playerOneTurn)
                {
                    txtFivesPlayer2.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerTwo.upperScores.setFives(value);
                    playTheGame();
                }
            }
            
        }

        private void btnSixes_Click(object sender, EventArgs e)
        {
            checkDice1.Visible = false;
            checkDice2.Visible = false;
            checkDice3.Visible = false;
            checkDice4.Visible = false;
            checkDice5.Visible = false;
            picDice1.Visible = false;
            picDice2.Visible = false;
            picDice3.Visible = false;
            picDice4.Visible = false;
            picDice5.Visible = false;

            int value = playerRoll.getUpper(6); // gets the value of the roll

            if (value == 0)
            {
                // if the roll will result in a 0, notifies the user of this to be sure they want to continue
                DialogResult dr = MessageBox.Show("Are you sure you want to select Sixes? You will get a score of 0.", "Sixes", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes: // if the user says yes to selecting sixes, gives the user a 0 for this category
                        if (playerOneTurn)
                        {
                            txtSixesPlayer1.Text = "0";
                            Globals.YahtzeeGame.PlayerOne.upperScores.setSixes(0);
                            playTheGame();
                        }
                        else if (!playerOneTurn)
                        {
                            txtSixesPlayer2.Text = "0";
                            Globals.YahtzeeGame.PlayerTwo.upperScores.setSixes(0);
                            playTheGame();
                        }
                        break;
                    case DialogResult.No: // if the user says no, shows the dice and allows them to choose another category
                        picDice1.Visible = true;
                        picDice2.Visible = true;
                        picDice3.Visible = true;
                        picDice4.Visible = true;
                        picDice5.Visible = true;
                        if (rollsLeft != 0) // if they can't roll again, doesn't display the hold buttons
                        {
                            checkDice1.Visible = true;
                            checkDice2.Visible = true;
                            checkDice3.Visible = true;
                            checkDice4.Visible = true;
                            checkDice5.Visible = true;
                        }
                        break;
                }
            }
            else // sets the category to the value of the roll and goes to the next turn`
            {
                if (playerOneTurn)
                {
                    txtSixesPlayer1.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerOne.upperScores.setSixes(value);
                    playTheGame();
                }
                else if (!playerOneTurn)
                {
                    txtSixesPlayer2.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerTwo.upperScores.setSixes(value);
                    playTheGame();
                }
            }
        }

        private void btnThreeOfAKind_Click(object sender, EventArgs e)
        {
            checkDice1.Visible = false;
            checkDice2.Visible = false;
            checkDice3.Visible = false;
            checkDice4.Visible = false;
            checkDice5.Visible = false;
            picDice1.Visible = false;
            picDice2.Visible = false;
            picDice3.Visible = false;
            picDice4.Visible = false;
            picDice5.Visible = false;

            int value = playerRoll.getSum(); // gets the value of the roll

            if (!playerRoll.checkThreeOfAKind())
            {
                // if the roll will result in a 0, notifies the user of this to be sure they want to continue
                DialogResult dr = MessageBox.Show("Are you sure you want to select Three Of A Kind? You will get a score of 0.", "Three Of A Kind", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes: // if the user says yes to selecting three of a kind, gives the user a 0 for this category
                        if (playerOneTurn)
                        {
                            txtThreeOfAKindPlayer1.Text = "0";
                            Globals.YahtzeeGame.PlayerOne.lowerScores.setThreeOfAKind(0);
                            playTheGame();
                        }
                        else if (!playerOneTurn)
                        {
                            txtThreeOfAKindPlayer2.Text = "0";
                            Globals.YahtzeeGame.PlayerTwo.lowerScores.setThreeOfAKind(0);
                            playTheGame();
                        }
                        break;
                    case DialogResult.No: // if the user says no, shows the dice and allows them to choose another category
                        picDice1.Visible = true;
                        picDice2.Visible = true;
                        picDice3.Visible = true;
                        picDice4.Visible = true;
                        picDice5.Visible = true;
                        if (rollsLeft != 0) // if they can't roll again, doesn't display the hold buttons
                        {
                            checkDice1.Visible = true;
                            checkDice2.Visible = true;
                            checkDice3.Visible = true;
                            checkDice4.Visible = true;
                            checkDice5.Visible = true;
                        }
                        break;
                }
            }
            else // sets the category to the value of the roll and goes to the next turn`
            {
                if (playerOneTurn)
                {
                    txtThreeOfAKindPlayer1.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerOne.lowerScores.setThreeOfAKind(value);
                    playTheGame();
                }
                else if (!playerOneTurn)
                {
                    txtThreeOfAKindPlayer2.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerTwo.lowerScores.setThreeOfAKind(value);
                    playTheGame();
                }
            }
        }

        private void btnFourOfAKind_Click(object sender, EventArgs e)
        {
            checkDice1.Visible = false;
            checkDice2.Visible = false;
            checkDice3.Visible = false;
            checkDice4.Visible = false;
            checkDice5.Visible = false;
            picDice1.Visible = false;
            picDice2.Visible = false;
            picDice3.Visible = false;
            picDice4.Visible = false;
            picDice5.Visible = false;

            int value = playerRoll.getSum(); // gets the value of the roll

            if (!playerRoll.checkFourOfAKind())
            {
                // if the roll will result in a 0, notifies the user of this to be sure they want to continue
                DialogResult dr = MessageBox.Show("Are you sure you want to select Four Of A Kind? You will get a score of 0.", "Four Of A Kind", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes: // if the user says yes to selecting four of a kind, gives the user a 0 for this category
                        if (playerOneTurn)
                        {
                            txtFourOfAKindPlayer1.Text = "0";
                            Globals.YahtzeeGame.PlayerOne.lowerScores.setFourOfAKind(0);
                            playTheGame();
                        }
                        else if (!playerOneTurn)
                        {
                            txtFourOfAKindPlayer2.Text = "0";
                            Globals.YahtzeeGame.PlayerTwo.lowerScores.setFourOfAKind(0);
                            playTheGame();
                        }
                        break;
                    case DialogResult.No: // if the user says no, shows the dice and allows them to choose another category
                        picDice1.Visible = true;
                        picDice2.Visible = true;
                        picDice3.Visible = true;
                        picDice4.Visible = true;
                        picDice5.Visible = true;
                        if (rollsLeft != 0) // if they can't roll again, doesn't display the hold buttons
                        {
                            checkDice1.Visible = true;
                            checkDice2.Visible = true;
                            checkDice3.Visible = true;
                            checkDice4.Visible = true;
                            checkDice5.Visible = true;
                        }
                        break;
                }
            }
            else // sets the category to the value of the roll and goes to the next turn`
            {
                if (playerOneTurn)
                {
                    txtFourOfAKindPlayer1.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerOne.lowerScores.setFourOfAKind(value);
                    playTheGame();
                }
                else if (!playerOneTurn)
                {
                    txtFourOfAKindPlayer2.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerTwo.lowerScores.setFourOfAKind(value);
                    playTheGame();
                }
            }
        }

        private void btnFullHouse_Click(object sender, EventArgs e)
        {
            checkDice1.Visible = false;
            checkDice2.Visible = false;
            checkDice3.Visible = false;
            checkDice4.Visible = false;
            checkDice5.Visible = false;
            picDice1.Visible = false;
            picDice2.Visible = false;
            picDice3.Visible = false;
            picDice4.Visible = false;
            picDice5.Visible = false;

            int value = Globals.YahtzeeGame.PlayerOne.lowerScores.getFullHouseVal(); // gets the value of the roll

            if (!playerRoll.checkFullHouse())
            {
                // if the roll will result in a 0, notifies the user of this to be sure they want to continue
                DialogResult dr = MessageBox.Show("Are you sure you want to select Full House? You will get a score of 0.", "Full House", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes: // if the user says yes to selecting full house, gives the user a 0 for this category
                        if (playerOneTurn)
                        {
                            txtFullHousePlayer1.Text = "0";
                            Globals.YahtzeeGame.PlayerOne.lowerScores.setFullHouse(0);
                            playTheGame();
                        }
                        else if (!playerOneTurn)
                        {
                            txtFullHousePlayer2.Text = "0";
                            Globals.YahtzeeGame.PlayerTwo.lowerScores.setFullHouse(0);
                            playTheGame();
                        }
                        break;
                    case DialogResult.No: // if the user says no, shows the dice and allows them to choose another category
                        picDice1.Visible = true;
                        picDice2.Visible = true;
                        picDice3.Visible = true;
                        picDice4.Visible = true;
                        picDice5.Visible = true;
                        if (rollsLeft != 0) // if they can't roll again, doesn't display the hold buttons
                        {
                            checkDice1.Visible = true;
                            checkDice2.Visible = true;
                            checkDice3.Visible = true;
                            checkDice4.Visible = true;
                            checkDice5.Visible = true;
                        }
                        break;
                }
            }
            else // sets the category to the value of the roll and goes to the next turn`
            {
                if (playerOneTurn)
                {
                    txtFullHousePlayer1.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerOne.lowerScores.setFullHouse(value);
                    playTheGame();
                }
                else if (!playerOneTurn)
                {
                    txtFullHousePlayer2.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerTwo.lowerScores.setFullHouse(value);
                    playTheGame();
                }
            }
        }

        private void btnSmallStraight_Click(object sender, EventArgs e)
        {
            checkDice1.Visible = false;
            checkDice2.Visible = false;
            checkDice3.Visible = false;
            checkDice4.Visible = false;
            checkDice5.Visible = false;
            picDice1.Visible = false;
            picDice2.Visible = false;
            picDice3.Visible = false;
            picDice4.Visible = false;
            picDice5.Visible = false;

            int value = Globals.YahtzeeGame.PlayerOne.lowerScores.getSmallStraightVal(); // gets the value of the roll

            if (!playerRoll.checkSmallStraight())
            {
                // if the roll will result in a 0, notifies the user of this to be sure they want to continue
                DialogResult dr = MessageBox.Show("Are you sure you want to select Small Straight? You will get a score of 0.", "Small Straight", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes: // if the user says yes to selecting small straight, gives the user a 0 for this category
                        if (playerOneTurn)
                        {
                            txtSmallStraightPlayer1.Text = "0";
                            Globals.YahtzeeGame.PlayerOne.lowerScores.setSmallStraight(0);
                            playTheGame();
                        }
                        else if (!playerOneTurn)
                        {
                            txtSmallStraightPlayer2.Text = "0";
                            Globals.YahtzeeGame.PlayerTwo.lowerScores.setSmallStraight(0);
                            playTheGame();
                        }
                        break;
                    case DialogResult.No: // if the user says no, shows the dice and allows them to choose another category
                        picDice1.Visible = true;
                        picDice2.Visible = true;
                        picDice3.Visible = true;
                        picDice4.Visible = true;
                        picDice5.Visible = true;
                        if (rollsLeft != 0) // if they can't roll again, doesn't display the hold buttons
                        {
                            checkDice1.Visible = true;
                            checkDice2.Visible = true;
                            checkDice3.Visible = true;
                            checkDice4.Visible = true;
                            checkDice5.Visible = true;
                        }
                        break;
                }
            }
            else // sets the category to the value of the roll and goes to the next turn`
            {
                if (playerOneTurn)
                {
                    txtSmallStraightPlayer1.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerOne.lowerScores.setSmallStraight(value);
                    playTheGame();
                }
                else if (!playerOneTurn)
                {
                    txtSmallStraightPlayer2.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerTwo.lowerScores.setSmallStraight(value);
                    playTheGame();
                }
            }
        }

        private void btnLargeStraight_Click(object sender, EventArgs e)
        {
            checkDice1.Visible = false;
            checkDice2.Visible = false;
            checkDice3.Visible = false;
            checkDice4.Visible = false;
            checkDice5.Visible = false;
            picDice1.Visible = false;
            picDice2.Visible = false;
            picDice3.Visible = false;
            picDice4.Visible = false;
            picDice5.Visible = false;

            int value = Globals.YahtzeeGame.PlayerOne.lowerScores.getLargeStraightVal(); // gets the value of the roll

            if (!playerRoll.checkLargeStraight())
            {
                // if the roll will result in a 0, notifies the user of this to be sure they want to continue
                DialogResult dr = MessageBox.Show("Are you sure you want to select Large Straight? You will get a score of 0.", "Large Straight", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes: // if the user says yes to selecting large straight, gives the user a 0 for this category
                        if (playerOneTurn)
                        {
                            txtLargeStraightPlayer1.Text = "0";
                            Globals.YahtzeeGame.PlayerOne.lowerScores.setLargeStraight(0);
                            playTheGame();
                        }else if (!playerOneTurn)
                        {
                            txtLargeStraightPlayer2.Text = "0";
                            Globals.YahtzeeGame.PlayerTwo.lowerScores.setLargeStraight(0);
                            playTheGame();
                        }
                        break;
                    case DialogResult.No: // if the user says no, shows the dice and allows them to choose another category
                        picDice1.Visible = true;
                        picDice2.Visible = true;
                        picDice3.Visible = true;
                        picDice4.Visible = true;
                        picDice5.Visible = true;
                        if (rollsLeft != 0) // if they can't roll again, doesn't display the hold buttons
                        {
                            checkDice1.Visible = true;
                            checkDice2.Visible = true;
                            checkDice3.Visible = true;
                            checkDice4.Visible = true;
                            checkDice5.Visible = true;
                        }
                        break;
                }
            }
            else // sets the category to the value of the roll and goes to the next turn`
            {
                if (playerOneTurn)
                {
                    txtLargeStraightPlayer1.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerOne.lowerScores.setLargeStraight(value);
                    playTheGame();
                }
                else if (!playerOneTurn)
                {
                    txtLargeStraightPlayer2.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerTwo.lowerScores.setLargeStraight(value);
                    playTheGame();
                }
            }
        }

        private void btnYahtzee_Click(object sender, EventArgs e)
        {
            checkDice1.Visible = false;
            checkDice2.Visible = false;
            checkDice3.Visible = false;
            checkDice4.Visible = false;
            checkDice5.Visible = false;
            picDice1.Visible = false;
            picDice2.Visible = false;
            picDice3.Visible = false;
            picDice4.Visible = false;
            picDice5.Visible = false;

            int value = Globals.YahtzeeGame.PlayerOne.lowerScores.getYahtzeeVal(); // gets the value of the roll

            if (!playerRoll.checkYahtzee())
            {
                // if the roll will result in a 0, notifies the user of this to be sure they want to continue
                DialogResult dr = MessageBox.Show("Are you sure you want to select Yahtzee? You will get a score of 0.", "Chance", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes: // if the user says yes to selecting yahtzee, gives the user a 0 for this category
                        if (playerOneTurn)
                        {
                            txtYahtzeePlayer1.Text = "0";
                            Globals.YahtzeeGame.PlayerOne.lowerScores.setYahtzee(0);
                            playTheGame();
                        }else if (!playerOneTurn)
                {
                    txtYahtzeePlayer2.Text = "0";
                    Globals.YahtzeeGame.PlayerTwo.lowerScores.setYahtzee(0);
                    playTheGame();
                }
                break;
                    case DialogResult.No: // if the user says no, shows the dice and allows them to choose another category
                        picDice1.Visible = true;
                        picDice2.Visible = true;
                        picDice3.Visible = true;
                        picDice4.Visible = true;
                        picDice5.Visible = true;
                        if (rollsLeft != 0) // if they can't roll again, doesn't display the hold buttons
                        {
                            checkDice1.Visible = true;
                            checkDice2.Visible = true;
                            checkDice3.Visible = true;
                            checkDice4.Visible = true;
                            checkDice5.Visible = true;
                        }
                        break;
                }
            }
            else // sets the category to the value of the roll and goes to the next turn`
            {
                if (playerOneTurn)
                {
                    txtYahtzeePlayer1.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerTwo.lowerScores.setYahtzee(value);
                    playTheGame();
                }
                else if (!playerOneTurn)
                {
                    txtYahtzeePlayer2.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerTwo.lowerScores.setYahtzee(value);
                    playTheGame();
                }
            }
        }

        private void btnChance_Click(object sender, EventArgs e)
        {
            checkDice1.Visible = false;
            checkDice2.Visible = false;
            checkDice3.Visible = false;
            checkDice4.Visible = false;
            checkDice5.Visible = false;
            picDice1.Visible = false;
            picDice2.Visible = false;
            picDice3.Visible = false;
            picDice4.Visible = false;
            picDice5.Visible = false;

            int value = playerRoll.getSum(); // gets the value of the roll

            // sets the category to the value of the roll and goes to the next turn`

            if (playerOneTurn)
                {
                    txtChancePlayer1.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerTwo.lowerScores.setChance(value);
                    playTheGame();
                }
                else if (!playerOneTurn)
                {
                    txtChancePlayer2.Text = value.ToString();
                    Globals.YahtzeeGame.PlayerTwo.lowerScores.setChance(value);
                    playTheGame();
                }
            
        }


        // event handler for the rules button, opens up the rules form
        private void btnRules_Click(object sender, EventArgs e)
        {
            Rules ruleForm = new Rules();
            ruleForm.ShowDialog();
        }

        // event handler for the exit button, exits the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // methods for changing the check for the hold buttons, calls the switch check method
        private void checkDice1_CheckedChanged(object sender, EventArgs e)
        {
            playerRoll.DiceRoll[0].switchCheck();
        }

        private void checkDice2_CheckedChanged(object sender, EventArgs e)
        {
            playerRoll.DiceRoll[1].switchCheck();
        }

        private void checkDice3_CheckedChanged(object sender, EventArgs e)
        {
            playerRoll.DiceRoll[2].switchCheck();
        }

        private void checkDice4_CheckedChanged(object sender, EventArgs e)
        {
            playerRoll.DiceRoll[3].switchCheck();
        }

        private void checkDice5_CheckedChanged(object sender, EventArgs e)
        {
            playerRoll.DiceRoll[4].switchCheck();
        }

        // method that disables the player buttons that already have a value associated with them
        public void disablePlayerOneButtons()
        {
            if(txtOnesPlayer1.Text == "")
            {
                btnOnes.Enabled = true;
            }
            else
            {
                btnOnes.Enabled = false;
            }

            if (txtTwosPlayer1.Text == "")
            {
                btnTwos.Enabled = true;
            }
            else
            {
                btnTwos.Enabled = false;
            }

            if (txtThreesPlayer1.Text == "")
            {
                btnThrees.Enabled = true;
            }
            else
            {
                btnThrees.Enabled = false;
            }

            if (txtFoursPlayer1.Text == "")
            {
                btnFours.Enabled = true;
            }
            else
            {
                btnFours.Enabled = false;
            }

            if (txtFivesPlayer1.Text == "")
            {
                btnFives.Enabled = true;
            }
            else
            {
                btnFives.Enabled = false;
            }

            if (txtSixesPlayer1.Text == "")
            {
                btnSixes.Enabled = true;
            }
            else
            {
                btnSixes.Enabled = false;
            }

            if (txtThreeOfAKindPlayer1.Text == "")
            {
                btnThreeOfAKind.Enabled = true;
            }
            else
            {
                btnThreeOfAKind.Enabled = false;
            }

            if (txtFourOfAKindPlayer1.Text == "")
            {
                btnFourOfAKind.Enabled = true;
            }
            else
            {
                btnFourOfAKind.Enabled = false;
            }

            if (txtFullHousePlayer1.Text == "")
            {
                btnFullHouse.Enabled = true;
            }
            else
            {
                btnFullHouse.Enabled = false;
            }

            if (txtSmallStraightPlayer1.Text == "")
            {
                btnSmallStraight.Enabled = true;
            }
            else
            {
                btnSmallStraight.Enabled = false;
            }

            if (txtLargeStraightPlayer1.Text == "")
            {
                btnLargeStraight.Enabled = true;
            }
            else
            {
                btnLargeStraight.Enabled = false;
            }

            if (txtYahtzeePlayer1.Text == "")
            {
                btnYahtzee.Enabled = true;
            }
            else
            {
                btnYahtzee.Enabled = false;
            }

            if (txtChancePlayer1.Text == "")
            {
                btnChance.Enabled = true;
            }
            else
            {
                btnChance.Enabled = false;
            }

        }

        // method that disables the player buttons that already have a value associated with them
        public void disablePlayerTwoButtons()
        {
            if (txtOnesPlayer2.Text == "")
            {
                btnOnes.Enabled = true;
            }
            else
            {
                btnOnes.Enabled = false;
            }

            if (txtTwosPlayer2.Text == "")
            {
                btnTwos.Enabled = true;
            }
            else
            {
                btnTwos.Enabled = false;
            }

            if (txtThreesPlayer2.Text == "")
            {
                btnThrees.Enabled = true;
            }
            else
            {
                btnThrees.Enabled = false;
            }

            if (txtFoursPlayer2.Text == "")
            {
                btnFours.Enabled = true;
            }
            else
            {
                btnFours.Enabled = false;
            }

            if (txtFivesPlayer2.Text == "")
            {
                btnFives.Enabled = true;
            }
            else
            {
                btnFives.Enabled = false;
            }

            if (txtSixesPlayer2.Text == "")
            {
                btnSixes.Enabled = true;
            }
            else
            {
                btnSixes.Enabled = false;
            }

            if (txtThreeOfAKindPlayer2.Text == "")
            {
                btnThreeOfAKind.Enabled = true;
            }
            else
            {
                btnThreeOfAKind.Enabled = false;
            }

            if (txtFourOfAKindPlayer2.Text == "")
            {
                btnFourOfAKind.Enabled = true;
            }
            else
            {
                btnFourOfAKind.Enabled = false;
            }

            if (txtFullHousePlayer2.Text == "")
            {
                btnFullHouse.Enabled = true;
            }
            else
            {
                btnFullHouse.Enabled = false;
            }

            if (txtSmallStraightPlayer2.Text == "")
            {
                btnSmallStraight.Enabled = true;
            }
            else
            {
                btnSmallStraight.Enabled = false;
            }

            if (txtLargeStraightPlayer2.Text == "")
            {
                btnLargeStraight.Enabled = true;
            }
            else
            {
                btnLargeStraight.Enabled = false;
            }

            if (txtYahtzeePlayer2.Text == "")
            {
                btnYahtzee.Enabled = true;
            }
            else
            {
                btnYahtzee.Enabled = false;
            }

            if (txtChancePlayer2.Text == "")
            {
                btnChance.Enabled = true;
            }
            else
            {
                btnChance.Enabled = false;
            }
        }
    }

}
