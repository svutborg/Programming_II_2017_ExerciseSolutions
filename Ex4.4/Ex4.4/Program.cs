using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray(1, 2, 3, 4, 56);
            Console.Read();
        }

        static void PrintArray(params double[] arr)
        {
            Console.Write("[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if(i != arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write(" ]");
        }
    }
}
