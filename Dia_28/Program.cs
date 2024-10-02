// Create and run simple C# console applications (Get started with C#, Part 2)
// Store and iterate through sequences of data using Arrays and the foreach statement in C#
// learn.microsoft.com/

// ========================================================================================= //
// Unit 4 of 7 - Complete a challenge activity for nested iteration and selection statements
// ========================================================================================= //

// Create a foreach statement to iterate through each element of your array.
// Report the Order IDs that start with the letter "B".

string[] fraudulentOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string counter in fraudulentOrderIDs)
{
    if (counter.StartsWith("B"))
    {
        Console.WriteLine(counter);
    }    
}
