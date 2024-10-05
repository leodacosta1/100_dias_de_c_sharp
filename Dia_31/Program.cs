// Create and run simple C# console applications (Get started with C#, Part 2)
// Create readable code with conventions, whitespace, and comments in C# 
// learn.microsoft.com/

// ============================================= //
// Unit 3 of 7 - Create arrays and foreach loops //
// ============================================= //

// ============================================================================== //
// Unit 4 of 7 - Construct a nested loop structure for student grade calculations //
// ============================================================================== //


/*
The using statement enables you to write code that implements members of the System namespace without requiring you to specify System.
For example, your code can use the Console.WriteLine() method without having to specify System.Console.WriteLine().
Among other things, the using statement makes your code easier to read.
*/

using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// Students names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    
    else if (currentStudent == "Lgoa")
        studentScores = loganScores;
    
    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    foreach (int score in studentScores)
    {
        // add the exam score to the sum
        sumAssignmentScores += score;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
