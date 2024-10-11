// learn.microsoft.com

// Add logic to C# console applications (Get started with C#, Part 3) 
// Control variable scope and logic using code blocks in C#  

// ======================================================= //
// Unit 2 of 7 > Exercise - Code blocks and variable scope //
// ======================================================= //


int value1 = 5;

if(value1 > 0)
{
    int value2 = 6;
    value1 += value2;
}

Console.WriteLine(value1);