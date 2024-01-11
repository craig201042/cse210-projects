using System;

class Program
{
    static void Main(string[] args)
    {
       Random randomGenerator = new Random();
       int magicNumber = randomGenerator.Next(1, 101);
       int number=0;
       while(number!=magicNumber)
       {
         Console.Write("What is your guess?");
         string guess=Console.ReadLine();
         number=int.Parse(guess);
         if (number>magicNumber)
         { 
          Console.WriteLine("lower");
         }
         else 
         {
          Console.WriteLine("higher");
         }
       }
       Console.WriteLine("You guessed it!");
    }
}