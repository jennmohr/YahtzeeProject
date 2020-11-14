// Jennifer Mohr & Nazmun Nahar
// CIS 3309 Section 001
// Sunday, April 5th, 2020
// Game Project - Yahtzee Game

// Upper Section Class 
// A class that contains a player's values for the upper section of the YAHTZEE score card

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class UpperSection
    {
        // Attributes that hold the player's values for each category

        int ones;
        int twos;
        int threes;
        int fours;
        int fives;
        int sixes;

        // Constructor for Upper Section
        public UpperSection()
        {
            this.ones = 0;
            this.twos = 0;
            this.threes = 0;
            this.fours = 0;
            this.fives = 0;
            this.sixes = 0;
        }

        // Adds up the columns in the lower section and returns the subtotal
        public int getUpperSubtotal()
        {
            return this.ones + this.twos + this.threes + this.fours + this.fives + this.sixes;
        }

        // Returns the value of the bonus, 35 if the subtotal is greater than or equal to 63
        public int getBonus()
        {
            int upperSubtotal = getUpperSubtotal();
            if (upperSubtotal >= 63)
            {
                return 35;
            }
            else
            {
                return 0;
            }
        }

        // Method that adds up the bonus and the subtotal to get the final total of the upper section
        public int getUpperTotal()
        {
            int upperSubtotal = getUpperSubtotal();
            return upperSubtotal + getBonus();
        }

        // Methods to set the players' category values based on the values relevant to the catergories and the players' rolls 
        public void setOnes(int value)
        {
            this.ones = value;
        }

        public void setTwos(int value)
        {
            this.twos = value;
        }

        public void setThrees(int value)
        {
            this.threes = value;
        }

        public void setFours(int value)
        {
            this.fours = value;
        }

        public void setFives(int value)
        {
            this.fives = value;
        }

        public void setSixes(int value)
        {
            this.sixes = value;
        }
    }
}