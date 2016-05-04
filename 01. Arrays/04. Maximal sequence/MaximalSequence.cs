using System;

class MaximalSequence
{
    static void Main()
    {
        short arraySize = short.Parse(Console.ReadLine());
        int[] array = new int[arraySize];
        for (short i = 0; i < arraySize; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxSequence = 1, commonMaxSequence = 0; ;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i-1])
            {
                maxSequence++;
                commonMaxSequence = Math.Max(maxSequence, commonMaxSequence);
            }
            else
            {
                maxSequence = 1;
            }
        }
        Console.WriteLine(commonMaxSequence);
    }
}