// learn.microsoft.com

// Add logic to C# console applications (Get started with C#, Part 3) 
// Evaluate Boolean expressions to make decisions in C# 

// ================================================================================ //
// Unit 6 of 9 > Exercise - Complete a challenge activity using Boolean expressions //
// ================================================================================ //

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin") && level > 55)
{
    Console.WriteLine($"Welcome, Super Admin user.");
}
else if (permission.Contains("Admin") && level <= 55)
{
    Console.WriteLine($"Welcome, Admin user.");
}
else if (permission.Contains("Manager") && level >= 20)
{
    Console.WriteLine($"Contact an Admnin for access");
}
else if (permission.Contains("Manager") && level <=20)
{
    Console.WriteLine($"You do not have sufficient privileges.");
}
else
{
    Console.WriteLine($"You do not have sufficient privileges.");
}