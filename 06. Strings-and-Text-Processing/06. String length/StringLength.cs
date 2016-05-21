using System;

class StringLength
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        inputText = inputText.Replace("\\", string.Empty);
        Console.WriteLine(inputText.PadRight(20, '*'));
    }
}