using System;

class TriangleSurface
{
    static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        double altitude = double.Parse(Console.ReadLine());

        double surface = (side * altitude) / 2;
        Console.WriteLine("{0:F2}", surface);
    }
}