using System;

class EnglishDigit
{
    static void Main()
    {
        string inputNumber = Console.ReadLine();

        Console.WriteLine(digitInWord(inputNumber[inputNumber.Length - 1]));
    }

    static string digitInWord (char digit)
    {
        switch (digit)
        {
            case '0':
                {
                    return "zero";
                }
            case '1':
                {
                    return "one";
                }
            case '2':
                {
                    return "two";
                }
            case '3':
                {
                    return "three";
                }
            case '4':
                {
                    return "four";
                }
            case '5':
                {
                    return "five";
                }
            case '6':
                {
                    return "six";
                }
            case '7':
                {
                    return "seven";
                }
            case '8':
                {
                    return "eight";
                }
            case '9':
                {
                    return "nine";
                }
            default:
                {
                    return "";
                }
        }
    }
}