using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.";  // sample text
            string[] forbiddenWords = "C#,CLR,Microsoft".Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries); // make list of forbidden words

            Console.WriteLine("Provided text:");
            Console.WriteLine(text); // display the provided text

            foreach(string word in forbiddenWords) // for each forbidden word replace all occurences of that word with asterisks of the same lettercount
            {
                text = text.Replace(word, new String('*', word.Length));
            }

            Console.WriteLine("Censored text"); // display censored text
            Console.WriteLine(text);
            Console.Read(); // wait for the user to serminate the program
        }
    }
}
