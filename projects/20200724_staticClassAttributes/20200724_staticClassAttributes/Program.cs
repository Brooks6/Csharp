using System;

namespace _20200724_staticClassAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Songs holiday = new Songs("holiday", "green day", 200);
            Console.WriteLine(Songs.songCount);

            Songs kashmir = new Songs("kashmir", "led zeppelin", 150);
            Console.WriteLine(Songs.songCount);

            Console.WriteLine(kashmir.artist);
            Console.ReadLine();
        }
    }
}
