using System;

namespace _20200724_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            sayHi("z23");//calling method
            sayHi("Brks");
            Console.ReadLine();
        }

        static void sayHi(string name)
        {
            Console.WriteLine("hello " + name);
        }
    }
}
