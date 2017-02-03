using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5, B = 10, temp; // declare variables A, B nd temp

            Console.WriteLine($"A={A}, B={B}"); // Printing the values of A and B

            Console.WriteLine("Swapping values...");
            temp = A; // Swapping te values of A and B through the use of temporary varaible temp
            A = B;
            B = temp;
            
            Console.WriteLine($"A={A}, B={B}"); // Printing the new values of A and B after the swap

            System.Threading.Thread.Sleep(5000); // Optional: wait for 5 seconds to give the user a chance to see the displayed message
        }
    }
}
