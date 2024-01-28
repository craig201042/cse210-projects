using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
class Program
{
    private static bool hide=false;
    private static string userInput;
    private static List<string> sl;

    static void Main(string[] args)
    {
        Reference  reference= new Reference("John", 3, 16, 17);
        string content="For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.For God did not send his Son into the world to condemn the world, but to save the world through him.";
        sl=content.Split(',').ToList();
        Scripture script = new Scripture(reference, content);
        Random rnd=new Random();
        Console.WriteLine(script.GetTheDispaly());
        Console.WriteLine("Press enter to continue or type 'Quit' to finish");
        userInput=Console.ReadLine();
        while(userInput!="Quit"){
            if(hide!=true){
             for(int i=0;i<3;i++){
                script.HideRandomWords(rnd.Next(sl.Count));
             }
             Console.Clear();
             Console.WriteLine(script.GetTheDispaly());
             Console.WriteLine("Press enter to continue or type 'Quit' to finish");
             userInput=Console.ReadLine();
             hide=script.IsCompletelyHidden(); 
            }
            else{
                break;
            }   
        }
    }
}