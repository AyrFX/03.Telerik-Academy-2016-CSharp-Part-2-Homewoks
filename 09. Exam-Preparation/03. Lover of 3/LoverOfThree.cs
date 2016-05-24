using System;
using System.Collections.Generic;

class LoverOfThree
{
    static void Main()
    {
        string[] fieldDimensions = Console.ReadLine().Split(' ');
        int fieldRows = int.Parse(fieldDimensions[0]);
        int fieldCols = int.Parse(fieldDimensions[1]);
        int[,] field = new int[fieldRows, fieldCols];
        for (int row = field.GetLength(0) - 1; row >= 0 ; row--)
        {
            for (int col = 0; col < field.GetLength(1); col++)
            {
                field[row, col] = 3 * (field.GetLength(0) - row - 1) + 3 * col;
            }
        }

        int movesCount = int.Parse(Console.ReadLine());
        List<string> moves = new List<string>();
        for (int i = 0; i < movesCount; i++)
        {

            string[] currentMoves = Console.ReadLine().Split(' ');
            int currentMovesCount = int.Parse(currentMoves[1]);
            for (int j = 0; j < currentMovesCount; j++)
            {
                moves.Add(currentMoves[0]);
            }
        }
        
        int currentRow = fieldRows - 1, currentCol = 0;
        ulong sum = 0;
        string lastDirection = moves[0], currentDirection = moves[0];
        for (int i = 0; i < moves.Count; i++)
        {
            currentDirection = moves[i];
            if (currentDirection != lastDirection)
            {
                lastDirection = currentDirection;
                continue;
            }
            if (i > 0)
            {
                NextMove(ref currentRow, ref currentCol, moves[i], field);
            }
            sum += (ulong)field[currentRow, currentCol];
            field[currentRow, currentCol] = 0;
            lastDirection = currentDirection;
        }

        Console.WriteLine(sum);
    }

    static void PrintArray(int[,] array)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write(" {0:D2} ", array[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void NextMove(ref int currentRow, ref int currentCol, string directions, int[,] field)
    {
        int newRow = currentRow, newCol = currentCol;

        if (directions.IndexOf("U") > -1)
        {
            newRow -= 1;
        }
        if (directions.IndexOf("R") > -1)
        {
            newCol += 1;
        }
        if (directions.IndexOf("D") > -1)
        {
            newRow += 1;
        }
        if (directions.IndexOf("L") > -1)
        {
            newCol -= 1;
        }
        if (0 <= newRow && newRow < field.GetLength(0) && 0 <= newCol && newCol < field.GetLength(1))
        {
            currentRow = newRow;
            currentCol = newCol;
        }
    }
}