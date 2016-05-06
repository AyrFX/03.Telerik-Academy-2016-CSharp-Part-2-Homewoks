using System;

class PrimeNumbers
{
    static void Main()
    {
        int searchTo = int.Parse(Console.ReadLine());
        bool[] sieve = new bool[searchTo + 1];
        for (int i = 0; i < sieve.Length; i++)
        {
            sieve[i] = true;
        }

        for (int i = 2; i < sieve.Length; i++)
        {
            if (sieve[i] == false && i != 2)
            {
                continue;
            }
            for (int j = i+1; j < sieve.Length; j++)
            {
                if (j % i == 0)
                {
                    sieve[j] = false;
                }
            }
        }

        for (int i = sieve.Length - 1; i >= 0; i--)
        {
            if (sieve[i] == true)
            {
                Console.WriteLine(i);
                return;
            }
        }
    }
}