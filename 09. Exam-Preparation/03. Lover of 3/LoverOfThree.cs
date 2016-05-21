using System;

class LoverOfThree
{
    enum directions { RU, UR, LU, UL, DL, LD, RD, DR };

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
        int[,] movesArray = new int[movesCount, 2];
        for (int i = 0; i < movesArray.GetLength(0); i++)
        {
            string[] currentMove = Console.ReadLine().Split(' ');
            switch (currentMove[0])
            {
                case "RU":
                    movesArray[i, 0] = (int)directions.RU;
                    break;
                case "UR":
                    movesArray[i, 0] = (int)directions.UR;
                    break;
                case "LU":
                    movesArray[i, 0] = (int)directions.LU;
                    break;
                case "UL":
                    movesArray[i, 0] = (int)directions.UL;
                    break;
                case "DL":
                    movesArray[i, 0] = (int)directions.DL;
                    break;
                case "LD":
                    movesArray[i, 0] = (int)directions.LD;
                    break;
                case "RD":
                    movesArray[i, 0] = (int)directions.RD;
                    break;
                case "DR":
                    movesArray[i, 0] = (int)directions.DR;
                    break;
            }
            movesArray[i, 1] = int.Parse(currentMove[1]);
        }

        for (int row = 0; row < movesArray.GetLength(0); row++)
        {

        }
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
}