using System;

class HexToBin
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        long decimalNumber = HexToDec(hexNumber);
        string binaryNumber = DecToBin(decimalNumber);

        Console.WriteLine(binaryNumber);
    }

    static long HexToDec(string hexNumber)
    {
        long decimalNumber = 0;

        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {
            decimalNumber += (long)(GetDecValue(hexNumber[i]) * Math.Pow(16, hexNumber.Length - i - 1));
        }

        return decimalNumber;
    }

    static int GetDecValue(char hex)
    {
        switch (hex)
        {
            case '0':
                return 0;
            case '1':
                return 1;
            case '2':
                return 2;
            case '3':
                return 3;
            case '4':
                return 4;
            case '5':
                return 5;
            case '6':
                return 6;
            case '7':
                return 7;
            case '8':
                return 8;
            case '9':
                return 9;
            case 'A':
                return 10;
            case 'B':
                return 11;
            case 'C':
                return 12;
            case 'D':
                return 13;
            case 'E':
                return 14;
            case 'F':
                return 15;
            default:
                return 0;
        }
    }

    static string DecToBin(long decNumber)
    {
        string binaryNumber = "";
        while (decNumber > 0)
        {
            binaryNumber = decNumber % 2 + binaryNumber;
            decNumber /= 2;
        }
        binaryNumber.TrimStart('0');

        return binaryNumber;
    }
}