using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_FrequencyInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };
            int[] count = new int[15];

            for (int i = 0; i < 15; i++)
            {
                for (int x = 0; x < numbers.Length; x++)
                {
                    if (numbers[x] == i)
                    {
                        count[i]++;
                    }

                }
            }
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Number {i} appears {count[i]} times");
            }

        }
    }
}
