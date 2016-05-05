using System;

class MaximalKSum
{
    public static void Main(string[] args)
    {
        short givenSequenceLength = short.Parse(Console.ReadLine());
        short searchedSequenceLength = short.Parse(Console.ReadLine());
        int[] sequence = new int[givenSequenceLength];
        for (int i = 0; i < givenSequenceLength; i++)
        {
            sequence[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(sequence);
        int sum = 0;
        for (int i = sequence.Length - 1; i > sequence.Length - 1 - searchedSequenceLength; i--)
        {
            sum += sequence[i];
        }

        Console.Write(sum);
    }
}