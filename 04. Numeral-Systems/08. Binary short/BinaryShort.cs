using System;

class BinaryShort
{
    static void Main()
    {
        short decimalNumber = short.Parse(Console.ReadLine());
        string binaryNumber = "";

        if (decimalNumber < 0)
        {
            decimalNumber++;
            decimalNumber += short.MaxValue;
            binaryNumber = "1" + DecToBin(decimalNumber).PadLeft(15, '0');
        }
        else
        {
            binaryNumber = "0" + DecToBin(decimalNumber).PadLeft(15, '0');
        }
        
        Console.WriteLine(binaryNumber);
    }

    static string DecToBin(short decimalNumber)
    {
        string binaryNumber = "";
        while (decimalNumber > 0)
        {
            binaryNumber = decimalNumber % 2 + binaryNumber;
            decimalNumber /= 2;
        }
        return binaryNumber;
    }
}