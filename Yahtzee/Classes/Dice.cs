// Jennifer Mohr & Nazmun Nahar
// CIS 3309 Section 001
// Sunday, April 5th, 2020
// Game Project - Yahtzee Game

// Dice Class 
// A class that represents a single dice, handles the rolling of a single dice, contains its value and whether or not it is held

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Dice
    {
        int value;
        bool held;


        // Constructor for Dice Object that sets the dice to a random value when instantiated
        public Dice()
        {
            this.held = false;
            this.value = roll();
        }


        // Get method that returns the value of the dice
        public int getValue()
        {
            return value;
        }

        // Set value method that sets the dice value to the new rolled number
        public void setValue(int value)
        {
            this.value = value;
        }

        // Method that switches the dice's hold value from what it was initially, is called when the Hold checkbox is checked or unchecked
        public void switchCheck()
        {
            if(this.held == false)
            {
                this.held = true;
            }
            else
            {
                this.held = false;
            }
        }

        // Method that sets the calue of the dice to a random int from 1-6, if the dice is being held it doesn't reroll it
        public int roll()
        {
            if (held)
            {
                return this.value;
            }

            int rolledValue;
            rolledValue = Globals.rnd.Next(1, 7);
            this.value = rolledValue;
            return value;
        }
    }
}
