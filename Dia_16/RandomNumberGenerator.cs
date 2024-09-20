using System;

class Program
{
    static void Main()
    {
        Random randomSomething = new Random(); // initialize the Random Class, creating the object of that class: Random()

        int randomNumber = randomSomething.Next();

        Console.WriteLine($"the random number is {randomNumber}");
    }
}
