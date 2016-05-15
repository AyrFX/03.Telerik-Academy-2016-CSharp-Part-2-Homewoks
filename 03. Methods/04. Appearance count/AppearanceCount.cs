using System;

class AppearanceCount
{
    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        string[] inpputNumbers = Console.ReadLine().Split(' ');
        int[] numbers = Array.ConvertAll(inpputNumbers, int.Parse);
        int numberForSeek = int.Parse(Console.ReadLine());
        Console.WriteLine(CountAppearances(numbers, numberForSeek));
    }

    static int CountAppearances(int[] array, int number)
    {
        int appearances = 0;
        foreach (var element in array)
        {
            if (element == number)
            {
                appearances += 1;
            }
        }
        return appearances;
    }
}