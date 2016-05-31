using System;
using System.Collections.Generic;

class BadCat
{
    public static void Main()
    {
        int linesNumber = int.Parse(Console.ReadLine());
        string[,] positions = new string[linesNumber, 3];
        for (int i = 0; i < linesNumber; i++)
        {
            string[] currentLine = Console.ReadLine().Split(' ');
            positions[i, 0] = currentLine[0];
            positions[i, 1] = currentLine[2];
            positions[i, 2] = currentLine[3];
        }

        string number = string.Empty;
        for (int i = 0; i < positions.GetLength(0); i++)
        {
            number += positions[i, 0];
            number += positions[i, 2];
        }

        for (int i = number.Length - 1; i > 0; i--)
        {
            for (int j = i - 1; j >= 0; j--)
            {
                if (number[i] == number[j])
                {
                    number = number.Remove(i, 1);
                    break;
                }
            }
        }

        number = SortString(number);

        bool swaped;
        do
        {
            swaped = false;
            for (int i = 0; i < positions.GetLength(0); i++)
            {
                string firstDigit = positions[i, 0];
                string secondDigit = positions[i, 2];
                int firstIndex = number.IndexOf(firstDigit);
                int secondIndex = number.IndexOf(secondDigit);
                if ((positions[i, 1] == "before" && firstIndex > secondIndex) ||
                    (positions[i, 1] == "after" && firstIndex < secondIndex))
                {
                    number = SwapChars(number, firstIndex, secondIndex);
                    swaped = true;
                }
            }
        }
        while (swaped);

        for (int i = number.Length - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                string swapedNumber = SwapChars(number, i, j);
                if (PassConditions(positions, swapedNumber) && long.Parse(swapedNumber) < long.Parse(number))
                {
                    number = swapedNumber;
                    i = number.Length - 1;
                    j = i - 1;
                }
            }
        }

        //		List<string> possibleNumbers = new List<string>();
        //		if (number[0] == '0')
        //		{
        //			for (int i = 0; i < number.Length; i++) {
        //				char currentChar = number[i];
        //				string tempNumber = number.Remove(i, 1);
        //				for (int j = 0; j < tempNumber.Length; j++)
        //				{
        //					tempNumber = number.Remove(i, 1);
        //					tempNumber = tempNumber.Insert(j, currentChar.ToString());
        //					if (PassConditions(positions, tempNumber) && tempNumber[0] != '0')
        //				    {
        //				    	possibleNumbers.Add(tempNumber);
        //				    }
        //				}
        //			}
        //			possibleNumbers.Sort();
        //		}
        //		
        //		number = possibleNumbers[0];
        Console.WriteLine(number);

        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }

    static string SwapChars(string input, int firstIndex, int secondIndex)
    {
        char[] array = input.ToCharArray();
        char tempChar = array[firstIndex];
        array[firstIndex] = array[secondIndex];
        array[secondIndex] = tempChar;
        return string.Join("", array);
    }

    static string SortString(string input)
    {
        char[] array = input.ToCharArray();
        Array.Sort(array);
        return string.Join("", array);
    }

    static bool PassConditions(string[,] positions, string number)
    {
        for (int i = 0; i < positions.GetLength(0); i++)
        {
            string firstDigit = positions[i, 0];
            string secondDigit = positions[i, 2];
            int firstIndex = number.IndexOf(firstDigit);
            int secondIndex = number.IndexOf(secondDigit);
            if ((positions[i, 1] == "before" && firstIndex > secondIndex) ||
                (positions[i, 1] == "after" && firstIndex < secondIndex))
            {
                return false;
            }
        }
        return true;
    }
}