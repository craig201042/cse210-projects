using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int value=1;
        int sum=0;
        float average=0;
        List<int> numbers = new List<int>();
        while(value!=0)
        {
          Console.Write("Enter number:");
          value=int.Parse(Console.ReadLine());
         
          numbers.Add(value);
        } 
        int max=numbers[0];
         foreach (int number in numbers)
        {
          sum+=number;
          average=sum/numbers.Count;
          if (number>max)
          {
            max=number;
          }  
        }
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {max}");
    }
}