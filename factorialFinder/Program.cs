using System;

namespace factorialFinder
{
    class Program
    {
        // Displays instructions and outputs the results of calculations
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to factorial finder 2022");

            // Outputs the result of the function on the input number
            Console.WriteLine("Please enter a number to be calculated recursively");
            Console.WriteLine(RecursiveFactorial(int.Parse(Console.ReadLine())));

            Console.WriteLine("Please enter a number to be calculated iteratively");
            Console.WriteLine(IterativeFactorial(int.Parse(Console.ReadLine())));

            Console.ReadLine();

        }

        private static int RecursiveFactorial(int n)
        {
            // Factorials can be generalised with the function n! = n * (n - 1)!
            // When 0 < n <= 2, n! = n
            // When n = 0, n! = 1
            if (n == 0)
            {
                return 1;
            }
            if (n <= 2)
            {
                return n;
            }
            return n * RecursiveFactorial(n - 1);
        }

        private static int IterativeFactorial(int n)
        {
            // This calculates factiorials by counting down from n and multiplying it by the total
            int output = 1;
            for (int i = n; i > 1; i--)
            {
                output = output * i;
            }
            return output;
        }
    }
}
