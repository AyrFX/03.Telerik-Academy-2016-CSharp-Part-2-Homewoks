using System;

class TriangleSurfaceBySides
{
    static void Main()
    {
        double firstSide = double.Parse(Console.ReadLine());
        double secondSide = double.Parse(Console.ReadLine());
        double thirdSide = double.Parse(Console.ReadLine());

        double halfPeremeter = (firstSide + secondSide + thirdSide) / 2;
        double surface = Math.Sqrt(halfPeremeter * (halfPeremeter - firstSide) * (halfPeremeter - secondSide) * (halfPeremeter - thirdSide));
        Console.WriteLine("{0:F2}", surface);
    }
}