using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_Part_A.RPS
{
    public enum RPS_Players
    {
        NONE,
        COMPUTER,
        PLAYER
    }

    public enum RPS_Choices
    {
        UNKOWN,
        ROCK,
        PAPER,
        SCISSORS,
    }

    /// <summary>
    /// This class plays ...
    /// Author: Dylan Hamilton
    /// Started: 12/02/2019
    /// Modified : 26/02/2020
    /// </summary>
    public class RPS_Game
    {
        public const string COMPUTER_NAME = "Computer";

        public string PlayerName { get; set; }
        //public string ComputerName { get; set; }
        public string WinnerName { get; set; }

        public RPS_Choices ComputerChoice { get; set; }
        public RPS_Choices PlayerChoice { get; set; }

        private Random randomGenerator = new Random();

        public int ComputerScore { get; set; }
        public int PlayerScore { get; set; }

        public void Start(string player)
        {
            PlayerName = player;
            WinnerName = "Unkown";
            PlayerScore = 0;
            ComputerScore = 0;
        }

        /// <summary>
        /// This generates a random choice for the 
        /// computer based on the number rolled.
        /// </summary>
        public void GetComputerChoice()
        {
            int choice;
            choice = randomGenerator.Next(3);

            if (choice == 0)
            {
                ComputerChoice = RPS_Choices.ROCK;
            }
            else if (choice == 1)
            {
                ComputerChoice = RPS_Choices.PAPER;
            }
            else
            {
                ComputerChoice = RPS_Choices.SCISSORS;
            }
        }


        /// <summary>
        /// This method will show whether the computer
        /// or player has won or if they have drawn
        /// </summary>
        public void WorkoutWinner()
        {
            if (PlayerChoice == ComputerChoice)
            {
                WinnerName = "You have Drawn!!!";
                ComputerScore++;
                PlayerScore++;
            }
            else if (PlayerChoice == RPS_Choices.ROCK && ComputerChoice == RPS_Choices.SCISSORS)
            {
                WinnerName = PlayerName;
                PlayerScore++;
            }
            else if (PlayerChoice == RPS_Choices.PAPER && ComputerChoice == RPS_Choices.ROCK)
            {
                WinnerName = PlayerName;
                PlayerScore++;
            }
            else if (PlayerChoice == RPS_Choices.SCISSORS && ComputerChoice == RPS_Choices.PAPER)
            {
                WinnerName = PlayerName;
                PlayerScore++;
            }
            else if (PlayerChoice == RPS_Choices.SCISSORS && ComputerChoice == RPS_Choices.ROCK)
            {
                WinnerName = COMPUTER_NAME;
                ComputerScore++;
            }
            else if (PlayerChoice == RPS_Choices.ROCK && ComputerChoice == RPS_Choices.PAPER)
            {
                WinnerName = COMPUTER_NAME;
                ComputerScore++;
            }
            else
            {
                WinnerName = COMPUTER_NAME;
                ComputerScore++;
            }
        }
    }
}
