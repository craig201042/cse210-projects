using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
       
       DateTime theCurrentTime = DateTime.Now; 
       List<string> _menu=new List<string>();
       _menu.Add("1.Write");
       _menu.Add("2.Display");
       _menu.Add("3.Load");
       _menu.Add("4.Save");
       _menu.Add("5.Quit");
       int choice=0;
       Journal journal=new Journal(); 
       PromptGenerator pg=new PromptGenerator();
       Entry entry=new Entry();
       while(choice<_menu.Count){
         Console.WriteLine("Please select one of the following choices?");
         foreach(string m in _menu){
         Console.WriteLine(m);
         }
         Console.Write("What would you like to do?");
         choice=int.Parse(Console.ReadLine());
         if(choice ==1){
              entry._prompt=pg.GetRandomPrompt();   
              Console.WriteLine(entry._prompt);
              entry._response=Console.ReadLine(); 
              entry._date=theCurrentTime.ToShortDateString(); 
              journal.AddEntry(entry);      
         }
         else if(choice==2){
              journal.Display();
         }
         else if(choice==3){
              Console.WriteLine("What is the file name?");
              string filename=Console.ReadLine();
              journal.loadFile(filename);
         }
         else if(choice==4){
               Console.WriteLine("What is the file name?");
               string filename=Console.ReadLine();
               Console.WriteLine("saving the file...");
               journal.saveFile(filename);
         }
         else if(choice==5){
               break;
         }
       }
    }
}