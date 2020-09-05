using System;

namespace _20200724_gettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies avengers = new Movies("the avengers", "joss whedon", "pg-13");
            Movies shrek = new Movies("shrek", "adam adamson", "pg");
            // g, pg, pg-13, r, nr
            avengers.GSRating = "r";
            Console.WriteLine(avengers.GSRating);
            Console.ReadLine();
        }
    }
}
