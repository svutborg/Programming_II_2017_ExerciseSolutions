using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            Console.WriteLine("Enter three numbers"); // ask for three numbers

            i = Convert.ToInt32(Console.ReadLine()); // store numbers
            j = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            
            /* write which is the larger of the three (GetMax is returned twice, once with the two first numbers 
             * and once more with the larger of the first two and the third number*/
            Console.WriteLine($"{GetMax(GetMax(i, j), k)} is the larger of {i}, {j} and {k}"); 

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
