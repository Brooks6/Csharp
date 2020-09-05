using System;

namespace _20200725_staticMethodsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Math.Sqrt(144));
            UsefulTools tools = new UsefulTools();
            UsefulTools.sayHi();

            Console.ReadLine();
        }
    }
}
