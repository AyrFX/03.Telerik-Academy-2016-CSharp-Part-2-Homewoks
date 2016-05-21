using System;

class CalculationProblem
{
    static void Main()
    {
        string[] inputData = Console.ReadLine().Split(' ');
        int sum = 0;
        foreach (string number in inputData)
        {
            sum += FromCode(number);
        }

        Console.WriteLine("{0} = {1}", ToCode(sum), sum);
    }

    static int FromCode(string codedNumber)
    {
        string digits = "abcdefghijklmnopqrstuvw";
        int result = 0;
        for (int i = codedNumber.Length - 1; i >= 0; i--)
        {
            result += (int)(digits.IndexOf(codedNumber[i]) * Math.Pow(23, codedNumber.Length - i - 1));
        }
        return result;
    }

    static string ToCode(int number)
    {
        string digits = "abcdefghijklmnopqrstuvw";
        int catsBase = 23;
        int reminder = 0;
        string result = string.Empty;
        while (number > 0)
        {
            reminder = number % catsBase;
            number = number / catsBase;
            result = digits[reminder] + result;
        }
        return result;
    }
}