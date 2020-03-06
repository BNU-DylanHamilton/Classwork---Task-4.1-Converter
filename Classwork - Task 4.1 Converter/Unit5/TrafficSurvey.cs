using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_Part_A.Unit5
{
    class TrafficSurvey
    {
        const int MAX_HOURS = 24;

        private int[] hours = new int[MAX_HOURS];

        public void TrafficCount()
        {
            SimpleIO.WriteTitle("Traffic Survey", "5.5");

            for (int i = 0; i < MAX_HOURS; i++)
            {
                Console.Write("Please enter the traffic count: ");
                hours[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void ShowTotal()
        {
            int sum = 0;
            for(int i = 0; i < MAX_HOURS; i++)
            {
                sum += hours[i];
            }
            Console.WriteLine();
            Console.WriteLine("The total cars within the 24 hour period is " + sum);
        }

        public void Busiest()
        {
            
        }
    }
}
