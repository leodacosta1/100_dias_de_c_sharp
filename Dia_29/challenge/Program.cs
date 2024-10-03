// Create and run simple C# console applications (Get started with C#, Part 2)
// Create readable code with conventions, whitespace, and comments in C# 
// learn.microsoft.com/

// ================================================================================== //
// Unit 5 of 8 - Exercise - Complete a challenge activity to improve code readability //
// ================================================================================== //

// Code challenge - apply style guidelines to improve readability

/*
string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new string(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
*/

// ===================

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] convertedMessage = foxPhrase.ToCharArray();

Array.Reverse(convertedMessage);

int letterCount = 0;

foreach (char counter in convertedMessage)
{ 
    if (counter == 'o')
    { 
        letterCount++;
    }
}

string newMessage = new string(convertedMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");