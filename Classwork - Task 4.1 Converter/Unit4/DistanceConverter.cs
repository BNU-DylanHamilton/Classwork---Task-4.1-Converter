using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_Part_A.Unit4
{
    /// <summary>
    /// This class will convert miles to whole feet
    /// or feet to miles
    /// 
    /// Author: Dylan Hamilton
    /// </summary>
    public class DistanceConverter
    {
        /// <summary>
        /// This method will take a number of
        /// miles and convert them to feet
        /// </summary>
        /// <returns></returns>
        public double ToFeet(double miles)
        {
            return (miles * 1760 * 3);
        }

        /// <summary>
        /// This method will take a number of
        /// feet and convert them to miles
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>

        public double ToMiles(double feet)
        {
            return (feet / 1760 / 3);
        }

        /// <summary>
        /// This method will ask the user to 
        /// enter the number of miles/feet.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>

        public double GetDouble(string prompt)
        {
            Console.Write("Please enter the number of " + prompt + ": ");
            double number = Convert.ToDouble(Console.ReadLine());

            return number;
        }
    }
}
