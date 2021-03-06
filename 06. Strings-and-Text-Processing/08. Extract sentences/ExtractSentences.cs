﻿using System;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        string word = Console.ReadLine().ToLower();
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
            string currentSentence = sentences[i].ToLower();
            if (currentSentence.IndexOf(word) > -1)
            {
                if (!IsWord(currentSentence, word))
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
        int start = 0;
        while(text.IndexOf(word, start) > -1)
        {
            int wordStart = text.IndexOf(word, start);
            char prevSymbol;
            bool frontDelimiter;
            if (wordStart > 0)
            {
                prevSymbol = text[wordStart - 1];
                //if (prevSymbol < 65 || (prevSymbol > 90 && prevSymbol < 97) || prevSymbol > 122)
                if (!char.IsLetter(prevSymbol))
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

            int wordEnd = text.IndexOf(word, start) + word.Length;
            char nextSymbol;
            bool endDelimiter;
            if (wordEnd < text.Length - 1)
            {
                nextSymbol = text[wordEnd];
                //if (nextSymbol < 65 || (nextSymbol > 90 && nextSymbol < 97) || nextSymbol > 122)
                if (!char.IsLetter(nextSymbol))
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

            //text = text.Remove(wordStart, wordEnd - wordStart);
            start = wordEnd - 1;

            if (frontDelimiter && endDelimiter)
            {
                return true;
            }
        }

        return false;
    }
}