// learn.microsoft.com

// Add logic to C# console applications (Get started with C#, Part 3) 
// Add looping logic to your code using the do-while and while statements in C# 

// ================================================================================================================= //
// Unit 5 of 8 > Exercise - Complete a challenge activity to differentiate between do and while iteration statements //
// ================================================================================================================= //

// Code project 2 - write code that validates string input

Console.WriteLine($"are you an Administrator, Manager or User?");

bool userIsWrong = true;

do
{
    string userInput = Console.ReadLine().Trim().ToLower();

    if (userInput == "Administrator" || userInput == "Manager" || userInput == "User")
    {
        Console.WriteLine($"Welcome.");
        break; //aqui é necessário o break ou o userIsWrong = true pra poder sair do loop caso tenha entrado no else uma vez
    }
    else
    {
        Console.WriteLine($"What?");
        userIsWrong = false;
    }
    
} while (userIsWrong == false);
