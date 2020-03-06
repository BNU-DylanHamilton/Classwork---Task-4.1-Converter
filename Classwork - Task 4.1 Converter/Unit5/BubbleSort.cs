using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_Part_A.Unit5
{
    /// <summary>
    /// This class sorts user inputted numbers into
    /// numerical order and then displays them.
    /// 
    /// Author: Dylan Hamilton
    /// </summary>
    class BubbleSort
    {
        const int MAX_NUMBERS = 6;

        private int[] numbers = new int[MAX_NUMBERS];

        /// <summary>
        /// This method asks the user to
        /// input the numbers required for
        /// the array.
        /// </summary>
        public void InputNumbers()
        {
            SimpleIO.WriteTitle("Sorting", "5.4");
            for(int i = 0; i < MAX_NUMBERS; i++)
            {
                Console.Write("Please enter a value. ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        /// <summary>
        /// This method shows the numbers
        /// in their numerical order.
        /// </summary>
        public void Display()
        {
            Console.Clear();
            SimpleIO.WriteTitle("Sorting", "5.4");
            for (int i = 0; i < MAX_NUMBERS; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        /// <summary>
        /// This method has a loop inside a loop which
        /// sorts all of the inputs into numerical 
        /// order.
        /// </summary>
        public void SortNumbers()
        {
            for(int i = 0; i < MAX_NUMBERS; i++)
            {
                for(int index = 0; index < (MAX_NUMBERS - 1); index++)
                {
                    if(numbers[index] > numbers[index + 1])
                    {
                        int temp = 0;
                        temp = numbers[index];
                        numbers[index] = numbers[index + 1];
                        numbers[index + 1] = temp;
                    }
                }
            }
        }
    }
}
