using System;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        string outputText = "";

        //string[] senteces = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string[] senteces = Regex.Split(text, @"(?<=[\.!\?])\s+");
        for (int i = 0; i < senteces.Length; i++)
        {
            if (senteces[i].IndexOf(word) > 0)
            {
                if (!IsWord(senteces[i], word))
                {
                    continue;
                }
                if (outputText != "")
                {
                    outputText += " ";
                }
                outputText += senteces[i].Trim();
            }
        }

        Console.WriteLine(outputText);

        //while (text.IndexOf(".") > 0 || text.IndexOf("!") > 0 || text.IndexOf("?") > 0)
        //{
        //    int sentenceEndIndex = text.IndexOf(".");
        //    if (sentenceEndIndex > -1 && sentenceEndIndex > text.IndexOf("!") && text.IndexOf("!") > -1)
        //    {
        //        sentenceEndIndex = text.IndexOf("!");
        //    };
        //    if (sentenceEndIndex > -1 && sentenceEndIndex > text.IndexOf("?") && text.IndexOf("?") > -1)
        //    {
        //        sentenceEndIndex = text.IndexOf("?");
        //    };
        //    string currentSentence = text.Substring(0, sentenceEndIndex + 1);
        //    if (currentSentence.IndexOf(word) > 0)
        //    {
        //        if (outputText != "")
        //        {
        //            outputText += " ";
        //        }
        //        outputText += currentSentence;
        //    }
        //    text = text.Replace(currentSentence, "");
        //    text = text.Trim();
        //}
        //Console.WriteLine(outputText);
    }

    static bool IsWord(string text, string word)
    {
        while(text.IndexOf(word) > 0)
        {

        }
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

        return frontDelimiter && endDelimiter;
    }
}