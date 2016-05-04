using System;

class AllocateArray
{
    static void Main()
    {
        byte arraySize = byte.Parse(Console.ReadLine());
        int[] array = new int[arraySize];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
            Console.WriteLine(array[i]);
        }
    }
}