using System;

class FillTheMatrix
{
    static void Main()
    {
        byte dimensions = byte.Parse(Console.ReadLine());
        int[,] array = new int[dimensions, dimensions];
        string fillType = Console.ReadLine();

        switch (fillType)
        {
            case "a":
                {
                    for (int col = 0; col < array.GetLength(1); col++)
                    {
                        for (int row = 0; row < array.GetLength(0); row++)
                        {
                            array[row, col] = (col * dimensions + row) + 1;
                        }
                    }
                    break;
                }
            case "b":
                {
                    for (int col = 0; col < array.GetLength(1); col++)
                    {
                        if (col % 2 == 0)
                        {
                            for (int row = 0; row < array.GetLength(0); row++)
                            {
                                array[row, col] = (col * dimensions + row) + 1;
                            }
                        }
                        else
                        {
                            for (int row = array.GetLength(0) - 1; row >= 0; row--)
                            {
                                array[row, col] = col * dimensions + (dimensions - row - 1) + 1;
                            }
                        }
                    }
                    break;
                }
            case "c":
                {
                    int counter = 1;
                    for (int i = 0; i <= dimensions - 1; i++)
                    {
                        int col = i, row = 0;
                        while (row <= i)
                        {
                            array[array.GetLength(0) - col - 1, row] = counter;
                            counter++;
                            col--;
                            row++;
                        }
                    }
                    for (int i = dimensions - 2; i >= 0; i--)
                    {
                        int col = 0, row = i;
                        while (col <= i)
                        {
                            array[col, array.GetLength(0) - row - 1] = counter;
                            counter++;
                            col++;
                            row--;
                        }
                    }
                    break;
                }
            case "d":
                {
                    byte direction = 0; //0 - down; 1 - right; 2 - up; 3 - left
                    int row = 0, col = 0, counter = 1;
                    int emptyRowStart = 0, emptyRowEnd = array.GetLength(0), emptyColStart = 0, emptyColEnd = array.GetLength(1);
                    while (counter <= dimensions * dimensions)
                    {
                        for (int i = emptyRowStart; i < emptyRowEnd; i++)
                        {
                            array[row, col] = counter;
                            row++;
                            counter++;
                        }
                        if (counter > dimensions * dimensions)
                        {
                            break;
                        }
                        row--;
                        col++;
                        switch (direction)
                        {
                            case 0:
                                {
                                    emptyColStart++;
                                    break;
                                }
                            case 1:
                                {
                                    emptyRowEnd--;
                                    break;
                                }
                            case 2:
                                {
                                    emptyColEnd--;
                                    break;
                                }
                            case 3:
                                {
                                    emptyRowStart++;
                                    break;
                                }

                        }
                        direction = GetNewDirection(direction);
                        for (int i = emptyColStart; i < emptyColEnd; i++)
                        {
                            array[row, col] = counter;
                            col++;
                            counter++;
                        }
                        if (counter > dimensions * dimensions)
                        {
                            break;
                        }
                        col--;
                        row--;
                        switch (direction)
                        {
                            case 0:
                                {
                                    emptyColStart++;
                                    break;
                                }
                            case 1:
                                {
                                    emptyRowEnd--;
                                    break;
                                }
                            case 2:
                                {
                                    emptyColEnd--;
                                    break;
                                }
                            case 3:
                                {
                                    emptyRowStart++;
                                    break;
                                }

                        }
                        direction = GetNewDirection(direction);
                        for (int i = emptyRowEnd - 1; i >= emptyRowStart; i--)
                        {
                            array[row, col] = counter;
                            row--;
                            counter++;
                        }
                        if (counter > dimensions * dimensions)
                        {
                            break;
                        }
                        row++;
                        col--;
                        switch (direction)
                        {
                            case 0:
                                {
                                    emptyColStart++;
                                    break;
                                }
                            case 1:
                                {
                                    emptyRowEnd--;
                                    break;
                                }
                            case 2:
                                {
                                    emptyColEnd--;
                                    break;
                                }
                            case 3:
                                {
                                    emptyRowStart++;
                                    break;
                                }

                        }
                        direction = GetNewDirection(direction);
                        for (int i = emptyColEnd - 1; i >= emptyColStart; i--)
                        {
                            array[row, col] = counter;
                            col--;
                            counter++;
                        }
                        if (counter > dimensions * dimensions)
                        {
                            break;
                        }
                        col++;
                        row++;
                        switch (direction)
                        {
                            case 0:
                                {
                                    emptyColStart++;
                                    break;
                                }
                            case 1:
                                {
                                    emptyRowEnd--;
                                    break;
                                }
                            case 2:
                                {
                                    emptyColEnd--;
                                    break;
                                }
                            case 3:
                                {
                                    emptyRowStart++;
                                    break;
                                }

                        }
                        direction = GetNewDirection(direction);
                    }
                    
                    break;
                }
        }

        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write(array[row, col]);
                if (col < array.GetLength(1) - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    static byte GetNewDirection(byte currentDirection)
    {
        if (currentDirection < 3)
        {
            return ++currentDirection;
        }
        else
        {
            return 0;
        }
    }
}