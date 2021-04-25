using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("This program finds the remainder");
            Console.WriteLine("Enter the Numerator: ");
            double numerator=double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Denominator");
            double denominator=double.Parse(Console.ReadLine());
            double modulus=numerator%denominator;
            Console.WriteLine($"The remainder is {modulus}");
            Console.WriteLine("Thank You!");
        }
    }
}
