using System;

class ParseTags
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        string openTag = "<upcase>";
        string closeTag = "</upcase>";

        while (inputText.IndexOf(openTag) > 0)
        {
            int taggedTextStartIdex = inputText.IndexOf(openTag);
            int taggedTextEndIndex = inputText.IndexOf(closeTag);
            int taggedTextLength = (taggedTextEndIndex + closeTag.Length) - taggedTextStartIdex;
            string taggedText = inputText.Substring(taggedTextStartIdex, taggedTextLength);
            inputText = inputText.Replace(taggedText, taggedText.ToUpper());
            inputText = inputText.Replace(openTag.ToUpper(), "");
            inputText = inputText.Replace(closeTag.ToUpper(), "");
        }

        Console.WriteLine(inputText);
    }

}