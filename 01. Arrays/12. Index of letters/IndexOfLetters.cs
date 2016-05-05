using System;

class IndexOfLetters
{
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine(Array.IndexOf(letters, word[i]));
        }
    }
}