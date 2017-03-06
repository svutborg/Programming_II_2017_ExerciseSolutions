using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a line in which you want to count occurences of a specific term:"); // ask for a line of text
            string s = Console.ReadLine();

            Console.WriteLine("Enter the term that you wan to count:"); // ask for serch term
            string t = Console.ReadLine();

            int counter = 0, index = -1;
            while ((index = s.IndexOf(t, index+1)) != -1) // while indexof does not return -1, increase counter
            {
                counter++;
            }
            Console.WriteLine(counter); // print the counter
            Console.Read();
        }
    }
}
