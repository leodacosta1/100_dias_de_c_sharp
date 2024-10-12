// learn.microsoft.com

// Add logic to C# console applications (Get started with C#, Part 3) 
// Branch the flow of code using the switch-case construct in C# 

// ===================================================== //
// Unit 2 of 7 > Exercise - Implement a switch statement //
// ===================================================== //

int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");