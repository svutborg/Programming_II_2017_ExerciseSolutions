using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1N._0
{
    class Program
    {
        delegate void MethodSelectorDelegate(); // Delegate that takes no arguments and returns nothing
        static void Main(string[] args)
        {
            MethodSelectorDelegate mp; // Instance of the methosd selector delegate
            while (true)
            {
                Console.WriteLine("Select Method 1 or 2"); // Ask to select one of the two methods by entering a number
                switch(Console.ReadLine()[0])
                {   
                    case '1': // In the case there the user has selected the first method
                        mp = Method1;
                        break;
                    case '2': // In the case where the user has selected the second method
                        mp = Method2;
                        break;
                    default:
                        mp = DefaultMethod;
                        break;
                }
                mp();
            }
        }

        static void DefaultMethod()
        {
            Console.WriteLine("Non-Valid method selected");
        }

        static void Method1()
        {
            Console.WriteLine("Method 1");
        }   
        static void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
}
