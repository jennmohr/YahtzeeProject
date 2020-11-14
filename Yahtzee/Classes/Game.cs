// Jennifer Mohr & Nazmun Nahar
// CIS 3309 Section 001
// Sunday, April 5th, 2020
// Game Project - Yahtzee Game

// Game Class 
// A class that represents the whole game, keeps track of how many turns have been played and checks to see who the winner is.
// Also holds the Player objects of both players in the game

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Game
    {
        int turnsLeft;
        public Player PlayerOne;
        public Player PlayerTwo;


        // Constructor for the Game object, sets the turns to 26 at the start of the game
        public Game()
        {
            this.turnsLeft = 26;
            
        }

        // Creates a new player based on the name entered for Player One
        public void setPlayerOne(string playerOneName)
        {
            this.PlayerOne = new Player(playerOneName);
        }


        // Creates a new player based on the name entered for Player Two
        public void setPlayerTwo(string playerTwoName)
        {
            this.PlayerTwo = new Player(playerTwoName);
        }

        // Get method that returns how any turns are left
        public int getTurnsLeft()
        {
            return turnsLeft;
        }

        // Method that decrements the amount of turns, called after one player goes
        public void decrementTurns()
        {
            turnsLeft--;
        }

        // Method that checks to see who the winner of the game is based on the players' final total scores, returns null if 
        // it is a tie
        public Player getWinner()
        {
            Player winner;

            if(PlayerOne.getTotalScore() > PlayerTwo.getTotalScore())
            {
                winner = PlayerOne;
            }else if(PlayerOne.getTotalScore() < PlayerTwo.getTotalScore())
            {
                winner = PlayerTwo;
            }
            else
            {
                winner = null;
            }

            return winner;
        }
    }
}
