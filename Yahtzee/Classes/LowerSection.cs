// Jennifer Mohr & Nazmun Nahar
// CIS 3309 Section 001
// Sunday, April 5th, 2020
// Game Project - Yahtzee Game

// Lower Section Class 
// A class that contains a player's values for the lower section of the YAHTZEE score card

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class LowerSection
    {

        // Constants for categories that have pre-set values

        int fullHouseConst = 25;
        int smallStraightConst = 30;
        int largeStraightConst = 40;
        int YAHTZEEConst = 50;

        // Attributes that hold the player's values for each category

        int threeOfAKind;
        int fourOfAKind;
        int fullHouse;
        int smallStraight;
        int largeStraight;
        int YAHTZEE;
        int chance;

        // Constructor for Lower Section
        public LowerSection()
        {
            this.threeOfAKind = 0;
            this.fourOfAKind = 0;
            this.fullHouse = 0;
            this.smallStraight = 0;
            this.largeStraight = 0;
            this.YAHTZEE = 0;
            this.chance = 0;
        }


        // Adds up the columns in the lower section and returns the total
        public int getLowerTotal()
        {
            return this.threeOfAKind + this.fourOfAKind + this.fullHouse + this.smallStraight + this.largeStraight + this.YAHTZEE + this.chance;
        } 


        // Get methods for the lower section constants
        public int getFullHouseVal()
        {
            return fullHouseConst;
        }

        public int getSmallStraightVal()
        {
            return smallStraightConst;
        }

        public int getLargeStraightVal()
        {
            return largeStraightConst;
        }

        public int getYahtzeeVal()
        {
            return YAHTZEEConst;
        }


        // Methods to set the players' category values based on the values relevant to the catergories and the players' rolls
        public void setThreeOfAKind(int value)
        {
            this.threeOfAKind = value;
        }

        public void setFourOfAKind(int value)
        {
            this.fourOfAKind = value;
        }

        public void setFullHouse(int value)
        {
            this.fullHouse = value;
        }

        public void setSmallStraight(int value)
        {
            this.smallStraight = value;
        }

        public void setLargeStraight(int value)
        {
            this.largeStraight = value;
        }

        public void setChance(int value)
        {
            this.chance = value;
        }

        public void setYahtzee(int value)
        {
            this.YAHTZEE = value;
        }
    }
}
