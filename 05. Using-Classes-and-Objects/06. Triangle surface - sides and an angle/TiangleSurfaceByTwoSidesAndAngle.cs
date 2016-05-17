using System;

class TiangleSurfaceByTwoSidesAndAngle
{
    static void Main()
    {
        double firstSide = double.Parse(Console.ReadLine());
        double secondSide = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());

        double surface = (firstSide * secondSide * Math.Sin(angle * Math.PI / 180)) / 2;
        Console.WriteLine("{0:F2}", surface);
    }
}