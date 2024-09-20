using System;

class Program
{
    static void Main()
    {
        Random randomSomething = new Random(); // initialize the Random Class, creating the object of that class: Random()

        int randomNumber = randomSomething.Next(); // Next() is a function part of the Random class, from the System namespace

        Console.WriteLine($"the random number is {randomNumber}");
    }
}
