using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DelegateAndReflextion
{

    public class Refle
    {
        public int Id {  get; set; }
        public Refle() { }
        public void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }


    internal class ReflectionExample
    {
        public static void DemoReflection()
        {

            Refle v= new Refle();

            // 1 way accessing
            Type type =  v.GetType();

            // 2 way accessing
            Type type1 = Type.GetType("Refle");

            // 3 way
            Type type2 = typeof(Refle);

             MethodInfo info=  type.GetMethod("Greet");

            // access method name,parameter,return type
            Console.WriteLine(info.Name+info.ReturnParameter+info.IsPublic);

            // access properties info
           PropertyInfo[] inf= type.GetProperties();

            foreach(PropertyInfo pi in inf)
            {
                Console.WriteLine(pi.Name+pi.CanWrite);
            }

            // access constructors 
          ConstructorInfo[] con=  type.GetConstructors();

            foreach(ConstructorInfo ci in con)
            {
                Console.WriteLine(ci.Name);
            }
        }

    }
}
