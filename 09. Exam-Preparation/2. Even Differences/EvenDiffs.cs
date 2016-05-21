using System;
using System.Numerics;

class EvenDiffs
{
    static void Main()
    {
        string[] sequence = Console.ReadLine().Split(' ');
        int[] numbers = Array.ConvertAll(sequence, int.Parse);

        int currentIndex = 1;
        BigInteger differencesSum = 0;
        uint currentDifference;
        while (currentIndex < numbers.Length)
        {
            currentDifference = (uint)Math.Abs(numbers[currentIndex] - numbers[currentIndex - 1]);
            if (currentDifference % 2 == 0)
            {
                currentIndex += 2;
            }
            else
            {
                currentIndex++;
            }
            if (currentDifference % 2 == 0)
            {
                differencesSum += currentDifference;
            }
        }
        Console.WriteLine(differencesSum);
    }
}