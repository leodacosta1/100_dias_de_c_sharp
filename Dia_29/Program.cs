// Create and run simple C# console applications (Get started with C#, Part 2)
// Create readable code with conventions, whitespace, and comments in C# 
// learn.microsoft.com/

// ===================================================================== //
// Unit 2 of 8 - Choose variable names that follow rules and conventions //
// ===================================================================== //

/*

Variable name rules
###################

Variable names can contain alphanumeric characters and the underscore (_) character. Special characters
like the pound #, the dash -, and the dollar sign $ are not allowed.

Variable names must begin with an alphabetical letter or an underscore, not a number. Using an underscore character to start
a variable name is typically reserved for private instance fields. A link to further reading can be found in the module summary.

Variable names must NOT be a C# keyword. For example, these variable name declarations won't be allowed: float float; or string string;.

Variable names are case-sensitive, meaning that string MyValue; and string myValue; are two different variables.


Variable name conventions
#########################

Variable names should use camel case, which is a style of writing that uses a lower-case letter at the beginning of the first word
and an upper-case letter at the beginning of each subsequent word. For example: string thisIsCamelCase;.

Variable names should be descriptive and meaningful in your application. You should choose a name for your variable that represents
the kind of data it will hold (not the data type). For example: bool orderComplete;, NOT bool isComplete;.

Variable names should be one or more entire words appended together. Don't use contractions because the name of the variable may be
unclear to others who are reading your code. For example: decimal orderAmount;, NOT decimal odrAmt;.

Variable names shouldn't include the data type of the variable. You might see some advice to use a style like string strMyValue;.
It was a popular style years ago. However, most developers don't follow this advice anymore and there are good reasons not to use it.

*/


// ======================================================= //
// Unit 3 of 8 - Exercise - Create effective code comments //
// ======================================================= //


/*
    The following code create five random OrderIDs
    to test the fraud detection process. OrderIDs
    consist of a letter from A to E, and a three
    digit number. Ex. A123.
*/
/*
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");
    
    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
*/

// ======================================================================== //
// Unit 4 of 8 - Exercise - Use whitespace to make your code easier to read //
// ======================================================================== //

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

/*
Use whitespace judiciously to improve the readability of your code.
Use line feeds to create empty lines to separate phrases of code. A phrase includes lines of code that are similar, or work together.
Use line feeds to separate code block symbols so that they are on their own line of code.
Use the tab key to line up a code block with the keyword they're associated with.
Indent code inside of a code block to show ownership.
*/