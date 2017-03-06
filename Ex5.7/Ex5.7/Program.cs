using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string TestString = "C# is not C++ and PHP is not Delphi"; // Teststring
            string[] s_split = TestString.Split(' '); // Split the string into an array of strings for every space in the string
            string TestStringReversed = ""; // make a new string to hold the reversed string
            for(int i = s_split.Length - 1; i > 0; i--)
            {   // Piece together the string in reverse (from last index to first)
                TestStringReversed += s_split[i] + ' ';
            }
            if(s_split.Length >= 1)
            {   // add the last element without a trailing space
                TestStringReversed += s_split[0];
            }
            Console.WriteLine($"\"{TestString}\"\nreversed is: \"{TestStringReversed}\""); // Print result
            Console.Read(); // Wait for user to terminate the program
        }
    }
}
