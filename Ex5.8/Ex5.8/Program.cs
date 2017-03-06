using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = File.Open("../../../HTML.html", FileMode.Open); // open file stream
            byte[] byteArray = new byte[fs.Length]; 
            UTF8Encoding enc = new UTF8Encoding(true);
            int i, j;

            fs.Read(byteArray, 0, byteArray.Length); // read and parse file content as UTF8 encoded text
            string fileContent = enc.GetString(byteArray);

            while (fileContent.Contains('\t')) // remoave all tabulators
            {
                fileContent = fileContent.Remove(fileContent.IndexOf('\t'), 1);
            }
            while (fileContent.Contains('<')) // remove all html tags
            {
                i = fileContent.IndexOf('<');
                j = fileContent.IndexOf('>');
                fileContent = fileContent.Remove(i, j - i + 1);
            }
            

            Console.WriteLine(fileContent); // print result

            Console.Read(); // wait for user to terminate the program
        }
    }
}
