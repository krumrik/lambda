using System;

namespace LambdaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Func<double, double, double> add = (x, y) => x + y;
            Func<double, double, double> multiply = (x, y) => x * y;
            Func<double, double, double> smallerValue = (x, y) => x < y ? x : y;

            Console.WriteLine($"{num1} + {num2} = {add(num1, num2)}");
            Console.WriteLine($"{num1} * {num2} = {multiply(num1, num2)}");
            Console.WriteLine($"{num1} - {num2} = {smallerValue(num1, num2)}");

        }
    }
}

