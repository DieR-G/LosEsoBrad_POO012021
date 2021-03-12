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

            Console.WriteLine($"The sum {a} + {b} is {add(a,b)}");
        }
        public static int add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
