using System;

namespace _20200724_objectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Students stu1 = new Students("Brooks", "IT", 3.3);
            Students stu2 = new Students("z23", "commerce", 4.0);
            Console.WriteLine("stu1: " + stu1.hasHonnors());
            Console.WriteLine("stu2: " + stu2.hasHonnors());
            Console.ReadLine();
        }
    }
}
