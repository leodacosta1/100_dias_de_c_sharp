// Enunciado: encontre a média de salário entre os funcionários de TI

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] simpleArray = {100, 200, 300, 400, 500, 600, 700, 800};
        int lowestValue = simpleArray.Min();
        Console.WriteLine($"the lowest value is {lowestValue}");        
        

        // Creating median function without using the System.Linq
        // Console.WriteLine($"{simpleArray.Length}");

        if (simpleArray.Length % 2 == 0) // checking if the array has an even number of elements
        {
            int evenMedian1 = (simpleArray.Length / 2) - 1; // adjusting to the zero-based indexing of the array
            int evenMedian2 = (simpleArray.Length / 2);
            int actualEvenMedian = (simpleArray[evenMedian1] + simpleArray[evenMedian2]) / 2;
            Console.WriteLine($"{actualEvenMedian}");
        }
        else // checking if the array has an odd number of elements
        {
            int oddMedian = (simpleArray.Length / 2);
            int oddMedianPosition = oddMedian;
            Console.WriteLine($"{simpleArray[oddMedianPosition]}");
        }
    }
}
