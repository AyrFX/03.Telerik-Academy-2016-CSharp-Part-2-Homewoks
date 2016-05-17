using System;

class BinToHex
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        long decimalNumber = BinToDec(binaryNumber);
        string hexadecimalNumber = DecToHex(decimalNumber);

        Console.WriteLine(hexadecimalNumber);
    }

    static long BinToDec(string binaryNumber)
    {
        long decimalNumber = 0;

        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            decimalNumber += (long)(Char.GetNumericValue(binaryNumber[i]) * Math.Pow(2, binaryNumber.Length - i - 1));
        }

        return decimalNumber;
    }

    static string DecToHex(long decimalNumber)
    {
        string hexadecimal = "";
        while (decimalNumber > 0)
        {
            hexadecimal = GetHexValue(decimalNumber % 16) + hexadecimal;
            decimalNumber /= 16;
        }
        hexadecimal.TrimStart('0');

        return hexadecimal;
    }

    static char GetHexValue(long decNumber)
    {
        switch (decNumber)
        {
            case 0:
                return '0';
            case 1:
                return '1';
            case 2:
                return '2';
            case 3:
                return '3';
            case 4:
                return '4';
            case 5:
                return '5';
            case 6:
                return '6';
            case 7:
                return '7';
            case 8:
                return '8';
            case 9:
                return '9';
            case 10:
                return 'A';
            case 11:
                return 'B';
            case 12:
                return 'C';
            case 13:
                return 'D';
            case 14:
                return 'E';
            case 15:
                return 'F';
            default:
                return ' ';
        }
    }
}