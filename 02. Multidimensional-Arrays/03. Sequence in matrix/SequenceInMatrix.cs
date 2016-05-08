using System;

class SequenceInMatrix
{
    static void Main()
    {
        string[] dimensions = Console.ReadLine().Split(' ');
        int rows = int.Parse(dimensions[0]);
        int cols = int.Parse(dimensions[1]);
        string[,] array = new string[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            string[] currentRow = Console.ReadLine().Split(' ');
            for (int j = 0; j < currentRow.Length; j++)
            {
                array[i, j] = currentRow[j];
            }
        }

        int maxSequenceLength = int.MinValue;

        //rows
        for (int row = 0; row < array.GetLength(0); row++)
        {
            string currentValue = array[row, 0];
            int currentSequenceCounter = 1;
            for (int col = 1; col < array.GetLength(1); col++)
            {
                if (currentValue == array[row, col])
                {
                    currentSequenceCounter++;
                    if (currentSequenceCounter > maxSequenceLength)
                    {
                        maxSequenceLength = currentSequenceCounter;
                    }
                }
                else
                {
                    currentValue = array[row, col];
                    currentSequenceCounter = 1;
                }
            }
        }

        //cols
        for (int col = 0; col < array.GetLength(1); col++)
        {
            string currentValue = array[0, col];
            int currentSequenceCounter = 1;
            for (int row = 1; row < array.GetLength(0); row++)
            {
                if (currentValue == array[row, col])
                {
                    currentSequenceCounter++;
                    if (currentSequenceCounter > maxSequenceLength)
                    {
                        maxSequenceLength = currentSequenceCounter;
                    }
                }
                else
                {
                    currentValue = array[row, col];
                    currentSequenceCounter = 1;
                }
            }
        }

        //diagonals from [0,0], [0,1], ...
        for (int startCol = 0; startCol < array.GetLength(1); startCol++)
        {
            string currentValue = array[0, 0];
            int currentSequenceCounter = 1;
            for (int row = 0, col = startCol; row < array.GetLength(0) && col < array.GetLength(1); row++, col++)
            {
                if (currentValue == array[row, col])
                {
                    currentSequenceCounter++;
                    if (currentSequenceCounter > maxSequenceLength)
                    {
                        maxSequenceLength = currentSequenceCounter;
                    }
                }
                else
                {
                    currentValue = array[row, col];
                    currentSequenceCounter = 1;
                }
            }
        }

        //diagonal from [0,0], [1,0], ...
        for (int startRow = 0; startRow < array.GetLength(0); startRow++)
        {
            string currentValue = array[0, 0];
            int currentSequenceCounter = 1;
            for (int row = startRow, col = 0; row < array.GetLength(0) && col < array.GetLength(1); row++, col++)
            {
                if (currentValue == array[row, col])
                {
                    currentSequenceCounter++;
                    if (currentSequenceCounter > maxSequenceLength)
                    {
                        maxSequenceLength = currentSequenceCounter;
                    }
                }
                else
                {
                    currentValue = array[row, col];
                    currentSequenceCounter = 1;
                }
            }
        }

        //diagonals from [0,m], [0,m-1], ..., [0,0]
        for (int startCol = array.GetLength(1) - 1; startCol <= 0; startCol--)
        {
            string currentValue = array[0, array.GetLength(1) - 1];
            int currentSequenceCounter = 1;
            for (int row = 0, col = startCol; row < array.GetLength(0) && col < array.GetLength(1); row++, col++)
            {
                if (currentValue == array[row, col])
                {
                    currentSequenceCounter++;
                    if (currentSequenceCounter > maxSequenceLength)
                    {
                        maxSequenceLength = currentSequenceCounter;
                    }
                }
                else
                {
                    currentValue = array[row, col];
                    currentSequenceCounter = 1;
                }
            }
        }

        //diagonal from [n,0], [n-1,0], ..., [0,0]
        for (int startRow = array.GetLength(0) - 1; startRow <= 0; startRow--)
        {
            string currentValue = array[array.GetLength(0) - 1, 0];
            int currentSequenceCounter = 1;
            for (int row = startRow, col = 0; row < array.GetLength(0) && col < array.GetLength(1); row++, col++)
            {
                if (currentValue == array[row, col])
                {
                    currentSequenceCounter++;
                    if (currentSequenceCounter > maxSequenceLength)
                    {
                        maxSequenceLength = currentSequenceCounter;
                    }
                }
                else
                {
                    currentValue = array[row, col];
                    currentSequenceCounter = 1;
                }
            }
        }

        Console.WriteLine(maxSequenceLength);
    }
}