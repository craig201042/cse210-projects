using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

class Program
{

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name=PromptUserName();
        int number=PromptUserNumber();
        Double square=SquareNumber(number);
        DisplayResult(name,square);             
    }
     static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name:");
        string name=Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        int number=int.Parse(Console.ReadLine());
        return number;
    }

    static Double SquareNumber(int number)
    {
        Double square=Math.Pow(number,2);
        return square;
    }

    static void DisplayResult(string name, Double square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
   