using System;

class SubstringsCount
{
    public static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();

        int occurences = (text.Length - text.Replace(pattern, "").Length) / pattern.Length;
        Console.WriteLine(occurences);
    }
}