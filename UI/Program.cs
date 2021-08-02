using System;
using ClassLibrary;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 2 numbers to Multiply");
            Console.WriteLine("First Number");
            double n1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Second Number");
            double n2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("The Answer is " + MyMath.Multiply(n1, n2));
        }
    }
}
