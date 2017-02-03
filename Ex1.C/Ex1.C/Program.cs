using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.C
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;

            Console.WriteLine("Enter the radius of a circle:"); // Ask for a radius

            r = Convert.ToDouble(Console.ReadLine()); // Read number

            Console.WriteLine($"Given the circle with radius {r}, the perimeter is {2*Math.PI*r:0.00}, and its area is {Math.PI*r*r:0.00}"); // Print results limited to two decimal places

            Console.Read(); // Wait for the user to end the program
        }
    }
}
