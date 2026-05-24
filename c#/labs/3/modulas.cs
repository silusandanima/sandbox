using System;
public class Modulas
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        int result = num1 % num2;
        if (result == 0)
        {
            Console.WriteLine($"{num1} is divisible by {num2}");
        }
        else
        {
            Console.WriteLine($"{num1} is not divisible by {num2}");
        }
    }
}