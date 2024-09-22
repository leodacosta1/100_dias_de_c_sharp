﻿// Perform basic string formatting in C# - UNIT 5 OF 8 - learn.microsoft.com

//The projectName variable will be used twice in the desired output.

//The russianMessage variable contains the message "View Russian output" in Russian. You must use this variable in your code that prints the message.

//You may not change these two lines of code, but you can add code above and below each line. You must use these two lines of code to form the desired output.

//You may only use either the Console.WriteLine() or the Console.Write() method twice.
//In other words, to complete this challenge, you can only create two instructions that actually print output to the console. If you need to print additional new lines or add any formatting, you must use what you've learned in this module to accomplish it.

//Use character escape sequences, verbatim strings, unicode, and string interpolation to generate the output.
//To complete this challenge, your code must produce the following output.

//==================================
// View English output:
//   c:\Exercise\ACME\data.txt

// Посмотреть русский вывод:
//   c:\Exercise\ACME\ru-RU\data.txt
//==================================


string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($"View English output:\n\t" + $@"c:\Exercise\{projectName}\date.txt");
Console.WriteLine($"{russianMessage}\n\t" + $@"c:\Exercise\{projectName}\ru-RU\data.txt");
