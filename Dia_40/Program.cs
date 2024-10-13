// learn.microsoft.com

// Add logic to C# console applications (Get started with C#, Part 3) 
// Iterate through a code block using for statement in C# 

// ================================================================= //
// Unit 2 of 6 > Exercise - Create and configure for iteration loops //
// ================================================================= //

/*
Trecho explicando o funcionamento e a sintaxe de um for loop:

The for statement includes the following six parts:
    a.  The for keyword.
    b.  A set of parentheses that defines the conditions of for iteration.
        The parentheses contain three distinct parts, separated by the end of
        statement operator, a semi-colon.
    c.  The first part defines and initializes the iterator variable.
        In this example: int i = 0. This section is referred to as the initializer.
    d.  The second part defines the completion condition. In this example: i < 10.
        In other words, the runtime will continue to iterate over the code in the code block
        below the for statement while i is less than 10. When i becomes equal to 10,
        the runtime stops executing the for statement's code block. The docs refer to this
        section as the condition.
    e.  The third part defines the action to take after each iteration. In this case,
        after each iteration, i++ will increment the value of i by 1. The docs refer to this
        section as the iterator.
    f.  Finally, the code block. The code block contains the code that will be executed
        for each iteration. Notice that the value of i is referenced inside of the code block.
        The docs refer to this section as the body.

*/

/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}
*/

/*
string[] names = { "Alex", "Eddie", "David", "Michael" };

// O contador precisa ser names.Length - 1 porque a contagem de elementos em uma array é feita
// com base 1, mas a indicação da posição dos elementos de uma array é com base 0.
// A posição do elemento "Michael" é 3, mas o comprimento da array, ou seja, names.Length é 4.
for (int i = names.Length - 1; i >= 0; i--)
{
    // Portanto, se fôssemos tentar printar o elemento de valor names.Length, o programa acusaria
    // uma exeção, pois estaríamos a tentar imprimir um elemento em uma posição maior que o
    // tamanho da nossa array.
    Console.WriteLine(names[i]);
}
*/

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David")
        names[i] = "Sammy";

foreach (string counter in names) Console.WriteLine(counter);