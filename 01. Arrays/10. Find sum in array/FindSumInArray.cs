using System;

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Please enter S: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Please enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter {0}-th element of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        //int s = 11;
        //int[] array = new int[] { 4, 3, 1, 4, 2, 5, 8 };
        int currentSum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                currentSum += array[j];
                if (currentSum > s)
                {
                    currentSum = 0;
                    break;
                }
                else if (currentSum == s)
                {
                    Console.Write("The sequence with sum of {0} is: ", s);
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write(array[k]);
                        if (k != j)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine();
                    return;
                }
            }
        }
        Console.WriteLine("There isn't sequence of elements with sum of {0}!", s);
    }
}