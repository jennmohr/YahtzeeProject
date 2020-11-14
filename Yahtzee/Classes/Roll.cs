// Jennifer Mohr & Nazmun Nahar
// CIS 3309 Section 001
// Sunday, April 5th, 2020
// Game Project - Yahtzee Game

// Roll Class 
// A class that represents a single roll of the dice for one player, deals with rolling each dice and validating whether they fit
// the criteria needed in each category. Also gets the sum of the roll and the sum of a certain dice value (for the upper section)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Roll
    {
        public Dice[] DiceRoll = new Dice[5];

        // Constructor for the array of dice, which represents a roll
        public Roll()
        {
            DiceRoll[0] = new Dice();
            DiceRoll[1] = new Dice();
            DiceRoll[2] = new Dice();
            DiceRoll[3] = new Dice();
            DiceRoll[4] = new Dice();
        }

        // Get method for the roll
        public Dice[] getDiceRoll()
        {
            return DiceRoll;
        }

        // Method that rolls/rerolls all of the dice in the array
        public void rollTheDice()
        {
            foreach (Dice die in DiceRoll){
                die.setValue(die.roll());
            }
        }

        // Checks the roll to see if there is at least three of the same dice value
        public bool checkThreeOfAKind()
        {
            bool threeOfAKind = false;

            for (int i = 1; i <= 6; i++)
            {
                int count = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (DiceRoll[j].getValue() == i)
                        count++;

                    if (count > 2)
                        threeOfAKind = true;
                }
            }

            return threeOfAKind;
        }


        // Checks the roll to see if there is at least four of the same dice value
        public bool checkFourOfAKind()
        {
            bool fourOfAKind = false;

            for (int i = 1; i <= 6; i++)
            {
                int count = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (DiceRoll[j].getValue() == i)
                        count++;

                    if (count > 3)
                        fourOfAKind = true;
                }
            }

            return fourOfAKind;
        }

        // Checks the roll to see if there is two of one dice value and three of another dice value
        public bool checkFullHouse()
        {
            bool fullHouse = false;

            int[] diceArr = makeArray();

            Array.Sort(diceArr);

            if ((diceArr[0] == diceArr[1] && diceArr[1] == diceArr[2] && diceArr[3] == diceArr[4] && diceArr[2] != diceArr[3])
                || (diceArr[0] == diceArr[1] && diceArr[2] == diceArr[3] && diceArr[3] == diceArr[4] && diceArr[1] != diceArr[2]))
            {
                fullHouse = true;
            }

            return fullHouse;
        }

        // Checks the roll to see if there is a small straight combination (1, 2, 3, 4), (2, 3, 4, 5), (3, 4, 5, 6)
        public bool checkSmallStraight()
        {
            bool smallStraight = false;

            int count = 0;

            int[] diceArr = makeArray();

            Array.Sort(diceArr);

            int one = diceArr[0];
            int two = diceArr[1];
            int three = diceArr[2];
            int four = diceArr[3];
            int five = diceArr[4];


            for(int i = 1; i < 5; i++)
            {
                if(diceArr[i] == diceArr[i - 1] + 1)
                {
                    count++;

                }else if(diceArr[i] == diceArr[i - 1]){

                }else{
                    smallStraight = false;
                }

               
            }

            if (count >= 3)
            {
                smallStraight = true;
            }

            return smallStraight;
        }

        // Checks the roll to see if there is a large straight combination (1, 2, 3, 4, 5) or (2, 3, 4, 5, 6)
        public bool checkLargeStraight()
        {
            bool largeStraight = false;

            int[] diceArr = makeArray();

            Array.Sort(diceArr);

            if(diceArr[0] == 1 && diceArr[1] == 2 && diceArr[2] == 3 && diceArr[3] == 4 && diceArr[4] == 5)
            {
                largeStraight = true;
            }else if (diceArr[0] == 2 && diceArr[1] == 3 && diceArr[2] == 4 && diceArr[3] == 5 && diceArr[4] == 6)
            {
                largeStraight = true;
            }

            return largeStraight;
        }


        // Checks the roll to see if there is five of the same dice value
        public bool checkYahtzee()
        {
            bool Yahtzee = false;

            for (int i = 1; i <= 6; i++)
            {
                int count = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (DiceRoll[j].getValue() == i)
                        count++;

                    if (count == 5)
                        Yahtzee = true;
                }
            }

            return Yahtzee;
        }

        // Method that adds up the value of each dice in the roll
        public int getSum()
        {
            int sum = DiceRoll[0].getValue() + DiceRoll[1].getValue() + DiceRoll[2].getValue() + DiceRoll[3].getValue() + DiceRoll[4].getValue();

            return sum;
        }


        // Method that adds up only the values of the dice that correspond to the number passed through (for the upper section)
        public int getUpper(int num)
        {
            int upperSum = 0;

            for(int i = 0; i < 5; i++)
            {
                if(DiceRoll[i].getValue() == num)
                {
                    upperSum += num;
                }
            }

            return upperSum;
        }


        // Method that makes an array of ints out of the values for the array of dice in a roll, this is so that it can be sorted
        // and analyzed for validating the roll's categories
        public int[] makeArray()
        {
            int[] newArray = new int[5];
            for(int i = 0; i < 5; i++)
            {
                newArray[i] = DiceRoll[i].getValue();
            }

            return newArray;
        }

    }
}
