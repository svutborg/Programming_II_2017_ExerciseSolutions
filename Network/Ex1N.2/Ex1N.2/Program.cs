using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex1E._2
{
    class Program
    {
        static bool keepRunning = true;
        static void Main(string[] args)
        {
            Thread T1 = new Thread(ThreadMethod);
            Thread T2 = new Thread(ThreadMethod);
            T1.Start("Thread 1");
            T2.Start("Thread 2");

            while (Console.ReadKey().Key != ConsoleKey.Escape) ; // Block main thread until escape is pressed

            keepRunning = false; // This will allow the other threads to stop running
            T1.Join();  // Joining the other threads ensures that the main thread will not close before both T1 and T2 has closed
            T2.Join();
        }

        static void ThreadMethod(object number)
        {
            while (keepRunning)
            {
                Console.WriteLine(number);
                for (int i = 0; i < 1000000; i++)
                {

                }
            }
        }
    }
}
