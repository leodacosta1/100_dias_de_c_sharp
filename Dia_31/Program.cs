// Create and run simple C# console applications (Get started with C#, Part 2)
// Create readable code with conventions, whitespace, and comments in C# 
// learn.microsoft.com/

// ============================================= //
// Unit 3 of 7 - Create arrays and foreach loops //
// ============================================= //


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

int sophiaSum = 0;

decimal sophiaScore;

foreach (int score in sophiaScores)
{
    sophiaSum += score;
}

sophiaScore = (decimal)sophiaSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
//Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
//Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
//Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
