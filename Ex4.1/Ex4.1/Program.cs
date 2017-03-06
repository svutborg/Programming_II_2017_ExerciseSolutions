using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{GetMax(1,4,5,6)}");
            Console.Read();
        }

        static int GetMax(int a, int b)
        {
            int max = a; // assign the first parameter to max 
            if (b > max) // update max if the second parameter is larger
            {
                max = b;
            }
            return max; // return the result
        }

        static int GetMax(int a, int b, int c = 0)
        {
            int max = a; // assign the first parameter to max 
            if (b > max) // update max if the second parameter is larger
            {
                max = b;
            }
            if (c > max) // update max if the third parameter is larger
            {
                max = c;
            }
            return max; // return the result
        }

        static int GetMax(params int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
    }
}
