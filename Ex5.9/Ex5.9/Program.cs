using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of positive integer numbers."); // Inform the user to enter numbers
            Console.WriteLine("Individual numbers are separated by a new line.");
            Console.WriteLine("Terminate sequence by entering an empty line.");
            string entry;
            List<int> entries = new List<int>();

            while ((entry = Console.ReadLine()) != "") 
            {   // Collect numbers untill the user touble tabs enter
                entries.Add(Convert.ToInt32(entry));
            }
            entries.Sort(); // Sort the list of numbers

            Console.WriteLine($"Sum of entries:     {Sum(entries)}"); // Print the sum of the numbers 
            Console.WriteLine($"Average of entries: {Average(entries)}"); // Print the average of the numbers 
            Console.WriteLine("Entered integers in assending order:"); 
            foreach(int i in entries) // Printing the sorted list
            {
                Console.WriteLine(i);
            }
            Console.Read(); // Wait for the user to terminate the program
        }

        /// <summary>
        /// Calculates the average of a list of integers, using the sum method
        /// </summary>
        /// <param name="numbers">List of numbers</param>
        /// <returns>The average of the provided numbers</returns>
        static double Average(List<int> numbers)
        {
            return Sum(numbers) / numbers.Count; // calculates and returns the average
        }

        /// <summary>
        /// Calculates the sum of a list of integers
        /// </summary>
        /// <param name="numbers">List of numbers</param>
        /// <returns>The sum of the provided numbers</returns>
        static int Sum(List<int> numbers)
        {
            int sum = 0;

            foreach(int i in numbers)
            {   // Add all numbers one by one
                sum += i; 
            }

            return sum;
        }
    }
}
