// learn.microsoft.com

// Add logic to C# console applications (Get started with C#, Part 3) 
// Evaluate Boolean expressions to make decisions in C# 

// =============================================== //
// Unit 2 of 9 > Exercise - Evaluate an expression //
// =============================================== //

//string value1 = " a";
//string value2 = "A ";
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

//Console.WriteLine("a" != "a");
//Console.WriteLine("a" != "A");
//Console.WriteLine(1 != 2);

//string myValue = "a";
//Console.WriteLine(myValue != "a");

//Console.WriteLine(1 > 2);
//Console.WriteLine(1 < 2);
//Console.WriteLine(1 >= 1);
//Console.WriteLine(1 <= 1);

/*  (!) Note:
    Some data types have methods that perform helpful utility tasks.
    The String data type has many of these. Several return a Boolean value including
    Contains(), StartsWith(), and EndsWith(). You can learn more about them in the
    Microsoft Learn module "Manipulate alphanumeric data using String class methods in C#".
*/

//string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(pangram.Contains("fox"));
//Console.WriteLine(pangram.Contains("cow"));

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));