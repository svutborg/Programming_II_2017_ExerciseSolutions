using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a line of text:"); // ask for a line of text
            string s = Console.ReadLine(); // tead a line fo text from the commandline

            Console.Write("What you entered will become ");
            for(int i = s.Length - 1; i >= 0; i--)
            {   // Print charcter by charcter in reverse order
                Console.Write(s[i]);
            }
            Console.Write(" in reverse order.");
            Console.Read(); // wait for the user to terminate the program
        }
    }
}
