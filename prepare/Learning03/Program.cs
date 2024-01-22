using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1=new Fraction();
        Fraction f2=new Fraction(5);
        Fraction f3=new Fraction(5,2);
        f1.SetTop(7);
        f1.GetTop();
        f2.SetBottom(3);
        f2.GetBottom();
        f3.SetTop(8);
        f3.GetTop();
        f3.SetBottom(3);
        f3.GetBottom();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}