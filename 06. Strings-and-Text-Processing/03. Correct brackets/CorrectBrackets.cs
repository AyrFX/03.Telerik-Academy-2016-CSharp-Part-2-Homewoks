
using System;

class CorrectBrackets
{
    public static void Main()
    {
        string expression = Console.ReadLine();
        int openBracket = 0, closeBracket = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                openBracket++;
            }
            else if (expression[i] == ')')
            {
                closeBracket++;
            }
            if (openBracket < closeBracket)
            {
                Console.WriteLine("Incorrect");
                return;
            }
        }

        if (openBracket == closeBracket)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}