/*
Write a program where the computer randomly selects a number between 1 and 100, and the user has to guess it.

If the guess is too low, print "Too low! Try again."
If the guess is too high, print "Too high! Try again."
If the guess is correct, print "Congratulations! You've guessed the number!" and exit the loop.
*/


Random random = new Random();
int numberGenerated = random.Next(1, 101);

Console.WriteLine($"Guess the number I generated between 1 and 100...\n\nType anything that's not an integer if you want to exit the program.\n\nYou will see an unhandled exception though.");
bool guessValue = false;

do
{
    int guess = int.Parse(Console.ReadLine());

    if (guess == numberGenerated)
    {   
        Console.WriteLine($"Congratulations! You've guessed the number!");
        guessValue = true;
    }
    else if (guess > numberGenerated)
        Console.WriteLine($"Too high! Try again.");
    else
        Console.WriteLine($"Too low! Try again.");
    
} while (guessValue == false);