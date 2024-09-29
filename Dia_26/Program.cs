// Random is a class, and in object-oriented programming (OOP), classes are blueprints for creating objects.
// dice is a variable of type Random, meaning it will hold a reference to an instance (or object) of the Random class.
// new Random() creates an instance of the Random class (i.e., an object), which is then assigned to the dice variable.
// in this context:

// dice is an object of type Random (it's an instance of the Random class).
// You can call methods (like Next()) on dice because it's an object with access to all the functionality defined in the Random class.
// In short, by writing Random dice = new Random();, you're both declaring a variable (dice) and assigning it a new object of the Random class.

Random dice = new Random(); // declaring a variable with the name dice, of the type Random and assigning it as a new object /* i.e. Random() */ of the Random class.

int roll1 = dice.Next(1, 7); // calling the Random.Next() method on the dice object
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) // checking if the result gets 2 dice with the same number
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3)) // checking if all 3 dice have the same number
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}

