using System;
namespace _20200725_inheritance
{
    public class Chef
    {
        public void makeChicken() {
            Console.WriteLine("chicken");
        }

        public void makeSalad()
        {
            Console.WriteLine("salad");
        }

        public virtual void makeBBQ() //virtual means this method can be overrided
        {
            Console.WriteLine("BBQ");
        }
    }
}
