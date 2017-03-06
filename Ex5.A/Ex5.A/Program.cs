using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5.A
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 5; // define the number of numbers that the user needs to enter
            Console.WriteLine($"Enter {N} integer numbers"); // Ask for N numbers
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {   // read the console for N numbers
                stack.Push(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Emptying the stack of numbers");
            while(stack.Count > 0)
            {   // As long as there are numbers on the stack, pop one
                Console.WriteLine(stack.Pop());
            }
            
            Console.Read(); // Wait for the user to terminate the program
        }
    }
}
