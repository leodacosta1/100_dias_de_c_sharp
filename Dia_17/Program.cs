using System;

class Program
{
    static void Main()
    {
        Random randomSomething = new Random();

        char[] characterList = {'a', 'b', 'c', 'd', 'e', 'f', '1', '2', '3', '4', '5'};

        int passwordLength = characterList.Length; // can also be assigned any int value, in case I want to change the password length

        string password = "";
        for (int counter = 0; counter < passwordLength; counter++)
        {
            int randomIndex = randomSomething.Next(characterList.Length);

            password += characterList[randomIndex];
        }

        Console.WriteLine($"The new password is {password}");
    }
}
