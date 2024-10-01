// Create and run simple C# console applications (Get started with C#, Part 2)
// Store and iterate through sequences of data using Arrays and the foreach statement in C#
// Unit 2 of 7 - Get Started with array basics
// learn.microsoft.com/

/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
fraudulentOrderIDs[3] = "D000";
*/

/*
string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// (!) Note: The Length property of an array is not zero-based.

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

*/


// ============================================= //
// Unit 3 of 7 - Implement the foreach statement
// ============================================= //


//string[] names = { "Rowena", "Robin", "Bao" };

/*
Below the foreach keyword, the code block that contains the Console.WriteLine(counter);
will execute once for each element of the names array.
As the .NET runtime loops through each element of the array,
the value stored in the current element of the names array is assigned
to the temporary variable counter for easy access inside of the code block.
*/

/*
foreach (string counter in names) 
{
    Console.WriteLine(counter);
}
*/

int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
int bin = 0;

foreach (int counter in inventory)
{
    sum += counter;
    bin++;
    Console.WriteLine($"Bin {bin} = {counter} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory");

/*
    .Use the foreach statement to iterate through each element in an array,
    executing the associated code block once for each element in the array.
    
    .The foreach statement sets the value of the current element in the array
    to a temporary variable, which you can use in the body of the code block.
    
    .Use the ++ increment operator to add 1 to the current value of a variable.
*/