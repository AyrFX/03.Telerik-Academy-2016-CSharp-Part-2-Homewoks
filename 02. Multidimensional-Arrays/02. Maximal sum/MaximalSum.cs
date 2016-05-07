using System;

class MaximalSum
{
    static void Main()
    {
        string[] dimensions = Console.ReadLine().Split(' ');
        short rows = short.Parse(dimensions[0]);
        short cols = short.Parse(dimensions[1]);
        int[,] array = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            string[] currentRowValues = Console.ReadLine().Split(' ');
            for (int col = 0; col < cols; col++)
            {
                array[row, col] = int.Parse(currentRowValues[col]);
            }
        }

        int currentSum = 0, maxSum = int.MinValue;
        for (int row = 0; row < array.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < array.GetLength(1) - 2; col++)
            {
                currentSum += array[row, col];
                currentSum += array[row + 1, col];
                currentSum += array[row + 2, col];
                currentSum += array[row, col + 1];
                currentSum += array[row + 1, col + 1];
                currentSum += array[row + 2, col + 1];
                currentSum += array[row, col + 2];
                currentSum += array[row + 1, col + 2];
                currentSum += array[row + 2, col + 2];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
                currentSum = 0;
            }
        }
        Console.WriteLine(maxSum);
    }
}