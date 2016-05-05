using System;

class SelectionSort
{
    public static void Main()
    {
        short arrayLength = short.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        short smallestIndex;
        for (short i = 0; i < array.Length; i++)
        {
            smallestIndex = FindSmallestIndex(array, i);
            SwapElements(array, smallestIndex, i);
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    static short FindSmallestIndex(int[] array, short searchFrom)
    {
        int min = int.MaxValue;
        short minIndex = searchFrom;
        for (short i = searchFrom; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
        }
        return minIndex;
    }

    static void SwapElements(int[] array, short firstIndex, short secondIndex)
    {
        int temp = array[firstIndex];
        array[firstIndex] = array[secondIndex];
        array[secondIndex] = temp;
    }
}