using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a url:"); // ask for a URL
            string url = Console.ReadLine();

            string protocol=""; // Initialise variables
            string server="";
            string ressource="";
            int i = 0, j;

            if((j = url.IndexOf("://"))>0) // if there is an occurence of "://", the string up to that point is a protocol
            {
                protocol = url.Substring(i, j);
                i = j + 3;
            }
            if ((j = url.IndexOf("/",i)) > 0) // The first slash after that separates the server from the ressource
            {
                server = url.Substring(i, j-i);
                ressource = url.Substring(j);
            }

            Console.WriteLine("URL decomposed:"); // Print results
            Console.WriteLine($"[protocol]=\"{protocol}\"");
            Console.WriteLine($"[server]=\"{server}\"");
            Console.WriteLine($"[ressource]=\"{ressource}\"");
            Console.Read(); // wait for the user to terminate the program
        }
    }
}
