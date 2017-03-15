using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1N._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using The callback method inline
            Console.WriteLine(MyClass.GetCallBackMethod()("text..."));

            // Creating local reference to the method
            MyClass.CallBackMethodDelegate del = MyClass.GetCallBackMethod();

            // The callBackMethod can now be used at will
            Console.WriteLine(del("Other text!!!"));

            Console.Read();
        }
    }
}
