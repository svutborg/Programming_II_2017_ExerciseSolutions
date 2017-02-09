using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Enter the lengths of the two chateti of a right angled triangle:"); // Ask for two chateti of a right angle triangle to be entered

            a = Convert.ToDouble(Console.ReadLine()); // Store the two entered numbers
            b = Convert.ToDouble(Console.ReadLine());

            RightAngleTriangle T = new RightAngleTriangle(a, b); // Create the new triangle object T

            Console.WriteLine("The entered triangle is the following properties:"); 
            Console.WriteLine(T.ToString()); // Print the properties of the triangle using T's to string method

            Console.Read(); // Wait for the user to colse the program
        }
    }
}
