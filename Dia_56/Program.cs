using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string infernoText = "inferno.txt";
        string inferno = "inferno";

        string content = File.ReadAllText(infernoText);

        int count = content.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                            .Count(word => word.Equals(inferno, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine($"The word '{inferno}' appears {count} times in the text.");
    }
}