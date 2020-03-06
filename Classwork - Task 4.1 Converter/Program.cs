using System;

namespace CO453_Part_A
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestDistanceConverter();
            //TestBook();
            //TestTournament();
            //TestMP3Chart();
            //TestBMI();
            TestRPS_Game();
            //TestBatesMotel();
            //TestTrafficSurvey();
            //TestBubbleSort();
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

            string details;

            SimpleIO.WriteTitle("Horror Story", "4.3");

            Console.Write("Would you like to enter your own details? (y/n) ");
            details = Console.ReadLine();

            if(details == "y")
            {
                Book.GetDetails();
            }

            Book.WriteChapter1();
            Book.WriteChapter2();
        }

        public static void TestTournament()
        {
            Unit5.Tournament tournament = new Unit5.Tournament();

            tournament.GetDetails();
            tournament.ShowScores();
        }

        public static void TestMP3Chart()
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

        public static void TestBMI()
        {
            Unit4.BMI BMI = new Unit4.BMI();

            BMI.GetDetails();
            BMI.CalculateBMI();
            BMI.DisplayBMI();
        }

        public static void TestRPS_Game()
        {
            RPS.GameController controller = new RPS.GameController();
            controller.RunGame();
        }

        public static void TestBatesMotel()
        {
            Unit5.BatesMotel motel = new Unit5.BatesMotel();

            SimpleIO.WriteTitle("The Bates Motel", "Task 5.6");

            string[] choices =
            {
                "1. Book a Room",
                "2. Vacate a Room",
                "3. Display All Rooms",
                "4. Vacate All Rooms",
                "5. Quit"
            };

            int choice = SimpleIO.GetChoice(choices);

            switch (choice)
            {
                case 1:
                    motel.Book(1, 2);
                    break;

                default:
                    break;
            }
        }

        public static void TestTrafficSurvey()
        {
            Unit5.TrafficSurvey survey = new Unit5.TrafficSurvey();

            survey.TrafficCount();
            survey.ShowTotal();
        }

        public static void TestBubbleSort()
        {
            Unit5.BubbleSort sorting = new Unit5.BubbleSort();

            sorting.InputNumbers();
            sorting.SortNumbers();
            sorting.Display();
        }
    }
}
