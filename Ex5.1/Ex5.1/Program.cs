using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = true;
            Console.WriteLine("Enter an arithmetic expression:"); // ask for an arithmetic expression
            string s = Console.ReadLine(); // read line into variable s

            int counter = 0; // This is a counter for brackets
            foreach(char c in s)
            {
                if(c == '(') // If a opening bracket is encountered, the counter is increased
                {
                    counter++;
                }
                else if (c == ')') // If a closing bracket is encountered, the counter is decreased
                {
                    counter--;
                }
                if(counter < 0) // If the counter goes negative, this means that there has been more closing brackets than opening brackets at this instant
                {
                    result = false;
                }
            }
            if(counter != 0) // If the counter does not end at 0 the number of closing brackets does not match the number of opening brackets
            {
                result = false;
            }
            if(result == true) // Inform the user about the result
            {
                Console.WriteLine("Pass: The parentheses were placed correctly in the entered expression.");
            }
            else
            {
                Console.WriteLine("Error: The parentheses were NOT placed correctly in the entered expression!");
            }
            Console.Read(); // Wait for the user to terminate the program
        }
    }
}
