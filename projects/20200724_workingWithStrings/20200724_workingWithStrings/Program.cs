using System;

namespace _20200724_workingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "i am Brooks";
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());//or Tolower()
            Console.WriteLine(phrase.Contains('a')); //also can check string, return bool
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf('a')); //similar to "contains function"
            Console.WriteLine(phrase.Substring(5, 3)); //grasp letter from index 5
            Console.ReadLine();
        }
    }
}
