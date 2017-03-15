using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1N._1
{
    class MyClass
    {
        public delegate string CallBackMethodDelegate(string s);

        private static string CallBackMethod(string message)
        {
            // This could just as easily have been a driver for bluetooth transmission
            return "Using " + message + " in private method";
        }

        public static CallBackMethodDelegate GetCallBackMethod()
        {
            return new CallBackMethodDelegate(CallBackMethod);
        }

    }
}
