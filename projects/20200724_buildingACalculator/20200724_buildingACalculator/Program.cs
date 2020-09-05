using System;

namespace _20200724_buildingACalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 10);
            */
            Console.Write("enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            Console.ReadLine();
        }
    }
}
