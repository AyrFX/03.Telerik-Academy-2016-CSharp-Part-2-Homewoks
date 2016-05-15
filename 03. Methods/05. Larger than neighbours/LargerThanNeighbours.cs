using System;

class LargerThanNeighbours
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        string[] inputNumbers = Console.ReadLine().Split(' ');
        int[] numbers = Array.ConvertAll(inputNumbers, int.Parse);
        int largerCounter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsLarger(numbers, i))
            {
                largerCounter++;
            }
        }

        Console.WriteLine(largerCounter);
    }

    static bool IsLarger(int[] array, int elementPosition)
    {
        if (elementPosition == 0 || elementPosition == array.Length - 1)
        {
            return false;
        }
        else
        {
            if (array[elementPosition] >= array[elementPosition + 1] && array[elementPosition] >= array[elementPosition - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}