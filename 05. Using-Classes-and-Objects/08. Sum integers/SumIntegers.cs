using System;

class SumIntegers
{
    static void Main()
    {
        string[] inputElements = Console.ReadLine().Split(' ');
        short[] numbers = Array.ConvertAll(inputElements, short.Parse);

        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        Console.WriteLine(sum);
    }
}