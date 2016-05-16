using System;

class BinToDec
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        long decimalNumber = 0;

        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            decimalNumber += (long)(Char.GetNumericValue(binaryNumber[i]) * Math.Pow(2, binaryNumber.Length - i - 1));
        }

        Console.WriteLine(decimalNumber);
    }
}