using System;

namespace _20200725_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef1 = new Chef();
            chineseChif chef2 = new chineseChif();

            chef1.makeChicken();
            chef2.makeChicken();
            chef2.makeRice();

            chef1.makeBBQ();
            chef2.makeBBQ();

            Console.ReadLine();
        }
    }
}
