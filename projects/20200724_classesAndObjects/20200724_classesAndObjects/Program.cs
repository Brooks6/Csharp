using System;


namespace _20200724_classesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books();
            book1.title = "brks";
            book1.author = "brks";
            book1.pages = 1;

            Console.WriteLine(book1.title);
            Console.ReadLine();
        }
    }
}
