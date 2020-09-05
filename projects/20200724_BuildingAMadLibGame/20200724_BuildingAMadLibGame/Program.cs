using System;

namespace _20200724_BuildingAMadLibGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;
            Console.Write("enter a color: ");
            color = Console.ReadLine();

            Console.Write("enter a pluralNoun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are {color}" + color);
            Console.WriteLine(pluralNoun+ "{plural noun} are blue");
            Console.WriteLine("I love {celebrity}" + celebrity);

            Console.ReadLine();
        }
    }
}
