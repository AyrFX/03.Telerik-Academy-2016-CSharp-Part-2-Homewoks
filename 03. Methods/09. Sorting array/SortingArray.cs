using System;

class SortingArray
{
    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        string[] elements = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(elements, int.Parse);

        SortArray(array);
        Console.WriteLine(string.Join(" ", array));
    }

    static int IndexOfMax(int[] array, int startFrom)
    {
        int maxElement = int.MinValue, maxElementIndex = 0;
        for (int i = startFrom; i < array.Length; i++)
        {
            if (maxElement < array[i])
            {
                maxElement = array[i];
                maxElementIndex = i;
            }
        }
        return maxElementIndex;
    }

    static void SwapElements (int[] array, int firstIndex, int secondIndex)
        {
        int tempValue = array[firstIndex];
        array[firstIndex] = array[secondIndex];
        array[secondIndex] = tempValue;
        }

    static void SortArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int maxIndex = IndexOfMax(array, i);
            SwapElements(array, i, maxIndex);
        }
        Array.Reverse(array);
    }
}