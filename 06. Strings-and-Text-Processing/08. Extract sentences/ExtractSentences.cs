using System;

class ExtractSentences
{
    static void Main()
    {
        string word = Console.ReadLine();
        word = " " + word + " ";
        string text = Console.ReadLine();

        while(text.IndexOf(".") > 0)
        {
            int sentenceEndIndex = text.IndexOf(".");
            string currentSentence = text.Substring(0, sentenceEndIndex + 1);
            if (currentSentence.IndexOf(word) > 0)
            {
                Console.WriteLine(currentSentence);
            }
            text = text.Replace(currentSentence, "");
            text = text.Trim();
        }
    }
}