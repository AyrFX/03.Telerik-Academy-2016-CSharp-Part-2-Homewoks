using System;

class ReverseNumber
{
    static void Main()
    {
        string inputNumber = Console.ReadLine();

        Console.WriteLine(Reverse(inputNumber));
    }

    static string Reverse(string input)
    {
        string result = "";
        for (int i = 0; i < input.Length; i++)
        {
            result = input[i] + result;
        }
        return result;
    }
}