using System;

class Program
{

    static void Main(string[] args)
    {
       Console.WriteLine("What is your score?");
       string userInput=Console.ReadLine();
       int score=int.Parse(userInput);  
       string letter;    
       if (score>=90)
       {
          letter="A";
       }
       else if (score>=80)
       {
          letter="B";
       }
       else if (score>=70)
       {
          letter="C";
       }
       else if (score>=60)
       {
          letter="D";
       }
       else 
       {
          letter="F";
       }
       Console.WriteLine($"Your letter grade is:{letter}");
       if(score>=70)
       {
           Console.WriteLine("Congratulate for passing the course!");
       }
       else
       {
           Console.WriteLine("Sorry for not passing the course,try again and you can do it!"); 
       }
    }
    
}