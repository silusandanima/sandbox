//Create a program which has a class called "Vehicle". Vehicle has 3 members: Brand, NoOfWheels and Sound(). Implement the class and print out the sound().
using System;

public class Vehicle
{
    public string Brand;
    public int NoOfWheels;
    public string Sound()
    {
        return "Vroom";
    }

    public static void Main(string[] args)
    {
        //Created the object of the class
        Vehicle Mc_p1 = new Vehicle();
        //Object  -> Mc_p1
        Console.WriteLine(Mc_p1.Sound());
    }
}

