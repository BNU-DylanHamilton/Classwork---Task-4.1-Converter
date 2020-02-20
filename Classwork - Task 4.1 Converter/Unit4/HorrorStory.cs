using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_Part_A.Unit4
{
    /// <summary>
    /// This class will create a horror
    /// story for the reader using their
    /// inputs.
    /// 
    /// Author: Dylan Hamilton
    /// </summary>
    class HorrorStory
    {
        // Attributes of Book

        private string author, name, town, companion;
        private string animal, weapon, job, gender, location;

        /// <summary>
        /// Prompt the user for an answer as a string and return it
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns>answer</returns>
        public string Ask(string prompt)
        {
            string answer;
            Console.Write(prompt);
            answer = Console.ReadLine();
            return answer;
        }

        /// <summary>
        /// Get the details of the author, name, town, animal
        /// job and weapon used in the books stories
        /// </summary>
        public void GetDetails() // keep using ask() to get information
        {
            author = Ask("Please type your name : ");
            name = Ask("Please type a friend's name : ");
            town = Ask("Now give me the name of a town : ");
            animal = Ask("Now a type of animal : ");
            job = Ask("Now a type of job : ");
            weapon = Ask("And your weapon of choice : ");
            gender = Ask("Now what is your gender : ");
            companion = Ask("What is the name of your companion : ");
            location = Ask("Where will you be travelling to : ");

        }

        /// <summary>
        /// This method creates a the first chapter of a story using 
        /// all the attributes of the class
        /// </summary>
        public void WriteChapter1()
        {
            Console.Clear();

            Console.WriteLine("A Horror Story : by " + author);
            Console.WriteLine("===============================");

            Console.WriteLine("It was a dark night in " + town + " and " + name
                + " could hear " + animal + "s screaming in the distance.");

            Console.WriteLine(name + " staggered terrified through the streets of "
                + town + ", realising " + checkGender(gender) + " had been followed.");

            Console.WriteLine("In the shadow of a doorway, a demented " + job
                + " waited, clutching a menacing " + weapon);
        }

        /// <summary>
        /// This method checks the gender that the user supplies
        /// and then places the correct gender value in the story.
        /// </summary>
        public string checkGender(string gender)
        {
            string answer;

            if (gender == "female")
            {
                answer = "she";
            }
            else
            {
                answer = "he";
            }
            return answer;
        }

        public void writeChapter2()
        {
            Console.WriteLine("When ");
        }

        public HorrorStory()
        {
            author = "Dylan";
            name = "Rhys";
            town = "Aylesbury";
            animal = "wolves";
            job = "blacksmith";
            weapon = "morning star";
            gender = "male";
            companion = "Andrew";
            location = "Wendover";
        }
    }
}
