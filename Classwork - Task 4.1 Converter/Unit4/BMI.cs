using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_Part_A.Unit4
{
    class BMI
    {
        private double weight, height, bmi;

        private string measurement;

        /// <summary>
        /// In this method it will ask the user which measurement 
        /// they would like to use and will store the measurements.
        /// </summary>
        public void GetDetails()
        {
            SimpleIO.WriteTitle("Body Mass Index", "Task 4.4");

            do
            {
                Console.Write("Would you like to use the metric measurements (kg and metres) " +
                "or the imperial measurements (pounds and inches)? ");
                measurement = Console.ReadLine();

            } while (measurement != "metric" && measurement != "imperial");
            
            if (measurement == "metric")
            {
                Console.Write("What is your weight in kg? ");
                weight = Convert.ToDouble(Console.ReadLine());

                Console.Write("What is your height in metres? ");
                height = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.Write("What is your weight in pounds? ");
                weight = Convert.ToDouble(Console.ReadLine());

                Console.Write("What is your height in inches? ");
                height = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void CalculateBMI()
        {
            if(measurement == "metric")
            {
                bmi = weight / (height * height);
            }
            else
            {
                bmi = (weight * 703) / (height * height);
            }
        }

        public void DisplayBMI()
        {
            Console.WriteLine("Your BMI is " + bmi);

            if (bmi < 18.5)
            {
                Console.WriteLine("You are underweight.");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("You are desirable weight for size.");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("You are overweight.");
            }
            else if (bmi >= 30 && bmi < 40)
            {
                Console.WriteLine("You are obese.");
            }
            else
            {
                Console.WriteLine("You are severely obese.");
            }
        }
    }
}
