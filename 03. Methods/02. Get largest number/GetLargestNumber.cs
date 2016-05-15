using System;

class GetLargestNumber
{
    static void Main()
    {
        string[] inputNumbers = Console.ReadLine().Split(' ');
        int[] numbers = Array.ConvertAll(inputNumbers, int.Parse);
        int maxNumber = GetMax(GetMax(numbers[0], numbers[1]), GetMax(numbers[1], numbers[2]));
        Console.WriteLine(maxNumber);
    }

    static int GetMax(int numberA, int numberB)
    {
        return Math.Max(numberA, numberB);
    }
}