using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateAndReflextion
{
    internal class Program
    {
      static  DelegateDemo demo = new DelegateDemo();
        static void Main(string[] args)
        {
            // stringOp();

            ReflectionExample.DemoReflection();
        }
        static void stringOp()
        {
            List<string> list = new List<string>() { "demo", "ram", "shankar", "dhoni", "sekar" };

            StringFilter filter = new StringFilter(demo.IsCorrectLength);
         //   filter += demo.IsStartsWith;
            StringFilter stringFilter = new StringFilter(demo.IsStartsWith);

            foreach (string s in list)
            {
                if(filter(s) && stringFilter(s))
                Console.WriteLine(s);
            }
        }
        // example for multicast delegates
        static void AirthmeticDelegateExe()
        {
           
            ArithmeticOperation ad = new ArithmeticOperation(demo.Add);// multi delegates
            ad += demo.Sub;
            ad += demo.Multiply;
            ad += demo.div;
            ad(3, 6);
        }
    }
}
