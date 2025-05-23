using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(1, 2);
        f1.SetBottom(3);
        Console.WriteLine($"f1: {f1.GetFractionString()}");
        Console.WriteLine($"f1: {f1.GetDecimalValue()}");
        Console.WriteLine($"f2: {f2.GetFractionString()}");
        Console.WriteLine($"f2: {f2.GetDecimalValue()}");
        Console.WriteLine($"f3: {f3.GetFractionString()}");
        Console.WriteLine($"f3: {f3.GetDecimalValue()}");
    }
}