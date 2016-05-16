using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(number));
    }

    static BigInteger Factorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }

        BigInteger result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}