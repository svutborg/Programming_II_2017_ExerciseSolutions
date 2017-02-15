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

            Console.WriteLine($"The last digit of {i} is {LastDigitAsAStringUsingEnum(i)}");

            Console.Read(); // Wait for the user to end the program
        }

        enum TextDigits { zero, one, two, three, four, five, six, seven, eight, nine};

        static string LastDigitAsAStringUsingEnum(int num)
        {
            return ((TextDigits)(num%10)).ToString();
        }

        static string LastDigitAsAString(int num)
        {
            string s;

            switch (num % 10) // Print the english name of the last digit 
            {
                case 0:
                    s = "zero";
                    break;
                case 1:
                    s = "one";
                    break;
                case 2:
                    s = "two";
                    break;
                case 3:
                    s = "three";
                    break;
                case 4:
                    s = "four";
                    break;
                case 5:
                    s = "five";
                    break;
                case 6:
                    s = "six";
                    break;
                case 7:
                    s = "seven";
                    break;
                case 8:
                    s = "eight";
                    break;
                case 9:
                    s = "nine";
                    break;
                default:
                    s = null; // Something when wrong if the digit was not amoungst 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9
                    break;
            }

            return s;
        }
    }
}
