// learn.microsoft.com

// Add logic to C# console applications (Get started with C#, Part 3) 
// Add looping logic to your code using the do-while and while statements in C# 

// ============================================================================================== //
// Unit 3 of 8 > Exercise - Complete a challenge activity using do and while iteration statements //
// ============================================================================================== //


// Role playing game battle challenge

int heroHealth = 10;
int monsterHealth = 10;

Random damage = new Random();
// hero and monster attacks are separated and generated inside the outer loop so the hit values are always different from the next ones

while (heroHealth > 0 && monsterHealth > 0)
{ 
    int heroAttack = damage.Next(1,11);
    
    // hero attacks
    monsterHealth -= heroAttack;
    Console.WriteLine($"You hit for {heroAttack} damage \n |Monster's health is {monsterHealth}|");


    if (monsterHealth > 0)
    {
        int monsterAttacks = damage.Next(1,11);
        // monster attacks
        heroHealth -= monsterAttacks;
        Console.WriteLine($"Monster hits you for {monsterAttacks} damage \n |Your health is {heroHealth}|");
        if (heroHealth <= 0)
        {
            Console.WriteLine($"You died!");
            break;
        }
    }
    else
    {
        Console.WriteLine($"You killed the monster! Victory!");
    }
}