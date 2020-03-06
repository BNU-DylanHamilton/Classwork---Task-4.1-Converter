using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_Part_A.Unit5
{
    /// <summary>
    /// Task 5.1 and Task 5.3
    /// This class gets and displays an array of tournament scores for 
    /// an array of players (names)
    /// 
    /// Dylan Hamilton
    /// </summary>
    public class Tournament
    {
        const int MAXN_SCORES = 6;

        // Another way of initialising attributes
        private int[] scores;

        //Not created yet
        private string[] names;

        /// <summary>
        /// Class Constructor (not needed)
        /// </summary>
        public Tournament()
        {
            scores = new int[MAXN_SCORES];
            names = new string[]
            {
                "Godfrey",
                "Eric",
                "Georgia",
                "Dylan",
                "Oluyemi",
                "Shamial",
                "Numan",
                "Liam",
                "Gita"
            };
        }

        /// <summary>
        /// This method will get the user to enter
        /// the names for the tournament and then
        /// get the user to enter their scores.
        /// </summary>
        public void GetDetails()
        {
            SimpleIO.WriteTitle("Enter Tournament Scores", "Task 5.3");

            for (int i = 0; i < MAXN_SCORES; i++)
            {
                Console.Write("Enter name for player " + (i + 1) + " > ");
                names[i] = Console.ReadLine();

                Console.Write("Enter score for " + names[i] + " > ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }            
        }

        public void GetScores()
        {
            SimpleIO.WriteTitle("Enter Tournament Scores", "Task 5.1");

            for (int i = 0; i < MAXN_SCORES; i++)
            {
                Console.Write("Enter score for player " + (i + 1) + " > ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }


        /// <summary>
        /// This method will take the two arrays and
        /// will display the scores each player got.
        /// </summary>
        public void ShowScores()
        {
            SimpleIO.WriteTitle("Show Tournament Scores", "Task 5.3");

            for (int i = 0; i < MAXN_SCORES; i++)
            {
                Console.WriteLine(names[i] + " scored " + scores[i]);
            }
        }
    }
}
