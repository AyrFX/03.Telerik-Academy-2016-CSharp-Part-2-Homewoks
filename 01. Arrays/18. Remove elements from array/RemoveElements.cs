using System;
using System.Linq;

class RemoveElements
{
    static void Main()
    {
        short arrayLength = short.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] subsequences = new int[arrayLength];
        for (int i = 0; i < subsequences.Length; i++)
        {
            subsequences[i] = 1;
        }

        for (int i = 1; i < array.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                
                if (array[j] <= array[i] && subsequences[i] < subsequences[j] + 1)
                {
                    subsequences[i] = subsequences[j] + 1;
                }
            }
        }


        Console.WriteLine(array.Length - subsequences.Max());
    }
}