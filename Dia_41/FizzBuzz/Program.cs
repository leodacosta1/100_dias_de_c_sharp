// learn.microsoft.com

// Add logic to C# console applications (Get started with C#, Part 3) 
// Iterate through a code block using for statement in C# 

// ================================================================================== //
// Unit 3 of 6 > Exercise - Complete a challenge activity using for and if statements //
// ================================================================================== //

//  rules:
//      Output values from 1 to 100, one number per line, inside the code block of an iteration statement.




for (int counter = 1; counter <= 100; counter++)
{
    if (counter % 3 == 0 && counter % 5 == 0)
        Console.WriteLine($"{counter} - FizzBuzz");
    else if (counter % 3 == 0)
        Console.WriteLine($"{counter} - Fizz");
    else if (counter % 5 == 0)
        Console.WriteLine($"{counter} - Buzz");
    else
        Console.WriteLine($"{counter}");
}