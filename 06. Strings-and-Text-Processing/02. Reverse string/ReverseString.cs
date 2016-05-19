using System;

class ReverseString
{
    public static void Main()
    {
        string inputString = Console.ReadLine();
        char[] letters = inputString.ToCharArray();
        Array.Reverse(letters);

        Console.WriteLine(new String(letters));
    }
}