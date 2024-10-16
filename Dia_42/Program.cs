// learn.microsoft.com

// Add logic to C# console applications (Get started with C#, Part 3) 
// Add looping logic to your code using the do-while and while statements in C# 

// ============================================================ //
// Unit 2 of 6 > Exercise - Create do and while iteration loops //
// ============================================================ //

Random random = new Random();
int current = random.Next(1,11);

do
{
    current = random.Next(1,11);

    if (current >= 8) continue; // transfere a execução do código para o fim da iteração atual, pulando o console.writeline

    Console.WriteLine(current);
}while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current2 = random.Next(1,11);
}
Console.WriteLine($"Last number: {current}");
*/