using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO.Ports;

namespace Ex1E._3
{
    class Program
    {
        static SerialPort sp;
        static void Main(string[] args)
        {
            Console.WriteLine("-->> SPL2000 - Serial Port Listener 2000 <<--");
            Console.WriteLine("This program will let you select a COM port and will listen on that port for as long as it is available, or untill the user presses the escape key.");

            while (SerialPort.GetPortNames().Count() > 0)
            {
                Console.WriteLine("Choose one of the following available ports:");
                foreach (string port in SerialPort.GetPortNames())
                {
                    Console.WriteLine(port);
                }
                string ans = Console.ReadLine();
                if (SerialPort.GetPortNames().Contains(ans))
                {
                    sp = new SerialPort(ans);
                    sp.Open();
                    sp.DataReceived += Sp_DataReceived;
                    if (sp.IsOpen)
                    {
                        break;
                    }
                }
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Thread.Sleep(500);
            }

        }

        private static void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Console.Write(sp.ReadExisting());
        }
    }
}
