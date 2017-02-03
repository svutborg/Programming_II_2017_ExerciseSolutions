using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");

            int i = Convert.ToInt32(Console.ReadLine()); // read a number from the console

            if (i%2 == 0) // the modulo operation will provide the memainder of the integer division by 2 (will check if 2 goes into the number)
            {
                Console.WriteLine($"{i} is even");
            }
            else
            {
                Console.WriteLine($"{i} is odd");
            }

            System.Threading.Thread.Sleep(5000); // Optional: wait for 5 seconds to give the user a chance to see the displayed message
        }
    }
}
