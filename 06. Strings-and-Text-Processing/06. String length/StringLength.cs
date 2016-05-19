using System;

class StringLength
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        Console.WriteLine(inputText.PadRight(20, '*'));
    }
}