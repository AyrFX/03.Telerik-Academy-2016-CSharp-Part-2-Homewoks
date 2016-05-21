using System;

class EnterNumbers
{
    static void Main()
    {
        string outputString = string.Empty;
        int lastNumber = 0, currentNumber;

        for (int i = 0; i < 10; i++)
        {
            if (outputString != string.Empty)
            {
                outputString += " < ";
            }
            if (outputString == string.Empty)
            {
                currentNumber = ReadNumber(0, 100);
            }
            else
            {
                currentNumber = ReadNumber(lastNumber, 100);
            }
            lastNumber = currentNumber;
            outputString += currentNumber;
        }

        Console.WriteLine(outputString);
    }

    static int ReadNumber(int start, int end)
    {
        int number;
        try
        {
            number = int.Parse(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            throw new Exception(ex.Message, ex.InnerException);
        }

        if (number < start || number > end)
        {
            throw new ArgumentException(string.Format("The number should be between {0} and {1}", start, end));
        }

        return number;
    }
}