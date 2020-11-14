// Jennifer Mohr & Nazmun Nahar
// CIS 3309 Section 001
// Sunday, April 5th, 2020
// Game Project - Yahtzee Game

// Globals Class 
// A class that allows each class to access the Game and the Random class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Globals
    {
        public static Game YahtzeeGame = new Game();
        public static Random rnd = new Random();
    }
}
