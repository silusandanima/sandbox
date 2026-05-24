// Write a C# console application the allows the user to enter a number and print it's multiplication table up to 10 using a function and a loop.
using System;
public class MultiplicationTable
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number to see its multiplication table: ");
        int number = int.Parse(Console.ReadLine());

        PrintMultiplicationTable(number);
    }
    public static void PrintMultiplicationTable(int n)
    {
        Console.WriteLine($"Multiplication Table for {n}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
} 