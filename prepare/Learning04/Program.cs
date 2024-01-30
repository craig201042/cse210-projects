using System;

class Program
{
    static void Main(string[] args)
    {
       Assignment assign=new Assignment("Craig", "Math");
       string str=assign.GetSummary();
       Console.WriteLine(str);
            
       MathAssignment mathassign=new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
       Console.WriteLine(mathassign.GetSummary());
       Console.WriteLine(mathassign.GetHomeworkList());
       
       WritingAssignment writingassign=new WritingAssignment("Mary Waters", "Chinese History", "The Causes of World War II");

       Console.WriteLine(writingassign.GetSummary());
       Console.WriteLine(writingassign.GetWritingInformation());


    }
}