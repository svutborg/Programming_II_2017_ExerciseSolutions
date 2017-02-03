using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.A
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, h;

            Console.WriteLine("Enter the width and height of a rectangle"); // Ask the user for two entries
            
            w = Convert.ToInt32(Console.ReadLine()); // store entry one as the width
            h = Convert.ToInt32(Console.ReadLine()); // store entry two as the height

            Console.WriteLine($"The perimiter of rectangle {w}x{h} is: {2 * w + 2 * h}"); // print the perimiter of the given rectangle
            Console.WriteLine($"The area of rectangle {w}x{h} is:      {w * h}"); // print the area of the given rectangle

            Console.Read(); // wait for user input
        }
    }
}
