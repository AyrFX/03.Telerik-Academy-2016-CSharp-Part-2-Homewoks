using System;

class SeriesOfLetters
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        for (int i = inputText.Length - 1; i > 0; i--)
        {
            if (inputText[i] == inputText[i-1])
            {
                inputText = inputText.Remove(i, 1);
            }
        }

        Console.WriteLine(inputText);
    }
}