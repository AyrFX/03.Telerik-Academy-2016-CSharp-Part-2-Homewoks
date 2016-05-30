using System;

class EnterNumbers
{
    static void Main()
    {
        string outputString = "1 < ";
        int lastNumber = 0, currentNumber;

        for (int i = 0; i < 10; i++)
        {
            if (i != 0)
            {
                outputString += " < ";
            }
            try
            {
                if (outputString == string.Empty)
                {
                    currentNumber = ReadNumber(1, 100);
                }
                else
                {
                    currentNumber = ReadNumber(lastNumber, 100);
                }
                lastNumber = currentNumber;
                outputString += currentNumber;
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
                return;
            }
        }

        outputString += " < 100";
        Console.WriteLine(outputString);
    }

    static int ReadNumber(int start, int end)
    {
        int number;
        number = int.Parse(Console.ReadLine());

        if (number <= start || number >= end)
        {
            throw new ArgumentException(string.Format("The number should be between {0} and {1}", start, end));
        }

        return number;
    }
}