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
            if (sieve[i] == false)
            {
                continue;
            }
            for (int j = i; j < sieve.Length; j+=i)
            {
                if (j % i == 0 && j != i)
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

        //for (int i = 0; i < sieve.Length; i++)
        //{
        //    Console.WriteLine("index {0} - {1}", i, sieve[i]);
        //}
    }
}