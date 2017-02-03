using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your current age?"); // Ask for the users current age
            Console.WriteLine($"In 10 years you will be: {Convert.ToInt16(Console.ReadLine()) + 10}"); // read entry and display back in context


            System.Threading.Thread.Sleep(2000); // Optional: wait for 2 seconds to give the user a chance to see the displayed message
        }
    }
}
