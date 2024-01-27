using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
class Program
{
    private static bool hide;
    private static string userInput;

    static void Main(string[] args)
    {
        Reference  reference= new Reference("John", 3, 16, 17);
        string content="For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.\rFor God did not send his Son into the world to condemn the world, but to save the world through him.";
        Scripture script = new Scripture(reference, content);
        Console.WriteLine(script.GetTheDispaly());
        Console.WriteLine("Press enter to continue or type 'Quit' to finish");
        userInput=Console.ReadLine();
        while(hide!=true){
            if(userInput!="Quit"){
             for(int i=0;i<3;i++){
                script.HideRandomWords(content.Length);
             }
            }
            else{
                break;
            }
          script.GetTheDispaly();
          hide=script.IsCompletelyHidden();       
        }
    }
}