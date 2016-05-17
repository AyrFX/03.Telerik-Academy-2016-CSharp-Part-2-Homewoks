using System;

class IntegerCalculations
{
    static void Main()
    {
        string[] elements = Console.ReadLine().Split(' ');
        short[] numbers = Array.ConvertAll(elements, short.Parse);

        Console.WriteLine(Min(numbers));
        Console.WriteLine(Max(numbers));
        Console.WriteLine("{0:F2}", Average(numbers));
        Console.WriteLine(Sum(numbers));
        Console.WriteLine(Product(numbers));
    }

    static short Min(params short[] numbers)
    {
        short result = short.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (result > numbers[i])
            {
                result = numbers[i];
            }
        }
        return result;
    }

    static short Max(params short[] numbers)
    {
        short result = short.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (result < numbers[i])
            {
                result = numbers[i];
            }
        }
        return result;
    }

    static double Average(params short[] numbers)
    {
        int result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            result += numbers[i];
        }
        return result / (numbers.Length * 1.0);
    }

    static int Sum(params short[] numbers)
    {
        int result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            result += numbers[i];
        }
        return result;
    }

    static long Product(params short[] numbers)
    {
        long result = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            result *= numbers[i];
        }
        return result;
    }
}