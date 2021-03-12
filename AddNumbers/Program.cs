using System;

namespace AddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"The product of {a} * {b} is {Multiply(a,b)}");
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
