using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            double number = double.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new ArgumentException();
            }
            Console.WriteLine("{0:F3}", Math.Sqrt(number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
        
    }
}