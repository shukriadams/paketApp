using System;
using SimpleLib;
using ComplexLib;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var simple = Simple.DoSomething();
            Complex complex = new Complex();
            var complexthing = complex.DoComplex();
            Console.WriteLine($"Hello World! simple : {simple} ... complex {complexthing}");
        }
    }
}
