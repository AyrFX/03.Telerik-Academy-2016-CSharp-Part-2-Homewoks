using System;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        string outputText = "";

        string[] sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < sentences.Length; i++)
        {
            sentences[i] = sentences[i].Trim() + '.';
        }
        //string[] senteces = Regex.Split(text, @"(?<=[\.!\?])\s+");
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].IndexOf(word) > 0 || sentences[i].IndexOf(word.ToUpper()) > 0 || sentences[i].IndexOf(word.ToLower()) > 0)
            {
                if (!IsWord(sentences[i], word) && !IsWord(sentences[i], word.ToUpper()) && !IsWord(sentences[i], word.ToLower()))
                {
                    continue;
                }
                if (outputText != "")
                {
                    outputText += " ";
                }
                outputText += sentences[i];
            }
        }

        Console.WriteLine(outputText);
    }

    static bool IsWord(string text, string word)
    {
        while(text.IndexOf(word) > 0)
        {
            int wordStart = text.IndexOf(word);
            char prevSymbol;
            bool frontDelimiter;
            if (wordStart > 0)
            {
                prevSymbol = text[wordStart - 1];
                if (prevSymbol < 65 || (prevSymbol > 90 && prevSymbol < 97) || prevSymbol > 122)
                {
                    frontDelimiter = true;
                }
                else
                {
                    frontDelimiter = false;
                }
            }
            else
            {
                frontDelimiter = true;
            }

            int wordEnd = text.IndexOf(word) + word.Length;
            char nextSymbol;
            bool endDelimiter;
            if (wordEnd < text.Length - 1)
            {
                nextSymbol = text[wordEnd];
                if (nextSymbol < 65 || (nextSymbol > 90 && nextSymbol < 97) || nextSymbol > 122)
                {
                    endDelimiter = true;
                }
                else
                {
                    endDelimiter = false;
                }
            }
            else
            {
                endDelimiter = true;
            }

            text = text.Remove(wordStart, wordEnd - wordStart);

            if (frontDelimiter && endDelimiter)
            {
                return true;
            }
        }

        return false;
    }
}