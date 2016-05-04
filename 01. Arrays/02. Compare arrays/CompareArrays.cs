using System;

class CompareArrays
{
    static void Main()
    {
        byte arraysSizes = byte.Parse(Console.ReadLine());

        int[] firstArray = new int[arraysSizes];
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        int[] secondArray = new int[arraysSizes];
        for (int i = 0; i < firstArray.Length; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        bool equal = true;
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                equal = false;
                break;
            }
        }
        if (equal)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}