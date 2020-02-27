using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_Part_A.SPF
{
    /// <summary>
    /// Thuis class will handle the input and output
    /// of the SPS Game
    /// </summary>
    public class GameController
    {
        public static string Title = "Scissors-Paper-Stone Game";

        public const string ROCK = "ROCK";
        public const string PAPER = "PAPER";
        public const string SCISSORS = "SCISSORS";

        public const int MAXN_TURNS = 3;

        private RPS_Game game = new RPS_Game();

        private int turn;

        public void RunGame()
        {
            SetupScreen();
            StartGame();

            for (turn = 1; turn <= MAXN_TURNS; turn++)
            {
                GetPlayerChoice();
                game.GetComputerChoice();

                ShowChoices();

                game.WorkoutWinner();
                ShowResult();

                Console.WriteLine();
                Console.Write("Press any key!");
                Console.ReadKey();
            }

            game.End();

            EndGame();
        }

        /// <summary>
        /// 
        /// </summary>
        private void EndGame()
        {
            Console.Clear();
            SimpleIO.WriteTitle(Title, "Week 3");

            Console.WriteLine("The overall winner is " + game.WinnerName);
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void GetPlayerChoice()
        {
            Console.Clear();
            SimpleIO.WriteTitle(Title, "Week 3");

            Console.WriteLine("Turn no " + turn + " of " + MAXN_TURNS);

            string[] choices = new string[]
            {
                ROCK,
                PAPER,
                SCISSORS
            };

            int choiceNo = SimpleIO.GetChoice(choices);

            if (choiceNo == 1)
            {
                game.PlayerChoice = RPS_Choices.ROCK;
            }
            else if (choiceNo == 2)
            {
                game.PlayerChoice = RPS_Choices.PAPER;

            }
            else game.PlayerChoice = RPS_Choices.SCISSORS;

            Console.WriteLine();
        }

        /// <summary>
        /// This method draws out an image of the choice for
        /// either the computer, or the player.  The player's
        /// choice is drawn at (x = 5, y = 14) and the computers 
        /// choice at (x = 50, y = 14)
        /// </summary>
        private void DrawChoice(RPS_Players player)
        {
            RPS_Choices choice;

            int x;
            int y = 14;

            if (player == RPS_Players.COMPUTER)
            {
                x = 50;
                choice = game.ComputerChoice;
            }
            else
            {
                choice = game.PlayerChoice;
                x = 5;
            }

            if (choice == RPS_Choices.SCISSORS)
            {
                Images.DrawScissors(x, y);
            }
            else if (choice == RPS_Choices.PAPER)
            {
                Images.DrawPaper(x, y);
            }
            else if (choice == RPS_Choices.ROCK)
            {
                Images.DrawStone(x, y);
            }
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void ShowChoices()
        {
            DrawChoice(RPS_Players.PLAYER);
            DrawChoice(RPS_Players.COMPUTER);

            Console.WriteLine("\n\tYou picked " + game.PlayerChoice);
            Console.WriteLine("\tThe computer choice is " + game.ComputerChoice);
            Console.WriteLine();
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void ShowResult()
        {
            Console.WriteLine("\tThe player score = " + game.PlayerScore);
            Console.WriteLine("\tThe Computer score = " + game.ComputerScore);

            if (game.PlayerScore > game.ComputerScore)
            {
                game.WinnerName = game.PlayerName;
                Console.WriteLine("\tThe player has won ");
            }
            else if (game.ComputerScore > game.PlayerScore)
            {
                game.WinnerName = RPS_Game.COMPUTER_NAME;
                Console.WriteLine("\tThe computer has won ");
            }
            else
            {
                game.WinnerName = "you have drawn!";
            }
            Console.WriteLine();
            Console.WriteLine("\tThe current winner is the " + game.WinnerName);
        }


        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void SetupScreen()
        {
            Console.Title = Title;

            Console.SetWindowSize(100, 36);
            Console.SetBufferSize(100, 36);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();  // clear screen in chosen colour
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void StartGame()
        {
            SimpleIO.WriteTitle(Title, "Week 3");
            game.Start("Dylan");
        }
    }
}
