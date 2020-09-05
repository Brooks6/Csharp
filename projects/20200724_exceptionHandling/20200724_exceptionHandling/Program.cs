using System;

namespace _20200724_exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("enter a number");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("enter another number");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //force to run the program
            }
            Console.ReadLine();
        }
    }
}
