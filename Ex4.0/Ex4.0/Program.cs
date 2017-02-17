using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:"); // Ask user to enter name
            Console.WriteLine($"Hello, {Console.ReadLine()}!"); // Print what is entered inside a string 

            Console.Read(); // Wait for the user to terminate the program
        }
    }
}
