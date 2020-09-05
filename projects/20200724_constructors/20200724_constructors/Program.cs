using System;

namespace _20200724_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books("a", "b", 1);
            Console.WriteLine(book1.pages);
            Console.ReadLine();
        }
    }
}
