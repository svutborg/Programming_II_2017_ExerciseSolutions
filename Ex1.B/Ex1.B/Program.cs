using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.B
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;

            Console.WriteLine("Enter three numbers"); // ask the user to enter three numbers

            i = Convert.ToInt32(Console.ReadLine()); // Store the three entered numbers
            j = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The sum of {i}, {j} and {k} is: {i+j+k}"); // print the entered numbers and their sum

            Console.Read(); // Wait for user to end the program
        }
    }
}
