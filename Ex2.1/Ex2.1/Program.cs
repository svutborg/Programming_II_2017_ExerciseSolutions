using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter two numbers"); // ask for two numbers

            i = Convert.ToInt32(Console.ReadLine()); // store numbers
            j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{GetMax(i,j)} is the larger of {i} and {j}"); // write which is the larger of the two

            Console.Read(); // Wait for the user to end the program
        }

        static int GetMax(int a, int b)
        {
            if (a > b) // return the larger of the two numbers, is case of equal numbers b will be returned
                return a;
            else
                return b;
        }
    }
}
