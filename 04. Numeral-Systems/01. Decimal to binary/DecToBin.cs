using System;

class DecToBin
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        string binary = "";
        while (number > 0)
        {
            binary = number % 2 + binary;
            number /= 2;
        }
        binary.TrimStart('0');

        Console.WriteLine(binary);
    }
}