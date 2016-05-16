using System;

class AddingPolynomials
{
    static void Main()
    {
        int polyLength = int.Parse(Console.ReadLine());
        string[] elements = Console.ReadLine().Split(' ');
        int[] firstPoly = Array.ConvertAll(elements, int.Parse);
        elements = Console.ReadLine().Split(' ');
        int[] secondPoly = Array.ConvertAll(elements, int.Parse);

        int[] result = AddPolynomials(firstPoly, secondPoly);
        Console.WriteLine(string.Join(" ", result));
    }

    static int[] AddPolynomials(int[] first, int[] second)
    {
        int[] result = new int[first.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = first[i] + second[i];
        }
        return result;
    }
}