using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3._7
{
    class Program
    {
        static void Main(string[] args)
        {

            Phone p1 = new Phone("Samsung", "Alpha", 2000, "Steffen", Battery.BatteryType.Li_Ion, "Cheap ass battery", 0, 0, 0, 4, 3, 2);

            p1.addCall(new CallInfo(new TimeSpan(0, 34, 41), DateTime.Now));
            p1.addCall(new CallInfo(new TimeSpan(0, 14, 21), DateTime.Now));

            Console.WriteLine(p1.callsToString());

            Console.Read();
        }
    }
}
