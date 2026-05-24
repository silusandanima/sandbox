//create a class for a dog where each dog has a name . when an object is created the dogs names should be assigned and printed.\
using System;
public  class Dog
{
    public string Name;
    //constructor
    public Dog(string DogName)
    {
        Name = DogName;
        Console.WriteLine("Dog created with name: " + Name);
    }
}