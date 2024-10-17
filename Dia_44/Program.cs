// learn.microsoft.com

// Add logic to C# console applications (Get started with C#, Part 3) 
// Add looping logic to your code using the do-while and while statements in C# 

// ================================================================================================================= //
// Unit 5 of 8 > Exercise - Complete a challenge activity to differentiate between do and while iteration statements //
// ================================================================================================================= //

/*
static void FirstTest()
{
    // nullable type string not initialized
    string? readResult;
    Console.WriteLine("Enter a string:");
    do
    {
        // but that's ok because the value will be assigned here
        // with the user input
        readResult = Console.ReadLine();
    // and the program will most likely never return a null value
    // from an user input because even if the user hits enter without
    // typing anything, the value will still be "" (empty), so the 
    // loop ends anyway
    } while (readResult == null);
}
*/

// Code project 1 - write code that validates integer input

//string? readResult;
bool goAgain = false;

Console.WriteLine($"Enter an integer between 5 and 10");

do
{
    int readResult = Int32.Parse(Console.ReadLine());
    if (readResult < 5 || readResult > 10)
    {
        Console.WriteLine($"Value must be between 5 and 10");
        goAgain = true;
    }
    else
    {
        Console.WriteLine($"That's a valid integer!");
        break;
    }
} while (goAgain == true);