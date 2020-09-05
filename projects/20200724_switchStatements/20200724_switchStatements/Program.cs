using System;

namespace _20200724_switchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getDay(0));
            Console.ReadLine();
        }

        static string getDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0: dayName = "Sunday"; break;
                case 1: dayName = "Monday"; break;
                default: dayName = "invalid day number";break;
            }

            return dayName;
        }
    }
}
