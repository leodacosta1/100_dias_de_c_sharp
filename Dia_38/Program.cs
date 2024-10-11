// learn.microsoft.com

// Add logic to C# console applications (Get started with C#, Part 3) 
// Control variable scope and logic using code blocks in C#  

// =========================================================================== //
// Unit 4 of 7 > Exercise - Complete a challenge activity using variable scope //
// =========================================================================== //

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
       Console.WriteLine("Set contains 42");
}

Console.WriteLine($"Total: {total}");