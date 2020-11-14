// Jennifer Mohr & Nazmun Nahar
// CIS 3309 Section 001
// Sunday, April 5th, 2020
// Game Project - Yahtzee Game

// Player Class 
// A class that represents a single player, the players' upper and lower section scores are stored within this class
// as well as the totals for each section/the total score

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Player
    {
        string name;
        public UpperSection upperScores;
        public LowerSection lowerScores;
        int upperSubtotal;
        int lowerSubtotal;
        int totalScore;

        // Constructor for the Player, sets their name to what is entered on the Welcome Form when passed as a string
        public Player(string name)
        {
            this.name = name;
            this.upperSubtotal = 0;
            this.lowerSubtotal = 0;
            this.upperScores = new UpperSection();
            this.lowerScores = new LowerSection();
            this.totalScore = 0;
        }

        // Method that adds up the upper and lower subtotals for a player and makes it their total score
        public int getTotalScore()
        {
            this.totalScore = upperSubtotal + lowerSubtotal;
            return this.totalScore;
        }

        // Methods that set the subtotals to the values passed through it from the Game Form
        public void setUpperSubtotal(int value)
        {
            this.upperSubtotal = value;
        }

        public void setLowerSubtotal(int value)
        {
            this.lowerSubtotal = value;
        }

        // Method that returns the player's nae as a string
        public string getName()
        {
            return this.name;
        }

    
    }
}
