using System;
using System.Collections.Generic;

class NumberAsArray
{
    static void Main()
    {
        string[] lengths = Console.ReadLine().Split(' ');
        string[] firstArrayStrings = Console.ReadLine().Split(' ');
        byte[] firstArray = Array.ConvertAll(firstArrayStrings, byte.Parse);
        string[] secondArrayStrings = Console.ReadLine().Split(' ');
        byte[] secondArray = Array.ConvertAll(secondArrayStrings, byte.Parse);

        List<int> result = SumArrays(firstArray, secondArray);

        Console.WriteLine(string.Join(" ", result));
    }

    static List<int> SumArrays(byte[] numberA, byte[] numberB)
    {
        List<int> result = new List<int>();
        int reminder = 0;
        for (int i = 0; i < Math.Max(numberA.Length, numberB.Length); i++)
        {
            if (i < numberA.Length && i < numberB.Length)
            {
                if (((numberA[i] + numberB[i]) % 10) + reminder >= 10)
                {
                    result.Add((((numberA[i] + numberB[i]) % 10) + reminder) % 10);
                    reminder = (numberA[i] + numberB[i] + reminder) / 10;
                }
                else
                {
                    result.Add(((numberA[i] + numberB[i]) % 10) + reminder);
                    reminder = (numberA[i] + numberB[i] + reminder) / 10;
                }
            }
            else if (i >= numberA.Length)
            {
                if ((numberB[i] % 10) + reminder >= 10)
                {
                    result.Add(((numberB[i] % 10) + reminder) % 10);
                    reminder = (numberB[i] + reminder) / 10;
                }
                else
                {
                    result.Add((numberB[i] % 10) + reminder);
                    reminder = (numberB[i]+ reminder) / 10;
                }
            }
            else if (i >= numberB.Length)
            {
                if ((numberA[i] % 10) + reminder >= 10)
                {
                    result.Add((((numberA[i] % 10) + reminder) % 10));
                    reminder = (numberA[i] + reminder) / 10;
                }
                else
                {
                    result.Add((numberA[i] % 10) + reminder);
                    reminder = (numberA[i] + reminder) / 10;
                }
            }
        }

        if (reminder > 0)
        {
            result.Add(reminder);
        }

        return result;
    }
}