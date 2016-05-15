using System;

class FirstLarger
{
    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        string[] inputArray = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(inputArray, int.Parse);

        Console.WriteLine(GetFirstLarger(array));
    }

    static int GetFirstLarger(int[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] >= array[i-1] && array[i] >= array[i+1])
            {
                return i;
            }
        }
        return -1;
    }
}