using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ender a line of text:"); // Ask for entry
            string s = Console.ReadLine();

            if(s.Length<20) // if shorter that 20 charcters pad to the right by '*'
            {
                s = s.PadRight(20, '*');
            }else if(s.Length>20) // If longer than 20 charcters shorten to 20
            {
                s = s.Substring(0, 20);
            }

            Console.WriteLine($"The padded version is:\n{s}"); // print result
            Console.Read(); // wait for user to terminate program.
        }
    }
}
