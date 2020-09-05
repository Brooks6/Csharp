using System;

namespace _20200724_gettingUseInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.ReadLine();
        }
    }
}
