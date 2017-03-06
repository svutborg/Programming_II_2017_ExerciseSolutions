using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            Console.WriteLine($"Given text:\n{text}");
            ChangeCase(ref text);
            Console.WriteLine($"Result:\n{text}");
            Console.Read();
        }

        static void ChangeCase(ref string s)
        {
            bool upper = false;            
            string[] dividers = { "<upcase>", "</upcase>" };
            string[] substrings = s.Split(dividers, StringSplitOptions.None); // Split string by <upcase> and </upcase>
            if (s.IndexOf(dividers[0]) == 0)
            {   // if the string starts by <upcase> tag, start in uppercase
                upper = true;
            }
            s = ""; // Clear the string
            for (int i = 0; i < substrings.Length; i++)
            {   // piece string back together with alternating upper and lower case 
                if (upper)
                {
                    s += substrings[i].ToUpper();
                    upper = false;
                }
                else
                {
                    s += substrings[i];
                    upper = true;
                }
            }
        }
    }
}
