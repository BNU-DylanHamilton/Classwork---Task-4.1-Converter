using System;

namespace CO453_Part_A
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestDistanceConverter();
            //TestBook();
            //Tournament();
            //MP3Chart();
        }

        public static void TestDistanceConverter()
        {
            double miles, feet;
            string outcome = "";

            Console.WriteLine("Dylan's Distance Converter");

            Unit4.DistanceConverter converter = new Unit4.DistanceConverter();

            ///<summary>
            ///The if statement below allows the user to 
            ///choose whether they would prefer to convert
            ///to miles or to feet and will run the correct
            ///code to suit their decision, and will repeat
            ///until one of the decisions have been made.
            /// </summary>

            do
            {
                Console.Write("Would you like to convert to feet, or miles? ");
                outcome = Console.ReadLine();

                if (outcome == "feet")
                {
                    miles = converter.GetDouble("miles");
                    feet = converter.ToFeet(miles);

                    Console.WriteLine("The number of feet is equal to " + feet);
                }
                else if (outcome == "miles")
                {
                    feet = converter.GetDouble("feet");
                    miles = converter.ToMiles(feet);

                    Console.WriteLine("The number of miles is equal to " + miles);
                }
            } while (outcome != "miles" && outcome != "feet");
        }

        public static void TestBook()
        {
            Unit4.HorrorStory Book = new Unit4.HorrorStory();

            Book.GetDetails();
            Book.WriteChapter1();
        }

        private static void Tournament()
        {
            Unit5.Tournament tournament = new Unit5.Tournament();

            tournament.GetDetails();
            tournament.ShowScores();
            tournament.ShowBest();
        }

        private static void MP3Chart()
        {
            Unit5.MP3Chart chart = new Unit5.MP3Chart();

            chart.ShowSongs();

            Boolean finish = false;

            while (!finish)
            {
                int songNo = chart.GetVotes();

                if(songNo == 0)
                {
                    finish = true;
                }
            }
            
            chart.ShowVotes();
        }
    }
}
