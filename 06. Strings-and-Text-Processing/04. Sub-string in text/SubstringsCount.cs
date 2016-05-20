using System;

class SubstringsCount
{
    public static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();

        //int occurences = (text.Length - text.Replace(pattern, "").Length) / pattern.Length;
        int occurences = 0;
        while (text.IndexOf(pattern, StringComparison.CurrentCultureIgnoreCase) > 0)
        {
            occurences++;
            text = text.Remove(text.IndexOf(pattern, StringComparison.CurrentCultureIgnoreCase), pattern.Length);
        }
        Console.WriteLine(occurences);
    }
}