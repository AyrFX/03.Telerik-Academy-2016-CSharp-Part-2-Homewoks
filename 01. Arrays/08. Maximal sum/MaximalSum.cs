using System;

class MaximalSum
{
    public static void Main(string[] args)
    {
        short arrayLength = short.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        //		int commonMaxSum = int.MinValue, currentMaxSum = 0;
        //		for (short i = 0; i < array.Length; i++) {
        //			for (int j = i; j < array.Length; j++) {
        //				currentMaxSum = 0;
        //				for (int k = i; k <= j; k++) {
        //					currentMaxSum += array[k];
        //				}
        //				if (currentMaxSum > commonMaxSum)
        //				{
        //					commonMaxSum = currentMaxSum;
        //				}
        //			}
        //		}

        int currentSum = 0, maxSum = int.MinValue;
        for (int j = 0; j < array.Length; j++)
        {
            for (int k = j; k < array.Length; k++)
            {
                currentSum += array[k];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
                else if (currentSum <= 0)
                {
                    j = k;
                    break;
                }
            }
            currentSum = 0;
        }

        Console.WriteLine(maxSum);
    }
}