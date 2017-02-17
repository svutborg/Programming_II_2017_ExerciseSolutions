using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialise array of 1000 random elements
            int[] test = new int[1000];
            Random rand = new Random();
            for(int i = 0; i < test.Length; i++)
            {
                test[i] = rand.Next(-1000, 1000);
            }
            
            Sort.QuickSort(test); // Sort the array
            PrintArray(test); // Print the sorted array
            Console.Read();
        }

        /// <summary>
        /// Prints an array of integers, give an optinal start and stop index.
        /// If no start and stop index is provided, the entire array is printed
        /// It will be printed in the following format:
        ///     [ ##, ##, ##, ## ]
        /// </summary>
        /// <param name="arr">The array to print</param>
        /// <param name="startIndex">The starting index for the printing</param>
        /// <param name="stopIndex">The stop index for printing</param>
        public static void PrintArray(int[] arr, int startIndex = 0, int stopIndex = 0)
        {
            Console.Write("[ "); 
            if(stopIndex == 0)
            {
                stopIndex = arr.Length - 1;
            }
            for (int i = startIndex; i < stopIndex + 1; i++)
            {
                Console.Write(arr[i]);
                if (i != stopIndex)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" ]");
        }
    }
}
