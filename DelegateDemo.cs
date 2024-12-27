using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateAndReflextion
{
    public delegate void ArithmeticOperation(int a,int b);

    public delegate bool StringFilter(string s);
    internal class DelegateDemo
    {
        public void Add(int a,int b)=> Console.WriteLine(a+ b);
        public void Sub(int a,int b)=> Console.WriteLine(a - b);
        public void Multiply(int a,int b)=> Console.WriteLine(a * b);
        public void div(int a, int b) => Console.WriteLine(a/b);
        public bool IsStartsWith(string s)=>s.StartsWith('s');
        public bool IsCorrectLength(string s) => s.Length == 5;

    }
}
