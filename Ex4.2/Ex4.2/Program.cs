using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            HandleMenu();
            Console.Read();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Welcome to this very versatile and extremely professional program.");
            Console.WriteLine("You as the user now has three options:");
            Console.WriteLine("1. Reverse the digits in a given number.");
            Console.WriteLine("2. Calculate the average of a sequence of numbers.");
            Console.WriteLine("3. Find the solution to the linear equation ax + b = 0, given a and b.");
            Console.WriteLine("\nSelect by entering the number of the desired function.");
        }

        static void HandleMenu()
        {
            DisplayMenu();
            int selection = int.Parse(Console.ReadLine());

            switch(selection)
            {
                case 1:
                    Console.WriteLine("======================< Reverse digits >======================");
                    Console.Write("Enter a number to have its digits reversed: ");
                    int num = int.Parse(Console.ReadLine());
                    if (ValidateInput(1, num))
                    {
                        Console.WriteLine($"The number {num} reversed becomes {ReverseDigits(num)}");
                    }
                    else
                    {
                        Console.WriteLine("Non-valid input, try again.\n");
                        HandleMenu();
                    }
                    break;
                case 2:
                    Console.WriteLine("=====================< Calculate average >====================");
                    Console.Write("Enter a sequence of numbers, separated by comma: ");
                    string ans2 = Console.ReadLine();
                    double[] numbers2 = ans2.Split(',').Select(double.Parse).ToArray();
                    if (ValidateInput(2, numbers2))
                    {
                        Console.WriteLine($"The average of {ans2} is {CalcAverage(numbers2)}");
                    }
                    else
                    {
                        Console.WriteLine("Non-valid input, try again.\n");
                        HandleMenu();
                    }
                    break;
                case 3:
                    Console.WriteLine("===================< Solve Linear Equation >==================");
                    Console.Write("Provide the parameters a and b, separated by comma: ");
                    string ans3 = Console.ReadLine();
                    double[] numbers3 = ans3.Split(',').Select(double.Parse).ToArray();
                    if (ValidateInput(3, numbers3))
                    {
                        Console.WriteLine($"The solution of the linear equation {numbers3[0]}x + {numbers3[1]} = 0 is: x = {SolveFirstOrderLinearEquation(numbers3[0], numbers3[1])}");
                    }
                    else
                    {
                        Console.WriteLine("Non-valid input, try again.\n");
                        HandleMenu();
                    }
                    break;
                default:
                    Console.WriteLine("Non-valid option selected, enter another number.\n");
                    HandleMenu();
                    break;
            }
        }

        static bool ValidateInput(int num)
        {
            if (num>=1 && num <= 50000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ValidateInput(int selection, params double[] numbers)
        {
            bool result = false;
            switch (selection)
            {
                case 1:
                    if (numbers[0] >= 1 && numbers[0] <= 50000000)
                    {
                        result = true;
                    }
                    break;
                case 2:
                    if(numbers.Length>0)
                    {
                        result = true;
                    }
                    break;
                case 3:
                    if (numbers.Length > 0)
                    {
                        if (numbers[0] != 0)
                        {
                            result = true;
                        }
                    }
                    break;
            }
                return result;
        }

        static int ReverseDigits(int num)
        {
            int result = num, i = 0;
           
            while(result > 0) // Count the number of digits
            {
                result /= 10;
                i++;
            }
            result = 0;

            while(i>0)
            {
                result += (num % 10) * Convert.ToInt32(Math.Pow(10, --i));
                num /= 10;
            }

            return result;
        }

        static double CalcAverage(params double[] numbers)
        {
            int i;
            double sum = 0;
            for(i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum / i;
        }
        
        /// <summary>
        /// Solves the first order linear equation ax + b = 0, given a and b
        /// </summary>
        /// <param name="a">Factor to x in the equation</param>
        /// <param name="b">Bias in the equation</param>
        /// <returns>The value of x that solves the equation</returns>
        static double SolveFirstOrderLinearEquation(double a, double b)
        {
            return -b/a;
        }
    }
}
