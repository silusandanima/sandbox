//Write a C# console application to calculate the factorial of a number using a function. The program should prompt the user to enter a positive integer, use a loop inside a function tocompute the factorial, and display the result.
using System;
public class FactorialCalculator
{
       public static void Main(string[] args)
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }
        long factorial = CalculateFactorial(number);
        Console.WriteLine($"The factorial of {number} is: {factorial}");
    }
    public static long CalculateFactorial(int n)
    {
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}