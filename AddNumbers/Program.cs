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
            Console.WriteLine($"The substraction of {a} - {b} is {Substract(a,b)}");
        }
        public static int Substract(int a, int b)
        {
            return a - b;
        }
    }
}
