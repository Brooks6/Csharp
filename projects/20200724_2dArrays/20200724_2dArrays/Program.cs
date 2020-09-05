using System;

namespace _20200724_2dArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                {1, 2},
                {3, 4},
                {5, 6}
            };
            int[,] myArray = new int[2, 3];//2 elements and each element have 3 elements inside it

            Console.WriteLine(numberGrid[1, 1]);
            Console.ReadLine();
        }
    }
}
