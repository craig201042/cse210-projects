using System;

class Program
{
   
    static void Main(string[] args)
    {
        List<string> prompts=new List<string>();
        List<string> questions=new List<string>();
        List<string> hints=new List<string>();
        
        List<string> menu=new List<string>();
        menu.Add("1.Start breathing activity");
        menu.Add("2.Start reflecting activity");
        menu.Add("3.Starting listing activity");
        menu.Add("4.Quit");

        string userchoice=" "; 
        int choice=0;      
        while(choice!=4){
         Console.WriteLine("Menu Options:");
         foreach(string s in menu){
               Console.WriteLine(s);
         }
         Console.WriteLine("Select a choice from the menu:");
         userchoice=Console.ReadLine();    
         choice=int.Parse(userchoice);
         if(choice==1){
            BreathingActivity b=new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly.Clear your mind and focus on your breathing.");
            b.run();
         }
         else if(choice==2){
            ReflectingActivity r=new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.This will help you recognize the power you have and how you can use it in other aspects of your life.", prompts, questions);
            r.run();
         }
         else if(choice==3){
            ListingActivity l=new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", hints);
            l.run();
         }
        }
    }
}