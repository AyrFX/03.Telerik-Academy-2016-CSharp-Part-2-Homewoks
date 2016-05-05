using System;

class BinarySearch
{
    public static void Main()
    {
        short arrayLength = short.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        for (short i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int searchFor = int.Parse(Console.ReadLine());

        if (array[0] == searchFor)
        {
            Console.WriteLine(0);
            return;
        }
        if (array[array.Length - 1] == searchFor)
        {
            Console.WriteLine(array.Length - 1);
            return;
        }

        int startIndex = 0, endIndex = array.Length - 1, middleIndex = 0;
        do
        {
            middleIndex = (endIndex + startIndex) / 2;
            if (searchFor == array[middleIndex])
            {
                break;
            }
            else if (searchFor < array[middleIndex])
            {
                endIndex = middleIndex;
            }
            else
            {
                startIndex = middleIndex;
            }
        }
        while (endIndex - startIndex > 1);

        if (array[middleIndex] != searchFor)
        {
            Console.WriteLine(-1);
        }
        else
        {
            while (middleIndex != 0 && array[middleIndex] == array[middleIndex - 1])
            {
                middleIndex--;
            }
            Console.Write(middleIndex);
        }
    }
}