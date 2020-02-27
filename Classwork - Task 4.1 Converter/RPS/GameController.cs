using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_Part_A.RPS

{
    /// <summary>
    /// Thuis class will handle the input and output
    /// of the RPS Game
    /// </summary>
    public class GameController
    {
        public static string Title = "Rock-Paper-Scissors Game";

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
                //game.ComputerChoice = RPS_Choices.PAPER;

                ShowChoices();

                game.WorkoutWinner();
                ShowResult();

                Console.WriteLine();
                Console.Write("Press any key!");
                Console.ReadKey();
            }

            EndGame();
        }

        /// <summary>
        /// This methods displays the overall winner
        /// and then puts the correct drawing for a win,
        /// draw or loss.
        /// </summary>
        private void EndGame()
        {
            Console.Clear();
            SimpleIO.WriteTitle(Title, "Week 3");

            Console.WriteLine("The overall winner is " + game.WinnerName);

            if(game.WinnerName == game.PlayerName)
            {
                Images.DrawThumbsUp();
            }
            else if(game.WinnerName == RPS_Game.COMPUTER_NAME)
            {
                Images.DrawThumbsDown();
            }
            else
            {
                Images.DrawSmile();
            }
        }

        /// <summary>
        /// This method gets the players choice,
        /// and shows the round number.
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
        /// This method shows the choices made by the user
        /// and the computer.
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
        /// This method shows the winner of the round
        /// or if the player and computer drew, and then 
        /// it shows the current winner of the game with 
        /// both players scores.
        /// </summary>
        private void ShowResult()
        {
            if (game.WinnerName == game.PlayerName)
            {
                Console.WriteLine("\t" + game.PlayerName + " has won this round!");
            }
            else if (game.WinnerName == RPS_Game.COMPUTER_NAME)
            {
                Console.WriteLine("\t" + RPS_Game.COMPUTER_NAME + " has won this round");
            }
            else
            {
                Console.WriteLine("\t You have drawn!");
            }


            if (game.PlayerScore > game.ComputerScore)
            {
                game.WinnerName = game.PlayerName;
            }
            else if (game.ComputerScore > game.PlayerScore)
            {
                game.WinnerName = RPS_Game.COMPUTER_NAME;
            }
            else
            {
                game.WinnerName = "you have drawn!";
            }

            Console.WriteLine();
            Console.WriteLine("\t" + game.PlayerName + "'s score = " + game.PlayerScore);
            Console.WriteLine("\tThe Computer score = " + game.ComputerScore);
            Console.WriteLine("\tThe current winner is " + game.WinnerName);
        }


        /// <summary>
        /// This method sets the window size
        /// and the colours of the game.
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
        /// This method starts the game
        /// and sets the player name.
        /// </summary>
        private void StartGame()
        {
            SimpleIO.WriteTitle(Title, "Week 3");
            game.Start("Dylan");
        }
    }
}
