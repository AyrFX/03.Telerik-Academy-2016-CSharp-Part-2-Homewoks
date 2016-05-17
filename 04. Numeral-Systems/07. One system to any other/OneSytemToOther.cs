using System;

class OneSytemToOther
{
    static void Main()
    {
        byte fromBase = byte.Parse(Console.ReadLine());
        string number = Console.ReadLine();
        byte toBase = byte.Parse(Console.ReadLine());

        long decimalNumber = AnyToDecimal(number, fromBase);
        string result = DecimalToAny(decimalNumber, toBase);
        Console.WriteLine(result);
    }

    static long AnyToDecimal(string number, byte fromBase)
    {
        if (fromBase == 10)
        {
            return long.Parse(number);
        }

        long resultNumber = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            resultNumber += (long)(GetDigitValue(number[i]) * Math.Pow(fromBase, number.Length - i - 1));
        }

        return resultNumber;
    }

    static byte GetDigitValue(char baseDigit)
    {
        switch (baseDigit)
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

    static string DecimalToAny(long number, byte toBase)
    {
        if (toBase == 10)
        {
            return number.ToString();
        }

        string resultNumber = "";
        while (number > 0)
        {
            resultNumber = GetDigitSign(number % toBase) + resultNumber;
            number /= toBase;
        }
        resultNumber.TrimStart('0');

        return resultNumber;
    }

    static char GetDigitSign(long decNumber)
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