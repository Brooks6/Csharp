﻿using System;

namespace _20200724_returnStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cube(5));
            Console.ReadLine();
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
