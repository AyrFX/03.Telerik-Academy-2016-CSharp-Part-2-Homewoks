using System;

class FrequentNumber
{
    public static void Main()
    {
        short arrayLength = short.Parse(Console.ReadLine());
        short[] array = new short[arrayLength];
        for (short i = 0; i < array.Length; i++)
        {
            array[i] = short.Parse(Console.ReadLine());
        }
        short[] occurences = new short[10001];
        for (short i = 0; i < occurences.Length; i++)
        {
            occurences[i] = 0;
        }

        for (short i = 0; i < array.Length; i++)
        {
            occurences[array[i]]++;
        }

        short maxOccurences = 0, maxIndex = 0;
        for (short i = 0; i < occurences.Length; i++)
        {
            if (occurences[i] > maxOccurences)
            {
                maxOccurences = occurences[i];
                maxIndex = i;
            }
        }

        Console.Write("{0} ({1} times)", maxIndex, maxOccurences);
    }
}