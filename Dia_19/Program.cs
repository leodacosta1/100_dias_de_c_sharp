// Unit 5 of 8 - Perform basic operations on numbers in C# 
//
// Complete the challenge to convert Fahrenheit to Celsius
//
// To convert temperatures in degrees Fahrenheit to Celsius, first subtract 32, then multiply by five ninths (5 / 9).
//
// Display the result of the temperature conversion in a formatted message
//
// Combine the variables with literal strings passed into a series of Console.WriteLine() commands to form the complete message.


int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5/9m);

Console.WriteLine($"The temperature is: {celsius} Celsius");