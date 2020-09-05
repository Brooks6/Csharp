using System;
namespace _20200725_inheritance
{
    public class chineseChif : Chef
    {
        public void makeRice()
        {
            Console.WriteLine("rice");
        }

        public override void makeBBQ() //overriding method
        {
            Console.WriteLine("AAP");
        }
    }
}
