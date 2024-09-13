using System;

class Program
{
    static void Main(string[] args)
    {
        int[] data = [100, 200, 300, 400, 500, 600, 700, 800, 900, 1000];

        int sum = 0;

        for (int counter = 0; counter < data.Length; counter++)
        {
            sum = sum + data[counter];
        }
        Console.WriteLine(sum);

        int median = sum / data.Length;
        
        Console.WriteLine(median);
    }
}