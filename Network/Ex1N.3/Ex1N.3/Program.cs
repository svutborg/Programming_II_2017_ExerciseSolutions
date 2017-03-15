using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;

namespace Ex1N._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Encoding E = Encoding.UTF8;
            string ip;
            IPAddress addr;

            do
            {
                Console.WriteLine("Enter Host IP address:");
                ip = Console.ReadLine();
            }
            while (!IPAddress.TryParse(ip, out addr));

            try
            {
                S.Connect(new IPEndPoint(addr, 7913));
                Console.WriteLine("Connected");
                while (true)
                {
                    string read = Console.ReadLine();
                    S.Send(E.GetBytes(read));
                }
            }
            catch(SocketException se)
            {
                Console.WriteLine(se.Message);
                Console.WriteLine("Quitting!");   
            }
            finally
            {
                if (S != null)
                    S.Close();
            }
            Console.Read();
        }
    }
}
