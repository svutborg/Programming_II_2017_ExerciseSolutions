using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:"); // ask for a number

            int i = Convert.ToInt32(Console.ReadLine()); // read number

            switch (i % 10) // Print the english name of the last digit 
            {
                case 0:
                    Console.WriteLine("The last digit is zero");
                    break;
                case 1:
                    Console.WriteLine("The last digit is one");
                    break;
                case 2:
                    Console.WriteLine("The last digit is two");
                    break;
                case 3:
                    Console.WriteLine("The last digit is three");
                    break;
                case 4:
                    Console.WriteLine("The last digit is four");
                    break;
                case 5:
                    Console.WriteLine("The last digit is five");
                    break;
                case 6:
                    Console.WriteLine("The last digit is six");
                    break;
                case 7:
                    Console.WriteLine("The last digit is seven");
                    break;
                case 8:
                    Console.WriteLine("The last digit is eight");
                    break;
                case 9:
                    Console.WriteLine("The last digit is nine");
                    break;
                default:
                    Console.WriteLine("Error"); // Something when wrong if the digit was not amoungst 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9
                    break;
            }

            Console.Read(); // Wait for the user to end the program
        }
    }
}
